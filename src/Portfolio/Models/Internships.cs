using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Internships : MarkDownFactory<Internship>
    {
        public Internships(string webRootPath) : base(webRootPath, "Internships/") { }
        public override Internship Create(string fileName) => new Internship(fileName);
    }

    public class Internship : MarkDownModel
    {
        public Internship(string fileName) : base(fileName){ }
    }
}
