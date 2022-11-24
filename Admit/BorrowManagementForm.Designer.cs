namespace Admit
{
	partial class BorrowManagementForm
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.pbxImage = new System.Windows.Forms.PictureBox();
			this.dgvShowData = new System.Windows.Forms.DataGridView();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnBorrow = new System.Windows.Forms.Button();
			this.txtBookID = new System.Windows.Forms.TextBox();
			this.txtPersonalID = new System.Windows.Forms.TextBox();
			this.lblBookID = new System.Windows.Forms.Label();
			this.lblPersonalID = new System.Windows.Forms.Label();
			this.lblBorrowManagement = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tabControl1.Location = new System.Drawing.Point(12, 53);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(603, 345);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.pbxImage);
			this.tabPage1.Controls.Add(this.dgvShowData);
			this.tabPage1.Controls.Add(this.txtInput);
			this.tabPage1.Controls.Add(this.btnSearch);
			this.tabPage1.Location = new System.Drawing.Point(4, 30);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(595, 311);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Search";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// pbxImage
			// 
			this.pbxImage.Location = new System.Drawing.Point(55, 87);
			this.pbxImage.Name = "pbxImage";
			this.pbxImage.Size = new System.Drawing.Size(474, 185);
			this.pbxImage.TabIndex = 6;
			this.pbxImage.TabStop = false;
			// 
			// dgvShowData
			// 
			this.dgvShowData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvShowData.Location = new System.Drawing.Point(55, 87);
			this.dgvShowData.Name = "dgvShowData";
			this.dgvShowData.RowTemplate.Height = 24;
			this.dgvShowData.Size = new System.Drawing.Size(474, 185);
			this.dgvShowData.TabIndex = 5;
			this.dgvShowData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellClick);
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(153, 31);
			this.txtInput.MaxLength = 5;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(201, 29);
			this.txtInput.TabIndex = 4;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(55, 30);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(92, 29);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnBorrow);
			this.tabPage2.Controls.Add(this.txtBookID);
			this.tabPage2.Controls.Add(this.txtPersonalID);
			this.tabPage2.Controls.Add(this.lblBookID);
			this.tabPage2.Controls.Add(this.lblPersonalID);
			this.tabPage2.Location = new System.Drawing.Point(4, 30);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(595, 311);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Borrow";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnBorrow
			// 
			this.btnBorrow.Location = new System.Drawing.Point(175, 205);
			this.btnBorrow.Name = "btnBorrow";
			this.btnBorrow.Size = new System.Drawing.Size(191, 30);
			this.btnBorrow.TabIndex = 3;
			this.btnBorrow.Text = "Borrow";
			this.btnBorrow.UseVisualStyleBackColor = true;
			this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
			// 
			// txtBookID
			// 
			this.txtBookID.Location = new System.Drawing.Point(246, 127);
			this.txtBookID.MaxLength = 5;
			this.txtBookID.Name = "txtBookID";
			this.txtBookID.Size = new System.Drawing.Size(197, 29);
			this.txtBookID.TabIndex = 2;
			// 
			// txtPersonalID
			// 
			this.txtPersonalID.Location = new System.Drawing.Point(246, 62);
			this.txtPersonalID.MaxLength = 5;
			this.txtPersonalID.Name = "txtPersonalID";
			this.txtPersonalID.Size = new System.Drawing.Size(197, 29);
			this.txtPersonalID.TabIndex = 1;
			// 
			// lblBookID
			// 
			this.lblBookID.AutoSize = true;
			this.lblBookID.Location = new System.Drawing.Point(135, 130);
			this.lblBookID.Name = "lblBookID";
			this.lblBookID.Size = new System.Drawing.Size(66, 21);
			this.lblBookID.TabIndex = 0;
			this.lblBookID.Text = "BookID";
			// 
			// lblPersonalID
			// 
			this.lblPersonalID.AutoSize = true;
			this.lblPersonalID.Location = new System.Drawing.Point(135, 65);
			this.lblPersonalID.Name = "lblPersonalID";
			this.lblPersonalID.Size = new System.Drawing.Size(93, 21);
			this.lblPersonalID.TabIndex = 0;
			this.lblPersonalID.Text = "PersonalID";
			// 
			// lblBorrowManagement
			// 
			this.lblBorrowManagement.AutoSize = true;
			this.lblBorrowManagement.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblBorrowManagement.Location = new System.Drawing.Point(12, 9);
			this.lblBorrowManagement.Name = "lblBorrowManagement";
			this.lblBorrowManagement.Size = new System.Drawing.Size(168, 21);
			this.lblBorrowManagement.TabIndex = 1;
			this.lblBorrowManagement.Text = "BorrowManagement";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// BorrowManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 416);
			this.Controls.Add(this.lblBorrowManagement);
			this.Controls.Add(this.tabControl1);
			this.Name = "BorrowManagementForm";
			this.Text = "BorrowManagementForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label lblBorrowManagement;
		private System.Windows.Forms.DataGridView dgvShowData;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnBorrow;
		private System.Windows.Forms.TextBox txtBookID;
		private System.Windows.Forms.TextBox txtPersonalID;
		private System.Windows.Forms.Label lblBookID;
		private System.Windows.Forms.Label lblPersonalID;
		private System.Windows.Forms.PictureBox pbxImage;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}