using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteNonQuery
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
				var sqlCommand = connection.CreateCommand();

				var result = 0;

				//Insert a row
				sqlCommand.CommandText = @"insert into GiaoVien([HoTen],[QueQuan])
										Values('Nguyễn Thị Tuyết','Quảng Ninh')";
				result = sqlCommand.ExecuteNonQuery();
				Console.WriteLine("Insert "+result + " row");


				//Update a row
				sqlCommand.CommandText = @"Update GiaoVien set HoTen='Nguyễn An' where Id=1";
				result = sqlCommand.ExecuteNonQuery();
				Console.WriteLine("Update " + result + " row");

				//Delete some rows
				sqlCommand.CommandText = @"Delete GiaoVien where Id>=3";
				result = sqlCommand.ExecuteNonQuery();
				Console.WriteLine("Delete " + result + " rows");
			}
			catch (Exception ex)
			{
				Console.WriteLine("error " + ex.Message);
			}

			Console.ReadKey();

		}
	}
}
