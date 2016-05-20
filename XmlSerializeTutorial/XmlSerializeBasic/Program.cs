using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace XmlSerializeBasic
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create a student object
			var student = new Student()
			{
				FirstName = "Tran Thi",
				LastName = "Thanh",
				Address = "123 Nguyen Luong Bang",
				Birthday = new DateTime(1990, 2, 14)
			};

			//Serialize object -> text
			var serializerObj = new XmlSerializer(typeof(Student));
			var writer = new StringWriter();
			serializerObj.Serialize(writer, student);
			var studentXml = writer.ToString();
			Console.WriteLine("XML document\n------\n" + studentXml);

			//Deserialize text -> object
			var deserializerObj = new XmlSerializer(typeof(Student));
			var reader = new StringReader(studentXml);
			var outputStudent = (Student)deserializerObj.Deserialize(reader);

			Console.WriteLine($"\nStudent :\n{outputStudent}");

			Console.ReadKey();
		}
	}
}

