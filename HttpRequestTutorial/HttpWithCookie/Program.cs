using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HttpWithCookie
{
	class Program
	{
		static CookieCollection CreateCookies()
		{
			var cookies = new CookieCollection()
			{
				new Cookie("UserName","Vo Quang Hoa"),
				new Cookie("HashCode","123456ABCDEF"),
				new Cookie("Setting1","Value1"),
				new Cookie("Setting2","Value2")
			};

			return cookies;
		}

		static void SendRequestWithCookie()
		{
			Console.WriteLine("Send a method with GET");

			var url = "http://httpbin.org/cookies";
			var request = WebRequest.Create(url) as HttpWebRequest;

			request.Accept = "text/html;text/plain";
			request.ContentType = "application/json; charset=utf-8";
			request.MediaType = "application/json";
			request.Headers.Add("Accept-Encoding", "gzip");

			var cookies = CreateCookies();
			request.CookieContainer = new CookieContainer();
			request.CookieContainer.Add(request.RequestUri, cookies);

			//Do the request and get the response
			var response = request.GetResponse() as HttpWebResponse;
		
			//Read the response and print to the console
			var stream = response.GetResponseStream();
			var responseData = new StreamReader(stream).ReadToEnd();
			Console.WriteLine($"Response is\n{responseData}");
		}

		static void Main(string[] args)
		{
			SendRequestWithCookie();

			Console.ReadKey();
		}
	}
}
