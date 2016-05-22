using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DownloadZingMp3
{
	public delegate void Update(string message);

	public class ZingMp3Downloader
	{
		public event Update OnUpdate;

		private HttpWrapper httpWrapper = new HttpWrapper();
		private XmlConvert<Data> xmlConvert = new XmlConvert<Data>();

		private string ParseFirstOccur(string data, string pattern)
		{
			var match = Regex.Match(data, pattern);
			return match.Success ? match.Groups[1].Value : "";
		}

		private string ParseXmlUrl(string songWebPageContent)
		{
			var pattern = "data-xml=\\\"([^\\\"]*)";
			return ParseFirstOccur(songWebPageContent, pattern);
		}

		private string ParseSongName(string pageName)
		{
			var pattern = "http://mp3.zing.vn/bai-hat/([^/]*)";
			return ParseFirstOccur(pageName, pattern).Replace('-', ' ');
		}

		private void Feedback(string message)
		{
			OnUpdate?.Invoke(message);
		}

		private Data DownloadXmlData(string xmlUrl)
		{
			return xmlConvert.Deserialize(httpWrapper.LoadText(xmlUrl));
		}

		public void Download(string url, string saveTo)
		{
			Feedback("Download started!");
			Feedback("Load song page...");
			var songContent = httpWrapper.LoadText(url);
			Feedback("Load song page...Done");

			Feedback("Load xml data...");
			var xmlPath = ParseXmlUrl(songContent);
			var xmlData = DownloadXmlData(xmlPath);
			var songName = ParseSongName(xmlData.Page);
			Feedback("Load xml data...Done");

			saveTo = Path.Combine(saveTo, songName);

			if (!Directory.Exists(saveTo))
			{
				Directory.CreateDirectory(saveTo);
			}

			Feedback("Download mp3 file...");
			httpWrapper.Download(xmlData.Item.Source, Path.Combine(saveTo, songName + ".mp3"), Feedback);
			Feedback("Download mp3 file completed!");

			Feedback("Download liric file...");
			httpWrapper.Download(xmlData.Item.Lyric, Path.Combine(saveTo, songName + ".lrc"), Feedback);
			Feedback("Download liric file completed!");
			
			Feedback("Download image file...");
			httpWrapper.Download(xmlData.Item.Backimage, Path.Combine(saveTo, songName + ".jpg"), Feedback);
			Feedback("Download image file completed!");
		}
	}
}
