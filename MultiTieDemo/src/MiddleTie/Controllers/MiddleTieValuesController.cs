using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace MiddleTie.Controllers
{
    [Route("api/[controller]")]
    public class MiddleTieValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("GetData")]
        public string GetData()
        {
            var httpClient = new HttpClient();
#if DEBUG
            var content = httpClient.GetStringAsync("http://localhost:5000/api/backendvalues/GetBackData").Result;
#else
            var content = httpClient.GetStringAsync("http://backendservice/api/backendvalues/GetBackData").Result;
#endif
            return "Data from back is " + content;
        }
    }
}
