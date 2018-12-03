using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YourGameOfTheYear.Models
{
    public class UserInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string NickName { get; set; }
        public int UserFK { get; set; }
        public int SubmittedReviewCount { get; set; }
        public int Comments { get; set; }
    }
}
