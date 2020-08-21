using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.M3.Models
{
    interface IProject
    {
        void createProject(string designType, DateTime startDate);
    }
}
