using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.ArraysAndString
{

    /*
     * Given a string, write a function to check if it is a permutation of a palindrome. 
     * A palindrome is a word or a phrase that is the same forwards and backwards. 
     * A permutation is rearrangement of letters. 
     * The palindrome does not need to be limited to just dictionary words.
     */
    public class PalindromePermutation
    {
        // count individual characters and if more than one characters count is odd then return false
        public static bool Solution1(string str)
        {
            int[] charIndex = new int[128];
            int oddCharCount = 0;
            foreach (char c in str)
            {
                int index = c - 'a';
                charIndex[index]++;
                if (charIndex[index] % 2 != 0)
                    oddCharCount++;
                else
                    oddCharCount--;
            }
            return oddCharCount < 2;
        }

        /// <summary>
        /// Using bit manipulation to find solution
        /// each char is represented by a bit vector and on each occurance the bit is toggled
        /// at end we need to verify if there are more than one set bit or not
        ///     if there are more than one set, return false else return true.
        ///     How to check if only one bit is set or not:
        ///     000100 - 000001 = 000011 
        ///     000100 & 000011 = 0  i.e. follow this process and 
        ///     if result is 0 then one bit is set else more than one bit is set
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Is one bit set</returns>
        public static bool Solution2(string str)
        {
            str = str.ToLower();
            int bitVector = 0;
            foreach(char c in str)
            {
                var index = c - 'a';
                bitVector = ToggleBit(bitVector, index);
            }
            if ((bitVector & (bitVector - 1)) == 0)
                return true;
            return false;
        }

        private static int ToggleBit(int bitVector, int index)
        {
            if (index < 0)
                return bitVector;
            // check if particular index is set or reset
            var maskBit = 1 << index;
            if((bitVector & maskBit) == 0)
            {
                // reset bit
                bitVector |= maskBit;
            } else
            {
                // set bit, not maskbit and and them
                maskBit = ~maskBit;
                bitVector &= maskBit;
            }
            return bitVector;
        }
    }
}
