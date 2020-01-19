using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HackDavis2020.Models;
using HackDavis2020.Data;

namespace HackDavis2020.Controllers
{
    public class SupporterController : Controller
    {
        private readonly SiteContext _context;

        public SupporterController(SiteContext context)
        {
            _context = context;
        }


        public IActionResult Home()
        {

            var bluePrints = _context.BluePrints.Where(m => m.ID > 0);

            return View(bluePrints);
        }
    }
}
