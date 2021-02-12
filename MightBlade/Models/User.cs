using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MightBlade.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserClass { get; set; }
        public int Gold { get; set; }
        public string Stats { get; set; }
        public string Inventory { get; set; }

    }
}
