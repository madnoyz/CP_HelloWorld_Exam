using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldApi.Controllers
{
    public class HelloController : ApiController
    {
        // GET: api/hello
        [HttpGet]
        public string Value()
        {
            return "Hello World";
        }

        // POST: api/hello
        [HttpPost]
        public void SaveNewValue([FromBody]string value)
        {
  
        }

        // PUT: api/hello/1
        [HttpPut]
        public void UpdateValue(int id, [FromBody]string value)
        {

        }

        // DELETE: api/hello/1
        [HttpDelete]
        public void RemoveValue(int id)
        {

        }


    }
}
