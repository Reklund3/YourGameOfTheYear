using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using YourGameOfTheYear.Models;

namespace YourGameOfTheYear.Data
{
    public class YourGameOfTheYearContext : DbContext, IYourGameOfTheYearContext
    {
        

        public YourGameOfTheYearContext(DbContextOptions<YourGameOfTheYearContext> options) : base(options)
        {

        }
        public YourGameOfTheYearContext()
        {
            
        }
        public DbSet<Consoles> Consoles { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Genre> Genre { get; set; }
        IQueryable<Consoles> IYourGameOfTheYearContext.Consoles { get => Consoles.AsNoTracking(); }

        IQueryable<Game> IYourGameOfTheYearContext.Games { get => Game.AsNoTracking(); }

        IQueryable<Genre> IYourGameOfTheYearContext.Genres { get => Genre.AsNoTracking(); }
    }
}