using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Enum
{
    /// <summary>
    /// Wybrana przez klienta usługa.
    /// </summary>
    public enum ServiceEnum
    {
        inpost_courier_standard = 2,


        inpost_locker_standard = 4,
        inpost_locker_allegro = 8,
        inpost_locker_pass_thru = 16
    }
}
