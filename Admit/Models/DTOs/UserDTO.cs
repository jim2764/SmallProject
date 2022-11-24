using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admit.Models.DTOs
{
	public class UserDTO
	{
		public string PersonalID { get; set; }
		public string UserName { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
	}
}
