using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetMethod
{
	class Program
	{
		static void UseDistinct()
		{
			Console.WriteLine("UseDistinct Examble ");
			var numbers = new List<int> {1, 2, 4, 5, 4, 5, 3, 2, 5 ,6 ,7,8 };
			foreach (var number in numbers.Distinct())
			{
				Console.Write(" {0}", number);
			}
			Console.WriteLine();
		}

		static void UseExcept()
		{
			Console.WriteLine("UseExcept Examble ");
			var numbers = new List<int> { 1, 2, 4, 5, 4, 5, 3, 2, 5, 6, 7, 8 };
			var exceptNumbers = new List<int> { 5,6,7,8 };
			foreach (var number in numbers.Except(exceptNumbers))
			{
				Console.Write(" {0}", number);
			}
			Console.WriteLine();
		}

		static void UseIntersect()
		{
			Console.WriteLine("UseIntersect Examble ");
			var numbers = new List<int> { 1, 2, 4, 5, 4, 5, 3, 2, 5, 6, 7, 8 };
			var anotherNumbers = new List<int> { 100, 6, 8, 6, 5,99 };
			foreach (var number in numbers.Intersect(anotherNumbers))
			{
				Console.Write(" {0}", number);
			}
			Console.WriteLine();
		}

		static void UseUnion()
		{
			Console.WriteLine("UseUnion Examble ");
			var numbers = new List<int> { 1,2,2,3,4,4 };
			var moreNumbers = new List<int> { 3,3,5,5,6,6,7,7 };
			foreach (var number in numbers.Union(moreNumbers))
			{
				Console.Write(" {0}", number);
			}
			Console.WriteLine();
		}

		static void UseConcat()
		{
			Console.WriteLine("UseUnion Examble ");
			var numbers = new List<int> { 1, 2, 2, 3, 4, 4 };
			var moreNumbers = new List<int> { 3, 3, 5, 5, 6, 6, 7, 7 };
			foreach (var number in numbers.Concat(moreNumbers))
			{
				Console.Write(" {0}", number);
			}
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			UseDistinct();

			UseExcept();

			UseIntersect();

			UseUnion();

			Console.ReadKey();
		}
	}
}
