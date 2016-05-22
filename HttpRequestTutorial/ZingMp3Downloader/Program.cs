using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZingMp3Downloader
{
	class Program
	{
		static void Main(string[] args)
		{
			var html = HttpDownloader.LoadTextContent();
			var url = ZingMp3HttpDownload.ParseSongXMLInfoPath(html);
		}
	}
}
