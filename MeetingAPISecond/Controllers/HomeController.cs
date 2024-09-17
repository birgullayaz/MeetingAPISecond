using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;
using System.Xml.Serialization;

namespace MeetingApp.Controllers
{ 
    public class HomeController : Controller
    {
    public IActionResult Index()
        {
            int UserCount = Repository.Users.Where(i => i.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul,Abd Kongre Merkezi",
                Date = new DateTime(2024,01,20,20,0,0),
                NumberOfPeople = UserCount,
            };
            int saat = DateTime.Now.Hour;
            ViewBag.selamlama = saat > 12 ? "iyi günler" : "Günaydın";
            return View(meetingInfo);

        }


    }
}





