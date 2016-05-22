using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HttpRequestWithParamValues
{
	class Program
	{
		static void SendGETRequestWithParam()
		{
			Console.WriteLine("Send a GET request with params 1");
			//Create http request with url
			var url = "http://httpbin.org/get?value=1&value2=22f";
			WebRequest request = WebRequest.Create(url);

			//Do the request and get the response
			var stream = request.GetResponse().GetResponseStream();

			//Read the response and print to the console
			var reader = new StreamReader(stream);
			var response = reader.ReadToEnd();
			Console.WriteLine($"Response is\n{response}");
		}

		static void SendGETRequestWithParam2()
		{
			var requestParam = new RequestData()
			{
				{"data1","Value 1"},
				{"data2","Value 2"},
				{"data3","Value xxxyy"},
			};

			Console.WriteLine("Send a GET request with params 2");
			//Create http request with url
			var url = "http://httpbin.org/get?" + requestParam.BuildString();
			var request = WebRequest.Create(url);

			//Do the request and get the response
			var stream = request.GetResponse().GetResponseStream();

			//Read the response and print to the console
			var reader = new StreamReader(stream);
			var response = reader.ReadToEnd();
			Console.WriteLine($"Response is\n{response}");
		}

		static void SendSimplePOSTRequestWithParams()
		{
			Console.WriteLine("Send a POST request with params");
			
			var url = "http://httpbin.org/post";
			var request = WebRequest.Create(url);
			request.Method = "POST";

			var postDataString = "param1=value1&param2=value2";
			var requestPostData = Encoding.ASCII.GetBytes(postDataString);

			var inputStream = request.GetRequestStream();
			inputStream.Write(requestPostData, 0, requestPostData.Length);
			inputStream.Flush();

			var stream = request.GetResponse().GetResponseStream();

			//Read the response and print to the console
			var reader = new StreamReader(stream);
			var response = reader.ReadToEnd();
			Console.WriteLine($"Response is\n{response}");
		}

		static void SendPOSTRequestWithParams()
		{
			Console.WriteLine("Send a POST request with params");
			var requestParam = new RequestData()
			{
				{"data1","POST Value 1"},
				{"data2","POST Value 2"},
				{"data3","POST Value xxxyy"},
			};
			var requestData = requestParam.BuildByteData();

			var url = "http://httpbin.org/post";
			var request = WebRequest.Create(url);
			request.Method = "POST";

			var inputStream = request.GetRequestStream();
			inputStream.Write(requestData, 0, requestData.Length);
			inputStream.Flush();

			var stream = request.GetResponse().GetResponseStream();

			//Read the response and print to the console
			var reader = new StreamReader(stream);
			var response = reader.ReadToEnd();
			Console.WriteLine($"Response is\n{response}");
		}

		static void Main(string[] args)
		{
			SendGETRequestWithParam();
			SendGETRequestWithParam2();

			SendSimplePOSTRequestWithParams();
			SendPOSTRequestWithParams();

			Console.ReadKey();
		}
	}
}
