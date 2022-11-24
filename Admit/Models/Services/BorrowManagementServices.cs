using Admit.Infrastructures.DAOs;
using Admit.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admit.Models.Services
{
	public class BorrowManagementServices
	{
		public bool HasUser(string personalID)
		{
			// Access database
			BorrowManagementDAO dao = new BorrowManagementDAO();
			return dao.GetUserCount(personalID) > 0;
		}

		public void BorrowBooks(BorrowDTO dto)
		{
			// Not find PersonalID Validation
			BorrowManagementDAO dao = new BorrowManagementDAO();
			if (dao.GetUserCount(dto.PID) == 0) throw new Exception("No User");

			// Not find BookID Validation
			if (dao.GetBookCount(dto.BID) == 0) throw new Exception("No Book");

			// Insert to database
			dao.Insert(dto);
		}
	}
}
