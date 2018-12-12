using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourGameOfTheYear.Data;

namespace YourGameOfTheYear.Models
{
    public class TopTen
    {
        private YourGameOfTheYearContext _context;
        private List<Game> TopTenGames;
        public TopTen(YourGameOfTheYearContext context)
        {
            this._context = context;
            this.TopTenGames = GetTopTen();
        }
        private List<Game> GetTopTen()
        {
            //TopTenGames.
            return TopTenGames;
        }
    }
}
