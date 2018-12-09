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
        public string GamgName { get; set; }
        public string GameDescription { get; set; }
        public List<Genre> Genre { get; set; }
        public string Studio { get; set; }
        public double GameRating { get; set; }
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime GameReleaseDate { get; set; }
        public Message Message { get; set; }
        public List<Consoles> ConsoleList;
        public enum ESRBRating{ EVERYONE, EVERYONE10PLUS, TEEN, MATURE, ADULTS, RATINGPENDING }
    }
}