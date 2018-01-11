using GreetSomeone.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeone.Controllers
{
    [Route("")]
    public class WebController : Controller
    {
        private Greet greet;

        public WebController(Greet greet)
        {
            this.greet = greet;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(greet);
        }

        [HttpPost("redirect")]
        public IActionResult PostMethod(string name)
        {
            greet.Name = name;
            return RedirectToAction("Greet");
        }

        [HttpGet("greet")]
        public IActionResult Greet()
        {
            return View(greet);
        }
    }
}
