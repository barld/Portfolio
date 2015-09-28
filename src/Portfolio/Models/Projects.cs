using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Portfolio.Models
{
    public class Projects : MarkDownFactory<Project>
    {
        public Projects(string webRootPath) : base(webRootPath, "Projects/"){}
        public override Project Create(string fileName) => new Project(fileName);
    }

    public class Project : MarkDownModel
    {
        public Project(string fileName) : base(fileName){}
    }
}
