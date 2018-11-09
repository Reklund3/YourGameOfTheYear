using System;
using System.ComponentModel.DataAnnotations;

namespace YourGameOfTheYear.Models
{
    public class Genre
    {
        [Key]
        public int ID { get; set; }
        public string GenreName { get; set; }
        public string GenreDescription { get; set; }
    }
}