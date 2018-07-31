using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model
{
    public class Address
    {
        public string id { get; set; }
        public string street { get; set; }
        public string building_number { get; set; }
        public string city { get; set; }
        public string post_code { get; set; }
        public string country_code { get; set; }
    }
}
