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
	public partial class AddShedules : Form
	{
		string connection_string;
		SqlConnection connection;
		SqlCommand cmd;
		SqlDataReader rdr;
		public AddShedules(SqlConnection connection, string connection_string)
		{
			InitializeComponent();
			this.connection = connection;
			this.connection_string = connection_string;
			
			//Form1.LoadGroupsToComboBox();
			//l_Direction.Text = "";
			//cb_Direction.DropDownStyle = ComboBoxStyle.DropDownList;
		}
		void LoadGroupsToComboBox()
		{
			string commandLine = @"SELECT direction_name FROM Directions";
			cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
			//	cb_Direction.Items.Add(rdr[0]);
			rdr.Close();
			connection.Close();
		}

	}
}
