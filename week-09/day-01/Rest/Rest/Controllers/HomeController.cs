using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }

            return Json(new { received = input, result = input * 2 });
        }

        [HttpGet("greeter")]
        public IActionResult Greeter([FromQuery]string name, [FromQuery]string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }

            return Json(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!" });
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            if (appendable == null)
            {
                return NotFound();
            }

            return Json(new { appended = appendable + "a" });
        }

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil([FromRoute] string what, [FromBody] SuchModel model)
        {

            if (model.Until == null)
            {
                return Json(new { error = "Please provide a number!" });
            }

            if (what.Equals(null))
            {
                return Json(new { error = "Stop nagging me!" });
            }

            if (what.Equals("sum"))
            {
                int sum = 0;

                for (int i = 0; i < model.Until + 1; i++)
                {
                    sum += i;
                }

                return Json(new { until = model.Until, result = sum });
            }

            if (what.Equals("factor"))
            {
                int factor = 1;

                for (int i = 0; i < model.Until + 1; i++)
                {
                    factor *= i;
                }

                return Json(new { until = model.Until, result = factor });
            }

            return Json("Yoo teso");
        }
    }
}