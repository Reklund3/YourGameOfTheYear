﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YourGameOfTheYear.Data;

namespace YourGameOfTheYear.Migrations
{
    [DbContext(typeof(YourGameOfTheYearContext))]
    partial class YourGameOfTheYearContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YourGameOfTheYear.Models.Consoles", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsoleCompany");

                    b.Property<DateTime>("ConsoleReleaseDate");

                    b.Property<string>("ConsolesName");

                    b.HasKey("ID")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("Consoles");
                });

            modelBuilder.Entity("YourGameOfTheYear.Models.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GameDescription");

                    b.Property<double>("GameRating");

                    b.Property<DateTime>("GameReleaseDate");

                    b.Property<string>("GamgName");

                    b.Property<int?>("MessageID");

                    b.Property<string>("Studio");

                    b.HasKey("ID")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("MessageID");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("YourGameOfTheYear.Models.GameReview", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId");

                    b.Property<double>("Stars");

                    b.Property<int>("UserReviewId");

                    b.HasKey("ID")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("GameId");

                    b.ToTable("GameReview");
                });

            modelBuilder.Entity("YourGameOfTheYear.Models.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GameID");

                    b.Property<string>("GenreDescription");

                    b.Property<string>("GenreName");

                    b.HasKey("ID")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.HasIndex("GameID");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("YourGameOfTheYear.Models.Message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.HasKey("ID");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("YourGameOfTheYear.Models.UserReview", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ReviewDate");

                    b.Property<string>("UserDescription");

                    b.Property<double>("UserRating");

                    b.Property<string>("UserReviewTitle");

                    b.HasKey("ID")
                        .HasAnnotation("SqlServer:Clustered", true);

                    b.ToTable("UserReview");
                });

            modelBuilder.Entity("YourGameOfTheYear.Models.Game", b =>
                {
                    b.HasOne("YourGameOfTheYear.Models.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageID");
                });

            modelBuilder.Entity("YourGameOfTheYear.Models.GameReview", b =>
                {
                    b.HasOne("YourGameOfTheYear.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YourGameOfTheYear.Models.Genre", b =>
                {
                    b.HasOne("YourGameOfTheYear.Models.Game")
                        .WithMany("Genre")
                        .HasForeignKey("GameID");
                });
#pragma warning restore 612, 618
        }
    }
}