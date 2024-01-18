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
			this.tb_GroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_GroupName.Location = new System.Drawing.Point(16, 42);
			this.tb_GroupName.Name = "tb_GroupName";
			this.tb_GroupName.Size = new System.Drawing.Size(483, 22);
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
			this.l_AddResult.AutoSize = true;
			this.l_AddResult.Location = new System.Drawing.Point(172, 166);
			this.l_AddResult.Name = "l_AddResult";
			this.l_AddResult.Size = new System.Drawing.Size(0, 16);
			this.l_AddResult.TabIndex = 6;
			// 
			// cb_Direction
			// 
			this.cb_Direction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cb_Direction.FormattingEnabled = true;
			this.cb_Direction.Location = new System.Drawing.Point(16, 111);
			this.cb_Direction.Name = "cb_Direction";
			this.cb_Direction.Size = new System.Drawing.Size(483, 24);
			this.cb_Direction.TabIndex = 8;
			// 
			// l_DirectionName
			// 
			this.l_DirectionName.AutoSize = true;
			this.l_DirectionName.Location = new System.Drawing.Point(13, 79);
			this.l_DirectionName.Name = "l_DirectionName";
			this.l_DirectionName.Size = new System.Drawing.Size(97, 16);
			this.l_DirectionName.TabIndex = 9;
			this.l_DirectionName.Text = "Направление";
			// 
			// AddGroups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 198);
			this.Controls.Add(this.l_DirectionName);
			this.Controls.Add(this.cb_Direction);
			this.Controls.Add(this.l_AddResult);
			this.Controls.Add(this.btn_AddGroup);
			this.Controls.Add(this.tb_GroupName);
			this.Controls.Add(this.L_GroupName);
			this.Name = "AddGroups";
			this.Text = "AddGroups";
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
	}
}