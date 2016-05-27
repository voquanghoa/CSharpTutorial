using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InnerJoin
{
	class Class
	{
		public string Name { get; set; }
		public string Teacher { get; set; }

		public Class(string name, string teacher)
		{
			Name = name;
			Teacher = teacher;
		}
	}

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
			var classes = new List<Class>
			{
				new Class("10", "Vo Van Thanh"),
				new Class("11", "Le Van Tam"),
				new Class("12", "Tran Thi Thuy"),
			};

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

			var studentInfor = from student in students
				join clas in classes on student.Class equals clas.Name
				select new
				{
					student.Name,
					clas.Teacher
				};

			foreach (var student in studentInfor)
			{
				Console.WriteLine($" Student: {student.Name} teacher: {student.Teacher}");
			}

			Console.ReadKey();
		}
	}
}
