using MVC.M3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC.M3.API
{
    public class GraphicDesignController : ApiController
    {
        // GET: api/GraphicDesign
        List<GraphicDesignProject> design = new List<GraphicDesignProject>();
        public GraphicDesignController()
        {
            design.Add(new GraphicDesignProject
            {
                NameOfProject = "ABC Type",
                Description = "Advanced Typogrpahy project: created in Swiss Style design",
                DesignType = "Poster Design",
                Thumbnail = "png"
            });

            design.Add(new GraphicDesignProject
            {
                NameOfProject = "Generation Adderall",
                Description = "Publication on 'Generation Adderall' article.",
                DesignType = "Publication Design",
                Thumbnail = "png"
            });

            design.Add(new GraphicDesignProject
            {
                NameOfProject = "Coffee",
                Description = "Illustrations on 'How to make coffee'",
                DesignType = "Illustration/Information Design",
                Thumbnail = "png"
            });
            design.Add(new GraphicDesignProject
            {
                NameOfProject = "Out Of Home Advertise",
                Description = "Nike run app branding and advertising brand book",
                DesignType = "Advertising Design",
                Thumbnail = "png"
            });



        }

        public List<GraphicDesignProject> Get()
        {

            return design;
        }

        // GET: api/GraphicDesign/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GraphicDesign
        public void Post([FromBody]string value)
        {
            
        }

        // PUT: api/GraphicDesign/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GraphicDesign/5
        public void Delete(int id)
        {
        }
    }
}
