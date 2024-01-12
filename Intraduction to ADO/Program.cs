using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Threading;

namespace Intraduction_to_ADO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string console_command = String.Empty;
			string connection_string = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			SqlConnection connection = new SqlConnection(connection_string);
			connection.Open();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = connection;
			SqlDataReader rdr = null;	
			
			Console.WriteLine("Доступные команды:\ninsert - Добавить запись\nselect - Вывести список книг\nexit - Выход\n");

			while (true)
			{
				Console.Write("Введите команду: > ");
				console_command = Console.ReadLine();

				if (console_command.ToLower().Equals("exit"))
				{ 
					if(connection.State == ConnectionState.Open)
						connection.Close();
					if (rdr != null)
						rdr.Close();
					break;
				}

				switch (console_command.ToLower())
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
							string[] arr_author_book = author_book.Split(' ');
							string inser_book = $"INSERT INTO Authors (first_name, last_name) OUTPUT INSERTED.Id VALUES (N'{arr_author_book[0]}', N'{(arr_author_book.Length > 1 ? arr_author_book[1]: " ")}')";
							cmd = new SqlCommand(inser_book, connection);
							int new_id = Convert.ToInt32(cmd.ExecuteScalar());
							string inser_author = $"INSERT INTO Books (author, titles, price, pages) VALUES ({new_id}, N'{title_book}', {price_book}, {pages_book})";
							cmd.CommandText = inser_author;
							Console.WriteLine($"{cmd.ExecuteNonQuery()} запись успешно добавлена\n");
						}
						break;

					case "select":
						{
							if (rdr != null)
								rdr.Close();

						string select_string = @"SELECT Authors.first_name, Authors.last_name, Books.titles, Books.author FROM Authors, Books WHERE Authors.id = Books.author";
						cmd.CommandText = select_string;
						rdr = cmd.ExecuteReader();

						Console.WriteLine("Authors \t | Book title");
						Console.WriteLine(new string('-', 50));

						while (rdr.Read())
							Console.WriteLine($"{rdr[0]} {rdr[1]} \t | {rdr[2]}");
						}
						break;

					default: Console.WriteLine("Команды не поддерживается!"); break;
				}
			}
		}
	}
}
