using System;
using System.ComponentModel.DataAnnotations;

namespace YourGameOfTheYear.Models
{
    public class Consoles
    {
        [Key]
        public int ID { get; private set; }
        public string ConsolesName { get; set; }
        public string ConsoleCompany { get; set; }
    }
}