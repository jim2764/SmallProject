using Admit.Infrastructures.DAOs;
using Admit.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admit.Models.Services
{
	public class AdmitLoginServices
	{
		/// <summary>
		/// if valid name variable return your account name
		/// if invalid name variable return empty string
		/// </summary>
		/// <param name="dto"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public bool IsValidAdmit(AdmitDTO dto, out string name)
		{
			name = string.Empty;
			// Access Database
			AdmitLoginDAO dao  = new AdmitLoginDAO();
			AdmitDTO dbDTO = dao.GetAdmit(dto);

			if (dbDTO.Account != dto.Account) return false;

			if (dbDTO.Password != dto.Password) return false;

			name = dbDTO.AdmitName;
			return true;
		}
	}
}
