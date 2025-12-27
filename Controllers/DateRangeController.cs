using AspNetMvcValidationPatterns.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMvcValidationPatterns.Controllers
{
    public class DateRangeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(DateRangeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // In a real application, you would save the data or perform further processing.
            ViewBag.Message = "Date range is valid!";
            return View(model);
        }
    }
}