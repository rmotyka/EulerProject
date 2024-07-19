using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    // https://www.hackerearth.com/practice/notes/factorial-of-large-number/

    public class Problem20
    {
        private const int MAX = 500;

        public void Calculate()
        {
            var result = Factorial(100);
            Console.WriteLine(result.Sum());
        }

        private int[] Factorial(int n)
        {
            var res = new int[MAX];

            res[0] = 1;
            int res_size = 1;

            for (int x = 2; x <= n; x++)
            {
                res_size = Multiply(x, res, res_size);
            }

            Array.Reverse(res, 0, res_size);

            return res.AsSpan(0, res_size).ToArray();
            //return res.Take(res_size).Aggregate("", (a, i) => a + i);
        }

        private int Multiply(int x, int[] res, int res_size)
        {
            int carry = 0;

            for (int i = 0; i < res_size; i++)
            {
                int prod = res[i] * x + carry;
                res[i] = prod % 10;
                carry = prod / 10;
            }

            while (carry != 0)
            {
                res[res_size] = carry % 10;
                carry = carry / 10;
                res_size++;
            }
            return res_size;
        }

    }
}
