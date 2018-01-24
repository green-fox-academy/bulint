using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrationTesting.Controllers
{
    [Route("guardian")]
    public class GuardianController : Controller
    {
        [HttpGet("groot")]
        public IActionResult IAmGroot(string message)
        {
            if (message == null)
            {
                return Json(new { error = "I am Error!" });
            }
            return Json(new { received = message, translated = "I am Groot!" });
        }
    }
}
