using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourGameOfTheYear.Data;
using YourGameOfTheYear.Models;

namespace YourGameOfTheYear.ViewComponents
{
    public class ReviewViewComponent : ViewComponent
    {
        private readonly YourGameOfTheYearContext _context;
        public ReviewViewComponent(YourGameOfTheYearContext context)
        {
            this._context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.UserReviews);
        }
    }
}
