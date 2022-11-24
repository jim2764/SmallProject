using Admit.Models.DTOs;
using Ispan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Admit.Infrastructures.DAOs
{
	public class AdmitLoginDAO
	{
		SqlDbHelper sqlDbHelper = new SqlDbHelper("default");
		public AdmitDTO GetAdmit(AdmitDTO dto)
		{
			string sql = "SELECT * FROM Admits WHERE Account = @Account";

			SqlParameter[] parameters = new SqlParameterBuilder()
										.AddVarchar("@Account", 10, dto.Account)
										.Builder();

			DataRowCollection rows = sqlDbHelper.Select(sql, parameters).Rows;

			if (rows.Count == 0) return new AdmitDTO();

			DataRow row = rows[0];

			return new AdmitDTO()
			{
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				AdmitName = row.Field<string>("AdmitName")
			};
		}


	}
}
