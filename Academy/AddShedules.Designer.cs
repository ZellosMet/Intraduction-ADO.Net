namespace Academy
{
	partial class AddShedules
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cb_Groups = new System.Windows.Forms.ComboBox();
			this.cb_Disciplines = new System.Windows.Forms.ComboBox();
			this.cb_Teachers = new System.Windows.Forms.ComboBox();
			this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
			this.btn_AddSchedule = new System.Windows.Forms.Button();
			this.l_GroupName = new System.Windows.Forms.Label();
			this.l_DisciplinesName = new System.Windows.Forms.Label();
			this.l_TeacherName = new System.Windows.Forms.Label();
			this.l_StartDate = new System.Windows.Forms.Label();
			this.tb_Time = new System.Windows.Forms.TextBox();
			this.l_Time = new System.Windows.Forms.Label();
			this.l_Result = new System.Windows.Forms.Label();
			this.dgv_ScheduleList = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleList)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_Groups
			// 
			this.cb_Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_Groups.FormattingEnabled = true;
			this.cb_Groups.Location = new System.Drawing.Point(13, 36);
			this.cb_Groups.Name = "cb_Groups";
			this.cb_Groups.Size = new System.Drawing.Size(409, 24);
			this.cb_Groups.TabIndex = 0;
			// 
			// cb_Disciplines
			// 
			this.cb_Disciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_Disciplines.FormattingEnabled = true;
			this.cb_Disciplines.Location = new System.Drawing.Point(13, 87);
			this.cb_Disciplines.Name = "cb_Disciplines";
			this.cb_Disciplines.Size = new System.Drawing.Size(409, 24);
			this.cb_Disciplines.TabIndex = 1;
			// 
			// cb_Teachers
			// 
			this.cb_Teachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_Teachers.FormattingEnabled = true;
			this.cb_Teachers.Location = new System.Drawing.Point(13, 132);
			this.cb_Teachers.Name = "cb_Teachers";
			this.cb_Teachers.Size = new System.Drawing.Size(409, 24);
			this.cb_Teachers.TabIndex = 2;
			// 
			// dtp_StartDate
			// 
			this.dtp_StartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtp_StartDate.Location = new System.Drawing.Point(13, 182);
			this.dtp_StartDate.Name = "dtp_StartDate";
			this.dtp_StartDate.Size = new System.Drawing.Size(409, 22);
			this.dtp_StartDate.TabIndex = 3;
			// 
			// btn_AddSchedule
			// 
			this.btn_AddSchedule.Location = new System.Drawing.Point(13, 290);
			this.btn_AddSchedule.Name = "btn_AddSchedule";
			this.btn_AddSchedule.Size = new System.Drawing.Size(172, 32);
			this.btn_AddSchedule.TabIndex = 4;
			this.btn_AddSchedule.Text = "Добавить расписание";
			this.btn_AddSchedule.UseVisualStyleBackColor = true;
			this.btn_AddSchedule.Click += new System.EventHandler(this.btn_AddSchedule_Click);
			// 
			// l_GroupName
			// 
			this.l_GroupName.AutoSize = true;
			this.l_GroupName.Location = new System.Drawing.Point(13, 14);
			this.l_GroupName.Name = "l_GroupName";
			this.l_GroupName.Size = new System.Drawing.Size(54, 16);
			this.l_GroupName.TabIndex = 5;
			this.l_GroupName.Text = "Группа";
			// 
			// l_DisciplinesName
			// 
			this.l_DisciplinesName.AutoSize = true;
			this.l_DisciplinesName.Location = new System.Drawing.Point(12, 68);
			this.l_DisciplinesName.Name = "l_DisciplinesName";
			this.l_DisciplinesName.Size = new System.Drawing.Size(87, 16);
			this.l_DisciplinesName.TabIndex = 6;
			this.l_DisciplinesName.Text = "Дисциплина";
			// 
			// l_TeacherName
			// 
			this.l_TeacherName.AutoSize = true;
			this.l_TeacherName.Location = new System.Drawing.Point(10, 114);
			this.l_TeacherName.Name = "l_TeacherName";
			this.l_TeacherName.Size = new System.Drawing.Size(111, 16);
			this.l_TeacherName.TabIndex = 7;
			this.l_TeacherName.Text = "Преподаватель";
			// 
			// l_StartDate
			// 
			this.l_StartDate.AutoSize = true;
			this.l_StartDate.Location = new System.Drawing.Point(10, 159);
			this.l_StartDate.Name = "l_StartDate";
			this.l_StartDate.Size = new System.Drawing.Size(137, 16);
			this.l_StartDate.TabIndex = 8;
			this.l_StartDate.Text = "Начало расписания";
			// 
			// tb_Time
			// 
			this.tb_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Time.Location = new System.Drawing.Point(12, 236);
			this.tb_Time.MaxLength = 5;
			this.tb_Time.Name = "tb_Time";
			this.tb_Time.Size = new System.Drawing.Size(410, 22);
			this.tb_Time.TabIndex = 10;
			this.tb_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Time_KeyPress);
			// 
			// l_Time
			// 
			this.l_Time.AutoSize = true;
			this.l_Time.Location = new System.Drawing.Point(12, 214);
			this.l_Time.Name = "l_Time";
			this.l_Time.Size = new System.Drawing.Size(48, 16);
			this.l_Time.TabIndex = 11;
			this.l_Time.Text = "Время";
			// 
			// l_Result
			// 
			this.l_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.l_Result.AutoSize = true;
			this.l_Result.Location = new System.Drawing.Point(207, 306);
			this.l_Result.Name = "l_Result";
			this.l_Result.Size = new System.Drawing.Size(0, 16);
			this.l_Result.TabIndex = 12;
			// 
			// dgv_ScheduleList
			// 
			this.dgv_ScheduleList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_ScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_ScheduleList.Location = new System.Drawing.Point(445, 36);
			this.dgv_ScheduleList.Name = "dgv_ScheduleList";
			this.dgv_ScheduleList.RowHeadersWidth = 51;
			this.dgv_ScheduleList.RowTemplate.Height = 24;
			this.dgv_ScheduleList.Size = new System.Drawing.Size(894, 285);
			this.dgv_ScheduleList.TabIndex = 13;
			// 
			// AddShedules
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1355, 333);
			this.Controls.Add(this.dgv_ScheduleList);
			this.Controls.Add(this.l_Result);
			this.Controls.Add(this.l_Time);
			this.Controls.Add(this.tb_Time);
			this.Controls.Add(this.l_StartDate);
			this.Controls.Add(this.l_TeacherName);
			this.Controls.Add(this.l_DisciplinesName);
			this.Controls.Add(this.l_GroupName);
			this.Controls.Add(this.btn_AddSchedule);
			this.Controls.Add(this.dtp_StartDate);
			this.Controls.Add(this.cb_Teachers);
			this.Controls.Add(this.cb_Disciplines);
			this.Controls.Add(this.cb_Groups);
			this.Name = "AddShedules";
			this.Text = "AddShedules";
			((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_Groups;
		private System.Windows.Forms.ComboBox cb_Disciplines;
		private System.Windows.Forms.ComboBox cb_Teachers;
		private System.Windows.Forms.DateTimePicker dtp_StartDate;
		private System.Windows.Forms.Button btn_AddSchedule;
		private System.Windows.Forms.Label l_GroupName;
		private System.Windows.Forms.Label l_DisciplinesName;
		private System.Windows.Forms.Label l_TeacherName;
		private System.Windows.Forms.Label l_StartDate;
		private System.Windows.Forms.TextBox tb_Time;
		private System.Windows.Forms.Label l_Time;
		private System.Windows.Forms.Label l_Result;
		private System.Windows.Forms.DataGridView dgv_ScheduleList;
	}
}