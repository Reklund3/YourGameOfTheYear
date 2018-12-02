using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YourGameOfTheYear.Models
{
    public class GameReview
    {
        [Key]
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; } 
        public int UserReviewId { get; set; } 
        List<UserReview> UserReviews { get; set; }
        public int Stars { get; set; }
    }
}