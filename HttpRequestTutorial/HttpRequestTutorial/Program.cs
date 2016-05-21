using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HttpRequestTutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create http request with url
			var url = "http://httpbin.org/";
			WebRequest request = WebRequest.Create(url);
			request.Method = "GET";

			//Do the request and get the response
			var stream = request.GetResponse().GetResponseStream();

			//Read the response and print to the console
			var reader = new StreamReader(stream);
			var response = reader.ReadToEnd();
			Console.WriteLine(response);

			Console.ReadKey();
		}
	}
}
