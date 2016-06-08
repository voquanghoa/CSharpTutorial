using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCommandParametterBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			var sqlConnection = @"Server=DESKTOP-3VKEQ47\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;";
			var connection = new SqlConnection(sqlConnection);
			try
			{
				connection.Open();
				Console.WriteLine("Connected to SQL Server");

				var sql = "Insert into GiaoVien(HoTen,QueQuan) values(@hoten,@quequan)";
				var sqlCommand = new SqlCommand(sql, connection);

				sqlCommand.Parameters.Add(new SqlParameter("hoten", "Nguyen Thanh Thao"));
				sqlCommand.Parameters.Add(new SqlParameter("quequan", "Binh Dinh"));

				sqlCommand.ExecuteNonQuery();

				Console.WriteLine("Done");

			}
			catch (Exception ex)
			{
				Console.WriteLine("error " + ex.Message);
			}

			Console.ReadKey();
		}
	}
}
