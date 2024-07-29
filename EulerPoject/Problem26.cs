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
            int longestCycle = 0;
            int longestDenominator = 0;
            DivideResult longestResult = new();
            for (int i = 1; i < 1_000; i++)
            {
                var result = Divide(1, i);
                if (result.CycleStartPosition is not null)
                {
                    var currentCycleLength = result.Decimals.Count - result.CycleStartPosition.Value;
                    if (longestCycle < currentCycleLength)
                    {
                        longestDenominator = i;
                        longestCycle = currentCycleLength;
                        longestResult = result;
                    }
                }
            }

            Console.WriteLine($"Longest cycle for {longestDenominator}");
            Console.WriteLine(longestResult.ToString());
        }

        public struct DivideResult
        {
            public int Quotient;
            public List<int> Decimals;
            public int? CycleStartPosition;

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("Quotient: " + Quotient);
                sb.Append("Decimals: 0.");
                foreach (int digit in Decimals)
                {
                    sb.Append(digit);
                }
                sb.AppendLine();
                if (CycleStartPosition is not null)
                {
                    sb.AppendLine("Cycle starts at position: " + CycleStartPosition);
                }
                else
                {
                    sb.AppendLine("No repeating cycle.");
                }

                return sb.ToString();
            }
        }

        public DivideResult Divide(int numerator, int denominator)
        {
            Dictionary<int, int> remainderPositions = [];
            List<int> decimals = [];

            int quotient = numerator / denominator;
            int remainder = numerator % denominator;

            while (remainder != 0 && !remainderPositions.ContainsKey(remainder))
            {
                remainderPositions[remainder] = decimals.Count;
                remainder *= 10;
                decimals.Add(remainder / denominator);
                remainder %= denominator;
            }

            DivideResult divideResult = new DivideResult
            {
                Quotient = quotient,
                Decimals = decimals,
                CycleStartPosition = null
            };

            if (remainder != 0)
            {
                divideResult.CycleStartPosition = remainderPositions[remainder];
            }

            return divideResult;
        }
    }
}
