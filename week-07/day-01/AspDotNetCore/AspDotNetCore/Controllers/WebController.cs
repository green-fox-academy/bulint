using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCore.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting([FromQuery] string name)
        {
            var greeting = new Greeting(name)
            {
                Content = name
            };

            greeting.Id = greeting.IncreaseCounter2();

            return View(greeting);
        }
    }
}