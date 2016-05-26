using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationMethod
{
	
	class Program
	{
		class Student
		{
			public string Name { get; set; }
			public int Score { get; set; }

			public Student(string name, int score)
			{
				Name = name;
				Score = score;
			}
		}
		static void Main(string[] args)
		{
			var numbers = new List<int> { 1, 2, 3, 4, 5 };
			Console.WriteLine(numbers.Aggregate((x, y) => x + y));//15
			Console.WriteLine(numbers.Aggregate((x, y) => x * y));//120

			Console.WriteLine(numbers.Average());//3
			Console.WriteLine(numbers.Count());//5
			Console.WriteLine(numbers.Max());//5
			Console.WriteLine(numbers.Min());//1
			Console.WriteLine(numbers.Sum());//15

			var students = new List<Student>
			{
				new Student("Nam",8),
				new Student("Binh",7),
				new Student("Chau",9),
				new Student("Doanh",6),
				new Student("Thu",6),
				new Student("Hoai",6),
				new Student("Minh",10),
				new Student("Hoang",8),
				new Student("Phat",10)
			};

			Console.WriteLine(students.Count(x => x.Score == 10));//2


			Console.WriteLine(students.Average(x=>x.Score));//3
			Console.WriteLine(students.Max(x => x.Score));//5
			Console.WriteLine(students.Min(x => x.Score));//1
			Console.WriteLine(students.Sum(x => x.Score));//15

			Console.ReadKey();


		}
	}
}
