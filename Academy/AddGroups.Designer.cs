namespace Academy
{
	partial class AddGroups
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
			this.L_GroupName = new System.Windows.Forms.Label();
			this.tb_GroupName = new System.Windows.Forms.TextBox();
			this.btn_AddGroup = new System.Windows.Forms.Button();
			this.l_AddResult = new System.Windows.Forms.Label();
			this.cb_Direction = new System.Windows.Forms.ComboBox();
			this.l_DirectionName = new System.Windows.Forms.Label();
			this.dgv_GroupList = new System.Windows.Forms.DataGridView();
			this.btn_UpdateGroup = new System.Windows.Forms.Button();
			this.tb_NewGroupName = new System.Windows.Forms.TextBox();
			this.cb_NewDirection = new System.Windows.Forms.ComboBox();
			this.chkb_Archive = new System.Windows.Forms.CheckBox();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_GroupList)).BeginInit();
			this.SuspendLayout();
			// 
			// L_GroupName
			// 
			this.L_GroupName.AutoSize = true;
			this.L_GroupName.Location = new System.Drawing.Point(13, 13);
			this.L_GroupName.Name = "L_GroupName";
			this.L_GroupName.Size = new System.Drawing.Size(123, 16);
			this.L_GroupName.TabIndex = 0;
			this.L_GroupName.Text = "Название группы";
			// 
			// tb_GroupName
			// 
			this.tb_GroupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_GroupName.Location = new System.Drawing.Point(16, 32);
			this.tb_GroupName.MaxLength = 10;
			this.tb_GroupName.Name = "tb_GroupName";
			this.tb_GroupName.Size = new System.Drawing.Size(221, 22);
			this.tb_GroupName.TabIndex = 4;
			// 
			// btn_AddGroup
			// 
			this.btn_AddGroup.Location = new System.Drawing.Point(16, 158);
			this.btn_AddGroup.Name = "btn_AddGroup";
			this.btn_AddGroup.Size = new System.Drawing.Size(137, 32);
			this.btn_AddGroup.TabIndex = 5;
			this.btn_AddGroup.Text = "Добавить группу";
			this.btn_AddGroup.UseVisualStyleBackColor = true;
			this.btn_AddGroup.Click += new System.EventHandler(this.btn_AddGroup_Click);
			// 
			// l_AddResult
			// 
			this.l_AddResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.l_AddResult.AutoSize = true;
			this.l_AddResult.Location = new System.Drawing.Point(172, 166);
			this.l_AddResult.Name = "l_AddResult";
			this.l_AddResult.Size = new System.Drawing.Size(0, 16);
			this.l_AddResult.TabIndex = 6;
			// 
			// cb_Direction
			// 
			this.cb_Direction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.cb_Direction.FormattingEnabled = true;
			this.cb_Direction.Location = new System.Drawing.Point(12, 96);
			this.cb_Direction.Name = "cb_Direction";
			this.cb_Direction.Size = new System.Drawing.Size(221, 24);
			this.cb_Direction.TabIndex = 8;
			// 
			// l_DirectionName
			// 
			this.l_DirectionName.AutoSize = true;
			this.l_DirectionName.Location = new System.Drawing.Point(13, 68);
			this.l_DirectionName.Name = "l_DirectionName";
			this.l_DirectionName.Size = new System.Drawing.Size(97, 16);
			this.l_DirectionName.TabIndex = 9;
			this.l_DirectionName.Text = "Направление";
			// 
			// dgv_GroupList
			// 
			this.dgv_GroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_GroupList.Location = new System.Drawing.Point(16, 212);
			this.dgv_GroupList.Name = "dgv_GroupList";
			this.dgv_GroupList.ReadOnly = true;
			this.dgv_GroupList.RowHeadersWidth = 51;
			this.dgv_GroupList.RowTemplate.Height = 24;
			this.dgv_GroupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_GroupList.Size = new System.Drawing.Size(697, 336);
			this.dgv_GroupList.TabIndex = 10;
			this.dgv_GroupList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GroupList_CellClick);
			// 
			// btn_UpdateGroup
			// 
			this.btn_UpdateGroup.Location = new System.Drawing.Point(570, 33);
			this.btn_UpdateGroup.Name = "btn_UpdateGroup";
			this.btn_UpdateGroup.Size = new System.Drawing.Size(143, 31);
			this.btn_UpdateGroup.TabIndex = 11;
			this.btn_UpdateGroup.Text = "Изменить группу";
			this.btn_UpdateGroup.UseVisualStyleBackColor = true;
			this.btn_UpdateGroup.Click += new System.EventHandler(this.btn_UpdateGroup_Click);
			// 
			// tb_NewGroupName
			// 
			this.tb_NewGroupName.Location = new System.Drawing.Point(345, 32);
			this.tb_NewGroupName.Name = "tb_NewGroupName";
			this.tb_NewGroupName.Size = new System.Drawing.Size(206, 22);
			this.tb_NewGroupName.TabIndex = 12;
			// 
			// cb_NewDirection
			// 
			this.cb_NewDirection.FormattingEnabled = true;
			this.cb_NewDirection.Location = new System.Drawing.Point(345, 96);
			this.cb_NewDirection.Name = "cb_NewDirection";
			this.cb_NewDirection.Size = new System.Drawing.Size(206, 24);
			this.cb_NewDirection.TabIndex = 13;
			// 
			// chkb_Archive
			// 
			this.chkb_Archive.AutoSize = true;
			this.chkb_Archive.Location = new System.Drawing.Point(345, 144);
			this.chkb_Archive.Name = "chkb_Archive";
			this.chkb_Archive.Size = new System.Drawing.Size(87, 20);
			this.chkb_Archive.TabIndex = 14;
			this.chkb_Archive.Text = "В архиве";
			this.chkb_Archive.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(570, 70);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(143, 31);
			this.btn_Save.TabIndex = 15;
			this.btn_Save.Text = "Сохранить";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(570, 107);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(143, 31);
			this.btn_Cancel.TabIndex = 16;
			this.btn_Cancel.Text = "Отмена";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// AddGroups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 560);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.chkb_Archive);
			this.Controls.Add(this.cb_NewDirection);
			this.Controls.Add(this.tb_NewGroupName);
			this.Controls.Add(this.btn_UpdateGroup);
			this.Controls.Add(this.dgv_GroupList);
			this.Controls.Add(this.l_DirectionName);
			this.Controls.Add(this.cb_Direction);
			this.Controls.Add(this.l_AddResult);
			this.Controls.Add(this.btn_AddGroup);
			this.Controls.Add(this.tb_GroupName);
			this.Controls.Add(this.L_GroupName);
			this.Name = "AddGroups";
			this.Text = "AddGroups";
			((System.ComponentModel.ISupportInitialize)(this.dgv_GroupList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label L_GroupName;
		private System.Windows.Forms.TextBox tb_GroupName;
		private System.Windows.Forms.Button btn_AddGroup;
		private System.Windows.Forms.Label l_AddResult;
		private System.Windows.Forms.ComboBox cb_Direction;
		private System.Windows.Forms.Label l_DirectionName;
		private System.Windows.Forms.DataGridView dgv_GroupList;
		private System.Windows.Forms.Button btn_UpdateGroup;
		private System.Windows.Forms.TextBox tb_NewGroupName;
		private System.Windows.Forms.ComboBox cb_NewDirection;
		private System.Windows.Forms.CheckBox chkb_Archive;
		private System.Windows.Forms.Button btn_Save;
		private System.Windows.Forms.Button btn_Cancel;
	}
}