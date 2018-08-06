using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model.Error
{
    public class Receiver
    {
        public List<string> first_name { get; set; }
        public List<string> last_name { get; set; }
        public List<string> name { get; set; }
        public List<string> email { get; set; }
        public List<string> phone { get; set; }
        
        //public Address address { get; set; }
    }
}
