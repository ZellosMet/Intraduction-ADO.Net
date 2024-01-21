namespace Academy
{
	partial class Form1
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
			this.cb_CurrentGroup = new System.Windows.Forms.ComboBox();
			this.l_GroupName = new System.Windows.Forms.Label();
			this.dgv_SudentsList = new System.Windows.Forms.DataGridView();
			this.btn_AddStudents = new System.Windows.Forms.Button();
			this.btn_Refresh = new System.Windows.Forms.Button();
			this.btn_AddGroups = new System.Windows.Forms.Button();
			this.btn_AddShedules = new System.Windows.Forms.Button();
			this.l_Search = new System.Windows.Forms.Label();
			this.tb_Search = new System.Windows.Forms.TextBox();
			this.l_CountStudents = new System.Windows.Forms.Label();
			this.rb_ForGroup = new System.Windows.Forms.RadioButton();
			this.rb_ForSpeciality = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgv_SudentsList)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_CurrentGroup
			// 
			this.cb_CurrentGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.cb_CurrentGroup.FormattingEnabled = true;
			this.cb_CurrentGroup.Location = new System.Drawing.Point(193, 114);
			this.cb_CurrentGroup.Name = "cb_CurrentGroup";
			this.cb_CurrentGroup.Size = new System.Drawing.Size(291, 24);
			this.cb_CurrentGroup.TabIndex = 0;
			this.cb_CurrentGroup.SelectedIndexChanged += new System.EventHandler(this.cb_CurrentGroup_SelectedIndexChanged);
			// 
			// l_GroupName
			// 
			this.l_GroupName.AutoSize = true;
			this.l_GroupName.Location = new System.Drawing.Point(12, 114);
			this.l_GroupName.Name = "l_GroupName";
			this.l_GroupName.Size = new System.Drawing.Size(162, 16);
			this.l_GroupName.TabIndex = 1;
			this.l_GroupName.Text = "Наименование группы :";
			// 
			// dgv_SudentsList
			// 
			this.dgv_SudentsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_SudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_SudentsList.Location = new System.Drawing.Point(15, 195);
			this.dgv_SudentsList.MultiSelect = false;
			this.dgv_SudentsList.Name = "dgv_SudentsList";
			this.dgv_SudentsList.ReadOnly = true;
			this.dgv_SudentsList.RowHeadersWidth = 51;
			this.dgv_SudentsList.RowTemplate.Height = 24;
			this.dgv_SudentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_SudentsList.Size = new System.Drawing.Size(773, 338);
			this.dgv_SudentsList.TabIndex = 2;
			this.dgv_SudentsList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SudentsList_CellContentDoubleClick);
			// 
			// btn_AddStudents
			// 
			this.btn_AddStudents.Location = new System.Drawing.Point(15, 22);
			this.btn_AddStudents.Name = "btn_AddStudents";
			this.btn_AddStudents.Size = new System.Drawing.Size(159, 29);
			this.btn_AddStudents.TabIndex = 3;
			this.btn_AddStudents.Text = "Добавить студента";
			this.btn_AddStudents.UseVisualStyleBackColor = true;
			this.btn_AddStudents.Click += new System.EventHandler(this.btn_AddStudents_Click);
			// 
			// btn_Refresh
			// 
			this.btn_Refresh.Location = new System.Drawing.Point(490, 114);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(99, 24);
			this.btn_Refresh.TabIndex = 4;
			this.btn_Refresh.Text = "Обновить";
			this.btn_Refresh.UseVisualStyleBackColor = true;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			// 
			// btn_AddGroups
			// 
			this.btn_AddGroups.Location = new System.Drawing.Point(193, 22);
			this.btn_AddGroups.Name = "btn_AddGroups";
			this.btn_AddGroups.Size = new System.Drawing.Size(143, 29);
			this.btn_AddGroups.TabIndex = 5;
			this.btn_AddGroups.Text = "Добавить группу";
			this.btn_AddGroups.UseVisualStyleBackColor = true;
			this.btn_AddGroups.Click += new System.EventHandler(this.btn_AddGroups_Click);
			// 
			// btn_AddShedules
			// 
			this.btn_AddShedules.Location = new System.Drawing.Point(355, 22);
			this.btn_AddShedules.Name = "btn_AddShedules";
			this.btn_AddShedules.Size = new System.Drawing.Size(171, 29);
			this.btn_AddShedules.TabIndex = 6;
			this.btn_AddShedules.Text = "Добавить расписание";
			this.btn_AddShedules.UseVisualStyleBackColor = true;
			this.btn_AddShedules.Click += new System.EventHandler(this.btn_AddShedules_Click);
			// 
			// l_Search
			// 
			this.l_Search.AutoSize = true;
			this.l_Search.Location = new System.Drawing.Point(12, 155);
			this.l_Search.Name = "l_Search";
			this.l_Search.Size = new System.Drawing.Size(199, 16);
			this.l_Search.TabIndex = 7;
			this.l_Search.Text = "Поиск по фамилии студента: ";
			// 
			// tb_Search
			// 
			this.tb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_Search.Location = new System.Drawing.Point(223, 155);
			this.tb_Search.Name = "tb_Search";
			this.tb_Search.Size = new System.Drawing.Size(565, 22);
			this.tb_Search.TabIndex = 8;
			this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
			// 
			// l_CountStudents
			// 
			this.l_CountStudents.AutoSize = true;
			this.l_CountStudents.Location = new System.Drawing.Point(595, 122);
			this.l_CountStudents.Name = "l_CountStudents";
			this.l_CountStudents.Size = new System.Drawing.Size(0, 16);
			this.l_CountStudents.TabIndex = 9;
			// 
			// rb_ForGroup
			// 
			this.rb_ForGroup.AutoSize = true;
			this.rb_ForGroup.Location = new System.Drawing.Point(15, 73);
			this.rb_ForGroup.Name = "rb_ForGroup";
			this.rb_ForGroup.Size = new System.Drawing.Size(146, 20);
			this.rb_ForGroup.TabIndex = 10;
			this.rb_ForGroup.TabStop = true;
			this.rb_ForGroup.Text = "Отбор по группам";
			this.rb_ForGroup.UseVisualStyleBackColor = true;
			this.rb_ForGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rb_ForGroup_MouseClick);
			// 
			// rb_ForSpeciality
			// 
			this.rb_ForSpeciality.AutoSize = true;
			this.rb_ForSpeciality.Location = new System.Drawing.Point(193, 73);
			this.rb_ForSpeciality.Name = "rb_ForSpeciality";
			this.rb_ForSpeciality.Size = new System.Drawing.Size(199, 20);
			this.rb_ForSpeciality.TabIndex = 11;
			this.rb_ForSpeciality.TabStop = true;
			this.rb_ForSpeciality.Text = "Отбор по специальностям";
			this.rb_ForSpeciality.UseVisualStyleBackColor = true;
			this.rb_ForSpeciality.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rb_ForSpeciality_MouseClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 545);
			this.Controls.Add(this.rb_ForSpeciality);
			this.Controls.Add(this.rb_ForGroup);
			this.Controls.Add(this.l_CountStudents);
			this.Controls.Add(this.tb_Search);
			this.Controls.Add(this.l_Search);
			this.Controls.Add(this.btn_AddShedules);
			this.Controls.Add(this.btn_AddGroups);
			this.Controls.Add(this.btn_Refresh);
			this.Controls.Add(this.btn_AddStudents);
			this.Controls.Add(this.dgv_SudentsList);
			this.Controls.Add(this.l_GroupName);
			this.Controls.Add(this.cb_CurrentGroup);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgv_SudentsList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_CurrentGroup;
		private System.Windows.Forms.Label l_GroupName;
		private System.Windows.Forms.DataGridView dgv_SudentsList;
		private System.Windows.Forms.Button btn_AddStudents;
		private System.Windows.Forms.Button btn_Refresh;
		private System.Windows.Forms.Button btn_AddGroups;
		private System.Windows.Forms.Button btn_AddShedules;
		private System.Windows.Forms.Label l_Search;
		private System.Windows.Forms.TextBox tb_Search;
		private System.Windows.Forms.Label l_CountStudents;
		private System.Windows.Forms.RadioButton rb_ForGroup;
		private System.Windows.Forms.RadioButton rb_ForSpeciality;
	}
}

