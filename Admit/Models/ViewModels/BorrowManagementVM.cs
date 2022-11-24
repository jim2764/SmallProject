using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Admit.Models.ViewModels
{
	public class BorrowManagementVM
	{
		[Required(ErrorMessage = "Please enter your 'PersonalID'")]
		public string Input { get; set; }
	}

	public class BorrowManagementBorrowVM
	{
		[Required(ErrorMessage = "PersonalID is required")]
		public string PersonalID { get; set; }
		[Required(ErrorMessage = "BookID is required")]
		public string BookID { get; set; }
	}

	public class BorrowManagementReturnVM
	{
		public string PersonalID { get; set; }
		public string UserName { get; set; }
		public string BookID { get; set; }
		public string BookName { get; set; }
		public string Author { get; set; }
	}

	public class BorrowManagementIndexVM
	{
		public string BookID { get; set; }
		public string BookName { get; set; }
		public string Author { get; set; }
	}
}
