using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
	class Program
	{
		static void PrintList(int[] list)
		{
			foreach (var item in list)
			{
				Console.Write("{0} ", item);
			}
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			var arr = new int[] {1,6,9,8,12,36,23,42,66, 19, 22, 33};

			//Solution 1
			int count = 0;
			var result = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				if(arr[i] % 3 == 0)
				{
					result[count] = arr[i];
					count++;
				}
			}

			
			Console.WriteLine("Result of solution 1");
			PrintList(result);

			//With Linq (method)
			result = arr.Where(x => x % 3 == 0).ToArray();
			Console.WriteLine("\n\nResult of solution 2");
			PrintList(result);

			//With linq syntax
			result = (from x in arr where x % 3 == 0 select x).ToArray();
			Console.WriteLine("\n\nResult of solution 3");
			PrintList(result);

			
			arr.GetEnumerator();

			Console.ReadKey();
		}
	}
}
