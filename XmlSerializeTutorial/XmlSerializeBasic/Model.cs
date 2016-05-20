using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerializeBasic
{
	public class Student
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public DateTime Birthday { get; set; }

		public string Address { get; set; }

		public override string ToString()
		{
			var stringBuilder = new StringBuilder();
			stringBuilder.Append($"First Name : {FirstName}\n");
			stringBuilder.Append($"Last Name  : {LastName}\n");
			stringBuilder.Append($"Address    : {Address}\n");
			stringBuilder.Append($"Birthday   : {Birthday}\n");
			return stringBuilder.ToString();
		}
	}
}
