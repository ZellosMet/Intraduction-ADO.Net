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

namespace Academy
{
	public partial class AddGroups : Form
	{
		string connection_string;
		SqlConnection connection;
		SqlCommand cmd;
		SqlDataReader rdr;
		public AddGroups(SqlConnection connection, string connection_string)
		{
			InitializeComponent();
			this.connection = connection;
			this.connection_string = connection_string;
			LoadGroupsToComboBox();
			l_AddResult.Text = "";
			cb_Direction.DropDownStyle = ComboBoxStyle.DropDownList;
		}
		void LoadGroupsToComboBox()
		{
			string commandLine = @"SELECT direction_name FROM Directions";
			cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
				cb_Direction.Items.Add(rdr[0]);
			rdr.Close();
			connection.Close();
		}

		private void btn_AddGroup_Click(object sender, EventArgs e)
		{
			string command, group_name, direction_name;
			int id_direction;
			if (tb_GroupName.Text.Length == 0)
			{ MessageBox.Show("Не заполнены обязательные поля 'Дисциплина'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
			group_name = tb_GroupName.Text;
			direction_name = cb_Direction.SelectedItem.ToString();

			command = $@"SELECT direction_id FROM Directions WHERE Directions.direction_name LIKE '{direction_name}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_direction = Convert.ToInt32(cmd.ExecuteScalar());

			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				try
				{
					command = $@"INSERT INTO Groups (group_name, direction)
							VALUES (@group_name, @direction)";
					cmd = new SqlCommand(command, connection);
					connection.Open();

					cmd.Parameters.Add("@group_name", SqlDbType.NChar, 10).Value = group_name;
					cmd.Parameters.Add("@direction", SqlDbType.SmallInt, 32).Value = id_direction;

					cmd.ExecuteNonQuery();
					l_AddResult.Text = "Студент успешно добавлен!";
				}
				catch (Exception exc)
				{
					MessageBox.Show($"Не удалось добавить группу. Ошибка: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connection.Close();
				}
			}
		}
	}
}
