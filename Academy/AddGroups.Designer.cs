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
			this.l_LessonForm = new System.Windows.Forms.Label();
			this.l_LessonTime = new System.Windows.Forms.Label();
			this.l_LessonDay = new System.Windows.Forms.Label();
			this.cb_LessonForm = new System.Windows.Forms.ComboBox();
			this.cb_LessonTime = new System.Windows.Forms.ComboBox();
			this.ck_Mo = new System.Windows.Forms.CheckBox();
			this.ck_Tu = new System.Windows.Forms.CheckBox();
			this.ck_We = new System.Windows.Forms.CheckBox();
			this.ck_Th = new System.Windows.Forms.CheckBox();
			this.ck_Fr = new System.Windows.Forms.CheckBox();
			this.ck_Sa = new System.Windows.Forms.CheckBox();
			this.ck_Su = new System.Windows.Forms.CheckBox();
			this.cb_NewLessonForm = new System.Windows.Forms.ComboBox();
			this.cb_NewLessonTime = new System.Windows.Forms.ComboBox();
			this.ck_NewSu = new System.Windows.Forms.CheckBox();
			this.ck_NewSa = new System.Windows.Forms.CheckBox();
			this.ck_NewFr = new System.Windows.Forms.CheckBox();
			this.ck_NewTh = new System.Windows.Forms.CheckBox();
			this.ck_NewWe = new System.Windows.Forms.CheckBox();
			this.ck_NewTu = new System.Windows.Forms.CheckBox();
			this.ck_NewMo = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_GroupList)).BeginInit();
			this.SuspendLayout();
			// 
			// L_GroupName
			// 
			this.L_GroupName.AutoSize = true;
			this.L_GroupName.Location = new System.Drawing.Point(16, 13);
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
			this.btn_AddGroup.Location = new System.Drawing.Point(16, 280);
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
			this.l_AddResult.Location = new System.Drawing.Point(166, 296);
			this.l_AddResult.Name = "l_AddResult";
			this.l_AddResult.Size = new System.Drawing.Size(0, 16);
			this.l_AddResult.TabIndex = 6;
			// 
			// cb_Direction
			// 
			this.cb_Direction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.cb_Direction.FormattingEnabled = true;
			this.cb_Direction.Location = new System.Drawing.Point(16, 77);
			this.cb_Direction.Name = "cb_Direction";
			this.cb_Direction.Size = new System.Drawing.Size(221, 24);
			this.cb_Direction.TabIndex = 8;
			// 
			// l_DirectionName
			// 
			this.l_DirectionName.AutoSize = true;
			this.l_DirectionName.Location = new System.Drawing.Point(16, 57);
			this.l_DirectionName.Name = "l_DirectionName";
			this.l_DirectionName.Size = new System.Drawing.Size(97, 16);
			this.l_DirectionName.TabIndex = 9;
			this.l_DirectionName.Text = "Направление";
			// 
			// dgv_GroupList
			// 
			this.dgv_GroupList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_GroupList.Location = new System.Drawing.Point(16, 335);
			this.dgv_GroupList.Name = "dgv_GroupList";
			this.dgv_GroupList.ReadOnly = true;
			this.dgv_GroupList.RowHeadersWidth = 51;
			this.dgv_GroupList.RowTemplate.Height = 24;
			this.dgv_GroupList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_GroupList.Size = new System.Drawing.Size(898, 265);
			this.dgv_GroupList.TabIndex = 10;
			this.dgv_GroupList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GroupList_CellClick);
			// 
			// btn_UpdateGroup
			// 
			this.btn_UpdateGroup.Location = new System.Drawing.Point(732, 25);
			this.btn_UpdateGroup.Name = "btn_UpdateGroup";
			this.btn_UpdateGroup.Size = new System.Drawing.Size(143, 31);
			this.btn_UpdateGroup.TabIndex = 11;
			this.btn_UpdateGroup.Text = "Изменить группу";
			this.btn_UpdateGroup.UseVisualStyleBackColor = true;
			this.btn_UpdateGroup.Click += new System.EventHandler(this.btn_UpdateGroup_Click);
			// 
			// tb_NewGroupName
			// 
			this.tb_NewGroupName.Location = new System.Drawing.Point(507, 32);
			this.tb_NewGroupName.Name = "tb_NewGroupName";
			this.tb_NewGroupName.Size = new System.Drawing.Size(206, 22);
			this.tb_NewGroupName.TabIndex = 12;
			// 
			// cb_NewDirection
			// 
			this.cb_NewDirection.FormattingEnabled = true;
			this.cb_NewDirection.Location = new System.Drawing.Point(507, 77);
			this.cb_NewDirection.Name = "cb_NewDirection";
			this.cb_NewDirection.Size = new System.Drawing.Size(206, 24);
			this.cb_NewDirection.TabIndex = 13;
			// 
			// chkb_Archive
			// 
			this.chkb_Archive.AutoSize = true;
			this.chkb_Archive.Location = new System.Drawing.Point(732, 188);
			this.chkb_Archive.Name = "chkb_Archive";
			this.chkb_Archive.Size = new System.Drawing.Size(87, 20);
			this.chkb_Archive.TabIndex = 14;
			this.chkb_Archive.Text = "В архиве";
			this.chkb_Archive.UseVisualStyleBackColor = true;
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(732, 62);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(143, 31);
			this.btn_Save.TabIndex = 15;
			this.btn_Save.Text = "Сохранить";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(732, 99);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(143, 31);
			this.btn_Cancel.TabIndex = 16;
			this.btn_Cancel.Text = "Отмена";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// l_LessonForm
			// 
			this.l_LessonForm.AutoSize = true;
			this.l_LessonForm.Location = new System.Drawing.Point(16, 114);
			this.l_LessonForm.Name = "l_LessonForm";
			this.l_LessonForm.Size = new System.Drawing.Size(117, 16);
			this.l_LessonForm.TabIndex = 17;
			this.l_LessonForm.Text = "Форма обучения";
			// 
			// l_LessonTime
			// 
			this.l_LessonTime.AutoSize = true;
			this.l_LessonTime.Location = new System.Drawing.Point(16, 166);
			this.l_LessonTime.Name = "l_LessonTime";
			this.l_LessonTime.Size = new System.Drawing.Size(114, 16);
			this.l_LessonTime.TabIndex = 18;
			this.l_LessonTime.Text = "Время обучения";
			// 
			// l_LessonDay
			// 
			this.l_LessonDay.AutoSize = true;
			this.l_LessonDay.Location = new System.Drawing.Point(16, 211);
			this.l_LessonDay.Name = "l_LessonDay";
			this.l_LessonDay.Size = new System.Drawing.Size(98, 16);
			this.l_LessonDay.TabIndex = 19;
			this.l_LessonDay.Text = "Дни обучения";
			// 
			// cb_LessonForm
			// 
			this.cb_LessonForm.FormattingEnabled = true;
			this.cb_LessonForm.Location = new System.Drawing.Point(16, 134);
			this.cb_LessonForm.Name = "cb_LessonForm";
			this.cb_LessonForm.Size = new System.Drawing.Size(221, 24);
			this.cb_LessonForm.TabIndex = 20;
			// 
			// cb_LessonTime
			// 
			this.cb_LessonTime.FormattingEnabled = true;
			this.cb_LessonTime.Location = new System.Drawing.Point(16, 184);
			this.cb_LessonTime.Name = "cb_LessonTime";
			this.cb_LessonTime.Size = new System.Drawing.Size(221, 24);
			this.cb_LessonTime.TabIndex = 21;
			// 
			// ck_Mo
			// 
			this.ck_Mo.AutoSize = true;
			this.ck_Mo.Location = new System.Drawing.Point(16, 243);
			this.ck_Mo.Name = "ck_Mo";
			this.ck_Mo.Size = new System.Drawing.Size(47, 20);
			this.ck_Mo.TabIndex = 22;
			this.ck_Mo.Text = "Пн";
			this.ck_Mo.UseVisualStyleBackColor = true;
			// 
			// ck_Tu
			// 
			this.ck_Tu.AutoSize = true;
			this.ck_Tu.Location = new System.Drawing.Point(69, 243);
			this.ck_Tu.Name = "ck_Tu";
			this.ck_Tu.Size = new System.Drawing.Size(45, 20);
			this.ck_Tu.TabIndex = 23;
			this.ck_Tu.Text = "Вт";
			this.ck_Tu.UseVisualStyleBackColor = true;
			// 
			// ck_We
			// 
			this.ck_We.AutoSize = true;
			this.ck_We.Location = new System.Drawing.Point(120, 243);
			this.ck_We.Name = "ck_We";
			this.ck_We.Size = new System.Drawing.Size(46, 20);
			this.ck_We.TabIndex = 24;
			this.ck_We.Text = "Ср";
			this.ck_We.UseVisualStyleBackColor = true;
			// 
			// ck_Th
			// 
			this.ck_Th.AutoSize = true;
			this.ck_Th.Location = new System.Drawing.Point(172, 243);
			this.ck_Th.Name = "ck_Th";
			this.ck_Th.Size = new System.Drawing.Size(45, 20);
			this.ck_Th.TabIndex = 25;
			this.ck_Th.Text = "Чт";
			this.ck_Th.UseVisualStyleBackColor = true;
			// 
			// ck_Fr
			// 
			this.ck_Fr.AutoSize = true;
			this.ck_Fr.Location = new System.Drawing.Point(223, 243);
			this.ck_Fr.Name = "ck_Fr";
			this.ck_Fr.Size = new System.Drawing.Size(46, 20);
			this.ck_Fr.TabIndex = 26;
			this.ck_Fr.Text = "Пт";
			this.ck_Fr.UseVisualStyleBackColor = true;
			// 
			// ck_Sa
			// 
			this.ck_Sa.AutoSize = true;
			this.ck_Sa.Location = new System.Drawing.Point(275, 243);
			this.ck_Sa.Name = "ck_Sa";
			this.ck_Sa.Size = new System.Drawing.Size(46, 20);
			this.ck_Sa.TabIndex = 27;
			this.ck_Sa.Text = "Сб";
			this.ck_Sa.UseVisualStyleBackColor = true;
			// 
			// ck_Su
			// 
			this.ck_Su.AutoSize = true;
			this.ck_Su.Location = new System.Drawing.Point(327, 243);
			this.ck_Su.Name = "ck_Su";
			this.ck_Su.Size = new System.Drawing.Size(45, 20);
			this.ck_Su.TabIndex = 28;
			this.ck_Su.Text = "Вс";
			this.ck_Su.UseVisualStyleBackColor = true;
			// 
			// cb_NewLessonForm
			// 
			this.cb_NewLessonForm.FormattingEnabled = true;
			this.cb_NewLessonForm.Location = new System.Drawing.Point(507, 134);
			this.cb_NewLessonForm.Name = "cb_NewLessonForm";
			this.cb_NewLessonForm.Size = new System.Drawing.Size(206, 24);
			this.cb_NewLessonForm.TabIndex = 29;
			// 
			// cb_NewLessonTime
			// 
			this.cb_NewLessonTime.FormattingEnabled = true;
			this.cb_NewLessonTime.Location = new System.Drawing.Point(507, 184);
			this.cb_NewLessonTime.Name = "cb_NewLessonTime";
			this.cb_NewLessonTime.Size = new System.Drawing.Size(206, 24);
			this.cb_NewLessonTime.TabIndex = 30;
			// 
			// ck_NewSu
			// 
			this.ck_NewSu.AutoSize = true;
			this.ck_NewSu.Location = new System.Drawing.Point(822, 243);
			this.ck_NewSu.Name = "ck_NewSu";
			this.ck_NewSu.Size = new System.Drawing.Size(45, 20);
			this.ck_NewSu.TabIndex = 37;
			this.ck_NewSu.Text = "Вс";
			this.ck_NewSu.UseVisualStyleBackColor = true;
			// 
			// ck_NewSa
			// 
			this.ck_NewSa.AutoSize = true;
			this.ck_NewSa.Location = new System.Drawing.Point(768, 243);
			this.ck_NewSa.Name = "ck_NewSa";
			this.ck_NewSa.Size = new System.Drawing.Size(46, 20);
			this.ck_NewSa.TabIndex = 36;
			this.ck_NewSa.Text = "Сб";
			this.ck_NewSa.UseVisualStyleBackColor = true;
			// 
			// ck_NewFr
			// 
			this.ck_NewFr.AutoSize = true;
			this.ck_NewFr.Location = new System.Drawing.Point(714, 243);
			this.ck_NewFr.Name = "ck_NewFr";
			this.ck_NewFr.Size = new System.Drawing.Size(46, 20);
			this.ck_NewFr.TabIndex = 35;
			this.ck_NewFr.Text = "Пт";
			this.ck_NewFr.UseVisualStyleBackColor = true;
			// 
			// ck_NewTh
			// 
			this.ck_NewTh.AutoSize = true;
			this.ck_NewTh.Location = new System.Drawing.Point(663, 243);
			this.ck_NewTh.Name = "ck_NewTh";
			this.ck_NewTh.Size = new System.Drawing.Size(45, 20);
			this.ck_NewTh.TabIndex = 34;
			this.ck_NewTh.Text = "Чт";
			this.ck_NewTh.UseVisualStyleBackColor = true;
			// 
			// ck_NewWe
			// 
			this.ck_NewWe.AutoSize = true;
			this.ck_NewWe.Location = new System.Drawing.Point(611, 243);
			this.ck_NewWe.Name = "ck_NewWe";
			this.ck_NewWe.Size = new System.Drawing.Size(46, 20);
			this.ck_NewWe.TabIndex = 33;
			this.ck_NewWe.Text = "Ср";
			this.ck_NewWe.UseVisualStyleBackColor = true;
			// 
			// ck_NewTu
			// 
			this.ck_NewTu.AutoSize = true;
			this.ck_NewTu.Location = new System.Drawing.Point(560, 243);
			this.ck_NewTu.Name = "ck_NewTu";
			this.ck_NewTu.Size = new System.Drawing.Size(45, 20);
			this.ck_NewTu.TabIndex = 32;
			this.ck_NewTu.Text = "Вт";
			this.ck_NewTu.UseVisualStyleBackColor = true;
			// 
			// ck_NewMo
			// 
			this.ck_NewMo.AutoSize = true;
			this.ck_NewMo.Location = new System.Drawing.Point(507, 243);
			this.ck_NewMo.Name = "ck_NewMo";
			this.ck_NewMo.Size = new System.Drawing.Size(47, 20);
			this.ck_NewMo.TabIndex = 31;
			this.ck_NewMo.Text = "Пн";
			this.ck_NewMo.UseVisualStyleBackColor = true;
			// 
			// AddGroups
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 612);
			this.Controls.Add(this.ck_NewSu);
			this.Controls.Add(this.ck_NewSa);
			this.Controls.Add(this.ck_NewFr);
			this.Controls.Add(this.ck_NewTh);
			this.Controls.Add(this.ck_NewWe);
			this.Controls.Add(this.ck_NewTu);
			this.Controls.Add(this.ck_NewMo);
			this.Controls.Add(this.cb_NewLessonTime);
			this.Controls.Add(this.cb_NewLessonForm);
			this.Controls.Add(this.ck_Su);
			this.Controls.Add(this.ck_Sa);
			this.Controls.Add(this.ck_Fr);
			this.Controls.Add(this.ck_Th);
			this.Controls.Add(this.ck_We);
			this.Controls.Add(this.ck_Tu);
			this.Controls.Add(this.ck_Mo);
			this.Controls.Add(this.cb_LessonTime);
			this.Controls.Add(this.cb_LessonForm);
			this.Controls.Add(this.l_LessonDay);
			this.Controls.Add(this.l_LessonTime);
			this.Controls.Add(this.l_LessonForm);
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
		private System.Windows.Forms.Label l_LessonForm;
		private System.Windows.Forms.Label l_LessonTime;
		private System.Windows.Forms.Label l_LessonDay;
		private System.Windows.Forms.ComboBox cb_LessonForm;
		private System.Windows.Forms.ComboBox cb_LessonTime;
		private System.Windows.Forms.CheckBox ck_Mo;
		private System.Windows.Forms.CheckBox ck_Tu;
		private System.Windows.Forms.CheckBox ck_We;
		private System.Windows.Forms.CheckBox ck_Th;
		private System.Windows.Forms.CheckBox ck_Fr;
		private System.Windows.Forms.CheckBox ck_Sa;
		private System.Windows.Forms.CheckBox ck_Su;
		private System.Windows.Forms.ComboBox cb_NewLessonForm;
		private System.Windows.Forms.ComboBox cb_NewLessonTime;
		private System.Windows.Forms.CheckBox ck_NewSu;
		private System.Windows.Forms.CheckBox ck_NewSa;
		private System.Windows.Forms.CheckBox ck_NewFr;
		private System.Windows.Forms.CheckBox ck_NewTh;
		private System.Windows.Forms.CheckBox ck_NewWe;
		private System.Windows.Forms.CheckBox ck_NewTu;
		private System.Windows.Forms.CheckBox ck_NewMo;
	}
}