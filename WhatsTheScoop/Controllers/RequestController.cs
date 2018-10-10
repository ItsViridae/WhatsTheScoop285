using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WhatsTheScoop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        // POST api/request
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/request/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // POST  !!FROM QUERY!! api/request
        [HttpPost]
        public void Postq([FromQuery] string value)
        {
        }

        // PUT !!FROM QUERY!! api/request/5
        [HttpPut("{id}")]
        public void Putq(int id, [FromQuery] string value)
        {
        }



        // DELETE api/request  Deletes @ that ID
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }










        //GET Should be used for Database Data Retrieval
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "pass in url object here" };
        }

        //GET api/request/id        GetDatabyID
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "string at that id";
        }
    }
}