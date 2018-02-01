using Microsoft.AspNetCore.Mvc;
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
        public IActionResult WarehouseSummary(long id, int amount)
        {
            return View(clothesService.SelectedItem(id, amount));
        }

        [HttpGet("warehouse/query")]
        public IActionResult WarehouseQuery()
        {
            return Ok();
        }
    }
}
