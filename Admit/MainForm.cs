using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admit
{
	public partial class MainForm : Form
	{
		public MainForm(string name)
		{
			InitializeComponent();
			InitForm();
			lblName.Text = "Hello, " + name;
		}

		private void InitForm()
		{
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.BackColor = Color.FromArgb(209, 234, 206);
			this.Icon = Properties.Resources.Iconbluebook;
		}

		private void btnFinish_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnBookManagement_Click(object sender, EventArgs e)
		{
			BookManagementForm form = new BookManagementForm();
			form.ShowDialog();
		}

		private void btnBorrowManagement_Click(object sender, EventArgs e)
		{
			BorrowManagementForm form = new BorrowManagementForm();
			form.ShowDialog();
		}
	}
}
