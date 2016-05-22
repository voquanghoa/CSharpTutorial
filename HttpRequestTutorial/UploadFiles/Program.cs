using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UploadFiles
{
	class Program
	{
		static void Main(string[] args)
		{
			var filePath = @"D:\Program.cs";
			var uploadUrl = "http://quanghoa.xyz/sample/upload.php";

			byte[] data = File.ReadAllBytes(filePath); 


			// Generate post objects
			Dictionary<string, object> postParameters = new Dictionary<string, object>();
			postParameters.Add("fileToUpload", new FormUpload.FileParameter(filePath));

			// Create request and receive response
			HttpWebResponse webResponse = FormUpload.MultipartFormDataPost(uploadUrl, postParameters);

			// Process response
			StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
			string fullResponse = responseReader.ReadToEnd();
			webResponse.Close();

			Console.WriteLine(fullResponse);
			Console.ReadKey();
		}
	}
}
