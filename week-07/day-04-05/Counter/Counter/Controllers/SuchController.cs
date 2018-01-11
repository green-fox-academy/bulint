using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Counter.Controllers
{
    [Route("")]
    public class SuchController : Controller
    {
        private Counter counter;

        public SuchController(Counter counter)
        {
            this.counter = counter;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(counter);
        }

        [HttpPost("increase")]
        public IActionResult IncreaseCounter()
        {
            counter.Number++;
            return RedirectToAction("Index");
        }
    }
}
