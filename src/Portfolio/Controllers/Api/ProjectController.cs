using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Portfolio.Models;
using Microsoft.AspNet.Hosting;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.Controllers.Api
{
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        private readonly IHostingEnvironment _environment;
        public ProjectController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Project> Get()
        {
            var projects = new Projects(_environment.WebRootPath);

            return projects.All;
        }
    }
}
