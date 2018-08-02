using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model
{
    public class Parcel
    {
        public string id { get; set; }
        public string template { get; set; }
        public string tracking_number { get; set; }
        public bool is_non_standard { get; set; }
        public Dimensions dimensions { get; set; }
        public Weight weight { get; set; }
    }
}
