using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using YourGameOfTheYear.Data;
using YourGameOfTheYear.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
        public List<Game> GetRecommendedGames(int UserId)
        {
            List<Game> GameListForUser = GamesForUser(UserId);
            List<UserReview> userReviews = UsersReviews(UserId);
            
            return GameListForUser;
        }
        private List<UserReview> UsersReviews(int UserId)
        {
            return UserReviews.Where(x => x.UserId == UserId).ToList();
        }
        private List<Game> GamesForUser(int UserId)
        {
            List<UserReview> usersReviews = UsersReviews(UserId);
            List<Game> RecommendedGames = Games;
            foreach (UserReview UR in usersReviews)
            {
                RecommendedGames.Remove(RecommendedGames.FirstOrDefault(x => x.ID == UR.GameId));
            }
            return RecommendedGames;
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