using Admit.Infrastructures.DAOs;
using Admit.Models.DTOs;
using Admit.Models.ViewModels;
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
	public partial class BorrowManagementReturnForm : Form
	{
		BorrowDTO dto = null;
		public BorrowManagementReturnForm(BorrowDTO dto)
		{
			InitializeComponent();
			this.dto = dto;
			DataBind();
			InitForm();
		}

		private void InitForm()
		{
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.BackColor = Color.FromArgb(209, 234, 206);
			this.Icon = Properties.Resources.Iconbluebook;
		}

		private void DataBind()
		{
			BorrowManagementReturnVM vm  = new BorrowManagementReturnVM();

			// Get User data from database 
			BorrowManagementDAO dao = new BorrowManagementDAO();
			BorrowDTO userDTO = dao.GetBorrowUser(dto.PID);

			// Get Book data from database
			BorrowDTO bookDTO = dao.GetBorrowBook(dto.BID);

			vm.PersonalID = userDTO.PID;
			vm.UserName = userDTO.UserName;
			vm.BookID = bookDTO.BID;
			vm.BookName = bookDTO.BookName;
			vm.Author = bookDTO.Author;

			lblPersonalID.Text = vm.PersonalID;
			lblUserName.Text = vm.UserName;
			lblBookID.Text = vm.BookID;
			lblBookName.Text = vm.BookName;
			lblAuthor.Text = vm.Author;
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure return?", "Success Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

			BorrowManagementDAO dao = new BorrowManagementDAO();
			dao.Delete(dto);

			DialogResult = DialogResult.OK;
		}
	}
}
