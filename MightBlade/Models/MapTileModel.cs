using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MightBlade.Models
{
    public class MapTileModel
    {
        public string name {get; set;}
        public Dictionary<string, MapTileModel> Exits {get; set;}
        public string description { get; set; }
        public string color { get; set; }

    }
}
