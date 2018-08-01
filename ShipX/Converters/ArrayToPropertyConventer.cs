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
            
            if (reader.TokenType == JsonToken.StartArray)
            {

            }
            
            return new object();

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {

            JToken t = JToken.FromObject(value);

            if (t.Type != JTokenType.Object)
            {
                if (t.Type == JTokenType.Array)
                {
                    var arr = value as Array;

                    if (arr.Length == 1)
                    {
                        

                        //arr.Length
                    }

                    if (arr.Length > 1)
                    {

                    }
                }
                
                t.WriteTo(writer);
            }
            else
            {
                JObject o = (JObject)t;
                IList<string> propertyNames = o.Properties().Select(p => p.Name).ToList();
                o.AddFirst(new JProperty("Keys", new JArray(propertyNames)));
                o.WriteTo(writer);
            }
        }
    }
}
