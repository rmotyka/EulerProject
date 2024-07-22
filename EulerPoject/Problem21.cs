using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    public class Problem21
    {
        public void Calculate() 
        {
            var amicableSum = 0;
            for (int i = 1; i < 10_000; i++)
            {
                var sumOfDivisors = GetDivisorsSum(i);
                var amicableNumber = GetDivisorsSum(sumOfDivisors);

                if (amicableNumber == i && i < sumOfDivisors)
                {
                    Console.WriteLine($"Amicable number: {i}");
                    amicableSum += i + sumOfDivisors;
                }
            }

            Console.WriteLine($"Amicable sum: {amicableSum}");
        }

        private int GetDivisorsSum(int number)
        {
            // Final result of summation of divisors
            int result = 0;

            // find all divisors which divides 'num'
            var loopLimit = Math.Sqrt(number);
            for (int i = 2; i <= loopLimit; i++)
            {

                // if 'i' is divisor of 'num'
                if (number % i == 0)
                {

                    // if both divisors are same then 
                    // add it only once else add both
                    var divisionProduct = number / i;
                    if (i == divisionProduct)
                    {
                        result += i;
                    }
                    else
                    {
                        result += (i + divisionProduct);
                    }
                }
            }

            // Add 1 to the result as 1 
            // is also a divisor
            return (result + 1);
        }
    }
}
