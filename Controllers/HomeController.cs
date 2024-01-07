using Microsoft.AspNetCore.Mvc;

namespace MeetingApp
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}