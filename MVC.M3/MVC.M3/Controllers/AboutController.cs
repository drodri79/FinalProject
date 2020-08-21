using MVC.M3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC.M3.Controllers
{
    public class AboutController : ApiController
    {
        // GET: api/About
        
        List<About> aboutList = new List<About>();
        public AboutController()
        {
            aboutList.Add(new About { FirstName = "David", LastName = "Rodriguez", Undergrad = "DePaul University", Grad = "Dominican University" });
        }
        public List<About> Get()
        {

            return aboutList;
        }
        

        // GET: api/About/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/About
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/About/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/About/5
        public void Delete(int id)
        {
        }
    }
}
