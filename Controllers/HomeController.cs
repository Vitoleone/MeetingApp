using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int UserCount = Repository.Users.Where(i=>i.WillAttend == true).Count();
            var meetingInfo = new MeetingInfo(){
                Id = 1,
                Location ="Istanbul, Unity Kongresi",
                Date = new DateTime(2024,12,1,15,15,0),
                NumberOfPeople = UserCount
            };
            return View(meetingInfo);
        }
    }
}