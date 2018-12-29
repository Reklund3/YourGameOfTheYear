using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YourGameOfTheYear.Data;
using YourGameOfTheYear.Models;

namespace YourGameOfTheYear.Services
{
    public class Repository : IRepository
    {
        private YourGameOfTheYearContext _context;
        public List<UserReview> UserReviews => _context.UserReviews.ToList();
        public List<Game> Games => _context.Games.ToList();
        public Repository(YourGameOfTheYearContext context)
        {
            this._context = context;
        }
        public void UpdateTrending()
        {
            foreach (Game game in Games)
            {
                if (UserReviews.Where(x => x.GameId == game.ID).Count() == 0)
                {
                    game.UserActivity = 0;
                }
                else
                {
                    game.UserReviews = UserReviews.Where(x => x.GameId == game.ID).ToList();
                    game.UserActivity = game.UserReviews.Where(x => x.ReviewDate > DateTime.Now.AddDays(-1)).Count();
                }
                Console.WriteLine(game.UserActivity);

            }
        }
        public void Add(Game game)
        {

        }

        public void Add(Genre genre)
        {
            
        }

        public void Add(Consoles consoles)
        {
            
        }

        public void Add(UserReview userReview)
        {
            
        }
    }
}