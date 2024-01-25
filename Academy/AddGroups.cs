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
		List<CheckBox> combobox_week_list = new List<CheckBox>();
		List<CheckBox> combobox_new_week_list = new List<CheckBox>();
		public AddGroups(SqlConnection connection, string connection_string)
		{
			InitializeComponent();
			this.connection = connection;
			this.connection_string = connection_string;
			LoadGroupsToComboBox(cb_Direction, cb_NewDirection, "SELECT direction_name FROM Directions");
			LoadGroupsToComboBox(cb_LessonForm, cb_NewLessonForm, "SELECT form_name FROM LessonsForms");
			LoadGroupsToComboBox(cb_LessonTime, cb_NewLessonTime, "SELECT time_name FROM LessonTimes");

			l_AddResult.Text = "";
			cb_Direction.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_NewDirection.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_LessonForm.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_LessonTime.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_NewLessonForm.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_NewLessonTime.DropDownStyle = ComboBoxStyle.DropDownList;

			btn_UpdateGroup.Enabled = false;
			btn_Save.Visible = false;
			btn_Cancel.Visible = false;
			tb_NewGroupName.Visible = false;
			cb_NewDirection.Visible = false;
			chkb_Archive.Visible = false;
			cb_NewLessonForm.Visible = false;
			cb_NewLessonTime.Visible = false;
			ck_NewMo.Visible = false;
			ck_NewTu.Visible = false;
			ck_NewWe.Visible = false;
			ck_NewTh.Visible = false;
			ck_NewFr.Visible = false;
			ck_NewSa.Visible = false;
			ck_NewSu.Visible = false;

			combobox_week_list.AddRange(new[] { ck_Mo, ck_Tu, ck_We, ck_Th, ck_Fr, ck_Sa, ck_Su});
			combobox_new_week_list.AddRange(new[] { ck_NewMo, ck_NewTu, ck_NewWe, ck_NewTh, ck_NewFr, ck_NewSa, ck_NewSu });

			LoadData();
		}

		int ConvertCheckBoxToDecimal(List<CheckBox> list)
		{
			string ck_all = string.Empty;

			for(int i = 0; i<list.Count(); i++)
				ck_all += Convert.ToInt32(list[i].Checked).ToString();

			return Convert.ToInt32(ck_all, 2);
		}

		void CovertDecimalToCheckBox(List<CheckBox> list, string value)
		{
			int[] array_bits = new int[list.Count()];
			string results = Convert.ToString(Convert.ToString(Convert.ToInt32(value, 10), 2));

			for(int i = results.Length-1, j = array_bits.Length-1; i>=0; i--, j--)
				array_bits[j] = Convert.ToInt32(results[i])-48;

			for(int i = 0; i < list.Count(); i++)
				list[i].Checked = Convert.ToBoolean(Convert.ToByte(array_bits[i]));
		}
		void LoadGroupsToComboBox(System.Windows.Forms.ComboBox cb, System.Windows.Forms.ComboBox ncb, string commandLine)
		{
			cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
			{ 
				cb.Items.Add(rdr[0]);
				ncb.Items.Add(rdr[0]);
			}
			rdr.Close();
			connection.Close();
		}
		private void btn_AddGroup_Click(object sender, EventArgs e)
		{
			string command, group_name, direction_name, form_name, time_name;
			int id_direction, id_form, id_time;
			if (tb_GroupName.Text.Length == 0)
			{ MessageBox.Show("Не заполнены обязательные поля 'Дисциплина'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
			group_name = tb_GroupName.Text;
			direction_name = cb_Direction.SelectedItem.ToString();
			form_name = cb_LessonForm.SelectedItem.ToString();
			time_name = cb_LessonTime.SelectedItem.ToString();


			command = $@"SELECT direction_id FROM Directions WHERE Directions.direction_name LIKE '{direction_name}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_direction = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			command = $@"SELECT form_id FROM LessonsForms WHERE LessonsForms.form_name LIKE '{form_name}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_form = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			command = $@"SELECT time_id FROM LessonTimes WHERE LessonTimes.time_name LIKE '{time_name}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_time = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			int days = ConvertCheckBoxToDecimal(combobox_week_list);

			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				try
				{
					command = $@"INSERT INTO Groups (group_name, direction, archive, lesson_form, lesson_time, lesson_day)
							VALUES (@group_name, @direction, '0', @form_name, @time_name, @days)";
					cmd = new SqlCommand(command, connection);
					connection.Open();

					cmd.Parameters.Add("@group_name", SqlDbType.NChar, 10).Value = group_name;
					cmd.Parameters.Add("@direction", SqlDbType.SmallInt, 32).Value = id_direction;
					cmd.Parameters.Add("@form_name", SqlDbType.TinyInt, 32).Value = id_form;
					cmd.Parameters.Add("@time_name", SqlDbType.TinyInt, 32).Value = id_time;
					cmd.Parameters.Add("@days", SqlDbType.TinyInt, 32).Value = days;

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
			SELECT	[Группа] = group_name, 
					[Направление] = direction_name, 
					[Архив] = IIF(Groups.archive = 1, 'В архиве', 'Не в архиве'),
					[Форма обучения] = form_name,
					[Время обучения] = time_name,
					[Дни обучения] = lesson_day
			FROM Groups, Directions, LessonsForms, LessonTimes 
			WHERE Groups.direction = Directions.direction_id
			AND Groups.lesson_form = LessonsForms.form_id
			AND Groups.lesson_time = LessonTimes.time_id";
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
			cb_NewLessonForm.SelectedIndex = cb_NewLessonForm.FindString(dgv_GroupList.Rows[dgv_GroupList.CurrentCell.RowIndex].Cells[3].Value.ToString());
			cb_NewLessonTime.SelectedIndex = cb_NewLessonTime.FindString(dgv_GroupList.Rows[dgv_GroupList.CurrentCell.RowIndex].Cells[4].Value.ToString());
			if(!(dgv_GroupList.Rows[dgv_GroupList.CurrentCell.RowIndex].Cells[2].Value.ToString() == "Не в архиве"))
				chkb_Archive.Checked = true;
			else
				chkb_Archive.Checked = false;

			string command = $@"(SELECT group_id FROM Groups WHERE Groups.group_name ='{tb_NewGroupName.Text}')";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_group = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			command = $@"SELECT lesson_day FROM Groups WHERE Groups.group_id LIKE '{id_group}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			string days_from_DB = Convert.ToInt32(cmd.ExecuteScalar()).ToString();
			connection.Close();
			CovertDecimalToCheckBox(combobox_new_week_list, days_from_DB);
		}
		private void btn_UpdateGroup_Click(object sender, EventArgs e)
		{
			btn_UpdateGroup.Enabled = true;
			btn_Save.Visible = true;
			btn_Cancel.Visible = true;
			tb_NewGroupName.Visible = true;
			cb_NewDirection.Visible = true;
			chkb_Archive.Visible = true;
			cb_NewLessonForm.Visible = true;
			cb_NewLessonTime.Visible = true;
			ck_NewMo.Visible = true;
			ck_NewTu.Visible = true;
			ck_NewWe.Visible = true;
			ck_NewTh.Visible = true;
			ck_NewFr.Visible = true;
			ck_NewSa.Visible = true;
			ck_NewSu.Visible = true;
		}
		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			btn_UpdateGroup.Enabled = false;
			btn_Save.Visible = false;
			btn_Cancel.Visible = false;
			tb_NewGroupName.Visible = false;
			cb_NewDirection.Visible = false;
			chkb_Archive.Visible = false;
			cb_NewLessonForm.Visible = false;
			cb_NewLessonTime.Visible = false;
			ck_NewMo.Visible = false;
			ck_NewTu.Visible = false;
			ck_NewWe.Visible = false;
			ck_NewTh.Visible = false;
			ck_NewFr.Visible = false;
			ck_NewSa.Visible = false;
			ck_NewSu.Visible = false;
			l_AddResult.Text = "";
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			string command, group, direction, form_name, time_name;
			int id_direction, id_form, id_time, days;
			bool archiv;
			if (tb_NewGroupName.Text.Length == 0)
			{ MessageBox.Show("Не заполнены обязательные поля 'Имя группы'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

			group = tb_NewGroupName.Text.Trim();
			form_name = cb_NewLessonForm.SelectedItem.ToString();
			time_name = cb_NewLessonTime.SelectedItem.ToString();
			direction = cb_NewDirection.SelectedItem.ToString();
			archiv = chkb_Archive.Checked;

			command = $@"SELECT direction_id FROM Directions WHERE Directions.direction_name LIKE '{direction}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_direction = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			command = $@"SELECT form_id FROM LessonsForms WHERE LessonsForms.form_name LIKE '{form_name}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_form = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			command = $@"SELECT time_id FROM LessonTimes WHERE LessonTimes.time_name LIKE '{time_name}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_time = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			days = ConvertCheckBoxToDecimal(combobox_new_week_list);

			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				try
				{
					command = $@"UPDATE Groups 
								SET group_name = @group_name, direction = @direction, archive = @archive, lesson_form = @form_name, lesson_time = @time_name, lesson_day = @days
								WHERE group_id = @id_group";
					cmd = new SqlCommand(command, connection);
					connection.Open();
			
					cmd.Parameters.Add("@group_name", SqlDbType.NVarChar, 10).Value = group;
					cmd.Parameters.Add("@direction", SqlDbType.SmallInt).Value = id_direction;
					cmd.Parameters.Add("@archive", SqlDbType.Bit).Value = archiv;
					cmd.Parameters.Add("@id_group", SqlDbType.Int).Value = id_group;
					cmd.Parameters.Add("@form_name", SqlDbType.TinyInt, 32).Value = id_form;
					cmd.Parameters.Add("@time_name", SqlDbType.TinyInt, 32).Value = id_time;
					cmd.Parameters.Add("@days", SqlDbType.TinyInt, 32).Value = days;

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
