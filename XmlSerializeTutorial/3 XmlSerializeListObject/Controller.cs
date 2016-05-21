using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializeListObject
{
	public class Controller<T> where T : class
	{
		private XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

		public string Serialize(T data)
		{
			var writer = new StringWriter();
			xmlSerializer.Serialize(writer, data);
			return writer.ToString();
		}

		public T Deserialize(string data)
		{
			var reader = new StringReader(data);
			return (T)xmlSerializer.Deserialize(reader);
		}
	}
}
