using Admit.Infrastructures.DAOs;
using Admit.Models.DTOs;
using Admit.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admit
{
	public partial class BookManagementForm : Form
	{
		BookManagementIndexVM[] books = null;

		BookManagementDAO dao = new BookManagementDAO();

		public BookManagementForm()
		{
			InitializeComponent();
			Display();
			InitForm();
			cbxTitle.SelectedIndex = 0;
		}

		private void InitForm()
		{
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.BackColor = Color.FromArgb(209, 234, 206);
			this.Icon = Properties.Resources.Iconbluebook;
		}

		// Show Data
		private void Display()
		{
			DataBind();
			txtInput.Text = string.Empty;
			dgvShowBook.DataSource = books;
		}

		// Access database
		private void DataBind()
		{
			books = dao.GetAllBook().Select(x => DTOToIndexVM(x)).ToArray();
		}

		private BookManagementIndexVM DTOToIndexVM(BookDTO dto)
		{
			return new BookManagementIndexVM()
			{
				BookID = dto.BookID,
				BookName = dto.BookName,
				Author = dto.Author,
				TotalAmount = dto.TotalAmount.ToString(),
				RemainderAmount = dto.TotalAmount - dao.TotalBorrowAmount(dto)
			};
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (cbxTitle.SelectedIndex == 0) dgvShowBook.DataSource = books;
			else
			{
				BookManagementVM vm = new BookManagementVM()
				{
					Title = cbxTitle.Text,
					Input = txtInput.Text
				};

				if (vm.Title == "BookID") dgvShowBook.DataSource = books.Where(x => x.BookID.Contains(vm.Input)).ToArray();
				if (vm.Title == "BookName") dgvShowBook.DataSource = books.Where(x => x.BookName.Contains(vm.Input)).ToArray();
				if (vm.Title == "Author") dgvShowBook.DataSource = books.Where(x => x.Author.Contains(vm.Input)).ToArray();
			}
		}

		private void btnInsert_Click(object sender, EventArgs e)
		{
			BookManagementInsertForm form = new BookManagementInsertForm();
			if (form.ShowDialog() == DialogResult.OK)
			{
				Display();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;

			if (rowIndex < 0) return;

			BookManagementIndexVM row = this.books[rowIndex];

			string bookID = row.BookID;

			BookManagementEditForm form = new BookManagementEditForm(bookID);

			if (form.ShowDialog() == DialogResult.OK)
			{
				Display();
			}
		}
	}
}
