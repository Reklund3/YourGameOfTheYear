using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YourGameOfTheYear.Models
{
    public class Game
    {
        [Key]
        public int ID { get; private set; }
        public string GamgName { get; set; }
        public string GameDescription { get; set; }
        public List<Genre> Genre { get; set; }
        public string Studio { get; set; }
        public double GameRating { get; set; }
        public List<Consoles> ConsoleList;
        public enum ESRBRating{ EVERYONE, EVERYONE10PLUS, TEEN, MATURE, ADULTS, RATINGPENDING }
    }
}