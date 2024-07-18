namespace EulerPoject
{

    public class Problem18
    {
        public void Calculate()
        {
            /*
                        long[,] input = 
                        {
                            {3, 0 ,0, 0 }, // 0
                            {7, 4, 0, 0 }, // 1
                            {2, 4, 6, 0 }, // 2
                            {8, 5, 9, 3 }, // 3
                        };
            */

            long[,] input =
                {
                    {75,0,   0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                    {5, 64,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                    {7, 47, 82,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                    {8, 35, 87, 10,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                    {0, 04, 82, 47, 65,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                    {9, 01, 23, 75, 03, 34,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                    {8, 02, 77, 73, 07, 63, 67,  0,  0,  0,  0,  0,  0,  0,  0 },
                    {9, 65, 04, 28, 06, 16, 70, 92,  0,  0,  0,  0,  0,  0,  0 },
                    {1, 41, 26, 56, 83, 40, 80, 70, 33,  0,  0,  0,  0,  0,  0 },
                    {1, 48, 72, 33, 47, 32, 37, 16, 94, 29,  0,  0,  0,  0,  0 },
                    {3, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14,  0,  0,  0,  0 },
                    {0, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57,  0,  0,  0 },
                    {1, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48,  0,  0 },
                    {3, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31,  0 },
                    {4, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 },
                 };

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
                    input[row, col] = currentValue + Math.Max(previous1, previous2);
                }
            }

            Console.WriteLine(input[0, 0]);
        }
    }
}
