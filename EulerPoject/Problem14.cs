namespace EulerPoject
{
    internal class Problem14
    {
        public void Calculate()
        {
            long maxCollatzNumber = 0;
            long maxI = 0;

            for (long i = 1_000_000; i > 1; i--)
            {
                Console.WriteLine($"Caluclate for i: {i} =====MAX i: {maxI} = {maxCollatzNumber}=======");
                var collatzNumber = GetCollatzNumber(i);
                //Console.WriteLine($"Result for i: {i} = {collatzNumber} and current max: {maxCollatzNumber}");
                if (collatzNumber > maxCollatzNumber)
                {
                    maxCollatzNumber = collatzNumber;
                    maxI = i;

                    Console.WriteLine($"MAX i: {i} = {collatzNumber}");
                }
            }

            Console.WriteLine($"=====MAX i: {maxI} = {maxCollatzNumber}=======");

        }

        private bool IsOdd(long num)
        {
            return num % 2 != 0;
        }

        private long GetNextIntWhenEven(long num) => num / 2;

        private long GetNextIntWhenOdd(long num) => num * 3 + 1;

        private long GetCollatzNumber(long startingNum)
        {
            long counter = 1;
            long currentNum = startingNum;
            while(currentNum > 1)
            {
                if (IsOdd(currentNum))
                {
                    currentNum = GetNextIntWhenOdd(currentNum);
                }
                else
                {
                    currentNum = GetNextIntWhenEven(currentNum);
                }

                counter++;
            }

            return counter;
        }
    }
}
