using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlSerializeElementAttribute
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
		[XmlAttribute("Name")]
		public string Name { get; set; }

		[XmlElement("Teacher")]
		public string TeacherName { get; set; }

		[XmlElement("Student")]
		public List<Student> Students { get; set; }

		[XmlIgnore]
		public int StudentCount {
			get
			{
				return Students?.Count??0;
			}
		}
	}

	[XmlRoot("Data")]
	public class StudentData : List<Class>
	{

	}
}
