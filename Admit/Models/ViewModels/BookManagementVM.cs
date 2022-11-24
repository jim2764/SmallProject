using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admit.Models.ViewModels
{
	public class BookManagementVM
	{
		public string Title { get; set; }
		public string Input { get; set; }
	}

	public class BookManagementIndexVM
	{
		public string BookID { get; set; }
		public string BookName { get; set; }
		public string Author { get; set; }
		public string TotalAmount { get; set; }
		public int RemainderAmount { get; set; }
	}

	public class BookManagementEditVM: IValidatableObject
	{
		public string BookID { get; set; }
		public string BookName { get; set; }
		public string Author { get; set; }
		public int TotalAmount { get; set; }
		public string FileName { get; set; }
		public string Description { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (BookID == string.Empty) yield return new ValidationResult("BookID is required", new string[] { "BookID" });
			if (BookName == string.Empty) yield return new ValidationResult("BookID is required", new string[] { "BookName" });
			if (Author == string.Empty) yield return new ValidationResult("BookID is required", new string[] { "Author" });
			if (TotalAmount == 0) yield return new ValidationResult("BookID is required", new string[] { "TotalAmount" });

		}
	}
}
