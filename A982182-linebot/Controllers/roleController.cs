using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace A982182_linebot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class roleController : ControllerBase
    {
        // GET: api/role
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/role/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/role
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/role/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/role/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
