using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerializeListObject
{
	class Program
	{
		static void Main(string[] args)
		{
			var xmlContent = File.ReadAllText("ClassesData.xml");
			var controller = new Controller<List<Class>>();
			var classesData = controller.Deserialize(xmlContent);
			var xmlContentCopy = controller.Serialize(classesData);
			File.WriteAllText("ClassesData-Copy.xml", xmlContentCopy);
		}
	}
}
