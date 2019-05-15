using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromCodeSignal.StringsRearangement
{
    class Program
    {

        /* Given an array of equal-length strings, you'd like to know if it's possible to rearrange the order of the elements 
         * in such a way that each consecutive pair of strings differ by exactly one character.Return true if it's possible, and false if not.

         Note: You're only rearranging the order of the strings, not the order of the letters within the strings!


        Example
        For inputArray = ["aba", "bbb", "bab"], the output should be
        stringsRearrangement(inputArray) = false.

        There are 6 possible arrangements for these strings:

        ["aba", "bbb", "bab"]
        ["aba", "bab", "bbb"]
        ["bbb", "aba", "bab"]
        ["bbb", "bab", "aba"]
        ["bab", "bbb", "aba"]
        ["bab", "aba", "bbb"]
        None of these satisfy the condition of consecutive strings differing by 1 character, so the answer is false.

        For inputArray = ["ab", "bb", "aa"], the output should be
        stringsRearrangement(inputArray) = true.

        It's possible to arrange these strings in a way that each consecutive pair of strings differ by 1 character 
        (eg: "aa", "ab", "bb" or "bb", "ab", "aa"), so return true.*/
        static void Main(string[] args)
        {
            var myArr = new[] { "aba", "bbb", "bab" };
            var myArr2 = new[] { "ab", "bb", "ba" };

            Console.WriteLine(stringsRearrangement(myArr));
        }

        public static bool stringsRearrangement(string[] inputArray)
        {
            var allPossibleRearangements = GeneratePermutations(inputArray);

            for (int j = 0; j < allPossibleRearangements.Count; j++)
            {
                int accesptedIterations = 0;
                for (int i = 0; i < allPossibleRearangements[j].Length - 1; i++)
                {
                    if (StringsDifferByOneChar(allPossibleRearangements[j][i], allPossibleRearangements[j][i + 1]) == false)
                    {
                        break;
                    }
                    else
                    {
                        accesptedIterations++;
                        if (accesptedIterations == inputArray.Length - 1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;

        }

        public static List<string[]> GeneratePermutations(string[] items)
        {
            string[] currentPermutations = new string[items.Length];

            bool[] inSelection = new bool[items.Length];

            List<string[]> results = new List<string[]>();

            PermuteItems(items, inSelection, currentPermutations, results, 0);

            return results;

        }

        public static void PermuteItems(string[] items, bool[] inSelection, string[] currentPermutations,
                                        List<string[]> results, int nextPosition)
        {
            if (nextPosition == items.Length)
            {
                string[] tempToAdd = new string[items.Length];
                currentPermutations.CopyTo(tempToAdd, 0);
                results.Add(tempToAdd);
            }
            else
            {
                for (int i = 0; i < items.Length; i++)
                {
                    if (inSelection[i] == false)
                    {
                        inSelection[i] = true;

                        currentPermutations[nextPosition] = items[i];

                        PermuteItems(items, inSelection, currentPermutations, results, nextPosition + 1);

                        inSelection[i] = false;
                    }
                }
            }

        }

        public static bool StringsDifferByOneChar(string str1, string str2)
        {
            int differs = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    differs++;
                    if (differs != 0 && differs > 1)
                    {
                        return false;
                    }
                }
            }
            return differs == 1;
        }

    }
}
