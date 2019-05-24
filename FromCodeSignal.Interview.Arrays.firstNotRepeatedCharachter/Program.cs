using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCodeSignal.Interview.Arrays.firstDuplicate
{

  /*  Note: Write a solution that only iterates over the string once and uses O(1) additional memory, 
   *  since this is what you would be asked to do during a real interview.

Given a string s consisting of small English letters,
find and return the first instance of a non-repeating character in it.If there is no such character, return '_'.

Example

For s = "abacabad", the output should be
firstNotRepeatingCharacter(s) = 'c'.

There are 2 non-repeating characters in the string: 'c' and 'd'. 
Return c since it appears in the string first.

For s = "abacabaabacaba", the output should be
firstNotRepeatingCharacter(s) = '_'.

There are no characters in this string that do not repeat.

Input/Output

[execution time limit] 3 seconds (cs)

[input] string s

A string that contains only lowercase English letters.

Guaranteed constraints:
1 ≤ s.length ≤ 105.

[output] char

The first non-repeating character in s, or '_' if there are no characters that do not repeat.*/

    class Program
    {
        static void Main(string[] args)
        {
            var s = "abacabad";
            Console.WriteLine(firstNotRepeatingCharacter(s));
        }

        public static char firstNotRepeatingCharacter(string s)
        {
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]]==2)
                    {
                        continue;
                    }
                    dict[s[i]]++;
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }

            return dict.Values.Contains(1) ? dict.First((p) => p.Value == 1).Key : '_';
        }


    }
}
