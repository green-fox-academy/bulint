using Microsoft.AspNetCore.Mvc;
using OrientationRetakeExam.Reporitories;
using OrientationRetakeExam.Services;

namespace OrientationRetakeExam.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private ClothesService clothesService;

        public HomeController(ClothesService clothesService)
        {
            this.clothesService = clothesService;
        }

        [HttpGet("warehouse")]
        public IActionResult Warehouse()
        {
            return View(clothesService.GetViewModel());
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
