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
            var leapYears = GetLeapYears(1900, 2000);

            while(true)
            {
                //var currentDate = $"{currentYear}-{currentMonth}-{currentDayOfMonth} = {currentWeekday}";
                //Console.WriteLine(currentDate);

                if (currentYear >= 1901 && currentDayOfMonth == 1 && currentWeekday == 7)
                {
                    firstSundaysCount++;
                }

                var monthLastDay = GetMonthLastDay(leapYears, currentYear, currentMonth);

                // calculate next day
                if (currentDayOfMonth == monthLastDay)
                {
                    // next month or year
                    if (currentMonth == 12)
                    {
                        currentMonth = 1;
                        currentYear++;
                    }
                    else
                    {
                        currentMonth++;
                    }

                    currentDayOfMonth = 1;
                }
                else
                {
                    currentDayOfMonth++;
                }

                if (currentWeekday == 7)
                {
                    currentWeekday = 1;
                }
                else
                {
                    currentWeekday++;
                }

                if (currentYear == 2000 && currentMonth == 12 && currentDayOfMonth == 31)
                {
                    break;
                }
            }

            Console.WriteLine(firstSundaysCount);
        }

        private int GetMonthLastDay(List<int> leapYears, int currentYear, int currentMonth)
        {
            var isLeapYear = leapYears.Contains(currentYear);
            return currentMonth switch
            {
                1 => 31,
                2 => isLeapYear ? 29 : 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new ArgumentException(),
            };
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
