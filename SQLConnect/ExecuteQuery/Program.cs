using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteQuery
{
	class Program
	{
		
		private static void InsertSomeData(SqlCommand sqlCommand)
		{
			var sampleData = new string[][]
			{
				new []{"Vo Thanh Hai", "Thái Bình"},
				new []{"Trần Đại Nghĩa","Thai Nguyen" },
				new []{"Lê Thanh Nga","Ninh Bình" }
			};
			foreach (var data in sampleData)
			{
				sqlCommand.CommandText = "Insert into GiaoVien(HoTen,QueQuan) Values" +
					$"(N'{data[0]}','{data[1]}')";
				sqlCommand.ExecuteNonQuery();
			}
		}
		static void Main(string[] args)
		{
			var sqlConnection = @"Server=DESKTOP-3VKEQ47\SQLEXPRESS;Initial Catalog=QLSV;Integrated Security=True;";
			var connection = new SqlConnection(sqlConnection);
			try
			{
				connection.Open();
				Console.WriteLine("Connected to SQL Server");
				var sqlCommand = connection.CreateCommand();

				//InsertSomeData(sqlCommand);


				sqlCommand.CommandText = "Select * from GiaoVien";
				var reader = sqlCommand.ExecuteReader();
				DataTable dataTable = new DataTable();
				dataTable.Load(reader);
				Console.WriteLine("ID  | HoTen               | QueQuan");
				Console.WriteLine("-----------------------------");
				foreach (DataRow row in dataTable.Rows)
				{
					var id = row[0].ToString().Trim();
					var hoten = row[1].ToString().Trim();
					var quequan = row[2].ToString().Trim();

					Console.WriteLine($"{id,-3} | {hoten,-20}| {quequan}");
				}


				sqlCommand.CommandText = "Select count(*) from GiaoVien";
				var count = sqlCommand.ExecuteScalar();
				Console.WriteLine($"\nCo {count} giao vien");
			}
			catch (Exception ex)
			{
				Console.WriteLine("error " + ex.Message);
			}

			Console.ReadKey();
		}
	}
}
