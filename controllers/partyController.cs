using Day1MVC.models;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Day1MVC.controllers
{
    public class partyController : Controller
    {
        public IActionResult allfriend()
        {
            var p = attendmember.Member.Where(x => x.willattend == "yes").ToList();
            return View("home", p);
        }


        public IActionResult addfriend()
        {
            return View("form");
        }
        public IActionResult adddata(member members)
        {
            attendmember.addmembers(members);
            List<member> p = attendmember.Member.Where(x => x.willattend == "yes").ToList();
            if (p != null)
            {
                return View("welcome");
            }
            else
            {
                return Content("see you later");
            }

        }
        public IActionResult showfriend()
        {
            List<member> p = attendmember.Member.Where(x => x.willattend == "yes").ToList();
            return View("memberscoming", p);
        }
    }
}
