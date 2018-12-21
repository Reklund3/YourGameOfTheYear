using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourGameOfTheYear.Data;
using YourGameOfTheYear.Models;

namespace YourGameOfTheYear.ViewComponents
{
    public class TopTrendingViewComponent : ViewComponent
    {
        private readonly YourGameOfTheYearContext _context;
        public TopTrendingViewComponent(YourGameOfTheYearContext context)
        {
            this._context = context;
        }
        public IViewComponentResult Invoke()
        {
            return View(_context.Games.OrderByDescending(x => x.GameRating).Take(10).Select(game => new TopTen { GameName = game.GamgName, Rating = game.GameRating }));
        }
    }
}