using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MightBlade.DBContexts;
using MightBlade.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MightBlade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private MyDBContext myDbContext;

        public ItemController(MyDBContext context)
        {
            myDbContext = context;
        }

        [HttpGet]
        public IList<Item> Get()
        {
            return (this.myDbContext.Items.ToList());
        }
    }
}
