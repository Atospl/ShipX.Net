using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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


            
            



            




        }
    }
}
