using System;
using System.Collections.Generic;
using YourGameOfTheYear.Models;

namespace YourGameOfTheYear.Services
{
    public interface IRepository
    {
        List<Game> Games { get; }
        List<UserReview> UserReviews { get; }
        void UpdateTrending();
    }
}