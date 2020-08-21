using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.M3.Models
{
    [Serializable]
    public class GraphicDesignProject 
    {
        public string NameOfProject;
        public string Description;
        public string DesignType;
        public string FrontEnd;
       
        public string Thumbnail;
 
    }

    public class Design : GraphicDesignProject, IProject
    {
        public override string ToString()
        {
            return NameOfProject.ToString();
        }

        void IProject.createProject(string designType, DateTime startDate)
        {
            throw new NotImplementedException();
        }
    }
         

}