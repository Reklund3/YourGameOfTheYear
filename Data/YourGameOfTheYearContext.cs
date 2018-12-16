using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using YourGameOfTheYear.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace YourGameOfTheYear.Data
{
    public class YourGameOfTheYearContext : DbContext ,IYourGameOfTheYearContext
    {
        

        public YourGameOfTheYearContext(DbContextOptions<YourGameOfTheYearContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   //////////////////////////
            //base.OnModelCreating(modelBuilder);
            // Consoles
            modelBuilder.Entity<Consoles>().HasKey(x => x.ID).ForSqlServerIsClustered();
            
            // Game
            modelBuilder.Entity<Game>().HasKey(x => x.ID).ForSqlServerIsClustered();

            // GameReview
            modelBuilder.Entity<GameReview>().HasKey(x => x.ID).ForSqlServerIsClustered();

            // Genre
            modelBuilder.Entity<Genre>().HasKey(x => x.ID).ForSqlServerIsClustered();

            // UserReview
            modelBuilder.Entity<UserReview>().HasKey(x => x.ID).ForSqlServerIsClustered();
        }

        public DbSet<Consoles> Consoles { get; set; }
        public DbSet<Game> Game { get; set; }
        public DbSet<Genre> Genre { get; set; }
        IQueryable<Consoles> IYourGameOfTheYearContext.Consoles { get => Consoles.AsNoTracking(); }

        IQueryable<Game> IYourGameOfTheYearContext.Games { get => Game.AsNoTracking(); }

        IQueryable<Genre> IYourGameOfTheYearContext.Genres { get => Genre.AsNoTracking(); }
    }
}