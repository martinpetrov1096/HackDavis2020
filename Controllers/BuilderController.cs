using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackDavis2020.Models;

namespace HackDavis2020.Controllers
{
    public class BuilderController : Controller
    {
        public IActionResult Home()
        {
            return View(LoggedInUser.LoggedInUsr);
        }

        public IActionResult Settings()
        {
            return View(LoggedInUser.BuilderSettings);
        }



    }
}
