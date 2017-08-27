using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.ArraysAndString
{
    /*
     * Assume you have a method isSubstring which checks if one word is a substring of another. 
     * Given two strings, s1 ans s2, write code to check if s2 is a rotation of s1 using
     * only one call to isSubstring (e.g., "waterbottle" is a rotation of "erbottlewat").
     */ 
    public class StringRotation
    {
        public static bool IsRotation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;
            string s1s1 = s1 + s1;
            return IsSubstring(s1s1, s2);
        }

        private static bool IsSubstring(string s1, string s2)
        {
            return s1.Contains(s2);
        }
    }
}
