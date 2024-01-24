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
using System.IO;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Academy
{
	public partial class AddStudents : Form
	{
		string connection_string;
		SqlConnection connection;
		SqlCommand cmd;
		SqlDataReader rdr;
		DataTable table;
		//string photo_path = "C:\\ProgramDatа\\LocalProject\\C#\\Intraduction-ADO.Net\\Academy\\photo\\not_photo.png";
		string photo_path = "C:\\Users\\Zello\\OneDrive\\Рабочий стол\\Учёба\\ДЗ\\C#\\ADO\\Intraduction to ADO\\Academy\\photo\\not_photo.png";
		byte[] data_photo = null;
		bool set_photo = false;
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
			ofd_AddPhoto.Filter = "Image file (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
			pb_AddPhoto.Image = Properties.Resources._default;
			LoadData();
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
			connection.Close();

			if(!set_photo)
				ConvertImageToData();

			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				try 
				{
					command = $@"INSERT INTO Students (last_name, first_name, middle_name, birth_date, [group], photo)
							VALUES (@last_name, @first_name, @middle_name, @birth_date, @id_group, @photo)";
					cmd = new SqlCommand(command, connection);
					connection.Open();

					cmd.Parameters.Add("@last_name", SqlDbType.NVarChar, 32).Value = last_name;
					cmd.Parameters.Add("@first_name", SqlDbType.NVarChar, 32).Value = first_name;
					cmd.Parameters.Add("@middle_name", SqlDbType.NVarChar, 32).Value = middle_name;
					cmd.Parameters.Add("@birth_date", SqlDbType.Date).Value = birth_date;
					cmd.Parameters.Add("@id_group", SqlDbType.Int).Value = id_group;
					cmd.Parameters.Add("@photo", SqlDbType.Image, 1000000).Value = data_photo;

					cmd.ExecuteNonQuery();
					l_AddResult.Text = "Студент успешно добавлен!";
				}
				catch (Exception exc)
				{
					MessageBox.Show($"Не удалось добавить студента. Ошибка: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					rdr?.Close();
					connection?.Close();
					set_photo = false;
				}
			}
			LoadData();
		}
		void LoadData()
		{
			string commandLine = $@"
			SELECT [Фамилия] = last_name, [Имя] = first_name, [Отчество] = middle_name, [Дата рождения] = birth_date, [Группа] = group_name
			FROM Groups, Students
			WHERE Students.[group] = Groups.group_id";
			SqlCommand cmd = new SqlCommand(commandLine, connection);

			connection.Open();
			rdr = cmd.ExecuteReader();

			table = new DataTable();
			for (int i = 0; i < rdr.FieldCount; i++) table.Columns.Add(rdr.GetName(i));
			while (rdr.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < rdr.FieldCount; i++)
				{
					if (i == 3) row[i] = Convert.ToString(rdr[i]).Split(' ')[0];
					else row[i] = rdr[i];
				}
				table.Rows.Add(row);
			}
			dgv_StudentsList.DataSource = table;
			rdr.Close();
			connection.Close();
		}

		private void btn_AddPhoto_Click(object sender, EventArgs e)
		{
			if (ofd_AddPhoto.ShowDialog() == DialogResult.OK)
				photo_path = ofd_AddPhoto.FileName;
			ConvertImageToData();
			pb_AddPhoto.Image = Image.FromFile(photo_path);
			set_photo = true;
		}

		void ConvertImageToData()
		{
			FileStream fs = new FileStream(photo_path, FileMode.Open);
			data_photo = new byte[fs.Length];
			fs.Read(data_photo, 0, data_photo.Length);
			fs.Close();
		}
	}
}
