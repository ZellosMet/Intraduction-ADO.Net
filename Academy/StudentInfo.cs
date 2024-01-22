using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Academy
{
	public partial class StudentInfo : Form
	{
		string connection_string, last_name, first_name, middle_name;
		int id_student;
		SqlConnection connection;
		SqlCommand cmd;
		SqlDataReader rdr;
		DataTable table;
		public StudentInfo(SqlConnection connection, string connection_string, string last_name, string first_name, string middle_name)
		{
			InitializeComponent();
			cb_NewGroup.DropDownStyle = ComboBoxStyle.DropDownList;
			dtp_NewBirthDate.Format = DateTimePickerFormat.Custom;
			dtp_NewBirthDate.CustomFormat = "yyy-MM-dd";

			tb_NewFirstName.Visible = false;
			tb_NewLastName.Visible = false;
			tb_NewMiddleName.Visible = false;
			dtp_NewBirthDate.Visible = false;
			cb_NewGroup.Visible = false;
			btn_Cancel.Visible = false;
			btn_Save.Visible = false;
			l_UpdateResult.Visible = false;

			this.connection = connection;
			this.connection_string = connection_string;
			this.last_name = last_name;
			this.first_name = first_name;
			this.middle_name = middle_name;

			l_LastName.Text = $"Фамилия: {last_name}";
			l_FirstName.Text = $"Имя: {first_name}";
			l_MiddleName.Text = $"Отчество: {middle_name}";

			tb_NewFirstName.Text = first_name;
			tb_NewLastName.Text = last_name;
			tb_NewMiddleName.Text = middle_name;

			string command = $@"SELECT stud_id 
								FROM Students 
								WHERE Students.last_name LIKE '{last_name}' 
								AND Students.first_name LIKE '{first_name}' 
								AND Students.middle_name LIKE '{middle_name}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_student = Convert.ToInt32(cmd.ExecuteScalar());

			command = $@"SELECT birth_date FROM Students WHERE Students.stud_id = {id_student}";
			cmd = new SqlCommand(command, connection);
			string birth_date = Convert.ToString(cmd.ExecuteScalar());

			dtp_NewBirthDate.Value = Convert.ToDateTime(birth_date.Split(' ')[0]);
			l_BirthDate.Text = $"Дата рождения: {birth_date.Split(' ')[0]}";

			command = $@"SELECT group_name FROM Groups, Students WHERE Students.[group] = Groups.group_id AND Students.stud_id = '{id_student}'";
			cmd = new SqlCommand(command, connection);
			string group = Convert.ToString(cmd.ExecuteScalar()).Trim();

			l_Group.Text = $"Группа: {group}";

			connection.Close();

			LoadTablesToComboBox();
			LoadDataGreads(id_student);
			LoadDataAttendance(id_student);

			cb_NewGroup.SelectedIndex = cb_NewGroup.FindString(group);
		}
		void LoadTablesToComboBox()
		{
			string commandLine = @"SELECT group_name FROM Groups";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
				cb_NewGroup.Items.Add(rdr[0]);
			rdr.Close();
			connection.Close();
		}

		void LoadDataGreads(int id_student)
		{
			string commandLine = $@"SELECT [Предмет] = Disciplines.discipline_name, [Оценка за первую пару] = Grades.grade_1, [Оценка за вторую пару] = Grades.grade_2
									FROM Disciplines, Students, Schedule, Grades 
									WHERE Grades.stud_id = Students.stud_id 
									AND Schedule.discipline = Disciplines.discipline_id
									AND Grades.lesson_id = Schedule.lesson_id
									AND Grades.stud_id = '{id_student}'";
			SqlCommand cmd = new SqlCommand(commandLine, connection);

			connection.Open();
			rdr = cmd.ExecuteReader();
			table = new DataTable();
			for (int i = 0; i < rdr.FieldCount; i++) table.Columns.Add(rdr.GetName(i));
			while (rdr.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < rdr.FieldCount; i++) row[i] = rdr[i];
				table.Rows.Add(row);
			}
			dgv_Grades.DataSource = table;
			rdr.Close();

			connection.Close();
		}


		void LoadDataAttendance(int id_student)
		{
			string commandLine = $@"SELECT [Предмет] = Disciplines.discipline_name, [Дата] = Schedule.[date], [Успеваемость] = IIF(Attendance.present = 1, 'Присутствовал', 'Отсутствовал')
									FROM Disciplines, Students, Schedule, Attendance
									WHERE Attendance.stud_id = Students.stud_id 
									AND Schedule.discipline = Disciplines.discipline_id
									AND Attendance.lessons_id = Schedule.lesson_id
									AND Attendance.stud_id = '{id_student}'";
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
					if(i==1) row[i] = Convert.ToString(rdr[i]).Split(' ')[0];
					else row[i] = rdr[i];
				}
				table.Rows.Add(row);
			}
			dgv_Attandances.DataSource = table;
			rdr.Close();

			connection.Close();
		}
		private void btn_UpdateStudent_Click(object sender, EventArgs e)
		{
			tb_NewFirstName.Visible = true;
			tb_NewLastName.Visible = true;
			tb_NewMiddleName.Visible = true;
			dtp_NewBirthDate.Visible = true;
			cb_NewGroup.Visible = true;
			btn_Cancel.Visible = true;
			btn_Save.Visible = true;
			l_UpdateResult.Visible = true;
		}
		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			tb_NewFirstName.Visible = false;
			tb_NewLastName.Visible = false;
			tb_NewMiddleName.Visible = false;
			dtp_NewBirthDate.Visible = false;
			cb_NewGroup.Visible = false;
			btn_Cancel.Visible = false;
			btn_Save.Visible = false;
			l_UpdateResult.Visible = false;
		}
		private void btn_Save_Click(object sender, EventArgs e)
		{
			string command, last_name, first_name, middle_name, birth_date, group;
			int id_group;
			if (tb_NewFirstName.Text.Length == 0 || tb_NewLastName.Text.Length == 0 || cb_NewGroup.Text.Length == 0)
			{ MessageBox.Show("Не заполнены обязательные поля 'Имя', 'Фамилия', 'Группа'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

			first_name = tb_NewFirstName.Text;
			last_name = tb_NewLastName.Text;
			middle_name = tb_NewMiddleName.Text;
			birth_date = dtp_NewBirthDate.Value.ToString().Split(' ')[0];
			group = cb_NewGroup.SelectedItem.ToString();

			command = $@"SELECT group_id FROM Groups WHERE Groups.group_name LIKE '{group}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_group = Convert.ToInt32(cmd.ExecuteScalar());

			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				try
				{
					command = $@"UPDATE Students 
								SET last_name = @last_name, first_name = @first_name, middle_name = @middle_name, birth_date = @birth_date, [group] = @id_group
								WHERE stud_id = @id_student";
					cmd = new SqlCommand(command, connection);
					connection.Open();

					cmd.Parameters.Add("@last_name", SqlDbType.NVarChar, 32).Value = last_name;
					cmd.Parameters.Add("@first_name", SqlDbType.NVarChar, 32).Value = first_name;
					cmd.Parameters.Add("@middle_name", SqlDbType.NVarChar, 32).Value = middle_name;
					cmd.Parameters.Add("@birth_date", SqlDbType.Date).Value = birth_date;
					cmd.Parameters.Add("@id_group", SqlDbType.Int).Value = id_group;
					cmd.Parameters.Add("@id_student", SqlDbType.Int).Value = id_student;

					cmd.ExecuteNonQuery();
					l_UpdateResult.Text = "Студент успешно изменён!";

					l_LastName.Text = $"Фамилия: {last_name}";
					l_FirstName.Text = $"Имя: {first_name}";
					l_MiddleName.Text = $"Отчество: {middle_name}";
					l_BirthDate.Text = $"Дата рождения: {birth_date.Split(' ')[0]}";
					l_Group.Text = $"Группа: {group}";
				}
				catch (Exception exc)
				{
					MessageBox.Show($"Не удалось изменить студента. Ошибка: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					rdr.Close();
					connection.Close();
				}
			}
		}
	}
}
