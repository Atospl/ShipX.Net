using Newtonsoft.Json;
using ShipX.Net.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipX.Net.Model
{
    [JsonConverter(typeof(StickerConventer))]
    public class Sticker
    {
        
        //public byte[] RawFileData { get; set; }

        ////[JsonConverter(typeof(StickerConventer))]
        //public string FileData { get; set; }
    }
}
