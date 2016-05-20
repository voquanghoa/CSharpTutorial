using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerializeElementAttribute
{
	class Program
	{
		static void Main(string[] args)
		{
			var xmlContent = File.ReadAllText("ClassesData.xml");

			var controller = new Controller<StudentData>();

			var classesData = controller.Deserialize(xmlContent);
			var xmlContentCopy = controller.Serialize(classesData);

			File.WriteAllText("ClassesData-Copy.xml", xmlContentCopy);
		}
	}
}
