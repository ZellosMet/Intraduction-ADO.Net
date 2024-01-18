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
			((System.ComponentModel.ISupportInitialize)(this.dgv_SudentsList)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_CurrentGroup
			// 
			this.cb_CurrentGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.cb_CurrentGroup.FormattingEnabled = true;
			this.cb_CurrentGroup.Location = new System.Drawing.Point(193, 73);
			this.cb_CurrentGroup.Name = "cb_CurrentGroup";
			this.cb_CurrentGroup.Size = new System.Drawing.Size(490, 24);
			this.cb_CurrentGroup.TabIndex = 0;
			this.cb_CurrentGroup.SelectedIndexChanged += new System.EventHandler(this.cb_CurrentGroup_SelectedIndexChanged);
			// 
			// l_GroupName
			// 
			this.l_GroupName.AutoSize = true;
			this.l_GroupName.Location = new System.Drawing.Point(12, 73);
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
			this.dgv_SudentsList.Location = new System.Drawing.Point(15, 103);
			this.dgv_SudentsList.MultiSelect = false;
			this.dgv_SudentsList.Name = "dgv_SudentsList";
			this.dgv_SudentsList.ReadOnly = true;
			this.dgv_SudentsList.RowHeadersWidth = 51;
			this.dgv_SudentsList.RowTemplate.Height = 24;
			this.dgv_SudentsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_SudentsList.Size = new System.Drawing.Size(773, 395);
			this.dgv_SudentsList.TabIndex = 2;
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
			this.btn_Refresh.Location = new System.Drawing.Point(689, 74);
			this.btn_Refresh.Name = "btn_Refresh";
			this.btn_Refresh.Size = new System.Drawing.Size(99, 23);
			this.btn_Refresh.TabIndex = 4;
			this.btn_Refresh.Text = "Обновить";
			this.btn_Refresh.UseVisualStyleBackColor = true;
			this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 498);
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
	}
}

