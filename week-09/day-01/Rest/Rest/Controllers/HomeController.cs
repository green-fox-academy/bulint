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
        public IActionResult Doubling(int input)
        {
            if (input == 0)
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

            else if (what.Equals("sum"))
            {
                int sum = 0;

                for (int i = 0; i < model.Until + 1; i++)
                {
                    sum += i;
                }

                return Json(new { until = model.Until, result = sum });
            }
            else if (what.Equals("factor"))
            {
                int factor = 1;

                for (int i = 0; i < model.Until + 1; i++)
                {
                    factor *= i;
                }

                return Json(new { until = model.Until, result = factor });
            }
            else
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
        }

        [HttpPost("arrays")]
        public IActionResult Arrays([FromBody] SuchModel model)
        {

            if (model.Numbers == null)
            {
                return Json(new { error = "Please provide the numbers!" });
            }

            if (model.What.Equals("sum"))
            {
                int sum = 0;

                foreach (var number in model.Numbers)
                {
                    sum += number;
                }

                return Json(new { result = sum });
            }
            else if (model.What.Equals("multiply"))
            {
                int multiplied = 1;

                foreach (var number in model.Numbers)
                {
                    multiplied *= number;
                }

                return Json(new { result = multiplied });
            }
            else if (model.What.Equals("double"))
            {
                int[] doubled = model.Numbers;

                for (int i = 0; i < model.Numbers.Length; i++)
                {
                    doubled[i] = model.Numbers[i] * 2;
                }

                return Json(new { result = doubled });
            }
            else
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
        }
    }
}