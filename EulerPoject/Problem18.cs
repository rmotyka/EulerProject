﻿namespace EulerPoject
{

    public class Problem18
    {
        public void Calculate()
        {
            long[,] input = 
            {
                {3, 0 ,0, 0 }, // 0
                {7, 4, 0, 0 }, // 1
                {2, 4, 6, 0 }, // 2
                {8, 5, 9, 3 }, // 3
            };

            int lastColumnIndex = input.GetUpperBound(0);
            int lastRowIndex = input.GetUpperBound(1);

            for (int row = lastRowIndex - 1; row >= 0; row--)
            {
                // data is triangle
                var lastColumntIndexWithData = row;

                for (int col = 0; col <= lastColumntIndexWithData; col++)
                {
                    var currentValue = input[row, col];
                    var previous1 = input[row + 1, col];
                    var previous2 = input[row + 1, col + 1];
                    if (previous1 > previous2)
                    {
                        currentValue += previous1;
                    }
                    else
                    {
                        currentValue += previous2;
                    }
                    input[row, col] = currentValue;
                }
            }

            Console.WriteLine(input[0,0]);
        }
    }
}
