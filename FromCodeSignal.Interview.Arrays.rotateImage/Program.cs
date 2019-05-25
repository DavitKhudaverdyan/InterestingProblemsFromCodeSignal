using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCodeSignal.Interview.Arrays.firstDuplicate
{
    /*Note: Try to solve this task in-place (with O(1) additional memory), 
     * since this is what you'll be asked to do during an interview.

     You are given an n x n 2D matrix that represents an image. Rotate the image by 90 degrees (clockwise).
     
     Example
     
     For
     
     a = [[1, 2, 3],
          [4, 5, 6],
          [7, 8, 9]]
     the output should be
     
     rotateImage(a) =
         [[7, 4, 1],
          [8, 5, 2],
          [9, 6, 3]]
     Input/Output
     
     [execution time limit] 3 seconds (cs)
     
     [input]
         array.array.integer a
     
     Guaranteed constraints:
     1 ≤ a.length ≤ 100,
     a [i].length = a.length,
     1 ≤ a [i]
         [j] ≤ 104.
     
     [output]
         array.array.integer */

    class Program
    {
        static void Main(string[] args)
        {
            var prompt = new int[3][];
            prompt[0] = new int[] { 1, 2, 3 };
            prompt[1] = new int[] { 4, 5, 6 };
            prompt[2] = new int[] { 7, 8, 9 };

            var res = rotateImage(prompt);
            Console.ReadLine();
        }

        public static int[][] rotateImage(int[][] a)
        {
            var length = a.GetLength(0);
            var result = new int[length][];
            for (int k = 0; k < length; k++)
            {
                result[k] = new int[length];
            }

            for (int i = 0; i < length; i++)
            {
                int temp = 0;
                for (int j = length - 1; j >= 0; j--)
                {
                    result[i][temp] = a[j][i];
                    temp++;
                }
            }
            return result;
        }



    }
}
