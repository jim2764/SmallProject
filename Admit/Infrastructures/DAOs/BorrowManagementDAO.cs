using Admit.Models.DTOs;
using Ispan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Admit.Infrastructures.DAOs
{
	public class BorrowManagementDAO
	{
		SqlDbHelper sqlDbHelper = new SqlDbHelper("default");

		public IEnumerable<BorrowDTO> GetAllBorrowedBook()
		{
			string sql = "SELECT * FROM Borrowes JOIN Books ON Borrowes.BID = Books.BookID JOIN Users ON Borrowes.PID = Users.PersonalID";

			return sqlDbHelper.Select(sql, null).AsEnumerable().Select(x => ParseToBorrowedDTO(x));
		}

		public BorrowDTO GetBorrowUser(string userID)
		{
			string sql = "SELECT PersonalID, UserName FROM Users WHERE PersonalID = @PersonalID";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@PersonalID", 5, userID)
										.Builder();

			DataRow row = sqlDbHelper.Select(sql, parameters).Rows[0];

			return new BorrowDTO()
			{
				PID = row.Field<string>("PersonalID"),
				UserName = row.Field<string>("UserName")
			};
		}

		public BorrowDTO GetBorrowBook(string bookID)
		{
			string sql = "SELECT BookID, BookName, Author FROM Books WHERE BookID = @BookID";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@BookID", 5, bookID)
										.Builder();

			DataRow row = sqlDbHelper.Select(sql, parameters).Rows[0];

			return new BorrowDTO()
			{
				BID = row.Field<string>("BookID"),
				BookName = row.Field<string>("BookName"),
				Author = row.Field<string>("Author")
			};
		}

		public void Insert(BorrowDTO dto)
		{
			string sql = "INSERT INTO Borrowes(PID, BID) VALUES(@PID, @BID)";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@PID", 5, dto.PID)
										.AddChar("@BID", 5, dto.BID)
										.Builder();

			sqlDbHelper.ExecuteNonQuery(sql, parameters);
		}

		public void Delete(BorrowDTO dto)
		{
			string sql = "DELETE FROM Borrowes WHERE PID = @PID AND BID = @BID";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@PID", 5, dto.PID)
										.AddChar("@BID", 5, dto.BID)
										.Builder();

			sqlDbHelper.ExecuteNonQuery(sql, parameters);
		}

		public int GetUserCount(string psersonalID)
		{
			string sql = "SELECT COUNT(*) AS count FROM Users WHERE PersonalID = @PersonalID";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@PersonalID", 5, psersonalID)
										.Builder();

			return sqlDbHelper.Select(sql, parameters).Rows[0].Field<int>("count");
		}

		public int GetBookCount(string bookID)
		{
			string sql = "SELECT COUNT(*) AS count FROM Books WHERE BookID = @BookID";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@BookID", 5, bookID)
										.Builder();

			return sqlDbHelper.Select(sql, parameters).Rows[0].Field<int>("count");
		}

		private BorrowDTO ParseToBorrowedDTO(DataRow row)
		{
			return new BorrowDTO()
			{
				PID = row.Field<string>("PID"),
				UserName = row.Field<string>("UserName"),
				BID = row.Field<string>("BID"),
				BookName = row.Field<string>("BookName"),
				Author = row.Field<string>("Author")
			};
		}
	}
}
