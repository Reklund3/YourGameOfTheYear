using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourGameOfTheYear.Models
{
    public class UserReview
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name = "Rating")]
        public int UserRating { get; set; }
        public static int[] Ratings = { 1, 2, 3, 4, 5 };
        public string UserReviewTitle { get; set; }
        public string UserDescription { get; set; }
        public DateTime ReviewDate { get; set; }
        public List<Message> Messages { get; set; }

        public int UserId { get; set; }
        public UserInfo UserInfo { get; set; }

        public string UserNickName { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}