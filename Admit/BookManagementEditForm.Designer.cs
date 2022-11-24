namespace Admit
{
	partial class BookManagementEditForm
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
			this.lblInEdit = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblDescription = new System.Windows.Forms.Label();
			this.gbxBook = new System.Windows.Forms.GroupBox();
			this.lblTotalAmount = new System.Windows.Forms.Label();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.lblBookName = new System.Windows.Forms.Label();
			this.lblBookID = new System.Windows.Forms.Label();
			this.txtTotalAmount = new System.Windows.Forms.TextBox();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.txtBookID = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.gbxImage = new System.Windows.Forms.GroupBox();
			this.pbxImage = new System.Windows.Forms.PictureBox();
			this.lblFileName = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbxBook.SuspendLayout();
			this.gbxImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInEdit
			// 
			this.lblInEdit.AutoSize = true;
			this.lblInEdit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblInEdit.Location = new System.Drawing.Point(12, 9);
			this.lblInEdit.Name = "lblInEdit";
			this.lblInEdit.Size = new System.Drawing.Size(39, 21);
			this.lblInEdit.TabIndex = 7;
			this.lblInEdit.Text = "Edit";
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDelete.Location = new System.Drawing.Point(647, 417);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(99, 40);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUpdate.Location = new System.Drawing.Point(473, 417);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(99, 40);
			this.btnUpdate.TabIndex = 1;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblDescription.Location = new System.Drawing.Point(47, 321);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(97, 21);
			this.lblDescription.TabIndex = 10;
			this.lblDescription.Text = "Description";
			// 
			// gbxBook
			// 
			this.gbxBook.Controls.Add(this.lblTotalAmount);
			this.gbxBook.Controls.Add(this.lblAuthor);
			this.gbxBook.Controls.Add(this.lblBookName);
			this.gbxBook.Controls.Add(this.lblBookID);
			this.gbxBook.Controls.Add(this.txtTotalAmount);
			this.gbxBook.Controls.Add(this.txtAuthor);
			this.gbxBook.Controls.Add(this.txtBookName);
			this.gbxBook.Controls.Add(this.txtBookID);
			this.gbxBook.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gbxBook.Location = new System.Drawing.Point(432, 51);
			this.gbxBook.Name = "gbxBook";
			this.gbxBook.Size = new System.Drawing.Size(325, 245);
			this.gbxBook.TabIndex = 0;
			this.gbxBook.TabStop = false;
			this.gbxBook.Text = "Book";
			// 
			// lblTotalAmount
			// 
			this.lblTotalAmount.AutoSize = true;
			this.lblTotalAmount.Location = new System.Drawing.Point(16, 203);
			this.lblTotalAmount.Name = "lblTotalAmount";
			this.lblTotalAmount.Size = new System.Drawing.Size(111, 21);
			this.lblTotalAmount.TabIndex = 3;
			this.lblTotalAmount.Text = "TotalAmount";
			// 
			// lblAuthor
			// 
			this.lblAuthor.AutoSize = true;
			this.lblAuthor.Location = new System.Drawing.Point(18, 148);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(64, 21);
			this.lblAuthor.TabIndex = 3;
			this.lblAuthor.Text = "Author";
			// 
			// lblBookName
			// 
			this.lblBookName.AutoSize = true;
			this.lblBookName.Location = new System.Drawing.Point(16, 100);
			this.lblBookName.Name = "lblBookName";
			this.lblBookName.Size = new System.Drawing.Size(95, 21);
			this.lblBookName.TabIndex = 3;
			this.lblBookName.Text = "BookName";
			// 
			// lblBookID
			// 
			this.lblBookID.AutoSize = true;
			this.lblBookID.Location = new System.Drawing.Point(16, 48);
			this.lblBookID.Name = "lblBookID";
			this.lblBookID.Size = new System.Drawing.Size(66, 21);
			this.lblBookID.TabIndex = 3;
			this.lblBookID.Text = "BookID";
			// 
			// txtTotalAmount
			// 
			this.txtTotalAmount.Location = new System.Drawing.Point(143, 200);
			this.txtTotalAmount.Name = "txtTotalAmount";
			this.txtTotalAmount.Size = new System.Drawing.Size(161, 29);
			this.txtTotalAmount.TabIndex = 3;
			// 
			// txtAuthor
			// 
			this.txtAuthor.Location = new System.Drawing.Point(143, 145);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(161, 29);
			this.txtAuthor.TabIndex = 2;
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(143, 97);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(161, 29);
			this.txtBookName.TabIndex = 1;
			// 
			// txtBookID
			// 
			this.txtBookID.Location = new System.Drawing.Point(143, 45);
			this.txtBookID.MaxLength = 5;
			this.txtBookID.Name = "txtBookID";
			this.txtBookID.ReadOnly = true;
			this.txtBookID.Size = new System.Drawing.Size(161, 29);
			this.txtBookID.TabIndex = 0;
			// 
			// txtDescription
			// 
			this.txtDescription.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtDescription.Location = new System.Drawing.Point(61, 366);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(325, 91);
			this.txtDescription.TabIndex = 4;
			// 
			// gbxImage
			// 
			this.gbxImage.Controls.Add(this.pbxImage);
			this.gbxImage.Controls.Add(this.lblFileName);
			this.gbxImage.Controls.Add(this.btnAdd);
			this.gbxImage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gbxImage.Location = new System.Drawing.Point(51, 33);
			this.gbxImage.Name = "gbxImage";
			this.gbxImage.Size = new System.Drawing.Size(325, 263);
			this.gbxImage.TabIndex = 3;
			this.gbxImage.TabStop = false;
			this.gbxImage.Text = "Image";
			// 
			// pbxImage
			// 
			this.pbxImage.Location = new System.Drawing.Point(33, 82);
			this.pbxImage.Name = "pbxImage";
			this.pbxImage.Size = new System.Drawing.Size(160, 160);
			this.pbxImage.TabIndex = 3;
			this.pbxImage.TabStop = false;
			// 
			// lblFileName
			// 
			this.lblFileName.AutoSize = true;
			this.lblFileName.Location = new System.Drawing.Point(6, 38);
			this.lblFileName.Name = "lblFileName";
			this.lblFileName.Size = new System.Drawing.Size(63, 21);
			this.lblFileName.TabIndex = 1;
			this.lblFileName.Text = "No File";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(217, 82);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(78, 39);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// BookManagementEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(806, 537);
			this.Controls.Add(this.gbxImage);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lblDescription);
			this.Controls.Add(this.gbxBook);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.lblInEdit);
			this.Name = "BookManagementEditForm";
			this.Text = "Edit";
			this.gbxBook.ResumeLayout(false);
			this.gbxBook.PerformLayout();
			this.gbxImage.ResumeLayout(false);
			this.gbxImage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblInEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.GroupBox gbxBook;
		private System.Windows.Forms.Label lblTotalAmount;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.Label lblBookName;
		private System.Windows.Forms.Label lblBookID;
		private System.Windows.Forms.TextBox txtTotalAmount;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.TextBox txtBookID;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.GroupBox gbxImage;
		private System.Windows.Forms.PictureBox pbxImage;
		private System.Windows.Forms.Label lblFileName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}