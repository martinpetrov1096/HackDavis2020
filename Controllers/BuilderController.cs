using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackDavis2020.Models;
using HackDavis2020.Data;
using Microsoft.EntityFrameworkCore;

namespace HackDavis2020.Controllers
{

    


    public class BuilderController : Controller
    {

        private readonly SiteContext _context;

        public BuilderController(SiteContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Home()
        {

            UserBluePrint userBluePrint = new UserBluePrint();
            var bluePrint = await _context.BluePrints
                .FirstOrDefaultAsync(m => m.ID == LoggedInUser.User.UserID);

            userBluePrint.BluePrint = bluePrint;
            userBluePrint.User = LoggedInUser.User;

            return View(userBluePrint);
        }




    }
}
