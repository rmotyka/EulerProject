using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EulerPoject
{
    public class Problem23
    {
        const int MaxNumberToVerity = 28_123;
        public void Calculate()
        {
            var result = 0;

            var allAbundants = GetAllAbudants();
            allAbundants.Sort();

            for (int i = 0; i < MaxNumberToVerity; i++)
            {
                var abudantPairFound = false;
                var allAbudantsSmallerThenI = allAbundants.Where(x => x <= i).ToArray();
                foreach (var abudant in allAbudantsSmallerThenI)
                {
                    var diff = i - abudant;
                    if (allAbudantsSmallerThenI.Contains(diff))
                    {
                        abudantPairFound = true;
                        break;
                    }
                }

                if (!abudantPairFound)
                {
                    Console.WriteLine($"No abudant pari for {i}");
                    result += i;
                }
            }

            Console.WriteLine(result);
        }

        private List<int> GetAllAbudants()
        {
            List<int> abudants = new();
            var problem21 = new Problem21();
            for (int i = 12; i < MaxNumberToVerity; i++)
            {
                var ds = problem21.GetDivisorsSum(i);
                if (ds > i)
                {
                    abudants.Add(i);
                }
            }

            return abudants;
        }
    }
}
