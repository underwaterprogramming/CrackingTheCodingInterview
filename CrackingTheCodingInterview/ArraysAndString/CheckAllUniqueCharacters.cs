using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.ArraysAndString
{
    /*
     * Implement an algorithm to determine if a string has all unique characters. 
     * What if you cannot use additional data structures.
     */

    public class CheckAllUniqueCharacters
    {
        public static bool IsAllCharactersUnique(string value)
        {
            value = value.ToLower();
            int[] asciiValue = new int[128];

            foreach(char c in value)
            {
                int indexOfChar = c - 'a';
                asciiValue[indexOfChar]++;
                if (asciiValue[indexOfChar] > 1)
                    return false;
            }
            return true;
        }

        // using bit vector and left shift
        public static bool IsCharactersUniqueUsingBitManipulations(string value)
        {
            int checker = 0;
            foreach(char c in value)
            {
                int shiftingCount = c - 'a';
                if ((checker & (1 << shiftingCount)) > 0)
                    return false;
                checker |= 1 << shiftingCount;
            }
            return true;
        }

    }
}
