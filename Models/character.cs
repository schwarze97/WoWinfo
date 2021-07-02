using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WoWinfo.Models
{
    public class character : ApiController
    {
        public string name { get; set; }
        public int level { get; set; }
        public int id { get; set; }


        public character()
        {

        }

        public character(int ID, string Name, int Level)
        {
            this.id = ID;
            this.name = Name;
            this.level = Level;
        }


        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}