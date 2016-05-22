using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace UploadFiles
{
	public static class FormUpload
	{
		private static readonly Encoding encoding = Encoding.UTF8;
		public static HttpWebResponse MultipartFormDataPost(string postUrl, Dictionary<string, object> postParameters)
		{
			var formDataBoundary = string.Format("----------{0:N}", Guid.NewGuid());
			var contentType = "multipart/form-data; boundary=" + formDataBoundary;

			var formData = GetMultipartFormData(postParameters, formDataBoundary);

			return PostForm(postUrl, contentType, formData);
		}
		private static HttpWebResponse PostForm(string postUrl, string contentType, byte[] formData)
		{
			HttpWebRequest request = WebRequest.Create(postUrl) as HttpWebRequest;

			request.Method = "POST";
			request.ContentType = contentType;
			request.CookieContainer = new CookieContainer();
			request.ContentLength = formData.Length;

			using (var requestStream = request.GetRequestStream())
			{
				requestStream.Write(formData, 0, formData.Length);
				requestStream.Close();
			}

			return request.GetResponse() as HttpWebResponse;
		}

		private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
		{
			var formDataStream = new MemoryStream();
			bool needsCLRF = false;

			foreach (var param in postParameters)
			{
				if (needsCLRF)
				{
					formDataStream.Write(encoding.GetBytes("\r\n"), 0, encoding.GetByteCount("\r\n"));
				}
					
				needsCLRF = true;

				if (param.Value is FileParameter)
				{
					FileParameter fileToUpload = (FileParameter)param.Value;

					string header = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\"\r\nContent-Type: {3}\r\n\r\n",
						boundary,
						param.Key,
						fileToUpload.FileName ?? param.Key,
						fileToUpload.ContentType ?? "application/octet-stream");

					formDataStream.Write(encoding.GetBytes(header), 0, encoding.GetByteCount(header));

					formDataStream.Write(fileToUpload.FileData, 0, fileToUpload.FileData.Length);
				}
				else
				{
					string postData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"\r\n\r\n{2}",
						boundary,
						param.Key,
						param.Value);
					formDataStream.Write(encoding.GetBytes(postData), 0, encoding.GetByteCount(postData));
				}
			}

			string footer = "\r\n--" + boundary + "--\r\n";
			formDataStream.Write(encoding.GetBytes(footer), 0, encoding.GetByteCount(footer));

			// Dump the Stream into a byte[]
			formDataStream.Position = 0;
			byte[] formData = new byte[formDataStream.Length];
			formDataStream.Read(formData, 0, formData.Length);
			formDataStream.Close();

			return formData;
		}

		public class FileParameter
		{
			public string FilePath { private set; get; }
			public string FileName { get; set; }
			public string ContentType { get; set; } = "application/octet-stream";

			private byte[] fileData;
			public byte[] FileData
			{
				get
				{
					return fileData = (fileData ?? File.ReadAllBytes(FilePath));
				}
			}

			public FileParameter(string path)
			{
				FilePath = path;
				FileName = Path.GetFileName(path);
			}

			
		}
	}
}
