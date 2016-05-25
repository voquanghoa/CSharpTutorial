using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousClass
{
	class Program
	{
		static void Main(string[] args)
		{
			var obj = new
			{
				PropertyA = 10,
				PropertyB = "Hello",
			};

			Console.WriteLine("Here is an object of an anonymous class");
			Console.WriteLine("Class of obj is {0}",obj.GetType());
			Console.WriteLine("obj.PropertyA = {0}", obj.PropertyA);
			Console.WriteLine("obj.PropertyB = {0}", obj.PropertyB);

			Console.ReadKey();
		}
	}
}
