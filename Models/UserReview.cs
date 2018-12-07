using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourGameOfTheYear.Models
{
    public class UserReview
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public double UserRating { get; set; }
        public string UserReviewTitle { get; set; }
        public string UserDescription { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}