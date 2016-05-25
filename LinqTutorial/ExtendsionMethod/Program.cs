using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendsionMethod
{
	public static class StringHelper
	{
		public static int WordCount(this string str)
		{
			return str.Split(new []{ ' ', '.', '?', ',' },StringSplitOptions.RemoveEmptyEntries).Length;
		}

		public static string ToNamingFormat(this string str)
		{
			var stringBuilder = new StringBuilder();
			for(int i = 0; i < str.Length; i++)
			{
				if(i==0 || str[i-1]==' ')
				{
					stringBuilder.Append(char.ToUpper(str[i]));
				}
				else
				{
					stringBuilder.Append(char.ToLower(str[i]));
				}
			}
			return stringBuilder.ToString();
		}

		public static bool IsNumberic(this string str)
		{
			double output;
			return double.TryParse(str, out output);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ngUYEN thi Thanh".ToNamingFormat());
			Console.WriteLine("TrAn ThI thU".ToNamingFormat());

			Console.WriteLine("TrAn ThI thU".WordCount());
			Console.WriteLine("vo Thi Thanh Thuy".WordCount());
			Console.WriteLine("Cong hoa xa hoi chu nghia".WordCount());

			Console.WriteLine("123.66".IsNumberic());
			Console.WriteLine("123.GG66".IsNumberic());
			Console.ReadKey();
		}
	}
}
