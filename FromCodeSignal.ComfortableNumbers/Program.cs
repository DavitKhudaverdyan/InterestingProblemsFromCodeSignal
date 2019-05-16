using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCodeSignal.ComfortableNumbers
{
    class Program
    {
        /*Let's say that number a feels comfortable with number b if a ≠ b and b lies in the segment [a - s(a), a + s(a)],
         * where s(x) is the sum of x's digits.

        How many pairs (a, b) are there, such that a<b, both a and b lie on the segment[l, r],
        and each number feels comfortable with the other (so a feels comfortable with b and b feels comfortable with a)?
        
        Example
        
        For l = 10 and r = 12, the output should be
        comfortableNumbers(l, r) = 2.
        
        Here are all values of s(x) to consider:
        
        s(10) = 1, so 10 is comfortable with 9 and 11;
        s(11) = 2, so 11 is comfortable with 9, 10, 12 and 13;
        s(12) = 3, so 12 is comfortable with 9, 10, 11, 13, 14 and 15.
        Thus, there are 2 pairs of numbers comfortable with each other within the segment[10; 12]: (10, 11) and(11, 12)*/

        static void Main(string[] args)
        {
            Console.WriteLine(comfortableNumbers(10,12));  // answer must be 2
            Console.WriteLine(comfortableNumbers(12, 108));  // answer must be 707
        }

        public static int comfortableNumbers(int l, int r)
        {
            int count = 0;

            for (int i = l; i < r; i++)
            {
                int maxBorder = Math.Min(r, i + SumOfDigits(i));
                for (int j = i+1; j <= maxBorder; j++)
                {
                    if (IsComfortableWithEachOther(i,j))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int SumOfDigits(int number)
        {
            if (number / 10 == 0)
            {
                return number % 10;
            }

            return number % 10 + SumOfDigits(number / 10);
        }

        public static bool IsComfortableWithEachOther(int number1, int number2)
        {
            int maxPointNum1 = number1 + SumOfDigits(number1);

            int minPointNum2 = number2 - SumOfDigits(number2);

            return maxPointNum1 >= number2 && minPointNum2 <= number1;
        }
    }
}
