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
			LoadTablesToComboBox();
		}
		void LoadTablesToComboBox()
		{
			string commandLine = @"SELECT group_name FROM Groups";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
				cb_CurrentGroup.Items.Add(rdr[0]);
			rdr.Close();
			connection.Close();
		}

		private void cb_CurrentGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			string commandLine = $@"
			SELECT[Имя] = first_name, [Фамилия] = last_name, [Отчество] = middle_name
			FROM Groups, Students
			WHERE Groups.group_name = '{cb_CurrentGroup.SelectedItem}'
			AND Groups.group_id = Students.[group]";			
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
		}
		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			cb_CurrentGroup_SelectedIndexChanged(sender, e);
		}

		private void btn_AddStudents_Click(object sender, EventArgs e)
		{
			AddStudents add_students = new AddStudents(connection, connection_string);
			add_students.Show();
		}
		private void btn_AddGroups_Click(object sender, EventArgs e)
		{
			AddGroups add_groups = new AddGroups(connection, connection_string);
			add_groups.Show();
		}

		private void btn_AddShedules_Click(object sender, EventArgs e)
		{
			AddShedules add_shedules = new AddShedules(connection, connection_string);
			add_shedules.Show();
		}
	}
}
