namespace Academy
{
	partial class AddStudents
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
			this.tb_FirsName = new System.Windows.Forms.TextBox();
			this.cb_Groups = new System.Windows.Forms.ComboBox();
			this.tb_MiddleName = new System.Windows.Forms.TextBox();
			this.tb_LastName = new System.Windows.Forms.TextBox();
			this.ofd_AddPhoto = new System.Windows.Forms.OpenFileDialog();
			this.btn_AddPhoto = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.dtp_BirthDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.l_AddResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tb_FirsName
			// 
			this.tb_FirsName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_FirsName.Location = new System.Drawing.Point(13, 33);
			this.tb_FirsName.Name = "tb_FirsName";
			this.tb_FirsName.Size = new System.Drawing.Size(552, 22);
			this.tb_FirsName.TabIndex = 0;
			// 
			// cb_Groups
			// 
			this.cb_Groups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_Groups.FormattingEnabled = true;
			this.cb_Groups.Location = new System.Drawing.Point(13, 258);
			this.cb_Groups.Name = "cb_Groups";
			this.cb_Groups.Size = new System.Drawing.Size(552, 24);
			this.cb_Groups.TabIndex = 4;
			// 
			// tb_MiddleName
			// 
			this.tb_MiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_MiddleName.Location = new System.Drawing.Point(13, 144);
			this.tb_MiddleName.Name = "tb_MiddleName";
			this.tb_MiddleName.Size = new System.Drawing.Size(552, 22);
			this.tb_MiddleName.TabIndex = 6;
			this.tb_MiddleName.TextChanged += new System.EventHandler(this.tb_MiddleName_TextChanged);
			// 
			// tb_LastName
			// 
			this.tb_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_LastName.Location = new System.Drawing.Point(13, 86);
			this.tb_LastName.Name = "tb_LastName";
			this.tb_LastName.Size = new System.Drawing.Size(552, 22);
			this.tb_LastName.TabIndex = 7;
			// 
			// ofd_AddPhoto
			// 
			this.ofd_AddPhoto.FileName = "openFileDialog1";
			// 
			// btn_AddPhoto
			// 
			this.btn_AddPhoto.Location = new System.Drawing.Point(13, 288);
			this.btn_AddPhoto.Name = "btn_AddPhoto";
			this.btn_AddPhoto.Size = new System.Drawing.Size(158, 42);
			this.btn_AddPhoto.TabIndex = 8;
			this.btn_AddPhoto.Text = "Добавить фотографию";
			this.btn_AddPhoto.UseVisualStyleBackColor = true;
			// 
			// btn_Add
			// 
			this.btn_Add.Location = new System.Drawing.Point(13, 357);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(158, 25);
			this.btn_Add.TabIndex = 9;
			this.btn_Add.Text = "Добавить студента";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// dtp_BirthDate
			// 
			this.dtp_BirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtp_BirthDate.Location = new System.Drawing.Point(13, 199);
			this.dtp_BirthDate.Name = "dtp_BirthDate";
			this.dtp_BirthDate.Size = new System.Drawing.Size(552, 22);
			this.dtp_BirthDate.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Имя";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "Фамилия";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 16);
			this.label3.TabIndex = 13;
			this.label3.Text = "Отчество";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 16);
			this.label4.TabIndex = 14;
			this.label4.Text = "Дата Рождения";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 234);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Группа";
			// 
			// l_AddResult
			// 
			this.l_AddResult.AutoSize = true;
			this.l_AddResult.Location = new System.Drawing.Point(189, 366);
			this.l_AddResult.Name = "l_AddResult";
			this.l_AddResult.Size = new System.Drawing.Size(0, 16);
			this.l_AddResult.TabIndex = 16;
			// 
			// AddStudents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 404);
			this.Controls.Add(this.l_AddResult);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtp_BirthDate);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.btn_AddPhoto);
			this.Controls.Add(this.tb_LastName);
			this.Controls.Add(this.tb_MiddleName);
			this.Controls.Add(this.cb_Groups);
			this.Controls.Add(this.tb_FirsName);
			this.Name = "AddStudents";
			this.Text = "AddStudents";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_FirsName;
		private System.Windows.Forms.ComboBox cb_Groups;
		private System.Windows.Forms.TextBox tb_MiddleName;
		private System.Windows.Forms.TextBox tb_LastName;
		private System.Windows.Forms.OpenFileDialog ofd_AddPhoto;
		private System.Windows.Forms.Button btn_AddPhoto;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.DateTimePicker dtp_BirthDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label l_AddResult;
	}
}