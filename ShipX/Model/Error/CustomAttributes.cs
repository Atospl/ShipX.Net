using Newtonsoft.Json;
using RestSharp.Serializers;
using ShipX.Net.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model.Error
{
    public class CustomAttributes
    {
        //[JsonConverter(typeof(ArrayToPropertyConventer))]
        //public string[] target_point { get; set; }

        //[JsonConverter(typeof(ArrayToPropertyConventer))]
        //public string[] sending_method { get; set; }

        //[JsonConverter(typeof(ArrayToPropertyConventer))]
        //public string[] dropoff_point { get; set; }


        //[JsonConverter(typeof(ArrayToPropertyConventer))]
        //public string[] allegro_transaction_id { get; set; }

        //[JsonConverter(typeof(ArrayToPropertyConventer))]
        //public string[] allegro_user_id { get; set; }

        public List<string> target_point { get; set; }
        public List<string> sending_method { get; set; }
        public List<string> dropoff_point { get; set; }
        public List<string> allegro_transaction_id { get; set; }
        public List<string> allegro_user_id { get; set; }


    }
}
