using Microsoft.AspNetCore.Mvc;

namespace MeetingApp
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Apply()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}