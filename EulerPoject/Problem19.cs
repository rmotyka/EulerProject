using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    public class Problem19
    {
        public void Calculate()
        {
            var currentYear = 1900;
            var currentMonth = 1; // 1 .. 12
            var currentDayOfMonth = 1;
            var currentWeekday = 1; // 1 .. 7

            var firstSundaysCount = 0;
            var leapYear = GetLeapYears(1900, 2000);

            while(true)
            {
                var newDayOfMonth = currentDayOfMonth + 1;
                

            }

            Console.WriteLine(firstSundaysCount);
        }

        private List<int> GetLeapYears(int startingYear, int endingYear)
        {
            var leapYears = new List<int>();
            for (int year = startingYear; year <= endingYear; year++)
            {
                if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                {
                    leapYears.Add(year);
                }
            }

            return leapYears;
        }
    }
}
