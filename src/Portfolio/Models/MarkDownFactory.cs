using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public abstract class MarkDownFactory<T> where T : MarkDownModel
    {
        protected string projectsDirectory;

        public MarkDownFactory(string webRootPath, string folder)
        {
            this.projectsDirectory = Path.Combine(webRootPath, folder);
        }

        public IEnumerable<T> All => Directory.GetFiles(projectsDirectory).Select(f => Create(f));
        public abstract T Create(string fileName);
    }

    public abstract class MarkDownModel
    {
        public MarkDownModel(string fileName)
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
