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
		static void SimpleGetMethod()
		{
			Console.WriteLine("Send a method with GET");
			//Create http request with url
			var url = "http://httpbin.org/ip";
			WebRequest request = WebRequest.Create(url);
			

			//Do the request and get the response
			var response = request.GetResponse() as HttpWebResponse;

			//Read the response and print to the console
			var stream = response.GetResponseStream();
			var responseData = new StreamReader(stream).ReadToEnd();
			Console.WriteLine($"Response is\n{responseData}");
		}

		static void SimplePostMethod()
		{
			Console.WriteLine("Send a method with POST");
			//Create http request with url
			var url = "http://httpbin.org/post";
			WebRequest request = WebRequest.Create(url);
			request.Method = "POST";

			//Do the request and get the response
			var response = request.GetResponse() as HttpWebResponse;

			//Read the response and print to the console
			var stream = response.GetResponseStream();
			var responseData = new StreamReader(stream).ReadToEnd();
			Console.WriteLine($"Response is\n{responseData}");
		}

		static void SimpleDeleteMethod()
		{
			Console.WriteLine("Send a method with DELETE");
			//Create http request with url
			var url = "http://httpbin.org/delete";
			WebRequest request = WebRequest.Create(url);
			request.Method = "DELETE";

			//Do the request and get the response
			var response = request.GetResponse() as HttpWebResponse;

			//Read the response and print to the console
			var stream = response.GetResponseStream();
			var responseData = new StreamReader(stream).ReadToEnd();
			Console.WriteLine($"Response is\n{responseData}");
		}

		static void SimplePutMethod()
		{
			Console.WriteLine("Send a method with PUT");
			//Create http request with url
			var url = "http://httpbin.org/put";
			WebRequest request = WebRequest.Create(url);
			request.Method = "PUT";

			//Do the request and get the response
			var response = request.GetResponse() as HttpWebResponse;

			//Read the response and print to the console
			var stream = response.GetResponseStream();
			var responseData = new StreamReader(stream).ReadToEnd();
			Console.WriteLine($"Response is\n{responseData}");
		}
		static void Main(string[] args)
		{
			SimpleGetMethod();
			SimplePostMethod();
			SimplePutMethod();
			SimpleDeleteMethod();

			Console.ReadKey();
		}
	}
}
