using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    internal class Problem25
    {
        public void Calculate()
        {
            int i = 0;
            while(true)
            {
                var f = Fibonacci(i);

                var s = f.ToString();
                var l = s.Length;
                if (l % 10 == 0)
                {
                    Console.WriteLine($"{i})\t\t[{l}]\t\t{s}");
                }

                if (l == 1_000)
                {
                    break;
                }

                i++;
            }
        }
        
        // Fast doubling algorithm
        private static BigInteger Fibonacci(int n)
        {
            BigInteger a = BigInteger.Zero;
            BigInteger b = BigInteger.One;
            for (int i = 31; i >= 0; i--)
            {
                BigInteger d = a * (b * 2 - a);
                BigInteger e = a * a + b * b;
                a = d;
                b = e;
                if ((((uint)n >> i) & 1) != 0)
                {
                    BigInteger c = a + b;
                    a = b;
                    b = c;
                }
            }
            return a;
        }

        
    }
}
