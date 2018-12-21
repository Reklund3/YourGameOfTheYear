using System;
using System.Linq;
using YourGameOfTheYear.Models;

namespace YourGameOfTheYear.Data
{
    public interface IYourGameOfTheYearContext
    {
        IQueryable<Consoles> Consoles { get; }
        IQueryable<Game> Games { get; }
        IQueryable<Genre> Genres { get; }
        IQueryable<UserReview> UserReviews { get; }
    }
}