using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackDavis2020.Models;
using HackDavis2020.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HackDavis2020.Controllers
{

    public class BuilderController : Controller
    {

        private readonly SiteContext _context;

        public BuilderController(SiteContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description")] BluePrint bluePrint)
        {
            bluePrint.OwnerID = LoggedInUser.User.UserID;
            if (ModelState.IsValid)
            {
                _context.Add(bluePrint);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Home));
            }
            return View(bluePrint);
        }

        public  IActionResult Home()
        {
            UserBluePrints userBluePrint = new UserBluePrints();

            var bluePrints = _context.BluePrints.Where(m => m.OwnerID == LoggedInUser.User.UserID);
            userBluePrint.BluePrints = bluePrints;
            userBluePrint.User = LoggedInUser.User;

            return View(userBluePrint);
        }

        public IActionResult Suggested()
        {

            string[] userLangs = LoggedInUser.User.Languages.Split(' ');
            List<BluePrint> bluePrints = new List<BluePrint>();



            foreach (var lang in userLangs) {

                bluePrints.AddRange(_context.BluePrints.Where(m => m.Languages.Contains(lang)));


                
            }
            var noDupsList = new HashSet<BluePrint>(bluePrints).ToList();



            return View(noDupsList);
        }
        


    }
}
