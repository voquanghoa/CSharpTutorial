using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadZingMp3
{
	class Program
	{
		
		static void Main(string[] args)
		{
			var url = "http://mp3.zing.vn/bai-hat/O-Me-Ly-Miu-Le/ZW7OZ7OE.html";
			var saveTo = @"D:\Song";

			if (!Directory.Exists(saveTo))
			{
				Directory.CreateDirectory(saveTo);
			}

			var zingMp3Downloader = new ZingMp3Downloader();

			zingMp3Downloader.OnUpdate += ZingMp3Downloader_OnUpdate;
			zingMp3Downloader.Download(url, saveTo);

			Console.WriteLine("Done");
			Console.ReadKey();
		}

		private static void ZingMp3Downloader_OnUpdate(string message)
		{
			Console.WriteLine(message);
		}
	}
}
