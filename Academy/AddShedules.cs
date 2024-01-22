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
		DataTable table;
		public AddShedules(SqlConnection connection, string connection_string)
		{
			InitializeComponent();
			this.connection = connection;
			this.connection_string = connection_string;
			
			LoadDataToComboBox();

			l_Result.Text = "";
			cb_Groups.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Disciplines.DropDownStyle = ComboBoxStyle.DropDownList;
			cb_Teachers.DropDownStyle = ComboBoxStyle.DropDownList;
			dtp_StartDate.Format = DateTimePickerFormat.Custom;
			dtp_StartDate.CustomFormat = "yyy-MM-dd";
			LoadData();

		}
		void LoadDataToComboBox()
		{
			string commandLine = @"SELECT group_name FROM Groups";
			cmd = new SqlCommand(commandLine, connection);
			connection.Open();
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
				cb_Groups.Items.Add(rdr[0]);
			rdr.Close();

			commandLine = @"SELECT discipline_name FROM Disciplines";
			cmd = new SqlCommand(commandLine, connection);
			rdr = cmd.ExecuteReader();
			while(rdr.Read())
				cb_Disciplines.Items.Add(rdr[0]);
			rdr.Close();

			commandLine = @"SELECT last_name, first_name, middle_name FROM Teachers";
			cmd = new SqlCommand(commandLine, connection);
			rdr = cmd.ExecuteReader();
			while (rdr.Read())
				cb_Teachers.Items.Add($"{rdr[0]} {rdr[1]} {rdr[2]}");
			rdr.Close();

			connection.Close();
		}

		private void btn_AddSchedule_Click(object sender, EventArgs e)
		{
			string command, t_last_name, t_first_name, t_middle_name, start_date, start_time, group, discipline;
			int id_group, id_teacher, id_discipline;

			if (tb_Time.Text.Length == 0 || !tb_Time.Text.Contains(':') || cb_Groups.Text.Length == 0 || cb_Disciplines.Text.Length == 0 || cb_Teachers.Text.Length == 0)
				{ MessageBox.Show("Не заполнены или не корректно заполнено обязательные поля 'Группа', 'Дисциплина', ' Преподаватель', 'Время'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
			t_last_name = cb_Teachers.Text.Split(' ')[0];
			t_first_name = cb_Teachers.Text.Split(' ')[1];
			t_middle_name = cb_Teachers.Text.Split(' ')[2];
			start_date = dtp_StartDate.Text.ToString().Split(' ')[0];
			group = cb_Groups.SelectedItem.ToString();
			discipline = cb_Disciplines.SelectedItem.ToString();
			start_time = tb_Time.Text;

			command = $@"SELECT group_id FROM Groups WHERE Groups.group_name LIKE '{group}'";
			cmd = new SqlCommand(command, connection);
			connection.Open();
			id_group = Convert.ToInt32(cmd.ExecuteScalar());

			command = $@"SELECT discipline_id FROM Disciplines WHERE Disciplines.discipline_name LIKE '{discipline}'";
			cmd = new SqlCommand(command, connection);
			id_discipline = Convert.ToInt32(cmd.ExecuteScalar());
			
			command = $@"SELECT teacher_id FROM Teachers WHERE Teachers.last_name LIKE '{t_last_name}' AND Teachers.first_name LIKE '{t_first_name}' AND Teachers.middle_name LIKE '{t_middle_name}'";
			cmd = new SqlCommand(command, connection);
			id_teacher = Convert.ToInt32(cmd.ExecuteScalar());
			connection.Close();

			using (SqlConnection connection = new SqlConnection(connection_string))
			{
				try
				{
					command = $@"EXEC dbo.AddSchedule @id_discipline, @id_teacher, @id_group, @start_date, @start_time";
					cmd = new SqlCommand(command, connection);
					connection.Open();

					cmd.Parameters.Add("@id_discipline", SqlDbType.SmallInt).Value = id_discipline;
					cmd.Parameters.Add("@id_teacher", SqlDbType.Int).Value = id_teacher;
					cmd.Parameters.Add("@id_group", SqlDbType.Int).Value = id_group;
					cmd.Parameters.Add("@start_date", SqlDbType.Date).Value = start_date;
					cmd.Parameters.Add("@start_time", SqlDbType.Time).Value = start_time;

					cmd.ExecuteNonQuery();
					l_Result.Text = "Расписание успешно добавлен!";
				}
				catch (Exception exc)
				{
					MessageBox.Show($"Не удалось добавить расписание. Ошибка: {exc.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					rdr?.Close();
					connection?.Close();
				}
			}
			LoadData();
		}

		private void tb_Time_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((e.KeyChar <= 47 || e.KeyChar >= 59) && e.KeyChar != 8)
				e.Handled = true;
		}
		void LoadData()
		{
			string commandLine = $@"
			SELECT [Предмет] = discipline_name, 
			[Преподаватель] = Teachers.last_name + ' ' + Teachers.first_name + ' ' + Teachers.middle_name, 
			[Дата] = [date], 
			[Время] = [time], 
			[Группа] = group_name,
			[Состояние] = IIF(spent = 1, 'Проведено', 'Запланировано')
			FROM Teachers, Groups, Schedule, Disciplines
			WHERE Disciplines.discipline_id = Schedule.discipline
			AND Teachers.teacher_id = Schedule.techer
			AND Groups.group_id = Schedule.[group]";
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
					if (i == 2) row[i] = Convert.ToString(rdr[i]).Split(' ')[0];
					else row[i] = rdr[i];
				}
				table.Rows.Add(row);
			}
			dgv_ScheduleList.DataSource = table;
			rdr.Close();

			connection.Close();
		}
	}
}
