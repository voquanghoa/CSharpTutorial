using System.Xml.Serialization;

namespace DownloadZingMp3
{
	[XmlRoot(ElementName = "item")]
	public class Item
	{
		[XmlElement(ElementName = "title")]
		public string Title { get; set; }
		[XmlElement(ElementName = "performer")]
		public string Performer { get; set; }
		[XmlElement(ElementName = "link")]
		public string Link { get; set; }
		[XmlElement(ElementName = "source")]
		public string Source { get; set; }
		[XmlElement(ElementName = "hq")]
		public string Hq { get; set; }
		[XmlElement(ElementName = "duration")]
		public string Duration { get; set; }
		[XmlElement(ElementName = "lyric")]
		public string Lyric { get; set; }
		[XmlElement(ElementName = "mvlink")]
		public string Mvlink { get; set; }
		[XmlElement(ElementName = "adparam")]
		public string Adparam { get; set; }
		[XmlElement(ElementName = "backimage")]
		public string Backimage { get; set; }
		[XmlElement(ElementName = "errorcode")]
		public string Errorcode { get; set; }
		[XmlElement(ElementName = "errormessage")]
		public string Errormessage { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "data")]
	public class Data
	{
		[XmlElement(ElementName = "item")]
		public Item Item { get; set; }
		[XmlAttribute(AttributeName = "page")]
		public string Page { get; set; }
	}
}
