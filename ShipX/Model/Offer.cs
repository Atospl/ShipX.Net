using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model
{
    public class Offer
    {
        public string id { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public string rate { get; set; }
        public string expires_at { get; set; }
        public Service service { get; set; }
        public Carrier carrier { get; set; }
        //public AdditionalServices additional_services { get; set; }
    }
}
