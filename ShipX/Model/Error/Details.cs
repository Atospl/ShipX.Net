using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model.Error
{
    public class Details
    {
        public string[] offer_id { get; set; }
        public string[] parcels { get; set; }

        public List<ShipX.Net.Model.Error.Receiver> receiver { get; set; }
        public List<ShipX.Net.Model.Error.AdditionalServices> additional_services { get; set; }
        public List<ShipX.Net.Model.Error.CustomAttributes> custom_attributes { get; set; }
    }
}



