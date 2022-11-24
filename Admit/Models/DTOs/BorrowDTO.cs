using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admit.Models.DTOs
{
	public class BorrowDTO
	{
		public string PID { get; set; }
		public string UserName { get; set; }
		public string BID { get; set; }
		public string BookName { get; set; }
		public string Author { get; set; }
	}
}
