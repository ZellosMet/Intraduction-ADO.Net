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

namespace Library_Desktop
{
	public partial class f_Library : Form
	{
		string connection_string;
		SqlConnection connection;
		SqlDataReader rdr;
		DataTable table;
		public f_Library()
		{
			InitializeComponent();
			connection_string = ConfigurationManager.ConnectionStrings["LibraryBD_PC"].ConnectionString;
			connection = new SqlConnection(connection_string);
			LoadTablesToComboBox();
		}

		void LoadTablesToComboBox()
		{
			string commandLine = @"SELECT Table_name FROM information_schema.tables";
			SqlCommand cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
				cb_table.Items.Add(rdr[0]);
			rdr.Close();
			connection.Close();
		}
		private void btn_Execute_Click(object sender, EventArgs e)
		{
			string cmdLine = rtb_Query.Text;
			SqlCommand cmd = new SqlCommand(cmdLine, connection);
			try
			{
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
				dgv_result.DataSource = table;				
			}
			catch (Exception exep)
			{
				MessageBox.Show(exep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if(rdr != null) rdr.Close();
				if(connection != null)connection.Close();
			}
		}

		private void cb_table_SelectedIndexChanged(object sender, EventArgs e)
		{
			string commandLine = $@"SELECT * FROM {cb_table.SelectedItem}";
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
			dgv_result.DataSource = table;
			rdr.Close();

			connection.Close();
		}
	}
}
