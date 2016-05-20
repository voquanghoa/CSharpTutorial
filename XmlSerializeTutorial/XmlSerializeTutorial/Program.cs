using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace XmlSerializeTutorial
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
			var controller = new Controller<Student>();
			//Serialize object -> text
			var studentXml = controller.Serialize(student);
			Console.WriteLine("XML document\n------\n" + studentXml);
			//Deserialize text -> object
			var outputStudent = controller.Deserialize(studentXml);
			Console.WriteLine($"\nStudent :\n{outputStudent}");
			Console.ReadKey();
		}
	}
}
