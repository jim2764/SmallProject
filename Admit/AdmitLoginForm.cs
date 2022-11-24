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
	public partial class AdmitLoginForm : Form
	{
		public AdmitLoginForm()
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

		private void btnLogin_Click(object sender, EventArgs e)
		{
			AdmitLoginVM vm = new AdmitLoginVM()
			{
				Account = txtAccount.Text,
				Password = txtPassword.Text,
			};

			// Emty Validation
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", txtAccount },
				{"Password", txtPassword },
			};
 
			bool isValid = ValidationHelper.Validate<AdmitLoginVM>(vm, map, errorProvider1);
			if (!isValid) return;

			// Account or Password error
			AdmitLoginServices services = new AdmitLoginServices();
			if (!services.IsValidAdmit(VMToDTO(vm), out string name))
			{
				MessageBox.Show("account or password incorrect");
				return;
			}

			// Login
			MainForm form = new MainForm(name);
			this.Hide();
			form.Show();
		}

		AdmitDTO VMToDTO(AdmitLoginVM vm)
		{
			return new AdmitDTO()
			{
				Account = vm.Account,
				Password = vm.Password,
			};
		}
	}
}
