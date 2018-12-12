using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourGameOfTheYear.Models
{
    public class GameReview
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; } 
        public int UserReviewId { get; set; } 
        List<UserReview> UserReviews { get; set; }
        public double Stars { get; set; }
    }
}