using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model
{
    public class Error
    {
        public int status { get; set; }
        public string error { get; set; }
        public string message { get; set; }
        public Details details { get; set; }

    }
}
