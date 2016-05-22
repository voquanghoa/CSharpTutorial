using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestWithHeader
{
	class Program
	{
		static void SendRequestToDantriDotCom(bool useMobileAgent)
		{
			Console.WriteLine("Send a method with GET");

			var url = "http://dantri.com";
			var request = WebRequest.Create(url) as HttpWebRequest;

			request.Accept = "text/html;text/plain";
			request.ContentType = "application/json; charset=utf-8";
			request.MediaType = "application/json";
			request.Headers.Add("Accept-Encoding", "gzip");

			if (useMobileAgent)
			{
				request.UserAgent = "Mozilla/5.0 (Linux; U; Android 4.0.3; ko-kr; LG-L160L Build/IML74K) AppleWebkit/534.30 (KHTML, like Gecko) Version/4.0 Mobile Safari/534.30";
			}

			//Do the request and get the response
			var response = request.GetResponse() as HttpWebResponse;

			//Read the response and print to the console
			Console.WriteLine("Response uri " + response.ResponseUri);
		}

		static void Main(string[] args)
		{
			SendRequestToDantriDotCom(false);
			SendRequestToDantriDotCom(true);

			Console.ReadKey();
		}
	}
}
