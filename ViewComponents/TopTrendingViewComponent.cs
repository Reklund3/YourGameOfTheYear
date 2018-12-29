using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourGameOfTheYear.Data;
using YourGameOfTheYear.Models;
using YourGameOfTheYear.Services;

namespace YourGameOfTheYear.ViewComponents
{
    public class TopTrendingViewComponent : ViewComponent
    {
        private readonly IRepository _repository;
        public TopTrendingViewComponent(IRepository repository)
        {
            this._repository = repository;
        }
        public IViewComponentResult Invoke()
        {
            _repository.UpdateTrending();
            return View(_repository.Games.OrderByDescending(x => x.UserActivity).Take(10));
        }
    }
}