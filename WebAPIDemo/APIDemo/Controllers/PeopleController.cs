using APIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIDemo.Controllers
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public class PeopleController : ApiController
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {

        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

       

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {

        }

        [Route("api/People/GetFirstNames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();
            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
    }
}
