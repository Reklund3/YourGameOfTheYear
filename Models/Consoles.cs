using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourGameOfTheYear.Models
{
    public class Consoles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; private set; }
        public string ConsolesName { get; set; }
        public string ConsoleCompany { get; set; }
    }
}