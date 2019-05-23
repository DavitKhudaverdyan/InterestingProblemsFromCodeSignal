using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCodeSignal.Interview.Arrays.firstDuplicate
{
    class Program
    {

        //        Given an array a that contains only numbers in the range from 1 to a.length, find the first duplicate number for which the second occurrence has the minimal index.
        //In other words, if there are more than 1 duplicated numbers, return the number for which the second occurrence has a smaller index than the second occurrence of the other number does.If there are no such elements, return -1.

        //Example

        //For a = [2, 1, 3, 5, 3, 2], the output should be firstDuplicate(a) = 3.

        //There are 2 duplicates: numbers 2 and 3. The second occurrence of 3 has a smaller index than the second occurrence of 2 does, so the answer is 3.

        //For a = [2, 2], the output should be firstDuplicate(a) = 2;

        //        For a = [2, 4, 3, 5, 1], the output should be firstDuplicate(a) = -1.

        //Input/Output

        //[execution time limit] 3 seconds(cs)

        //[input]
        //        array.integer a

        //Guaranteed constraints:
        //1 ≤ a.length ≤ 105,
        //1 ≤ a[i] ≤ a.length.

        //[output] integer

        //The element in a that occurs in the array more than once and has the minimal index for its second occurrence.
        //If there are no such elements, return -1.

        static void Main(string[] args)
        {
            var a = new int[] { 2, 1, 3, 5, 3, 2 };
            var c = new int[] { 2, 2 };

            var b = new int[] { 8, 4, 6, 2, 6, 4, 7, 9, 5, 8 };

            Console.WriteLine(firstDuplicate1(a));
        }

        public static int firstDuplicate(int[] a)
        {
            var duplicateIndex = -1;

            var lastPossibleMinIndex = a.Length - 1;

            for (int i = 0; i < lastPossibleMinIndex; i++)
            {
                for (int j = i + 1; j <= lastPossibleMinIndex; j++)
                {
                    if (a[i] == a[j])
                    {
                        duplicateIndex = j;
                        lastPossibleMinIndex = j;
                        break;
                    }
                }
            }

            return duplicateIndex == -1 ? -1 : a[duplicateIndex];
        }

        public static int firstDuplicate1(int[] a)
        {
            var arr = new int[a.Length+1];

            for (int i = 0; i < a.Length; i++)
            {
                arr[a[i]]++;
                if (arr[a[i]]==2)
                {
                    return a[i];
                }
            }

            return -1;
        }

    }
}
