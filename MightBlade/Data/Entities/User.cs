using System;
using System.Collections.Generic;

namespace MightBlade.Data.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email {get; set;}
        public string UserName { get; set; }
        public string UserClass { get; set; }
        public int Level {get; set;}
        public int Gold { get; set; }
        public string Stats { get; set; }
        public string Inventory { get; set; }
        public MapTile CurrentLocation {get; set;}

    }
}