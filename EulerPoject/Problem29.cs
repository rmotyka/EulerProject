using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    internal class Problem29
    {
        internal void Calculate()
        {
            HashSet<BigInteger> results = new();

            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    var res = Pow(a, b);
                    results.Add(res);
                }
            }

            Console.WriteLine(results.Count);
        }

        private BigInteger Pow(int a, int b)
        {
            BigInteger res = 1;
            for (int i = 0; i < b; i++)
            {
                res *= a;
            }

            return res;
        }
    }
}
