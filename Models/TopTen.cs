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
            foreach (Game g in _context.Game)
            {
                if(g.GameRating != 0)
                {
                    if (TopTenGames[0] == null)
                    {
                        TopTenGames.Add(g);
                    }
                    else if (TopTenGames[0].GameRating < g.GameRating)
                    {
                        TopTenGames.Insert(0, g);
                    }
                    else
                    {
                        TopTenGames.Add(g);
                    }
                }
            }
            TopTenGames.Take(10);
            return TopTenGames;
        }
    }
}
