using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
	public partial class Form1 : Form
	{
		string selection = "group";
		string connection_string;
		SqlConnection connection;
		SqlDataReader rdr;
		DataTable table;
		public Form1()
		{
			InitializeComponent();
			cb_CurrentGroup.DropDownStyle = ComboBoxStyle.DropDownList;
			connection_string = ConfigurationManager.ConnectionStrings["Academy_PC"].ConnectionString;
			//connection_string = ConfigurationManager.ConnectionStrings["Academy_NB"].ConnectionString;
			connection = new SqlConnection(connection_string);
			rb_ForGroup.Checked = true;
			chkb_Archive.Checked = false;
			LoadTablesToComboBox();
		}
		void LoadTablesToComboBox()
		{
			cb_CurrentGroup.Items.Clear();
			string commandLine;
			if (selection == "group")
			{
				cb_CurrentGroup.Items.Add("");

				if(chkb_Archive.Checked)
					commandLine = @"SELECT group_name FROM Groups WHERE Groups.archive = 1";
				else
					commandLine = @"SELECT group_name FROM Groups WHERE Groups.archive = 0";
			}
			else commandLine = @"SELECT speciality_name FROM Specialites";

			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
				cb_CurrentGroup.Items.Add(rdr[0]);
			rdr.Close();
			connection.Close();

			if(selection == "group")
				commandLine = $@"SELECT [Фамилия] = last_name, [Имя] = first_name, [Отчество] = middle_name FROM Students";
			else
				commandLine = $@"SELECT [Фамилия] = Students.last_name, [Имя] = Students.first_name, [Отчество] = Students.middle_name
								FROM Students, Groups, Directions, Specialites, SpecialitesDirectionRelation
								WHERE Students.[group] = Groups.group_id
								AND Groups.direction = Directions.direction_id
								AND Directions.direction_id = SpecialitesDirectionRelation.direction
								AND SpecialitesDirectionRelation.speciality = Specialites.speciality_id
								AND Specialites.speciality_name = '{cb_CurrentGroup.Items[0]}'";
			LoadTableToGridView(commandLine);
		}

		public void LoadTableToGridView(string commandLine)
		{
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
			dgv_SudentsList.DataSource = table;

			rdr.Close();
			connection.Close();

			l_CountStudents.Text = $"Количество студентов: {dgv_SudentsList.RowCount - 1}";
		}

		private void cb_CurrentGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			string commandLine = string.Empty;
			if (selection == "group")
			{
				if (cb_CurrentGroup.Text.Length == 0)
				{
					commandLine = $@"SELECT [Фамилия] = last_name, [Имя] = first_name, [Отчество] = middle_name
									FROM Students";
				}
				else
				{
					commandLine = $@"SELECT [Фамилия] = last_name, [Имя] = first_name, [Отчество] = middle_name
									FROM Groups, Students
									WHERE Groups.group_name = '{cb_CurrentGroup.SelectedItem}'
									AND Groups.group_id = Students.[group]";
				}
			}
			else
			{
				commandLine = $@"SELECT [Фамилия] = Students.last_name, [Имя] = Students.first_name, [Отчество] = Students.middle_name
								FROM Students, Groups, Directions, Specialites, SpecialitesDirectionRelation
								WHERE Students.[group] = Groups.group_id
								AND Groups.direction = Directions.direction_id
								AND Directions.direction_id = SpecialitesDirectionRelation.direction
								AND SpecialitesDirectionRelation.speciality = Specialites.speciality_id
								AND Specialites.speciality_name = '{(cb_CurrentGroup.Text.Length == 0? cb_CurrentGroup.Items[0] : cb_CurrentGroup.SelectedItem)}'";
			}
			LoadTableToGridView(commandLine);

		}
		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			if (dgv_SudentsList.RowCount == 0) return;
			cb_CurrentGroup_SelectedIndexChanged(sender, e);
		}

		private void btn_AddStudents_Click(object sender, EventArgs e)
		{
			AddStudents add_students = new AddStudents(connection, connection_string);
			add_students.ShowDialog();
			cb_CurrentGroup_SelectedIndexChanged(sender, e);
		}
		private void btn_AddGroups_Click(object sender, EventArgs e)
		{
			AddGroups add_groups = new AddGroups(connection, connection_string);
			add_groups.ShowDialog();
			LoadTablesToComboBox();
		}

		private void btn_AddShedules_Click(object sender, EventArgs e)
		{
			AddShedules add_shedules = new AddShedules(connection, connection_string);
			add_shedules.ShowDialog();
		}

		private void tb_Search_TextChanged(object sender, EventArgs e)
		{
			(dgv_SudentsList.DataSource as DataTable).DefaultView.RowFilter = $"Фамилия LIKE '{tb_Search.Text}%' OR Имя LIKE '{tb_Search.Text}%' OR Отчество LIKE '{tb_Search.Text}%'";
			l_CountStudents.Text = $"Количество студентов: {dgv_SudentsList.RowCount - 1}";
		}

		private void dgv_SudentsList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv_SudentsList.RowCount == 0) return;
			int index = dgv_SudentsList.CurrentCell.RowIndex;
			string last_name = dgv_SudentsList.Rows[index].Cells[0].Value.ToString();
			string first_name = dgv_SudentsList.Rows[index].Cells[1].Value.ToString();
			string middle_name = dgv_SudentsList.Rows[index].Cells[2].Value.ToString();

			StudentInfo stud_info = new StudentInfo(connection, connection_string, last_name, first_name, middle_name);
			stud_info.ShowDialog();
			cb_CurrentGroup_SelectedIndexChanged(sender, e);
		}

		private void rb_ForGroup_MouseClick(object sender, MouseEventArgs e)
		{
			selection = "group";
			rb_ForSpeciality.Checked = false;
			rb_ForGroup.Checked = true;
			LoadTablesToComboBox();
		}

		private void rb_ForSpeciality_MouseClick(object sender, MouseEventArgs e)
		{
			selection = "speciality";
			rb_ForSpeciality.Checked = true;
			rb_ForGroup.Checked = false;
			LoadTablesToComboBox();
		}
		private void rb_ForGroup_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_ForGroup.Checked) 
				chkb_Archive.Enabled = true;
			else
				chkb_Archive.Enabled = false;
		}

		private void chkb_Archive_CheckedChanged(object sender, EventArgs e)
		{
			LoadTablesToComboBox();
		}
	}
}
