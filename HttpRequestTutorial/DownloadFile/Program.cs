using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DownloadFile
{
	class Program
	{
		static void DownloadFile(string url, string saveAs)
		{
			var request = WebRequest.Create(url);

			//Do the request and get the response
			var response = request.GetResponse() as HttpWebResponse;

			//Read the response
			var inputStream = response.GetResponseStream();
			var outputStream = File.OpenWrite(saveAs);

			var buffer = new byte[10 * 1024];//10kb
			var downloadSize = 0;
			var downloadSizeTotal = 0;

			while((downloadSize = inputStream.Read(buffer, 0, buffer.Length)) > 0)
			{
				downloadSizeTotal += downloadSize;
				outputStream.Write(buffer, 0, downloadSize);
				Console.WriteLine("Downloaded {0} Kb", downloadSizeTotal / 1024);
			}

			inputStream.Close();
			outputStream.Close();
			Console.WriteLine("Download done");
		}
		static void Main(string[] args)
		{
			DownloadFile("http://stream7.r13s120.vcdn.vn/fsfsdfdsfdserwrwq3/30d959a1e5c95eee7ddf38d42351aa27/57417b09/2015/12/18/f/5/f52284e842834f98b143b07711032a07.mp3",
				"D:\\file.mp3");

			Console.ReadKey();
		}
	}
}
