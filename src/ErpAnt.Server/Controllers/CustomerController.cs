using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ErpAnt.Server.Controllers
{
    public class CustomerController : ControllerBase

    {      
       // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            
            return new string[] { "value1", "value2" };
        }
        
    }
}