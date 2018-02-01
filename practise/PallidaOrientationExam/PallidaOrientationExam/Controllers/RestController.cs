using Microsoft.AspNetCore.Mvc;
using PallidaOrientationExam.Services;

namespace PallidaOrientationExam.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        private CarService carService;

        public RestController(CarService carService)
        {
            this.carService = carService;
        }

        [HttpGet("search/{brand}")]
        public IActionResult SearchBrand([FromRoute]string brand)
        {
            return Json(new { result = "ok", data = carService.GetCarsByBrand(brand) });
        }
    }
}
