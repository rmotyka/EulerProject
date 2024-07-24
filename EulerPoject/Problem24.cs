using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerPoject
{
    public class Problem24
    {
        private static int _permutationsCouter = 0;

        public void Calculate()
        {
            int[] arr = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

            PrintPermutations(arr, 0, arr.Length);
        }

        // Function to right rotate the segment arr[i....j] of arr
        static void RightRotate(int[] arr, int i, int j)
        {
            int temp = arr[j];
            for (int k = j; k > i; k--)
            {
                arr[k] = arr[k - 1];
            }
            arr[i] = temp;
        }

        // Function to left rotate the segment arr[i....j] of arr
        static void LeftRotate(int[] arr, int i, int j)
        {
            int temp = arr[i];
            for (int k = i; k < j; k++)
            {
                arr[k] = arr[k + 1];
            }
            arr[j] = temp;
        }

        // Function to print permutations of the array
        static void PrintPermutations(int[] arr, int i, int n)
        {
            // Base case: if i reaches the end of the array and there are no elements to swap with
            if (i == n - 1)
            {
                _permutationsCouter++;

                if (_permutationsCouter % 1_000 == 0)
                {
                    Console.Write(_permutationsCouter + ")\t");
                    Console.WriteLine(string.Join("", arr));
                }
                return;
            }

            // If we do not rotate any segment starting from the i+1th index
            PrintPermutations(arr, i + 1, n);

            // If we rotate a segment, we can have rotations of the segment arr[i....j]
            for (int j = i + 1; j < n; j++)
            {
                RightRotate(arr, i, j);
                PrintPermutations(arr, i + 1, n);
                LeftRotate(arr, i, j);
            }
        }



    }
}
