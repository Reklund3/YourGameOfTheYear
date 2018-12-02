using System;
using Microsoft.EntityFrameworkCore;

namespace YourGameOfTheYear.Data
{
    public class YourGameOfTheYearContext : DbContext, IYourGameOfTheYearContext
    {
        public YourGameOfTheYearContext()
        {

        }
    }
}