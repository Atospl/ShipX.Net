using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Converters
{
    class ArrayToPropertyConventer : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return false;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {

            }


            return new string[] { Convert.ToString(reader.Value) };

            //return serializer.Deserialize(reader, objectType);

            //return new object();
        }

        //public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => ReadJson(reader, objectType, existingValue, serializer);



        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            JToken token = JToken.FromObject(value);

            if (token.Type != JTokenType.Object)
            {
                if (token.Type == JTokenType.Array)
                {
                    var arr = value as Array;

                    string a = arr.GetValue(0).ToString();

                    if (arr.Length == 1)
                    {
                        JObject jo = new JObject();
                        token = Convert.ToString(arr.GetValue(0));
                        token.WriteTo(writer);
                    }
                    
                }
                
            }
            else
            {
                JObject o = (JObject)token;
                IList<string> propertyNames = o.Properties().Select(p => p.Name).ToList();
                o.AddFirst(new JProperty("Keys", new JArray(propertyNames)));
                o.WriteTo(writer);
            }
        }
    }
}
