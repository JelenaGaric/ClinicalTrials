using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Model.Utils
{
    class MyDateTimeConverter : DateTimeConverterBase
    {
        private const string Format = "MMMM dd, yyyy";

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((DateTime)value).ToString(Format));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.Value == null)
            {
                return null;
            }

            var s = reader.Value.ToString();

            DateTime result;
          
            result = Convert.ToDateTime(s);

            return result;
        }
    }
}
