namespace Admit
{
	partial class BorrowManagementReturnForm
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
			this.lblReturn = new System.Windows.Forms.Label();
			this.gbxUser = new System.Windows.Forms.GroupBox();
			this.UserName = new System.Windows.Forms.Label();
			this.PersonalID = new System.Windows.Forms.Label();
			this.lblPersonalID = new System.Windows.Forms.Label();
			this.gpxBook = new System.Windows.Forms.GroupBox();
			this.BookName = new System.Windows.Forms.Label();
			this.BookID = new System.Windows.Forms.Label();
			this.btnReturn = new System.Windows.Forms.Button();
			this.Author = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblBookID = new System.Windows.Forms.Label();
			this.lblBookName = new System.Windows.Forms.Label();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.gbxUser.SuspendLayout();
			this.gpxBook.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblReturn
			// 
			this.lblReturn.AutoSize = true;
			this.lblReturn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblReturn.Location = new System.Drawing.Point(12, 19);
			this.lblReturn.Name = "lblReturn";
			this.lblReturn.Size = new System.Drawing.Size(62, 21);
			this.lblReturn.TabIndex = 0;
			this.lblReturn.Text = "Return";
			// 
			// gbxUser
			// 
			this.gbxUser.BackColor = System.Drawing.Color.White;
			this.gbxUser.Controls.Add(this.UserName);
			this.gbxUser.Controls.Add(this.PersonalID);
			this.gbxUser.Controls.Add(this.lblUserName);
			this.gbxUser.Controls.Add(this.lblPersonalID);
			this.gbxUser.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gbxUser.Location = new System.Drawing.Point(38, 55);
			this.gbxUser.Name = "gbxUser";
			this.gbxUser.Size = new System.Drawing.Size(484, 161);
			this.gbxUser.TabIndex = 1;
			this.gbxUser.TabStop = false;
			this.gbxUser.Text = "User";
			// 
			// UserName
			// 
			this.UserName.AutoSize = true;
			this.UserName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.UserName.Location = new System.Drawing.Point(4, 98);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(91, 21);
			this.UserName.TabIndex = 0;
			this.UserName.Text = "UserName";
			// 
			// PersonalID
			// 
			this.PersonalID.AutoSize = true;
			this.PersonalID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PersonalID.Location = new System.Drawing.Point(4, 46);
			this.PersonalID.Name = "PersonalID";
			this.PersonalID.Size = new System.Drawing.Size(93, 21);
			this.PersonalID.TabIndex = 0;
			this.PersonalID.Text = "PersonalID";
			// 
			// lblPersonalID
			// 
			this.lblPersonalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblPersonalID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblPersonalID.Location = new System.Drawing.Point(115, 46);
			this.lblPersonalID.Name = "lblPersonalID";
			this.lblPersonalID.Size = new System.Drawing.Size(352, 21);
			this.lblPersonalID.TabIndex = 0;
			this.lblPersonalID.Text = "label1";
			this.lblPersonalID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gpxBook
			// 
			this.gpxBook.BackColor = System.Drawing.Color.White;
			this.gpxBook.Controls.Add(this.Author);
			this.gpxBook.Controls.Add(this.BookName);
			this.gpxBook.Controls.Add(this.lblAuthor);
			this.gpxBook.Controls.Add(this.lblBookName);
			this.gpxBook.Controls.Add(this.lblBookID);
			this.gpxBook.Controls.Add(this.BookID);
			this.gpxBook.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.gpxBook.Location = new System.Drawing.Point(38, 255);
			this.gpxBook.Name = "gpxBook";
			this.gpxBook.Size = new System.Drawing.Size(484, 165);
			this.gpxBook.TabIndex = 1;
			this.gpxBook.TabStop = false;
			this.gpxBook.Text = "Book";
			// 
			// BookName
			// 
			this.BookName.AutoSize = true;
			this.BookName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.BookName.Location = new System.Drawing.Point(6, 82);
			this.BookName.Name = "BookName";
			this.BookName.Size = new System.Drawing.Size(95, 21);
			this.BookName.TabIndex = 0;
			this.BookName.Text = "BookName";
			// 
			// BookID
			// 
			this.BookID.AutoSize = true;
			this.BookID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.BookID.Location = new System.Drawing.Point(4, 39);
			this.BookID.Name = "BookID";
			this.BookID.Size = new System.Drawing.Size(66, 21);
			this.BookID.TabIndex = 0;
			this.BookID.Text = "BookID";
			// 
			// btnReturn
			// 
			this.btnReturn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnReturn.Location = new System.Drawing.Point(206, 464);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(148, 32);
			this.btnReturn.TabIndex = 0;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// Author
			// 
			this.Author.AutoSize = true;
			this.Author.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Author.Location = new System.Drawing.Point(4, 123);
			this.Author.Name = "Author";
			this.Author.Size = new System.Drawing.Size(64, 21);
			this.Author.TabIndex = 0;
			this.Author.Text = "Author";
			// 
			// lblUserName
			// 
			this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblUserName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblUserName.Location = new System.Drawing.Point(115, 98);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(352, 21);
			this.lblUserName.TabIndex = 0;
			this.lblUserName.Text = "label1";
			this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBookID
			// 
			this.lblBookID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblBookID.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblBookID.Location = new System.Drawing.Point(115, 39);
			this.lblBookID.Name = "lblBookID";
			this.lblBookID.Size = new System.Drawing.Size(352, 21);
			this.lblBookID.TabIndex = 0;
			this.lblBookID.Text = "label1";
			this.lblBookID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblBookName
			// 
			this.lblBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblBookName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblBookName.Location = new System.Drawing.Point(115, 82);
			this.lblBookName.Name = "lblBookName";
			this.lblBookName.Size = new System.Drawing.Size(352, 21);
			this.lblBookName.TabIndex = 0;
			this.lblBookName.Text = "label1";
			this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAuthor
			// 
			this.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblAuthor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblAuthor.Location = new System.Drawing.Point(115, 123);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(352, 21);
			this.lblAuthor.TabIndex = 0;
			this.lblAuthor.Text = "label1";
			this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BorrowManagementReturnForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 530);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.gpxBook);
			this.Controls.Add(this.gbxUser);
			this.Controls.Add(this.lblReturn);
			this.Name = "BorrowManagementReturnForm";
			this.Text = "BorrowManagementReturn";
			this.gbxUser.ResumeLayout(false);
			this.gbxUser.PerformLayout();
			this.gpxBook.ResumeLayout(false);
			this.gpxBook.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblReturn;
		private System.Windows.Forms.GroupBox gbxUser;
		private System.Windows.Forms.Label UserName;
		private System.Windows.Forms.Label PersonalID;
		private System.Windows.Forms.Label lblPersonalID;
		private System.Windows.Forms.GroupBox gpxBook;
		private System.Windows.Forms.Label BookName;
		private System.Windows.Forms.Label BookID;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label Author;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.Label lblBookName;
		private System.Windows.Forms.Label lblBookID;
	}
}