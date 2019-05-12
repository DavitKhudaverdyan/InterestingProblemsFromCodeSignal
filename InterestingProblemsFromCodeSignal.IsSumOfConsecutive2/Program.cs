using System;
using System.Collections.Generic;
using System.Linq;

namespace InterestingProblemsFromCodeSignal.IsSumOfConsecutive2
{
    class Program
    {
        //Find the number of ways to express n as sum of some (at least two) consecutive positive integers.

        /*      Example

     For n = 9, the output should be
     isSumOfConsecutive2(n) = 2.

     There are two ways to represent n = 9: 2 + 3 + 4 = 9 and 4 + 5 = 9.

     For n = 8, the output should be
     isSumOfConsecutive2(n) = 0.

     There are no ways to represent n = 8.*/

        static void Main(string[] args)
        {
            isSumOfConsecutive2(9);
        }

        public static int isSumOfConsecutive2(int n)
        {
            var divisors = DivisorsOf2n(n);

            int count = 0;

            for (int i = 0; i < divisors.Count(); i++)
            {
                if ((2 * n / divisors[i] - divisors[i] + 1) % 2 == 0)
                {
                    count++;
                }

            }
            return count;
        }

        public static List<int> DivisorsOf2n(int n)
        {
            List<int> answer = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if (2 * n % i == 0)
                {
                    answer.Add(i);
                }
            }
            return answer;
        }
    }
}
