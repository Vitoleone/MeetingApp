using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Meeting Page";
            return View();
        }
        [HttpGet]
        public IActionResult Apply()
        {
            ViewBag.Title = "Apply";
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo userInfo)
        {
            ViewBag.Title = "Apply";
            return View();
        }

        public IActionResult List()
        {
            ViewBag.Title = "User List";
            return View();
        }
    }
}