using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public JsonResult Greeting(int id, [FromQuery]string name)
        {
            var greeting = new Greeting(name);
            greeting.IncreaseCounter();

            return new JsonResult(new Greeting(name));
        }
    }
}