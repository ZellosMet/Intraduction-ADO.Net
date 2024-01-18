using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Academy
{
	public partial class AddStudents : Form
	{
		string connection_string;
		SqlConnection connection;
		SqlCommand cmd;
		SqlDataReader rdr;
		string path_photo = string.Empty;

		public AddStudents(SqlConnection connection, string connection_string)
		{
			InitializeComponent();
			this.connection = connection;
			this.connection_string = connection_string;
			LoadGroupsToComboBox();
			l_AddResult.Text = "";
			cb_Groups.DropDownStyle = ComboBoxStyle.DropDownList;
			dtp_BirthDate.Format = DateTimePickerFormat.Custom;
			dtp_BirthDate.CustomFormat = "yyy-MM-dd";
		}
		void LoadGroupsToComboBox()
		{
			string commandLine = @"SELECT group_name FROM Groups";
			cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
				cb_Groups.Items.Add(rdr[0]);
			rdr.Close();
			connection.Close();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			string command, last_name, first_name, middle_name, birth_date, group;
			int id_group;
			if (tb_FirsName.Text.Length == 0 || tb_LastName.Text.Length == 0 || cb_Groups.Text.Length == 0)
			{ MessageBox.Show("Не заполнены обязательные поля 'Имя', 'Фамилия', 'Группа'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
			first_name = tb_FirsName.Text;
			last_name = tb_LastName.Text;
			middle_name = tb_MiddleName.Text;
			birth_date = dtp_BirthDate.Value.ToString().Split(' ')[0];
			group = cb_Groups.SelectedItem.ToString();

			command = $@"SELECT group_id FROM Groups WHERE Groups.group_name LIKE '{group}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_group = Convert.ToInt32(cmd.ExecuteScalar());

			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				try
				{
					command = $@"INSERT INTO Students (last_name, first_name, middle_name, birth_date, [group])
							VALUES (@last_name, @first_name, @middle_name, @birth_date, @id_group)";
					cmd = new SqlCommand(command, connection);
					connection.Open();

					cmd.Parameters.Add("@last_name", SqlDbType.NVarChar, 32).Value = last_name;
					cmd.Parameters.Add("@first_name", SqlDbType.NVarChar, 32).Value = first_name;
					cmd.Parameters.Add("@middle_name", SqlDbType.NVarChar, 32).Value = middle_name;
					cmd.Parameters.Add("@birth_date", SqlDbType.Date).Value = birth_date;
					cmd.Parameters.Add("@id_group", SqlDbType.Int).Value = id_group;

					cmd.ExecuteNonQuery();
					l_AddResult.Text = "Студент успешно добавлен!";
				}
				catch (Exception exc)
				{
					MessageBox.Show($"Не удалось добавить студента. Ошибка: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connection.Close();
				}
			}
		}
	}
}
