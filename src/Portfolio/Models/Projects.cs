using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Portfolio.Models
{
    public class Projects
    {
        private string projectsDirectory;

        public Projects(string webRootPath)
        {
            this.projectsDirectory = Path.Combine(webRootPath, "Projects/");
        }

        public IEnumerable<Project> All => Directory.GetFiles(this.projectsDirectory).Select(f => new Project(f));
    }

    public class Project
    {
        public Project(string fileName)
        {
            this.FileName = fileName;
            this.Name = Path.GetFileNameWithoutExtension(fileName);
        }
        public int ID { get; set; }
        public string FileName { get; }
        public string Name { get; set; }
        public string RawContent => File.ReadAllText(this.FileName);
    }
}
