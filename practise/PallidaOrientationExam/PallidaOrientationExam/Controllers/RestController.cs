using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaOrientationExam.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        [HttpGet("search/{brand}")]
        public IActionResult SearchBrand()
        {
            return Ok();
        }
    }
}
