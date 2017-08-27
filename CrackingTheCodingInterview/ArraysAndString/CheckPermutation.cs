using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.ArraysAndString
{
    /*
     * Given two string, write a method to decide if one is a permutation of other or not
     * god -> dog
     */

    public class CheckPermutation
    {

        public static bool IsPermutation(string original, string final)
        {
            if (original.Length != final.Length)
                return false;

            int[] checker = new int[128];
            int sum = 0;
            for (int i = 0; i< original.Length; i++) {
                int indexerFirst = original[i] - 'a';
                int indexerSecond = final[i] - 'a';
                checker[indexerFirst]++;
                checker[indexerSecond]--;
                sum = checker[indexerFirst] + checker[indexerSecond];
            }

            if (sum != 0)
                return false;

            return true;
        }

        public static bool IsPermutationCharCount(string original, string final)
        {
            original = original.ToLower();
            final = final.ToLower();
            if (original.Length != final.Length)
                return false;
            int[] value = new int[128];

            foreach(char c in original)
            {
                int indexToConsider = c - 'a';
                value[indexToConsider]++;
            }

            foreach(char c in final)
            {
                int indexToConsider = c - 'a';
                value[indexToConsider]--;
                if (value[indexToConsider] < 0)
                    return false;
            }
            return true;
        }


        public static bool IsPermutationBySorting(string orignal, string final)
        {
            if (orignal.Length != final.Length)
                return false;

            var a = GetSortedString(orignal);
            var b = GetSortedString(final);
            if (a.Equals(b))
                return true;

            return false;
        }

        private static string GetSortedString(string value)
        {
            char[] charValue = value.ToCharArray();
            Array.Sort(charValue);
            return new string(charValue);
        }
    }
}
