using Admit.Infrastructures.DAOs;
using Admit.Models.DTOs;
using Admit.Models.Services;
using Admit.Models.ViewModels;
using Ispan.EStore.Infrastructures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Admit
{
	public partial class BookManagementInsertForm : Form
	{
		public BookManagementInsertForm()
		{
			InitializeComponent();
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

		private void Clear()
		{
			txtBookID.Text = string.Empty;
			txtBookName.Text = string.Empty;
			txtAuthor.Text = string.Empty;
			txtTotalAmount.Text = string.Empty;
			lblFileName.Text = "No File";
			pbxImage.Image = null;
			openFileDialog1.FileName = "No Picture";
			txtDescription.Text = string.Empty;
		}

		private BookDTO EditVMToDTO(BookManagementEditVM vm)
		{
			return new BookDTO()
			{
				BookID = vm.BookID,
				BookName = vm.BookName,
				Author = vm.Author,
				TotalAmount = vm.TotalAmount,
				FileName = vm.FileName,
				Description = vm.Description
			};
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			BookManagementServices services = new BookManagementServices();

			BookManagementEditVM vm = new BookManagementEditVM()
			{
				BookID = txtBookID.Text,
				BookName = txtBookName.Text,
				Author = txtAuthor.Text,
				TotalAmount = services.StringTOInt(txtTotalAmount.Text),
				FileName = lblFileName.Text,
				Description = txtDescription.Text
			};


			//Validation
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"BookID", txtBookID },
				{"BookName", txtBookName },
				{"Author", txtAuthor },
				{"TotalAmount", txtTotalAmount }
			};

			bool isValid = ValidationHelper.Validate<BookManagementEditVM>(vm, map, errorProvider1);
			if (!isValid) return;

			
			try
			{
				// Insert Book
				services.InsertBook(EditVMToDTO(vm), openFileDialog1.FileName);

				MessageBox.Show("Success Insert");

				DialogResult = DialogResult.OK;
			}
			catch(Exception ex)
			{
				MessageBox.Show($"Error\r\nBecause: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			Clear();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			BookManagementServices services = new BookManagementServices();

			if (services.TryAddImage(openFileDialog1, out string path))
			{
				string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);

				// Show
				lblFileName.Text = filename;
				pbxImage.Image = new Bitmap(path);
				pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
			}
		}
	}
}
