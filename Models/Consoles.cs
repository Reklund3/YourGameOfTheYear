using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourGameOfTheYear.Models
{
    public class Consoles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Display(Name = "Console")]
        public string ConsolesName { get; set; }
        [Display(Name = "Manufacture")]
        public string ConsoleCompany { get; set; }
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString ="{0:d}")]
        public DateTime ConsoleReleaseDate { get; set; }
    }
}