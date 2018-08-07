using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model.Error
{
    public class Error
    {
        public int status { get; set; }
        public string error { get; set; }
        public string message { get; set; }
        public ShipX.Net.Model.Error.Details details { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }
        
        public string ToJsonIndented()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
