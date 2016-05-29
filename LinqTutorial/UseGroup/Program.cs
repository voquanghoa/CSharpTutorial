using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UseGroup
{
	internal class Student
	{
		public string Name { get; set; }
		public string Class { get; set; }
		public int Score { get; set; }

		public Student(string name, string className, int score)
		{
			Name = name;
			Class = className;
			Score = score;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var students = new List<Student>
			{
				new Student("Thuy", "10",9),
				new Student("Duc", "10",5),
				new Student("Xuan", "10",8),
				new Student("Vui", "11",3),
				new Student("Nam", "11",4),
				new Student("Minh", "12",7),
				new Student("Giang", "12",5),
			};

			var studentReport = from x in students
				group x by x.Class
				into studentGroup
				select new
				{
					Class = studentGroup.Key,
					AverageScore = (from y in studentGroup select y.Score)
						.Average()
				};

			/*studentReport = students.GroupBy(x => x.Class).Select(y => new
			{
				Class = y.Key,
				AverageScore = y.Average(x => x.Score)
			});*/

			foreach (var classInfor in studentReport)
			{
				Console.WriteLine($"Class {classInfor.Class} - Average score {classInfor.AverageScore}");
			}

			Console.ReadKey();
		}
	}
}
