using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereMethod
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

		public override string ToString()
		{
			return $" {Name,-10} Score {Score}";
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
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

			students = students.Where(x => x.Score >= 7).Where(x => x.Score <= 9).ToList();
			students.ForEach(Console.WriteLine);


			Console.ReadKey();
		}
	}
}
