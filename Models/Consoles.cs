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
        public string ConsolesName { get; set; }
        public string ConsoleCompany { get; set; }
        [DisplayFormat(DataFormatString ="{0:d}")]
        public DateTime ConsoleReleaseDate { get; set; }
    }
}