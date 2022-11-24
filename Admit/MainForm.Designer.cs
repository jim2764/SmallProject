namespace Admit
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnBookManagement = new System.Windows.Forms.Button();
			this.lblName = new System.Windows.Forms.Label();
			this.btnBorrowManagement = new System.Windows.Forms.Button();
			this.btnFinish = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBookManagement
			// 
			this.btnBookManagement.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBookManagement.Location = new System.Drawing.Point(45, 81);
			this.btnBookManagement.Name = "btnBookManagement";
			this.btnBookManagement.Size = new System.Drawing.Size(314, 70);
			this.btnBookManagement.TabIndex = 0;
			this.btnBookManagement.Text = "Book Management";
			this.btnBookManagement.UseVisualStyleBackColor = true;
			this.btnBookManagement.Click += new System.EventHandler(this.btnBookManagement_Click);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblName.Location = new System.Drawing.Point(41, 29);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(56, 21);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "label1";
			// 
			// btnBorrowManagement
			// 
			this.btnBorrowManagement.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBorrowManagement.Location = new System.Drawing.Point(45, 173);
			this.btnBorrowManagement.Name = "btnBorrowManagement";
			this.btnBorrowManagement.Size = new System.Drawing.Size(314, 70);
			this.btnBorrowManagement.TabIndex = 1;
			this.btnBorrowManagement.Text = "Borrow Management";
			this.btnBorrowManagement.UseVisualStyleBackColor = true;
			this.btnBorrowManagement.Click += new System.EventHandler(this.btnBorrowManagement_Click);
			// 
			// btnFinish
			// 
			this.btnFinish.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnFinish.Location = new System.Drawing.Point(45, 265);
			this.btnFinish.Name = "btnFinish";
			this.btnFinish.Size = new System.Drawing.Size(314, 70);
			this.btnFinish.TabIndex = 2;
			this.btnFinish.Text = "Finish";
			this.btnFinish.UseVisualStyleBackColor = true;
			this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 361);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.btnFinish);
			this.Controls.Add(this.btnBorrowManagement);
			this.Controls.Add(this.btnBookManagement);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBookManagement;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnBorrowManagement;
		private System.Windows.Forms.Button btnFinish;
	}
}