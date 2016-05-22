using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ZingMp3Downloader
{
	public class HttpDownloader
	{
		public static string LoadTextContent(string url)
		{
			var request = WebRequest.Create(url) as HttpWebRequest;
			request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
			var stream = request.GetResponse().GetResponseStream();
			return new StreamReader(stream).ReadToEnd();
		}
	}
}
