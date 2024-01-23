using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
		DataTable table;
		int id_group;
		public AddGroups(SqlConnection connection, string connection_string)
		{
			InitializeComponent();
			this.connection = connection;
			this.connection_string = connection_string;
			LoadGroupsToComboBox();
			l_AddResult.Text = "";
			cb_Direction.DropDownStyle = ComboBoxStyle.DropDownList;
			btn_UpdateGroup.Enabled = false;
			btn_Save.Visible = false;
			btn_Cancel.Visible = false;
			tb_NewGroupName.Visible = false;
			cb_NewDirection.Visible = false;
			chkb_Archive.Visible = false;
			LoadData();
		}
		void LoadGroupsToComboBox()
		{
			string commandLine = @"SELECT direction_name FROM Directions";
			cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{ 
				cb_Direction.Items.Add(rdr[0]);
				cb_NewDirection.Items.Add(rdr[0]);
			}
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
			connection.Close();

			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				try
				{
					command = $@"INSERT INTO Groups (group_name, direction, archive)
							VALUES (@group_name, @direction, '0')";
					cmd = new SqlCommand(command, connection);
					connection.Open();

					cmd.Parameters.Add("@group_name", SqlDbType.NChar, 10).Value = group_name;
					cmd.Parameters.Add("@direction", SqlDbType.SmallInt, 32).Value = id_direction;

					cmd.ExecuteNonQuery();
					l_AddResult.Text = "Группа успешно добавлена!";
				}
				catch (Exception exc)
				{
					MessageBox.Show($"Не удалось добавить группу. Ошибка: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					connection?.Close();
				}
			}
			LoadData();
		}

		void LoadData()
		{
			string commandLine = $@"
			SELECT [Группа] = group_name, [Направление] = direction_name, [Архив] = IIF(Groups.archive = 1, 'В архиве', 'Не в архиве')
			FROM Groups, Directions
			WHERE Groups.direction= Directions.direction_id";
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
			dgv_GroupList.DataSource = table;
			connection.Close();
		}
		private void dgv_GroupList_CellClick(object sender,DataGridViewCellEventArgs e)
		{
			btn_UpdateGroup.Enabled = true;
			tb_NewGroupName.Text = dgv_GroupList.Rows[dgv_GroupList.CurrentCell.RowIndex].Cells[0].Value.ToString().Trim();
			cb_NewDirection.SelectedIndex = cb_NewDirection.FindString(dgv_GroupList.Rows[dgv_GroupList.CurrentCell.RowIndex].Cells[1].Value.ToString());
			if(!(dgv_GroupList.Rows[dgv_GroupList.CurrentCell.RowIndex].Cells[2].Value.ToString() == "Не в архиве"))
				chkb_Archive.Checked = true;
			else
				chkb_Archive.Checked = false;

			string command = $@"(SELECT group_id FROM Groups WHERE Groups.group_name='{tb_NewGroupName.Text}')";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_group = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();
		}
		private void btn_UpdateGroup_Click(object sender, EventArgs e)
		{
			btn_UpdateGroup.Enabled = true;
			btn_Save.Visible = true;
			btn_Cancel.Visible = true;
			tb_NewGroupName.Visible = true;
			cb_NewDirection.Visible = true;
			chkb_Archive.Visible = true;
		}
		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			btn_UpdateGroup.Enabled = false;
			btn_Save.Visible = false;
			btn_Cancel.Visible = false;
			tb_NewGroupName.Visible = false;
			cb_NewDirection.Visible = false;
			chkb_Archive.Visible = false;
			l_AddResult.Text = "";
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			string command, group, direction;
			int id_direction;
			bool archiv;
			if (tb_NewGroupName.Text.Length == 0)
			{ MessageBox.Show("Не заполнены обязательные поля 'Имя группы'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

			group = tb_NewGroupName.Text.Trim();
			direction = cb_NewDirection.SelectedItem.ToString();
			archiv = chkb_Archive.Checked;

			command = $@"SELECT direction_id FROM Directions WHERE Directions.direction_name LIKE '{direction}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_direction = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				try
				{
					command = $@"UPDATE Groups 
								SET group_name = @group_name, direction = @direction, archive = @archive
								WHERE group_id = @id_group";
					cmd = new SqlCommand(command, connection);
					connection.Open();
			
					cmd.Parameters.Add("@group_name", SqlDbType.NVarChar, 10).Value = group;
					cmd.Parameters.Add("@direction", SqlDbType.SmallInt).Value = id_direction;
					cmd.Parameters.Add("@archive", SqlDbType.Bit).Value = archiv;
					cmd.Parameters.Add("@id_group", SqlDbType.Int).Value = id_group;
			
					cmd.ExecuteNonQuery();
					l_AddResult.Text = "Группа успешно изменён!";
				}
				catch (Exception exc)
				{
					MessageBox.Show($"Не удалось изменить студента. Ошибка: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					rdr?.Close();
					connection?.Close();
				}
				LoadData();
			}
		}
	}
}
