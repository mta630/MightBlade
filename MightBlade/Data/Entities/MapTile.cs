using System;
using System.Collections.Generic;

namespace MightBlade.Data.Entities
{
    public class MapTile
    {        
        public string name {get; set;}
        public Dictionary<string, MapTile> Exits {get; set;}
        public string description { get; set; }
        public string color { get; set; }
        public IEnumerable<Monster> Monsters { get; set; }
        
    }
}