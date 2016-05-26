using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantifiersMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = new List<int>() { 6, 8, 9, 7, 11, 6 };
			Console.WriteLine(numbers.All(x => x > 5)); //true
			Console.WriteLine(numbers.All(x => x % 3 ==0)); //false

			Console.WriteLine(numbers.Any(x => x > 10)); //true
			Console.WriteLine(numbers.Any(x => x > 12)); //false

			Console.WriteLine(numbers.Contains(9)); //true
			Console.WriteLine(numbers.Contains(10)); //false

			var numers2 = new List<int>() { 6, 8, 9, 7, 11, 6 };
			var numers3 = new List<int>() { 6, 8, 9, 7, 6, 11 };
			Console.WriteLine(numbers.SequenceEqual(numers2)); //false
			Console.WriteLine(numbers.SequenceEqual(numers3)); //false

			Console.ReadKey();
		}
	}
}
