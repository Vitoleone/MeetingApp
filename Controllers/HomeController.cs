using Microsoft.AspNetCore.Mvc;

namespace MeetingApp
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Homepage";
            return View();
        }
    }
}