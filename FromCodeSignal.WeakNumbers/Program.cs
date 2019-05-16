using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCodeSignal.WeakNumbers
{
    class Program
    {
       /* We define the weakness of number x as the number of positive integers smaller than x that have more divisors than x.

        It follows that the weaker the number, the greater overall weakness it has. For the given integer n, you need to answer two questions:
        
        what is the weakness of the weakest numbers in the range [1, n]?
        how many numbers in the range [1, n] have this weakness?
        Return the answer as an array of two elements, where the first element is the answer to the first question, 
        and the second element is the answer to the second question.
        
        Example
        
        For n = 9, the output should be
        weakNumbers(n) = [2, 2].
        
        Here are the number of divisors and the specific weakness of each number in range[1, 9]:
        
        1: d(1) = 1, weakness(1) = 0;
        2: d(2) = 2, weakness(2) = 0;
        3: d(3) = 2, weakness(3) = 0;
        4: d(4) = 3, weakness(4) = 0;
        5: d(5) = 2, weakness(5) = 1;
        6: d(6) = 4, weakness(6) = 0;
        7: d(7) = 2, weakness(7) = 2;
        8: d(8) = 4, weakness(8) = 0;
        9: d(9) = 3, weakness(9) = 2.
        As you can see, the maximal weakness is 2, and there are 2 numbers with that weakness level.
        
        Input/Output
        
        [execution time limit] 3 seconds(cs)
        
        [input]
                integer n
        
        Guaranteed constraints:
        1 ≤ n ≤ 1000.
        
        [output]
                array.integer
        
        Array of two elements: the weakness of the weakest number, and the number of integers in range[1, n] with this weakness.*/

        static void Main(string[] args)
        {
            weakNumbers(9);     // [2, 2]
            weakNumbers(500);   // [403, 1]
            weakNumbers(7);     // [2, 1]

        }

        public static int[] weakNumbers(int n)
        {
            var weaknessList = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                weaknessList.Add(GetWeakness(i));
            }

            var result = new int[2];

            result[0] = weaknessList.Max();
            result[1] = weaknessList.Count(p => p == result[0]);

            return result;
        }

        public static int NumberOfDivisors(int n)
        {
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static int GetWeakness(int n)
        {
            int weakness = 0;

            int divisorsOfN = NumberOfDivisors(n);

            for (int i = 1; i <= n; i++)
            {
                if (NumberOfDivisors(i)> divisorsOfN)
                {
                    weakness++;
                }
            }
            return weakness;
        }

    }
}
