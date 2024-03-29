using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            ViewBag.Title = "Apply";
            return View();
        }
        [HttpPost]
        public IActionResult Apply(UserInfo userInfo)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Title = "Başvuru Durumu";
                Repository.CreateUser(userInfo);
                ViewBag.UserCount = Repository.Users.Where(i=>i.WillAttend == true).Count();
                return View("Thanks",userInfo);
            }
            else
            {
                return View(userInfo);
            }
           
        }

        public IActionResult List()
        {
            ViewBag.Title = "User List";
            return View(Repository.Users);
        }

        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }
    }
}