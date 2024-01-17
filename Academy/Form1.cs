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
			connection_string = ConfigurationManager.ConnectionStrings["Academy_PC"].ConnectionString;
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
				comboBox1.Items.Add(rdr[0]);
			rdr.Close();
			connection.Close();
		}
	}
}
