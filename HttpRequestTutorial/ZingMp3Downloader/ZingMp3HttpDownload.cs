using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZingMp3Downloader
{
	public class ZingMp3HttpDownload
	{

		public string ParseSongXMLInfoPath(string webContent)
		{
			var pattern = "data-xml=\\\"([^\\\"]*)";
			var match = Regex.Match(webContent, pattern);
			if (match.Success)
			{
				return match.Groups[1].Value;
			}
			return "";
		}

		public Data DownloadXmlData(string url)
		{
			var xml = HttpDownloader.LoadTextContent(url);
			var xmlConverter = new XmlConvert<Data>();
			return xmlConverter.Deserialize(xml);
		}
	}
}
