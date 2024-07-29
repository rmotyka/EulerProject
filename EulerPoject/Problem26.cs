using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EulerPoject
{
    internal class Problem26
    {
        public void Calculate()
        {
            Divide(1, 6);
        }

        public void Divide(int numerator, int denominator)
        {
            Dictionary<int, int> remainderPositions = new Dictionary<int, int>();
            List<int> decimals = new List<int>();

            int quotient = numerator / denominator;
            int remainder = numerator % denominator;

            while (remainder != 0 && !remainderPositions.ContainsKey(remainder))
            {
                remainderPositions[remainder] = decimals.Count;
                remainder *= 10;
                decimals.Add(remainder / denominator);
                remainder %= denominator;
            }

            Console.WriteLine("Quotient: " + quotient);
            Console.Write("Decimals: 0.");
            foreach (int digit in decimals)
            {
                Console.Write(digit);
            }
            Console.WriteLine();

            if (remainder != 0)
            {
                Console.WriteLine("Cycle starts at position: " + remainderPositions[remainder]);
            }
            else
            {
                Console.WriteLine("No repeating cycle.");
            }
        }
    }
}
