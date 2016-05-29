using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectSample
{
	internal class Program
	{

		private static void Main()
		{
			var students = new List<Student>
			{
				new Student("An", 8, 5, 10),
				new Student("Thach", 9, 10, 9),
				new Student("Binh", 7, 8, 4),
				new Student("Chau", 5, 9, 10),
				new Student("Nam", 6, 9, 9),
				new Student("Tuan", 5, 4, 5),
				new Student("Giang", 7, 10, 10),
				new Student("Dung", 7, 9, 10),
			};
			
			var names = from x in students
				select x.Name;

			//names = students.Select(x => x.Name);

			foreach (var name in names)
			{
				Console.WriteLine(name);
			}

			var goodStudents = from x in students
				where (x.Score1 + x.Score2 + x.Score3)/3 >= 8
				orderby (x.Score1 + x.Score2 + x.Score3)/3 descending, x.Name
				select new
				{
					x.Name,
					AverageScore = (x.Score1 + x.Score2 + x.Score3)/3
				};

			/*goodStudents = students.Where(x => (x.Score1 + x.Score2 + x.Score3) / 3 >= 8)
				.OrderByDescending(x => (x.Score1 + x.Score2 + x.Score3) / 3)
				.ThenBy(x => x.Name).Select(x => new
				{
					x.Name,
					AverageScore = (x.Score1 + x.Score2 + x.Score3) / 3
				});*/

			foreach (var studentInfo in goodStudents)
			{
				Console.WriteLine($" {studentInfo.Name} {studentInfo.AverageScore}");
			}
			/////////////////////Su dung let
			goodStudents = from x in students
						   let total = x.Score1 + x.Score2 + x.Score3
						   let average = total / 3
							where average >= 8
							orderby average descending, x.Name
							select new
							{
								x.Name,
								AverageScore = average
							};
			/*goodStudents = students.Select(x => new
			{
				Average = (x.Score1 + x.Score2 + x.Score3) / 2,
				Student = x
			})	.Where(y => y.Average >= 8)
				.OrderByDescending(z => z.Average)
				.ThenBy(t => t.Student.Name)
				.Select(k => new
				{
					k.Student.Name,
					AverageScore = k.Average
				});
				*/

			foreach (var studentInfo in goodStudents)
			{
				Console.WriteLine($" {studentInfo.Name} {studentInfo.AverageScore}");
			}

			Console.ReadKey();
		}
	}
}
