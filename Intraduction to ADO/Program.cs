using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;
using System.Configuration;

namespace Intraduction_to_ADO
{
	internal class Program
	{
		//Проверка на наличие автора
		public static bool CheckAuthor(string author, SqlCommand sc)
		{
			sc.CommandText = $"SELECT COUNT(*) FROM Authors WHERE first_name = N'{author.Split(' ')[0]}' AND last_name = N'{(author.Split(' ').Length > 1 ? author.Split(' ')[1] : " ")}'";
			sc.ExecuteScalar();
			return (Convert.ToInt32(sc.ExecuteScalar())) !=0  ? true : false; 
		}
		/////////////////////////////
		
		//Закрытие Ридера
		public static void CloseReader(SqlDataReader rdr)
		{
			if (rdr != null)
				rdr.Close();
		}
		/////////////////////////////
		static void Main(string[] args)
		{
			string console_command = String.Empty;
			string connection_string = ConfigurationManager.ConnectionStrings["LibraryBD_PC"].ConnectionString;
			//string connection_string = ConfigurationManager.ConnectionStrings["LibraryBD_NB"].ConnectionString;
			SqlConnection connection = new SqlConnection(connection_string);
			connection.Open();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = connection;
			SqlDataReader rdr = null;	

			//Управление
			Console.WriteLine("Доступные команды:\n" +
								"insert - Добавить запись\n" +
								"select - Вывести краткий список книг\n" +
								"select [Authors | Books] - Вывести указанную таблицу\n" +
								"delete <Authors | Books> <id> - Удаляет запись из указанной таблици\n" +
								"update <Authors | Books> - Изменяет содержимое ячейки\n" +
								"exit - Выход\n");

			while (true)
			{
				Console.Write("Введите команду: > ");
				console_command = Console.ReadLine();
				//Проверка на выход
				if (console_command.ToLower().Equals("exit"))
				{ 
					if(connection.State == ConnectionState.Open)
						connection.Close();
					CloseReader(rdr);
					break;
				}
				//Кейс на добавоение
				switch (console_command.ToLower().Split(' ')[0])
				{
					case "insert":
						{
							Console.Write("Введите данные книги\nНазвание: > ");
							string title_book = Console.ReadLine();
							Console.Write("Автор: > ");
							string author_book = Console.ReadLine();
							Console.Write("Цена: > ");
							string price_book = Console.ReadLine();
							Console.Write("Количество страниц в книге: > ");
							string pages_book = Console.ReadLine();

							if (!CheckAuthor(author_book, cmd))
							{
								//Автора нет
								string inser_author  = $"INSERT INTO Authors (first_name, last_name) OUTPUT INSERTED.Id VALUES (N'{author_book.Split(' ')[0]}', N'{(author_book.Split(' ').Length > 1 ? author_book.Split(' ')[1] : " ")}')";
								cmd.CommandText = inser_author;
								int new_id = Convert.ToInt32(cmd.ExecuteScalar());
								string inser_book = $"INSERT INTO Books (author, titles, price, pages) VALUES ({new_id}, N'{title_book}', {price_book}, {pages_book})";
								cmd.CommandText = inser_book;
								Console.WriteLine($"{cmd.ExecuteNonQuery()} запись успешно добавлена\n");
							}
							else 
							{
								//Автор есть
								cmd.CommandText = $"SELECT id FROM Authors WHERE Authors.first_name LIKE N'{author_book.Split(' ')[0]}' AND Authors.last_name LIKE N'{author_book.Split(' ')[1]}'";
								int id_author = Convert.ToInt32(cmd.ExecuteScalar());
								string inser_book = $"INSERT INTO Books (author, titles, price, pages) VALUES ({id_author}, N'{title_book}', {price_book}, {pages_book})";
								cmd.CommandText = inser_book;
								Console.WriteLine($"{cmd.ExecuteNonQuery()} запись успешно добавлена\n");
							}
						}
						CloseReader(rdr);
						break;
					//Кейс на запрос
					case "select": 
						string select_string = String.Empty;
							if (console_command.Split(' ').Length > 1)
							{
								switch (console_command.ToLower().Split(' ')[1])
								{
									case "authors": //По авторам
										{ 
											select_string = @"SELECT * FROM Authors";
											cmd.CommandText = select_string;
											rdr = cmd.ExecuteReader();

											Console.WriteLine("№ | Authors");
											Console.WriteLine(new string('-', 50));

											while (rdr.Read())
												Console.WriteLine($"{rdr[0]} | {rdr[1]} {rdr[2]}");
										}
									CloseReader(rdr);
									break;

									case "books": //По книгам
										{
											{
												select_string = @"SELECT Books.id, Authors.first_name, Authors.last_name, Books.titles, Books.price, Books.pages 
																FROM Books, Authors WHERE Authors.id = Books.author";
												cmd.CommandText = select_string;
												rdr = cmd.ExecuteReader();

												Console.WriteLine("№ | Authors | Title | Price | Pages");
												Console.WriteLine(new string('-', 90));

												while (rdr.Read())
													Console.WriteLine($"{rdr[0]} | {rdr[1]} {rdr[2]} | {rdr[3]} | {rdr[4]} | {rdr[5]}");
											}
										}
									CloseReader(rdr);
									break;
								}
							break;
							}
						//Краткий запрос
						{

							select_string = @"SELECT Books.id, Authors.first_name, Authors.last_name, Books.titles, Books.author FROM Authors, Books WHERE Authors.id = Books.author";
							cmd.CommandText = select_string;
							rdr = cmd.ExecuteReader();

							Console.WriteLine("№ | Authors \t\t | Book title");
							Console.WriteLine(new string('-', 50));

							while (rdr.Read())
								Console.WriteLine($"{rdr[0]} | {rdr[1]} {rdr[2]} \t | {rdr[3]}");
						}
						CloseReader(rdr);
						break;
					// Кейс на удаление
					case "delete":
						{
							if (console_command.Split(' ').Length <= 1)	
							{
								Console.WriteLine("Не корректная команда!");
								break;
							}
							else 
							{								
								try
								{
									//Пробуем удалять
									string delete_string = $"DELETE FROM {console_command.ToLower().Split(' ')[1]} WHERE {console_command.ToLower().Split(' ')[1]}.id = {console_command.Split(' ')[2]}";
									cmd.CommandText = delete_string;
									Console.WriteLine($"{cmd.ExecuteNonQuery()} запись успешно удалина\n");
								}
								catch (Exception)
								{
									//Если не удалось удалить
									Console.WriteLine("Не удалось удалить запись! Записи не существует или он связон с другими таблицами");
								}
							}
						}
						CloseReader(rdr);
						break;
					//Кейс на обновление
					case "update":
						{
							//Обновление автора
							if (console_command.Split(' ')[1] == "authors")
							{
								Console.Write("Введите номер записи: > ");
								string id_author = Console.ReadLine();
								Console.Write("Введите имя и фамилию автора: > ");
								string name_author = Console.ReadLine();
								try
								{
									string update_string = $"UPDATE Authors SET Authors.first_name = N'{name_author.Split(' ')[0]}', Authors.last_name = N'{(name_author.Split(' ').Length > 1 ? name_author.Split(' ')[1] : " ")}' WHERE Authors.id = '{id_author}'";
									cmd.CommandText = update_string;
									Console.WriteLine($"{cmd.ExecuteNonQuery()} запись успешно добавлена\n");
								}
								catch (Exception)
								{
									Console.WriteLine("Не удалось обновить запись! Записи не существует");
								}
							}
							/////////////////////
							//Обновление книги
							else if (console_command.Split(' ')[1] == "books")
							{
								Console.Write("Укажите какие данные хотите изменить(Title, Price, Pages): > ");
								string column = Console.ReadLine();
								switch (column.ToLower())
								{
									//Название книги
									case "title":
									{
											Console.Write("Введите номер записи: > ");
											string id_book = Console.ReadLine();
											Console.Write("Введите новое название книги: > ");
											string new_title = Console.ReadLine();
											try
											{
												string update_string = $"UPDATE Books SET Books.titles = N'{new_title}'WHERE Books.id = '{id_book}'";
												cmd.CommandText = update_string;
												Console.WriteLine($"{cmd.ExecuteNonQuery()} запись успешно добавлена\n");
											}
											catch (Exception)
											{
												Console.WriteLine("Не удалось обновить запись! Записи не существует");
											}
										}
									break;
									/////////////////////////////
									//Цена книги
									case "price":
										{
											Console.Write("Введите номер записи: > ");
											string id_book = Console.ReadLine();
											Console.Write("Введите новую цену книги: > ");
											string new_price = Console.ReadLine();
											try
											{
												string update_string = $"UPDATE Books SET Books.price = N'{new_price}'WHERE Books.id = '{id_book}'";
												cmd.CommandText = update_string;
												Console.WriteLine($"{cmd.ExecuteNonQuery()} запись успешно добавлена\n");
											}
											catch (Exception)
											{
												Console.WriteLine("Не удалось обновить запись! Записи не существует");
											}
										}
										break;
									///////////////////////////
									//Страницы книги
									case "pages":
										{
											Console.Write("Введите номер записи: > ");
											string id_book = Console.ReadLine();
											Console.Write("Введите новое количество страниц книги: > ");
											string new_pages = Console.ReadLine();
											try
											{
												string update_string = $"UPDATE Books SET Books.pages = N'{new_pages}'WHERE Books.id = '{id_book}'";
												cmd.CommandText = update_string;
												Console.WriteLine($"{cmd.ExecuteNonQuery()} запись успешно добавлена\n");
											}
											catch (Exception)
											{
												Console.WriteLine("Не удалось обновить запись! Записи не существует");
											}
										}
										break;
									////////////////////
									//Нет столбца
									default:
									{ 
										Console.WriteLine("Такой записи не существует");											
									}
									break;
									////////////
								}
							}
							//Нет таблицы
							else Console.WriteLine("Таблицы не существует");
						}
						break;
					default: Console.WriteLine("Команды не поддерживается!"); break;
				}
			}
		}
	}
}
