using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourGameOfTheYear.Models
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name ="Title")]
        public string GamgName { get; set; }
        [Display(Name = "Description")]
        public string GameDescription { get; set; }
        public List<Genre> Genre { get; set; }
        [Display(Name = "Game Studio")]
        public string Studio { get; set; }
        [Display(Name = "Rating")]
        public double GameRating { get; set; }
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime GameReleaseDate { get; set; }
        public List<UserReview> UserReviews { get; set; }
        public List<Consoles> ConsoleList;
        public enum ESRBRating{ EVERYONE, EVERYONE10PLUS, TEEN, MATURE, ADULTS, RATINGPENDING }
    }
}