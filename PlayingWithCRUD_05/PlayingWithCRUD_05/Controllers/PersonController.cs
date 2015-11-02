using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlayingWithCRUD_05.Models;

namespace PlayingWithCRUD_05.Controllers
{
    public class PersonController : ApiController
    {
        // GET: api/Person
        public List<Person> Get()
        {
            return new List<Person>() 
            {
                new Person{Id = 101,Name = "Harun",Address = "DHK",Roll = 40},
                new Person{Id = 102,Name = "Harun1",Address = "DHK2",Roll = 401}, 
                new Person{Id = 103,Name = "Harun2",Address = "DHK3",Roll = 402}

            };
        }

        // GET: api/Person/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Person
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
