using System;
using System.Collections.Generic;
using System.Linq;

namespace PartitioningMethod
{
	internal class Program
	{
		private static void PrintList(IEnumerable<int> numbers)
		{
			Console.WriteLine("List is");
			foreach (var number in numbers)
			{
				Console.Write($"{number} ");
			}
			Console.WriteLine();
		}

		private static void Main()
		{
			var number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
			PrintList(number.Skip(3));				//4 5 6 7 8
			PrintList(number.SkipWhile(x=>x<6));	//6 7 8

			PrintList(number.Take(3));				//1 2 3
			PrintList(number.TakeWhile(x => x < 6));//1 2 3 4 5

			Console.ReadKey();
		}
	}
}
