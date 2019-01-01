using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using YourGameOfTheYear.Data;
using YourGameOfTheYear.Models;
using YourGameOfTheYear.Services;

namespace YourGameOfTheYear.ViewComponents
{
    public class TopTenRecommendedViewComponent : ViewComponent
    {
        private readonly IRepository _repository;
        private readonly YourGameOfTheYearContext _context;
        public TopTenRecommendedViewComponent(IRepository repository, YourGameOfTheYearContext context)
        {
            this._context = context;
            this._repository = repository;
        }
        public IViewComponentResult Invoke()
        {
            List<Game> RecommendedGames = _repository.GetRecommendedGames(_context.Users.FirstOrDefault(x => x.Email == User.Identity.Name).Id);
            return View(RecommendedGames.OrderByDescending(x => x.GameRating).Take(10));
        }
    }
}
