namespace Admit
{
	partial class BookManagementForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lblBookManagement = new System.Windows.Forms.Label();
			this.cbxTitle = new System.Windows.Forms.ComboBox();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.dgvShowBook = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvShowBook)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBookManagement
			// 
			this.lblBookManagement.AutoSize = true;
			this.lblBookManagement.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblBookManagement.Location = new System.Drawing.Point(12, 18);
			this.lblBookManagement.Name = "lblBookManagement";
			this.lblBookManagement.Size = new System.Drawing.Size(152, 21);
			this.lblBookManagement.TabIndex = 0;
			this.lblBookManagement.Text = "BookManagement";
			// 
			// cbxTitle
			// 
			this.cbxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTitle.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.cbxTitle.FormattingEnabled = true;
			this.cbxTitle.Items.AddRange(new object[] {
            "All",
            "BookID",
            "BookName",
            "Author"});
			this.cbxTitle.Location = new System.Drawing.Point(36, 84);
			this.cbxTitle.Name = "cbxTitle";
			this.cbxTitle.Size = new System.Drawing.Size(128, 29);
			this.cbxTitle.TabIndex = 1;
			// 
			// txtInput
			// 
			this.txtInput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtInput.Location = new System.Drawing.Point(170, 84);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(324, 29);
			this.txtInput.TabIndex = 0;
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearch.Location = new System.Drawing.Point(500, 84);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(101, 29);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnInsert.Location = new System.Drawing.Point(500, 18);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(101, 29);
			this.btnInsert.TabIndex = 1;
			this.btnInsert.Text = "Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// dgvShowBook
			// 
			this.dgvShowBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvShowBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvShowBook.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvShowBook.Location = new System.Drawing.Point(36, 134);
			this.dgvShowBook.Name = "dgvShowBook";
			this.dgvShowBook.RowTemplate.Height = 24;
			this.dgvShowBook.Size = new System.Drawing.Size(565, 272);
			this.dgvShowBook.TabIndex = 5;
			this.dgvShowBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// BookManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 442);
			this.Controls.Add(this.dgvShowBook);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.cbxTitle);
			this.Controls.Add(this.lblBookManagement);
			this.Name = "BookManagementForm";
			this.Text = "BookManagement";
			((System.ComponentModel.ISupportInitialize)(this.dgvShowBook)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblBookManagement;
		private System.Windows.Forms.ComboBox cbxTitle;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.DataGridView dgvShowBook;
	}
}