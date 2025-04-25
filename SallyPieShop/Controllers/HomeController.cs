using Microsoft.AspNetCore.Mvc;
using SallyPieShop.Data;

namespace SallyPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;
        public HomeController(IPieRepository ieRepository)
        {
            _pieRepository = ieRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_pieRepository.AllPies);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }

    }
}
