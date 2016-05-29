using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
	class Program
	{
		static void Main(string[] args)
		{
			foreach (var number in Enumerable.Range(1, 5))
			{
				Console.WriteLine(number);//1 2 3 4 5
			}

			foreach (var number in Enumerable.Repeat(10, 5))
			{
				Console.WriteLine(number);//10 10 10 10 10
			}

			Console.ReadKey();
		}
	}
}
