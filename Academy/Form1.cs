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
		void CloseConnection()
		{ 
			if(rdr != null) rdr.Close();
			if(connection != null)connection.Close();
		}
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
			SELECT [Фамилия] = last_name, [Имя] = first_name, [Отчество] = middle_name
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
			CloseConnection();
			if (dgv_SudentsList.RowCount == 0) return;
			cb_CurrentGroup_SelectedIndexChanged(sender, e);
		}

		private void btn_AddStudents_Click(object sender, EventArgs e)
		{
			CloseConnection();
			AddStudents add_students = new AddStudents(connection, connection_string);
			add_students.ShowDialog();
		}
		private void btn_AddGroups_Click(object sender, EventArgs e)
		{
			CloseConnection();
			AddGroups add_groups = new AddGroups(connection, connection_string);
			add_groups.ShowDialog();
		}

		private void btn_AddShedules_Click(object sender, EventArgs e)
		{
			CloseConnection();
			AddShedules add_shedules = new AddShedules(connection, connection_string);
			add_shedules.ShowDialog();
		}

		private void tb_Search_TextChanged(object sender, EventArgs e)
		{
			(dgv_SudentsList.DataSource as DataTable).DefaultView.RowFilter = $"Фамилия LIKE '%{tb_Search.Text}%'";
		}

		private void dgv_SudentsList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgv_SudentsList.RowCount == 0) return;
			int index = dgv_SudentsList.CurrentCell.RowIndex;
			DataGridViewCell l_name = dgv_SudentsList.Rows[index].Cells[0];
			DataGridViewCell f_name = dgv_SudentsList.Rows[index].Cells[1];
			DataGridViewCell m_name = dgv_SudentsList.Rows[index].Cells[2];
			string last_name = l_name.Value.ToString();
			string first_name = f_name.Value.ToString();
			string middle_name = m_name.Value.ToString();

			CloseConnection();
			StudentInfo stud_info = new StudentInfo(connection, connection_string, last_name, first_name, middle_name);
			stud_info.ShowDialog();		
		}
	}
}
