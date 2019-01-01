using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YourGameOfTheYear.Models
{
    public class UserInfo : IdentityUser<int>
    {
        [Key]
        public int ID { get; }
        public string NickName { get; set; }
        public int SubmittedReviewCount { get; set; }
        public int CommentsCount { get; set; }
        public DateTime AccountCreatedDate { get; set; }
    }
}
