using System;
using System.Collections.Generic;

namespace XmlSerializeListObject
{
	public class Student
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public DateTime Birthday { get; set; }

		public string Address { get; set; }
	}

	public class Class
	{
		public string Name { get; set; }

		public List<Student> Students { get; set; }

		public string TeacherName { get; set; }
	}
}
