using System;
using Newtonsoft.Json;

namespace JsonSerializeTutorial
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
				Birthday = new DateTime(1990, 1, 2)
			};

			var json = JsonConvert.SerializeObject(student);
			Console.WriteLine($"Json data\n{json}");

			var newStudent = JsonConvert.DeserializeObject<Student>(json);
			Console.WriteLine($"New Student\n{student}");
			Console.ReadKey();
		}
	}
}
