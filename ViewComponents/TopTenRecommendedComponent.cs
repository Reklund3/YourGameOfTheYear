using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourGameOfTheYear.Data;

namespace YourGameOfTheYear.ViewComponents
{
    public class TopTenRecommendedViewComponent : ViewComponent
    {
        private readonly YourGameOfTheYearContext _context;
        public TopTenRecommendedViewComponent(YourGameOfTheYearContext context)
        {
            this._context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Games.OrderByDescending(x => x.GameRating).Take(10));
        }
    }
}
