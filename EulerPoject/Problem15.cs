using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    internal struct Point
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    internal class Problem15
    {
        public void Calculate()
        {
            const int maxDim = 21;
            int lastIndex = maxDim - 1;

            var nodes = new ulong[maxDim, maxDim];

            for (int row = lastIndex; row >= 0; row--)
            {
                for (int col = lastIndex; col >= 0; col--)
                {
                    if (col == lastIndex || row == lastIndex)
                    {
                        nodes[row, col] = 1;
                    }
                    else
                    {
                        nodes[row, col] = nodes[row + 1, col] + nodes[row, col + 1];
                    }
                }
            }

            Console.WriteLine(nodes[0, 0]);
        }
    }
}
