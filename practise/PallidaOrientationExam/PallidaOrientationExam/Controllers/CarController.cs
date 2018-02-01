using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaOrientationExam.Controllers
{
    [Route("")]
    public class CarController : Controller
    {
        [HttpGet("search")]
        public IActionResult Search()
        {
            return Ok();
        }

        [HttpGet("search/{brand}")]
        public IActionResult Brand()
        {
            return Ok();
        }
    }
}
