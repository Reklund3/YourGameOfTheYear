using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YourGameOfTheYear.Data;
using YourGameOfTheYear.Models;

namespace YourGameOfTheYear.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ConsolesController : Controller
    {
        private readonly YourGameOfTheYearContext _context;

        public ConsolesController(YourGameOfTheYearContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        // GET: Consoles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Consoles.ToListAsync());
        }
        [AllowAnonymous]
        // GET: Consoles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consoles = await _context.Consoles
                .FirstOrDefaultAsync(m => m.ID == id);
            if (consoles == null)
            {
                return NotFound();
            }

            return View(consoles);
        }

        // GET: Consoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Consoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ConsolesName,ConsoleCompany,ConsoleReleaseDate")] Consoles consoles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consoles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consoles);
        }

        // GET: Consoles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consoles = await _context.Consoles.FindAsync(id);
            if (consoles == null)
            {
                return NotFound();
            }
            return View(consoles);
        }

        // POST: Consoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ConsolesName,ConsoleCompany,ConsoleReleaseDate")] Consoles consoles)
        {
            if (id != consoles.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consoles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsolesExists(consoles.ID))
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
            return View(consoles);
        }

        // GET: Consoles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consoles = await _context.Consoles
                .FirstOrDefaultAsync(m => m.ID == id);
            if (consoles == null)
            {
                return NotFound();
            }

            return View(consoles);
        }

        // POST: Consoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consoles = await _context.Consoles.FindAsync(id);
            _context.Consoles.Remove(consoles);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsolesExists(int id)
        {
            return _context.Consoles.Any(e => e.ID == id);
        }
    }
}
