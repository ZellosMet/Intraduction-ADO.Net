namespace Library_Desktop
{
	partial class f_Library
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
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_Execute = new System.Windows.Forms.Button();
			this.dgv_result = new System.Windows.Forms.DataGridView();
			this.rtb_Query = new System.Windows.Forms.RichTextBox();
			this.cb_table = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_result)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// btn_Execute
			// 
			this.btn_Execute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Execute.Location = new System.Drawing.Point(899, 12);
			this.btn_Execute.Name = "btn_Execute";
			this.btn_Execute.Size = new System.Drawing.Size(94, 29);
			this.btn_Execute.TabIndex = 2;
			this.btn_Execute.Text = "Execute";
			this.btn_Execute.UseVisualStyleBackColor = true;
			this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
			// 
			// dgv_result
			// 
			this.dgv_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_result.Location = new System.Drawing.Point(0, 123);
			this.dgv_result.Name = "dgv_result";
			this.dgv_result.RowHeadersWidth = 51;
			this.dgv_result.RowTemplate.Height = 24;
			this.dgv_result.Size = new System.Drawing.Size(1005, 451);
			this.dgv_result.TabIndex = 3;
			// 
			// rtb_Query
			// 
			this.rtb_Query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtb_Query.Location = new System.Drawing.Point(12, 12);
			this.rtb_Query.Name = "rtb_Query";
			this.rtb_Query.Size = new System.Drawing.Size(881, 29);
			this.rtb_Query.TabIndex = 4;
			this.rtb_Query.Text = "";
			// 
			// cb_table
			// 
			this.cb_table.FormattingEnabled = true;
			this.cb_table.Location = new System.Drawing.Point(12, 70);
			this.cb_table.Name = "cb_table";
			this.cb_table.Size = new System.Drawing.Size(881, 24);
			this.cb_table.TabIndex = 6;
			this.cb_table.SelectedIndexChanged += new System.EventHandler(this.cb_table_SelectedIndexChanged);
			// 
			// f_Library
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1005, 574);
			this.Controls.Add(this.cb_table);
			this.Controls.Add(this.rtb_Query);
			this.Controls.Add(this.dgv_result);
			this.Controls.Add(this.btn_Execute);
			this.Name = "f_Library";
			this.Text = "Library";
			((System.ComponentModel.ISupportInitialize)(this.dgv_result)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button btn_Execute;
		private System.Windows.Forms.DataGridView dgv_result;
		private System.Windows.Forms.RichTextBox rtb_Query;
		private System.Windows.Forms.ComboBox cb_table;
	}
}

