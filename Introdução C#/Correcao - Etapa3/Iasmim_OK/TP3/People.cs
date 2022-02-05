using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class People
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public int CalculateNextBirthdayDate()
        {
            DateTime currentDate = DateTime.Today;
            DateTime nextDate = BirthDate.AddYears(currentDate.Year - BirthDate.Year);

            if (nextDate < currentDate)
                nextDate = nextDate.AddYears(1);

            int numDays = (nextDate - currentDate).Days;

            return numDays;
        }
    }
}
