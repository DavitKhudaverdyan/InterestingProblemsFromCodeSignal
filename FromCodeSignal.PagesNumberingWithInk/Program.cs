using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCodeSignal.PagesNumberingWithInk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pagesNumberingWithInk(21, 5));
        }

        public static int pagesNumberingWithInk(int current, int numberOfDigits)
        {
            while (NumberOfDigits(current) <= numberOfDigits)
            {
                numberOfDigits -= NumberOfDigits(current);
                current++;
            }
            return current-1;
        }

        public static int NumberOfDigits(int number)
        {
            return number.ToString().Length;
        }
    }
}
