using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadZingMp3
{
	public class HttpWrapper
	{
		private HttpWebRequest CreateHttpWebRequest(string url)
		{
			var request = WebRequest.Create(url) as HttpWebRequest;
			request.Timeout = 5000;//5s
			return request;
		}
		public string LoadText(string url)
		{
			var request = CreateHttpWebRequest(url);
			request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
			var stream = request.GetResponse().GetResponseStream();
			return new StreamReader(stream).ReadToEnd();
		}

		public void Download(string url, string path, Action<string> feedback)
		{
			var request = CreateHttpWebRequest(url);

			//Do the request and get the response
			var response = request.GetResponse() as HttpWebResponse;

			//Read the response
			var inputStream = response.GetResponseStream();
			var outputStream = File.OpenWrite(path);

			var buffer = new byte[10 * 1024];//10kb
			var downloadSize = 0;
			var downloadSizeTotal = 0;
			feedback("Downloaded 0 Kb");

			while ((downloadSize = inputStream.Read(buffer, 0, buffer.Length)) > 0)
			{
				downloadSizeTotal += downloadSize;
				outputStream.Write(buffer, 0, downloadSize);
				feedback(string.Format("Downloaded {0} Kb", downloadSizeTotal / 1024));
			}

			inputStream.Close();
			outputStream.Close();
			feedback("Downloaded Done");
		}
	}
}
