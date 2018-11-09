using System;
using System.ComponentModel.DataAnnotations;

namespace YourGameOfTheYear.Models
{
    public class UserReview
    {
        [Key]
        public int ID { get; set; }
        public double UserRating { get; set; }
        public string UserReviewTitle { get; set; }
        public string UserDescription { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}