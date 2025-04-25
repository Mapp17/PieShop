using Microsoft.AspNetCore.Mvc;
using SallyPieShop.Data;
using SallyPieShop.Models;

namespace SallyPieShop.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackRepository.AddFeedback(feedback);
                _feedbackRepository.SaveChanges();
                return RedirectToAction("FeedbackComplete");
            }
            else
            {
                return View(feedback);
            }
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}
