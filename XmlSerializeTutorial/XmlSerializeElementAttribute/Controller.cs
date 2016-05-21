using System.IO;
using System.Xml.Serialization;

namespace XmlSerializeElementAttribute
{
	public class Controller<T> where T : class
	{
		private XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

		public string Serialize(T data)
		{
			StringWriter writer = new StringWriter();
			xmlSerializer.Serialize(writer, data);
			return writer.ToString();
		}

		public T Deserialize(string data)
		{
			StringReader reader = new StringReader(data);
			return (T)xmlSerializer.Deserialize(reader);
		}
	}
}
