namespace Academy
{
	partial class StudentInfo
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
			this.l_FirstName = new System.Windows.Forms.Label();
			this.l_LastName = new System.Windows.Forms.Label();
			this.l_MiddleName = new System.Windows.Forms.Label();
			this.l_BirthDate = new System.Windows.Forms.Label();
			this.l_Group = new System.Windows.Forms.Label();
			this.dgv_Attandances = new System.Windows.Forms.DataGridView();
			this.dgv_Grades = new System.Windows.Forms.DataGridView();
			this.l_Attendances = new System.Windows.Forms.Label();
			this.l_Grades = new System.Windows.Forms.Label();
			this.btn_UpdateStudent = new System.Windows.Forms.Button();
			this.tb_NewFirstName = new System.Windows.Forms.TextBox();
			this.tb_NewLastName = new System.Windows.Forms.TextBox();
			this.tb_NewMiddleName = new System.Windows.Forms.TextBox();
			this.dtp_NewBirthDate = new System.Windows.Forms.DateTimePicker();
			this.cb_NewGroup = new System.Windows.Forms.ComboBox();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.l_UpdateResult = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Attandances)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Grades)).BeginInit();
			this.SuspendLayout();
			// 
			// l_FirstName
			// 
			this.l_FirstName.AutoSize = true;
			this.l_FirstName.Location = new System.Drawing.Point(13, 13);
			this.l_FirstName.Name = "l_FirstName";
			this.l_FirstName.Size = new System.Drawing.Size(39, 16);
			this.l_FirstName.TabIndex = 0;
			this.l_FirstName.Text = "Имя: ";
			// 
			// l_LastName
			// 
			this.l_LastName.AutoSize = true;
			this.l_LastName.Location = new System.Drawing.Point(13, 45);
			this.l_LastName.Name = "l_LastName";
			this.l_LastName.Size = new System.Drawing.Size(72, 16);
			this.l_LastName.TabIndex = 1;
			this.l_LastName.Text = "Фамилия: ";
			// 
			// l_MiddleName
			// 
			this.l_MiddleName.AutoSize = true;
			this.l_MiddleName.Location = new System.Drawing.Point(13, 78);
			this.l_MiddleName.Name = "l_MiddleName";
			this.l_MiddleName.Size = new System.Drawing.Size(76, 16);
			this.l_MiddleName.TabIndex = 2;
			this.l_MiddleName.Text = "Отчество: ";
			// 
			// l_BirthDate
			// 
			this.l_BirthDate.AutoSize = true;
			this.l_BirthDate.Location = new System.Drawing.Point(13, 111);
			this.l_BirthDate.Name = "l_BirthDate";
			this.l_BirthDate.Size = new System.Drawing.Size(112, 16);
			this.l_BirthDate.TabIndex = 3;
			this.l_BirthDate.Text = "Дата рождения: ";
			// 
			// l_Group
			// 
			this.l_Group.AutoSize = true;
			this.l_Group.Location = new System.Drawing.Point(12, 142);
			this.l_Group.Name = "l_Group";
			this.l_Group.Size = new System.Drawing.Size(60, 16);
			this.l_Group.TabIndex = 4;
			this.l_Group.Text = "Группа: ";
			// 
			// dgv_Attandances
			// 
			this.dgv_Attandances.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dgv_Attandances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Attandances.Location = new System.Drawing.Point(19, 205);
			this.dgv_Attandances.Name = "dgv_Attandances";
			this.dgv_Attandances.RowHeadersWidth = 51;
			this.dgv_Attandances.RowTemplate.Height = 24;
			this.dgv_Attandances.Size = new System.Drawing.Size(611, 370);
			this.dgv_Attandances.TabIndex = 5;
			// 
			// dgv_Grades
			// 
			this.dgv_Grades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_Grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_Grades.Location = new System.Drawing.Point(652, 205);
			this.dgv_Grades.Name = "dgv_Grades";
			this.dgv_Grades.RowHeadersWidth = 51;
			this.dgv_Grades.RowTemplate.Height = 24;
			this.dgv_Grades.Size = new System.Drawing.Size(473, 370);
			this.dgv_Grades.TabIndex = 6;
			// 
			// l_Attendances
			// 
			this.l_Attendances.AutoSize = true;
			this.l_Attendances.Location = new System.Drawing.Point(19, 183);
			this.l_Attendances.Name = "l_Attendances";
			this.l_Attendances.Size = new System.Drawing.Size(103, 16);
			this.l_Attendances.TabIndex = 7;
			this.l_Attendances.Text = "Посещаемость";
			// 
			// l_Grades
			// 
			this.l_Grades.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.l_Grades.AutoSize = true;
			this.l_Grades.Location = new System.Drawing.Point(652, 182);
			this.l_Grades.Name = "l_Grades";
			this.l_Grades.Size = new System.Drawing.Size(101, 16);
			this.l_Grades.TabIndex = 8;
			this.l_Grades.Text = "Успеваемость";
			// 
			// btn_UpdateStudent
			// 
			this.btn_UpdateStudent.Location = new System.Drawing.Point(652, 10);
			this.btn_UpdateStudent.Name = "btn_UpdateStudent";
			this.btn_UpdateStudent.Size = new System.Drawing.Size(204, 26);
			this.btn_UpdateStudent.TabIndex = 9;
			this.btn_UpdateStudent.Text = "Изменить студента";
			this.btn_UpdateStudent.UseVisualStyleBackColor = true;
			this.btn_UpdateStudent.Click += new System.EventHandler(this.btn_UpdateStudent_Click);
			// 
			// tb_NewFirstName
			// 
			this.tb_NewFirstName.Location = new System.Drawing.Point(428, 10);
			this.tb_NewFirstName.Name = "tb_NewFirstName";
			this.tb_NewFirstName.Size = new System.Drawing.Size(201, 22);
			this.tb_NewFirstName.TabIndex = 10;
			// 
			// tb_NewLastName
			// 
			this.tb_NewLastName.Location = new System.Drawing.Point(428, 42);
			this.tb_NewLastName.Name = "tb_NewLastName";
			this.tb_NewLastName.Size = new System.Drawing.Size(201, 22);
			this.tb_NewLastName.TabIndex = 11;
			// 
			// tb_NewMiddleName
			// 
			this.tb_NewMiddleName.Location = new System.Drawing.Point(428, 72);
			this.tb_NewMiddleName.Name = "tb_NewMiddleName";
			this.tb_NewMiddleName.Size = new System.Drawing.Size(201, 22);
			this.tb_NewMiddleName.TabIndex = 12;
			// 
			// dtp_NewBirthDate
			// 
			this.dtp_NewBirthDate.Location = new System.Drawing.Point(428, 104);
			this.dtp_NewBirthDate.Name = "dtp_NewBirthDate";
			this.dtp_NewBirthDate.Size = new System.Drawing.Size(200, 22);
			this.dtp_NewBirthDate.TabIndex = 13;
			// 
			// cb_NewGroup
			// 
			this.cb_NewGroup.FormattingEnabled = true;
			this.cb_NewGroup.Location = new System.Drawing.Point(428, 142);
			this.cb_NewGroup.Name = "cb_NewGroup";
			this.cb_NewGroup.Size = new System.Drawing.Size(200, 24);
			this.cb_NewGroup.TabIndex = 14;
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(652, 42);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(204, 23);
			this.btn_Save.TabIndex = 15;
			this.btn_Save.Text = "Сохранить";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(652, 71);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(204, 23);
			this.btn_Cancel.TabIndex = 16;
			this.btn_Cancel.Text = "Отмена";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// l_UpdateResult
			// 
			this.l_UpdateResult.AutoSize = true;
			this.l_UpdateResult.Location = new System.Drawing.Point(652, 104);
			this.l_UpdateResult.Name = "l_UpdateResult";
			this.l_UpdateResult.Size = new System.Drawing.Size(0, 16);
			this.l_UpdateResult.TabIndex = 17;
			// 
			// StudentInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1143, 598);
			this.Controls.Add(this.l_UpdateResult);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.cb_NewGroup);
			this.Controls.Add(this.dtp_NewBirthDate);
			this.Controls.Add(this.tb_NewMiddleName);
			this.Controls.Add(this.tb_NewLastName);
			this.Controls.Add(this.tb_NewFirstName);
			this.Controls.Add(this.btn_UpdateStudent);
			this.Controls.Add(this.l_Grades);
			this.Controls.Add(this.l_Attendances);
			this.Controls.Add(this.dgv_Grades);
			this.Controls.Add(this.dgv_Attandances);
			this.Controls.Add(this.l_Group);
			this.Controls.Add(this.l_BirthDate);
			this.Controls.Add(this.l_MiddleName);
			this.Controls.Add(this.l_LastName);
			this.Controls.Add(this.l_FirstName);
			this.Name = "StudentInfo";
			this.Text = "StudentInfo";
			((System.ComponentModel.ISupportInitialize)(this.dgv_Attandances)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Grades)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label l_FirstName;
		private System.Windows.Forms.Label l_LastName;
		private System.Windows.Forms.Label l_MiddleName;
		private System.Windows.Forms.Label l_BirthDate;
		private System.Windows.Forms.Label l_Group;
		private System.Windows.Forms.DataGridView dgv_Attandances;
		private System.Windows.Forms.DataGridView dgv_Grades;
		private System.Windows.Forms.Label l_Attendances;
		private System.Windows.Forms.Label l_Grades;
		private System.Windows.Forms.Button btn_UpdateStudent;
		private System.Windows.Forms.TextBox tb_NewFirstName;
		private System.Windows.Forms.TextBox tb_NewLastName;
		private System.Windows.Forms.TextBox tb_NewMiddleName;
		private System.Windows.Forms.DateTimePicker dtp_NewBirthDate;
		private System.Windows.Forms.ComboBox cb_NewGroup;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.Label l_UpdateResult;
	}
}