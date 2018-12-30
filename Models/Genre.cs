using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourGameOfTheYear.Models
{
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name = "Genre")]
        public string GenreName { get; set; }
        [Display(Name = "Genre Description")]
        public string GenreDescription { get; set; }
        public List<Game> Games { get; set; }
    }
}