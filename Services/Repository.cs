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
        public Repository(YourGameOfTheYearContext context)
        {
            this._context = context;
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