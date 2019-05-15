using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCodeSignal.SquareDigitsSequence
{
    class Program
    {
        /*Consider a sequence of numbers a0, a1, ..., an, in which an element is equal to the sum of squared digits of the previous element.
         * The sequence ends once an element that has already been in the sequence appears again.

         Given the first element a0, find the length of the sequence.
         
         
         Example
         
         For a0 = 16, the output should be
         squareDigitsSequence(a0) = 9.
         
         Here's how elements of the sequence are constructed:
         
         
         a0 = 16
         a1 = 12 + 62 = 37
         a2 = 32 + 72 = 58
         a3 = 52 + 82 = 89
         a4 = 82 + 92 = 145
         a5 = 12 + 42 + 52 = 42
         a6 = 42 + 22 = 20
         a7 = 22 + 02 = 4
         a8 = 42 = 16, which has already occurred before (a0)
         Thus, there are 9 elements in the sequence.
         
         
         For a0 = 103, the output should be
         squareDigitsSequence(a0) = 4.
         
         
         The sequence goes as follows: 103 -> 10 -> 1 -> 1, 4 elements altogether.*/


        static void Main(string[] args)
        {
    
            Console.WriteLine(squareDigitsSequence(16));
        }

        public static int squareDigitsSequence(int a0)
        {
            var sequence = new List<int>();
            sequence.Add(a0);
            while (true)
            {
                int newElement = SquareOfDigits(sequence.Last());

                if (sequence.Contains(newElement))
                {
                    return sequence.Count + 1;
                }
                sequence.Add(newElement);
            }
        }

        public static int SquareOfDigits(int number)
        {
            if (number / 10 == 0)
            {
                return (number % 10) * (number % 10);
            }
            return ((number % 10) * (number % 10)) + SquareOfDigits(number / 10);
        }
    }
}
