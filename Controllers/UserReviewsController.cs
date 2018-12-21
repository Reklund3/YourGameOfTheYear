using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using YourGameOfTheYear.Data;
using YourGameOfTheYear.Models;

namespace YourGameOfTheYear.Controllers
{
    public class UserReviewsController : Controller
    {
        private readonly YourGameOfTheYearContext _context;

        public UserReviewsController(YourGameOfTheYearContext context)
        {
            _context = context;
        }

        // GET: UserReviews
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserReviews.ToListAsync());
        }

        // GET: UserReviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userReview = await _context.UserReviews
                .FirstOrDefaultAsync(m => m.ID == id);
            if (userReview == null)
            {
                return NotFound();
            }

            return View(userReview);
        }

        // GET: UserReviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserReviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserRating,UserReviewTitle,UserDescription,ReviewDate,GameId")] UserReview userReview)
        {
            if (ModelState.IsValid)
            {
                userReview.ReviewDate = DateTime.UtcNow;
                _context.Add(userReview);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details), nameof(GamesController).Replace("Controller",""), new { ID = userReview.GameId } );
            }
            return View(userReview);
        }

        // GET: UserReviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userReview = await _context.UserReviews.FindAsync(id);
            if (userReview == null)
            {
                return NotFound();
            }
            return View(userReview);
        }

        // POST: UserReviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserRating,UserReviewTitle,UserDescription,ReviewDate,GameId")] UserReview userReview)
        {
            if (id != userReview.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userReview);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserReviewExists(userReview.ID))
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
            return View(userReview);
        }

        // GET: UserReviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userReview = await _context.UserReviews
                .FirstOrDefaultAsync(m => m.ID == id);
            if (userReview == null)
            {
                return NotFound();
            }

            return View(userReview);
        }

        // POST: UserReviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userReview = await _context.UserReviews.FindAsync(id);
            _context.UserReviews.Remove(userReview);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserReviewExists(int id)
        {
            return _context.UserReviews.Any(e => e.ID == id);
        }
    }
}
