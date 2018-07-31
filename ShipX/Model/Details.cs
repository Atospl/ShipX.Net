using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model
{
    public class Details
    {
        public string[] offer_id { get; set; }
        public string[] parcels { get; set; }
        public string[] receiver { get; set; }

        public AdditionalServices[] additional_services { get; set; }
        public CustomAttributes[] custom_attributes { get; set; }
        
    }
}



