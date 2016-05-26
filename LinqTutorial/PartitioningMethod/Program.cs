using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitioningMethod
{
	class Program
	{
		private static void PrintList(IEnumerable<int> numbers)
		{
			Console.WriteLine("List is");
			foreach (var number in numbers)
			{
				Console.Write("{0} ", number);
			}
			Console.WriteLine();
		}
		static void Main(string[] args)
		{
			var number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
			PrintList(number.Skip(3));				//4 5 6 7 8
			PrintList(number.SkipWhile(x=>x<6));	//6 7 8

			PrintList(number.Take(3));				//1 2 3
			PrintList(number.TakeWhile(x => x < 6));//1 2 3 4 5

			Console.ReadKey();

		}
	}
}
