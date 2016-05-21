using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializeTutorialWithAttributes
{
	public class GenderConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(bool);
		}
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return reader.Value.Equals("Male");
		}
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue((bool)value ? "Male" : "Female");
		}
	}

	public class Student
	{
		[JsonProperty(PropertyName="firstName")]
		public string FirstName { get; set; }

		[JsonProperty(PropertyName = "lastName")]
		public string LastName { get; set; }

		[JsonIgnore]
		public string Email { get; set; }

		[JsonProperty(Order = 1)]
		public DateTime Birthday { get; set; }

		[JsonProperty(Required = Required.Always)]
		public string Address { get; set; }

		[JsonConverter(typeof(GenderConverter))]
		public bool Gender { get; set; }

		public override string ToString()
		{
			var stringBuilder = new StringBuilder();
			stringBuilder.Append($"First Name : {FirstName}\n");
			stringBuilder.Append($"Last Name  : {LastName}\n");
			stringBuilder.Append($"Address    : {Address}\n");
			stringBuilder.Append($"Birthday   : {Birthday}\n");
			return stringBuilder.ToString();
		}
	}
}
