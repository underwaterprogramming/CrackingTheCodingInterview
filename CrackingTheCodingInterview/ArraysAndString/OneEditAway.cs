using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.ArraysAndString
{
    /*
     * There are three types of edits that can be performed on strings: 
     * insert a character, remove a character, or replace a character.
     * Given two strings, write a function to check if they are one edit (or zero edit) away.
     */
    public class OneEditAway
    {

        public static bool Solution1(string s1, string s2)
        {
            if (s1.Length == s2.Length)
            {
                // it can be one replace
                return IsOneReplaceAway(s1, s2);
            }
            else
            {
                // can be either one insert or one remove
                string shorterString = s1.Length < s2.Length ? s1 : s2;
                // other = equal or longer
                string otherString = s1.Length < s2.Length ? s2 : s1;
                return isOneInsertAway(shorterString, otherString);
            }
        }

        private static bool IsOneReplaceAway(string s1, string s2)
        {
            int index1 = 0, index2 = 0;
            bool isDiffFound = false;
            while (index1 < s1.Length && index2 < s2.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (isDiffFound)
                        return false;
                    isDiffFound = true;
                }
                index1++;
                index2++;
            }
            return true;
        }

        private static bool isOneInsertAway(string shorterString, string longerString)
        {
            int index1 = 0, index2 = 0;
            bool isDiffFound = false;
            while (index1 < shorterString.Length && index2 < longerString.Length)
            {
                if (shorterString[index1] == longerString[index2])
                {
                    index1++;
                    index2++;
                }
                else
                {
                    if (isDiffFound)
                        return false;
                    isDiffFound = true;
                    index2++;
                }
            }
            return true;
        }

        public static bool IsOneEditAway(string s1, string s2)
        {
            string shorterString = s1.Length < s2.Length ? s1 : s2;
            // other = equal or longer
            string otherString = s1.Length < s2.Length ? s2 : s1;

            int index1 = 0, index2 = 0;
            bool isDiffFound = false;

            while (index1 < shorterString.Length && index2 < otherString.Length)
            {
                if (shorterString[index1].Equals(otherString[index2]))
                {
                    index1++;
                }
                else
                {
                    if (isDiffFound)
                        return false;
                    isDiffFound = true;
                    if (shorterString.Length == otherString.Length)
                        index1++;
                }
                index2++;
            }
            return true;
        }
    }
}
