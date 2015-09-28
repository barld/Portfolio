using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Hosting;
using Portfolio.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IHostingEnvironment _environment;
        private readonly Projects _projects;
        public ProjectController(IHostingEnvironment environment)
        {
            _environment = environment;
            _projects = new Projects(_environment.WebRootPath);
            
        }

        // GET: /<controller>/
        public IActionResult Index() => View(_projects.All);

        [Route("[controller]/{projectName}")]
        public IActionResult Get(string projectName)
        {
            if(_projects.All.Count(p => p.Name == projectName) == 1)
            {
                return View("ProjectPage", _projects.All.First(p => p.Name == projectName));
            }
            return Json(projectName);
        }
    }
}
