using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admit.Models.DTOs
{
	public class BookDTO
	{
		public string BookID { get; set; }
		public string BookName { get; set; }
		public string Author { get; set; }
		public int TotalAmount { get; set; }
		public string FileName { get; set; }
		public string Description { get; set; }
	}
}
