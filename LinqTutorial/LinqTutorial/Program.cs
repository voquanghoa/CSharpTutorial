using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			var arr = new int[] {69,85,45,26,36,44,78,66};
			var result = arr.First(x => x % 12 == 0);
		}
	}
}
