using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HackDavis2020.Data;
using HackDavis2020.Models;

namespace HackDavis2020.Controllers
{
    public class BluePrintsController : Controller
    {
        private readonly SiteContext _context;

        public BluePrintsController(SiteContext context)
        {
            _context = context;
        }

        // GET: BluePrints
        public async Task<IActionResult> Index()
        {
            return View(await _context.BluePrints.ToListAsync());
        }

        // GET: BluePrints/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bluePrint = await _context.BluePrints
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bluePrint == null)
            {
                return NotFound();
            }

            return View(bluePrint);
        }

        // GET: BluePrints/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BluePrints/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description")] BluePrint bluePrint)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bluePrint);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bluePrint);
        }

        // GET: BluePrints/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bluePrint = await _context.BluePrints.FindAsync(id);
            if (bluePrint == null)
            {
                return NotFound();
            }
            return View(bluePrint);
        }

        // POST: BluePrints/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description")] BluePrint bluePrint)
        {
            if (id != bluePrint.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bluePrint);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BluePrintExists(bluePrint.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bluePrint);
        }

        // GET: BluePrints/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bluePrint = await _context.BluePrints
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bluePrint == null)
            {
                return NotFound();
            }

            return View(bluePrint);
        }

        // POST: BluePrints/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bluePrint = await _context.BluePrints.FindAsync(id);
            _context.BluePrints.Remove(bluePrint);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BluePrintExists(int id)
        {
            return _context.BluePrints.Any(e => e.ID == id);
        }
    }
}
