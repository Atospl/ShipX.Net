using ShipX.Net.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Test
{
    public static class Helper
    {
        public static ShipXClient GetShipXClient()
        {
            Ini iniParser = new Ini(@"c:\shipx.ini");
            string orgId = iniParser.GetValue("ORG");
            string token = iniParser.GetValue("TOKEN");
            return new ShipXClient(orgId, token);
        }
    }
}
