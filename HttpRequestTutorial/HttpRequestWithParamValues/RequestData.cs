using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace HttpRequestWithParamValues
{
	public class RequestData : Dictionary<string, string>
	{
		public string BuildString()
		{
			return string.Join("&", this.Select(ConvertToKeyValuePair));
		}

		public byte[] BuildByteData()
		{
			return Encoding.ASCII.GetBytes(BuildString());
		}

		private string ConvertToKeyValuePair(KeyValuePair<string, string> keyvalue)
		{
			return string.Format("{0}={1}", keyvalue.Key, HttpUtility.UrlEncode(keyvalue.Value));
		}
	}
}
