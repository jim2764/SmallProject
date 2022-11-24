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
	public partial class BorrowManagementForm : Form
	{
		IEnumerable<BorrowDTO> borrowDTOs = null;

		BorrowManagementDAO dao = new BorrowManagementDAO();
		public BorrowManagementForm()
		{
			InitializeComponent();
			DataBind();
			dgvShowData.Visible = false;
			ShowImage();
			InitForm();
			//Display();
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

			BorrowManagementVM vm = new BorrowManagementVM();
			vm.Input = txtInput.Text;
			dgvShowData.DataSource = dgvShowData.DataSource = borrowDTOs.Where(x => x.PID == vm.Input).Select(x => DTOToIndexVM(x)).ToArray(); ;
		}

		// Access database
		private void DataBind()
		{
			borrowDTOs = dao.GetAllBorrowedBook();
		}

		private BorrowManagementIndexVM DTOToIndexVM(BorrowDTO dto)
		{
			return new BorrowManagementIndexVM()
			{
				BookID = dto.BID,
				BookName = dto.BookName,
				Author = dto.Author,
			};
		}

		private void ShowImage()
		{
			string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
			string destinationPath = path + "\\Image\\" + "ShowBooks.jpg";
			pbxImage.ImageLocation = destinationPath;
			pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			// Get View
			BorrowManagementVM vm = new BorrowManagementVM();
			vm.Input = txtInput.Text;

			// Field is empty Validation
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Input", txtInput }
			};

			bool isValid = ValidationHelper.Validate<BorrowManagementVM>(vm, map, errorProvider1);
			if (!isValid) return;

			// Not find PersonalID Validation
			BorrowManagementServices services = new BorrowManagementServices();
			if (!services.HasUser(vm.Input))
			{
				MessageBox.Show("No User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			} 

			pbxImage.Visible = false;
			dgvShowData.Visible = true;

			dgvShowData.DataSource = borrowDTOs.Where(x => x.PID == vm.Input).Select(x => DTOToIndexVM(x)).ToArray();
		}

		private void tabControl1_Selected(object sender, TabControlEventArgs e)
		{
			DataBind();
			dgvShowData.Visible = false;
			pbxImage.Visible = true;
			txtInput.Text = string.Empty;
			ShowImage();
		}

		private void btnBorrow_Click(object sender, EventArgs e)
		{
			// Get View
			BorrowManagementBorrowVM vm = new BorrowManagementBorrowVM();
			vm.PersonalID = txtPersonalID.Text;
			vm.BookID = txtBookID.Text;

			// Field is empty Validation
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"PersonalID", txtPersonalID },
				{"BookID", txtBookID }
			};

			bool isValid = ValidationHelper.Validate<BorrowManagementBorrowVM>(vm, map, errorProvider1);
			if (!isValid) return;

			try
			{
				// VM to DTO
				BorrowDTO dto = VMToDTO(vm);

				BorrowManagementServices services = new BorrowManagementServices();
				// Borrowes Book
				services.BorrowBooks(dto);

				MessageBox.Show("Success Borrow", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private BorrowDTO VMToDTO(BorrowManagementBorrowVM vm)
		{
			return new BorrowDTO()
			{
				PID = vm.PersonalID,
				BID = vm.BookID,
			};
		}

		private void dgvShowData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;

			if (rowIndex < 0) return;

			BorrowDTO dto = new BorrowDTO();
			dto.PID = borrowDTOs.ToArray()[rowIndex].PID;
			dto.BID = borrowDTOs.ToArray()[rowIndex].BID;

			// Open form
			BorrowManagementReturnForm form = new BorrowManagementReturnForm(dto);

			if (form.ShowDialog() == DialogResult.OK) Display();
		}
	}
}
