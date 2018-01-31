using Microsoft.AspNetCore.Mvc;

namespace OrientationRetakeExam.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("warehouse")]
        public IActionResult Warehouse()
        {
            return Ok();
        }

        [HttpPost("warehouse/summary")]
        public IActionResult WarehouseSummary()
        {
            return Ok();
        }

        [HttpGet("warehouse/query")]
        public IActionResult WarehouseQuery()
        {
            return Ok();
        }
    }
}
