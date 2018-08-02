using Newtonsoft.Json;
using RestSharp.Serializers;
using ShipX.Net.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model
{
    public class CustomAttributes
    {
        [JsonConverter(typeof(ArrayToPropertyConventer))]
        public string[] target_point { get; set; }

        /// <summary>
        /// Lista sposobów nadania
        /// SendingMethodEnum
        /// </summary>

        [JsonConverter(typeof(ArrayToPropertyConventer))]
        public string[] sending_method { get; set; }


        [JsonConverter(typeof(ArrayToPropertyConventer))]
        public string[] dropoff_point { get; set; }

        
    }
}
