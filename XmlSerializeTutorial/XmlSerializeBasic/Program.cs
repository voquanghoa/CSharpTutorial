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
			//Create object
			var student = new Student()
			{
				FirstName = "Tran Thi",
				LastName = "Thanh",
				Address = "123 Nguyen Luong Bang",
				Birthday = new DateTime(1990, 2, 14)
			};

			//Serialize object -> text
			XmlSerializer serializerObj = new XmlSerializer(typeof(Student));
			MemoryStream outputMemoryStream = new MemoryStream();
			serializerObj.Serialize(outputMemoryStream, student);
			outputMemoryStream.Close();

			var studentXml = Encoding.ASCII.GetString(outputMemoryStream.ToArray());
			Console.WriteLine("XML document\n------\n" + studentXml);

			//Deserialize text -> object
			XmlSerializer deserializerObj = new XmlSerializer(typeof(Student));
			MemoryStream inputMemoryStream = new MemoryStream(Encoding.ASCII.GetBytes(studentXml));
			var outputStent = (Student)deserializerObj.Deserialize(inputMemoryStream);

			Console.WriteLine("\nStudent :");
			Console.WriteLine($"First Name	:{outputStent.FirstName}");
			Console.WriteLine($"Last Name	:{outputStent.LastName}");
			Console.WriteLine($"Address		:{outputStent.Address}");
			Console.WriteLine($"Birthday	:{outputStent.Birthday}");

			Console.ReadKey();
		}
	}
}

