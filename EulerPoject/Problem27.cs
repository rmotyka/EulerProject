namespace EulerPoject
{
    internal class Problem27
    {
        public void Calculate()
        {
            int resultA = 0;
            int resultB = 0;
            int maxNumberOfPrimes = 0;

            for (int a = -999; a <= 999; a++)
            {
                for (int b = -1000; b <= 1000; b++)
                {
                    int numberOfPrimes = 0;
                    int n = 0;
                    while(true)
                    {
                        var y = n * n + a * n + b;
                        if (IsPrime(y))
                        {
                            numberOfPrimes++;
                        }
                        else
                        {
                            break;
                        }

                        n++;
                    }

                    if (maxNumberOfPrimes < numberOfPrimes)
                    {
                        Console.WriteLine($"current max number of primxes {numberOfPrimes} for {a} and {b}");
                        maxNumberOfPrimes = numberOfPrimes;
                        resultA = a;
                        resultB = b;
                    }
                }
            }

            Console.WriteLine(resultA * resultB);
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
