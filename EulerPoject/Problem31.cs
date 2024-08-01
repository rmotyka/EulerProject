using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    internal class Problem31
    {
        internal void Calculate()
        {
            int target = 200;
            int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
            int[] ways = new int[target + 1];
            ways[0] = 1;

            foreach (int coin in coins)
            {
                for (int i = coin; i <= target; i++)
                {
                    var newWays = ways[i - coin];
                    ways[i] += newWays;
                }
            }

            Console.WriteLine(ways[target]);
        }
    }
}
