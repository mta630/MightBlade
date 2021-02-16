using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MightBlade.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int DamageMod { get; set; }
        public int HealthMod { get; set; }
        public int ManaMod { get; set; }
        public int SellValue { get; set; }
        public int BuyValue { get; set; }

    }
}
