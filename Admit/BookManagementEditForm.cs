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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admit
{
	public partial class BookManagementEditForm : Form
	{
		private string BookID;
		private BookManagementServices services = new BookManagementServices();

		public BookManagementEditForm(string bookID)
		{
			InitializeComponent();
			this.BookID = bookID;
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
			// Access DataBase
			BookManagementDAO dao = new BookManagementDAO();
			BookManagementEditVM vm = DTOVMToEdit(dao.GetBook(BookID));

			// Show On Form
			txtBookID.Text = vm.BookID;
			txtBookName.Text = vm.BookName;
			txtAuthor.Text = vm.Author;
			txtTotalAmount.Text = vm.TotalAmount.ToString();
			txtDescription.Text = vm.Description;

			// Image
			if (services.HasImage(vm.FileName))
			{
				lblFileName.Text = vm.FileName;

				string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
				string destinationPath = path + "\\Image\\" + vm.FileName;
				pbxImage.ImageLocation = destinationPath;
				pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
			}
			else
			{
				lblFileName.Text = "No File";
			}
		}

		private BookManagementEditVM DTOVMToEdit(BookDTO dto)
		{
			return new BookManagementEditVM()
			{
				BookID = dto.BookID,
				BookName = dto.BookName,
				Author = dto.Author,
				TotalAmount = dto.TotalAmount,
				FileName = dto.FileName,
				Description = dto.Description
			};
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

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (services.TryAddImage(openFileDialog1, out string path))
			{
				string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);

				// Show
				lblFileName.Text = filename;
				pbxImage.Image = new Bitmap(path);
				pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			BookManagementEditVM vm = new BookManagementEditVM()
			{
				BookID = txtBookID.Text,
				BookName = txtBookName.Text,
				Author = txtAuthor.Text,
				TotalAmount = services.StringTOInt(txtTotalAmount.Text),
				FileName = lblFileName.Text,
				Description = txtDescription.Text
			};

			// Validation
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
				// Update book
				pbxImage.Image.Dispose();
				services.UpdateBook(EditVMToDTO(vm), openFileDialog1.FileName);

				MessageBox.Show("Success Update");

				DialogResult = DialogResult.OK;
			}
			catch(Exception ex)
			{
				MessageBox.Show($"Error\r\nBecause: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

			BookManagementEditVM vm = new BookManagementEditVM()
			{
				BookID = txtBookID.Text,
				BookName = txtBookName.Text,
				Author = txtAuthor.Text,
				TotalAmount = services.StringTOInt(txtTotalAmount.Text),
				FileName = lblFileName.Text,
				Description = txtDescription.Text
			};

			try
			{
				// Delete this data
				BookManagementServices services = new BookManagementServices();
				if(services.HasImage(vm.FileName))
				{
					pbxImage.Image.Dispose();
				}
				services.DeleteBook(EditVMToDTO(vm), lblFileName.Text);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error\r\nBecause: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
