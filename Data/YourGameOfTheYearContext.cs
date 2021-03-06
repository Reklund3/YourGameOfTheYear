using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using YourGameOfTheYear.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace YourGameOfTheYear.Data
{
    public class YourGameOfTheYearContext : IdentityDbContext<UserInfo, IdentityRole<int>, int>, IYourGameOfTheYearContext
    {
        

        public YourGameOfTheYearContext(DbContextOptions<YourGameOfTheYearContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   //////////////////////////
            base.OnModelCreating(modelBuilder);
            // Consoles
            modelBuilder.Entity<Consoles>().HasKey(x => x.ID).ForSqlServerIsClustered();
            
            // Game
            modelBuilder.Entity<Game>().HasKey(x => x.ID).ForSqlServerIsClustered();
            modelBuilder.Entity<Game>().HasOne(x => x.Genre).WithMany(x => x.Games).HasForeignKey(x => x.GenreId);
            
            // Genre
            modelBuilder.Entity<Genre>().HasKey(x => x.ID).ForSqlServerIsClustered();
            //modelBuilder.Entity<Genre>().HasOne(x => x.GameId).WithMany(x =>)
            // UserReview
            modelBuilder.Entity<UserReview>().HasKey(x => x.ID).ForSqlServerIsClustered();
            modelBuilder.Entity<UserReview>().HasOne(x => x.Game).WithMany(x => x.UserReviews).HasForeignKey(x => x.GameId);
            //modelBuilder.Entity<UserReview>().HasOne(x => x.UserInfo).WithOne(x => x.Id).HasForeignKey(x => x.UserId);
            // UserInfo
            modelBuilder.Entity<UserInfo>().Property(x => x.AccountCreatedDate)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAdd();
        }
        
        public DbSet<Consoles> Consoles { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<UserReview> UserReviews { get; set; }
        public DbSet<UserInfo> UsersInfo { get; set; }
        IQueryable<Consoles> IYourGameOfTheYearContext.Consoles { get => Consoles.AsNoTracking(); }
        IQueryable<Game> IYourGameOfTheYearContext.Games { get => Games.AsNoTracking(); }
        IQueryable<Genre> IYourGameOfTheYearContext.Genres { get => Genre.AsNoTracking(); }
        IQueryable<UserReview> IYourGameOfTheYearContext.UserReviews { get => UserReviews.AsNoTracking(); }
        IQueryable<UserInfo> IYourGameOfTheYearContext.UsersInfo { get => UsersInfo.AsNoTracking(); }

    }
}