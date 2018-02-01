using Microsoft.AspNetCore.Mvc;
using PallidaOrientationExam.Services;

namespace PallidaOrientationExam.Controllers
{
    [Route("")]
    public class CarController : Controller
    {
        private CarService carService;

        public CarController(CarService carService)
        {
            this.carService = carService;
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery]string q, string police, string diplomat)
        {
            return View(carService.GetFilteredCars(q, police, diplomat));
        }

        [HttpGet("search/{brand}")]
        public IActionResult Brand([FromRoute]string brand)
        {
            return View("Search", carService.GetCarsByBrand(brand));
        }
    }
}
