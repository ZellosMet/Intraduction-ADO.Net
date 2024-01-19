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
		SqlConnection connection;
		SqlCommand cmd;
		SqlDataReader rdr;
		DataTable table;
		public StudentInfo(SqlConnection connection, string connection_string, string last_name, string first_name, string middle_name)
		{
			InitializeComponent();
			this.connection = connection;
			this.connection_string = connection_string;
			this.last_name = last_name;
			this.first_name = first_name;
			this.middle_name = middle_name;
			l_LastName.Text = $"Фамилия: {last_name}";
			l_FirstName.Text = $"Имя: {first_name}";
			l_MiddleName.Text = $"Отчество: {middle_name}";

			string command = $@"SELECT stud_id 
								FROM Students 
								WHERE Students.last_name LIKE '{last_name}' 
								AND Students.first_name LIKE '{first_name}' 
								AND Students.middle_name LIKE '{middle_name}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			int id_student = Convert.ToInt32(cmd.ExecuteScalar());

			command = $@"SELECT birth_date FROM Students WHERE Students.stud_id = {id_student}";
			cmd = new SqlCommand(command, connection);
			string birth_date = Convert.ToString(cmd.ExecuteScalar());

			l_BirthDate.Text = $"Дата рождения: {birth_date.Split(' ')[0]}";

			command = $@"SELECT group_name FROM Groups, Students WHERE Students.[group] = Groups.group_id AND Students.stud_id = '{id_student}'";
			cmd = new SqlCommand(command, connection);
			string group = Convert.ToString(cmd.ExecuteScalar());

			l_Group.Text = $"Группа: {group}";

			connection.Close();

			LoadDataGreads(id_student);
			LoadDataAttendance(id_student);
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
	}
}
