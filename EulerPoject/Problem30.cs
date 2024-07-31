using System.Numerics;

namespace EulerPoject
{
    internal class Problem30
    {
        internal void Calculate()
        {
            BigInteger number = 2;
            BigInteger sumOfNumbers = 0;
            BigInteger upperLimit = 6 * (Pow5(9));

            while(number <= upperLimit)
            {
                var digits = GetDigits(number);
                BigInteger sum = 0;
                foreach (var digit in digits)
                {
                    var pow5Digit = Pow5(digit);
                    sum += pow5Digit;
                    if (sum > number)
                    {
                        break;
                    }
                }

                if (sum == number)
                {
                    sumOfNumbers += number;
                    Console.WriteLine($"Number: {number}, sum of numbers {sumOfNumbers}");
                }

                number++;
            }
        }

        public static Stack<BigInteger> GetDigits(BigInteger number)
        {
            if (number == 0)
            {
                return new Stack<BigInteger>();
            }

            var digits = GetDigits(number / 10);
            digits.Push(number % 10);
            return digits;
        }

        private BigInteger Pow5(BigInteger a)
        {
            BigInteger res = 1;
            for (int i = 0; i < 5; i++)
            {
                res *= a;
            }

            return res;
        }

    }
}
