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
        public ProjectController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var projects = new Projects(_environment.WebRootPath);



            return View(projects.All);
        }
    }
}
