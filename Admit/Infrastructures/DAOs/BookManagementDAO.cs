using Admit.Models.DTOs;
using Ispan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admit.Infrastructures.DAOs
{
	public class BookManagementDAO
	{
		private SqlDbHelper sqlDbHelper = new SqlDbHelper("default");

		public UserDTO GetUser(UserDTO dto)
		{
			string sql = "SELECT * FROM Users WHERE PersonalID = @PersonalID";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@PersonalID", 5, dto.PersonalID)
										.Builder();

			return sqlDbHelper.Select(sql, parameters).AsEnumerable().Select(x => ParseToUserDTO(x)).ToArray()[0];
		}

		public IEnumerable<BookDTO> GetAllBook()
		{
			string sql = "SELECT * FROM Books";

			return sqlDbHelper.Select(sql, null).AsEnumerable().Select(x => ParseToBookDTO(x));
		}

		public BookDTO GetBook(string bookID)
		{
			string sql = "SELECT * FROM Books WHERE BookID = @BookID";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@BookID", 5, bookID)
										.Builder();

			return sqlDbHelper.Select(sql, parameters).AsEnumerable().Select(x => ParseToBookDTO(x)).ToArray()[0];
		}

		public int HasThisImage(string filename)
		{
			string sql = "SELECT COUNT(*) as count FROM Books WHERE FileName = @FileName";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddNVarchar("@FileName", 50, filename)
										.Builder();

			return sqlDbHelper.Select(sql, parameters).Rows[0].Field<int>("count");
		}

		public void BookInsert(BookDTO dto)
		{
			string sql = "INSERT INTO Books VALUES (@BookID, @BookName, @Author, @TotalAmount, @FileName, @Description, 0, 0)";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@BookID", 5, dto.BookID)
										.AddNVarchar("@BookName", 50, dto.BookName)
										.AddNVarchar("@Author", 50, dto.Author)
										.AddInt("@TotalAmount", dto.TotalAmount)
										.AddNVarchar("@FileName", 50, dto.FileName)
										.AddNVarchar("@Description", 200, dto.Description)
										.Builder();

			sqlDbHelper.ExecuteNonQuery(sql, parameters);
		}



		public void BookUpdate(BookDTO dto)
		{
			string sql = "UPDATE Books SET BookName = @BooName, Author = @Author, TotalAmount = @TotalAmount, FileName = @FileName, Description = @Description WHERE BookID = @BookID";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@BookID", 5, dto.BookID)
										.AddNVarchar("@BooName", 50, dto.BookName)
										.AddNVarchar("@Author", 50, dto.Author)
										.AddInt("@TotalAmount", dto.TotalAmount)
										.AddNVarchar("@FileName", 50, dto.FileName)
										.AddNVarchar("@Description", 200, dto.Description)
										.Builder();

			sqlDbHelper.ExecuteNonQuery(sql, parameters);
		}

		public void BookDelete(string bookID)
		{
			string sql = "DELETE FROM Books WHERE BookID = @BookID";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@BookID", 5, bookID)
										.Builder();

			sqlDbHelper.ExecuteNonQuery(sql, parameters);
		}

		public int TotalBorrowAmount(BookDTO dto)
		{
			string sql = "SELECT Count(*) as count FROM Borrowes WHERE BID = @BID";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddChar("@BID", 5, dto.BookID)
										.Builder();

			DataTable table = sqlDbHelper.Select(sql, parameters);

			return table.Rows[0].Field<int>("count");
		}

		private UserDTO ParseToUserDTO(DataRow row)
		{
			return new UserDTO()
			{
				PersonalID = row.Field<string>("PersonalID"),
				UserName = row.Field<string>("UserName"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
			};
		}

		private BookDTO ParseToBookDTO(DataRow row)
		{
			return new BookDTO()
			{
				BookID = row.Field<string>("BookID"),
				BookName = row.Field<string>("BookName"),
				Author = row.Field<string>("Author"),
				TotalAmount = row.Field<int>("TotalAmount"),
				FileName = row.Field<string>("FileName"),
				Description = row.Field<string>("Description")
			};
		}
	}
}
