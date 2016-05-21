using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializeTutorialWithAttributes
{
	class Program
	{
		static void Main(string[] args)
		{
			var student = new Student()
			{
				FirstName = "Nguyen Thanh",
				LastName = "Linh",
				Address = "999 Nguyen Luong Bang",
				Birthday = new DateTime(1990, 1, 2),
				Gender = true,
				Email = "email@host.com"
			};

			var json = JsonConvert.SerializeObject(student);
			Console.WriteLine($"Json data\n{json}");

			var newStudent = JsonConvert.DeserializeObject<Student>(json);
			Console.WriteLine($"New Student\n{student}");
			Console.ReadKey();
		}
	}
}
