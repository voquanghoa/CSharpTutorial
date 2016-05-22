using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpRequestWithProxy
{
	class Program
	{
		static void SimpleGetMethod(bool useProxy)
		{
			Console.WriteLine("Send a method with GET");
			//Create http request with url
			var url = "http://httpbin.org/ip";
			WebRequest request = WebRequest.Create(url);

			if (useProxy)
			{
				request.Proxy = new WebProxy("61.135.217.16", 80);
			}

			//Do the request and get the response
			var response = request.GetResponse() as HttpWebResponse;

			//Read the response and print to the console
			var stream = response.GetResponseStream();
			var responseData = new StreamReader(stream).ReadToEnd();
			Console.WriteLine($"Response is\n{responseData}");
		}

		static void Main(string[] args)
		{
			SimpleGetMethod(false);
			SimpleGetMethod(true);

			Console.ReadKey();
		}
	}
}
