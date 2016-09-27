using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Mvc.AttributeRouting.Demo.Controllers
{
    public class ValuesController : Controller
    {
        [HttpGet("api/random/getmore")]
        public IEnumerable<string> GetMoreStuff()
        {
            return new string[] { "value3", "value4" };
        }

        // GET api/values
        [HttpGet("api/myvalues")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("api/myvalues/{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
