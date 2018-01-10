using BankOfSimba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    [Route("Simba")]
    public class AnimalController : Controller
    {
        public static AnimalViewModel AnimalViewModel = new AnimalViewModel();

        [HttpGet("")]
        public IActionResult Index()
        {
            return View(AnimalViewModel);
        }
    }
}
