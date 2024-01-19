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
			// StudentInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1143, 598);
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
	}
}