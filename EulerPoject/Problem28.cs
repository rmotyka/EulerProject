using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    internal class Problem28
    {
        public enum Driection
        {
            E,
            S,
            W,
            N
        }

        /*
         		
                        -1	0	1	
				
                1	    2	x   x  x		
                0	    2	1	2	
                -1	    2  	2	2	
					
         */

        public void Calculate()
        {
            var sum = 1 + 3 + 5 + 7 + 9;

            var incrementator = 4;
            var curentNumber = 9;


            while(true)
            {
                for (int i = 0; i < 4; i++)
                {
                    curentNumber += incrementator;

                    sum += curentNumber;
                }

                incrementator += 2;
            }
        }
    }
}
