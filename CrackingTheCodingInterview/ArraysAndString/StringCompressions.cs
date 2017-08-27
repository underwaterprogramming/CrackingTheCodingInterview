using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.ArraysAndString
{
    /*
     * Implement a method to perform basic string compression using the counts of repeated characters.
     * For examples, the string aabcccccaaa would become a2b1c5a3.
     * If the "compressed" string would not become smaller than the original string, 
     * your method should return the original string.
     * You can assume the string has only uppercase and lowercase letters.
     */ 
    public class StringCompressions
    {
        public static string Solution1(string str)
        {
            char prevChar = str[0];
            int charCount = 0;
            StringBuilder sb = new StringBuilder();
            foreach(char c in str)
            {
                if(prevChar != c)   
                {
                    sb.Append(prevChar).Append(charCount);
                    charCount = 0;
                }
                charCount++;
                prevChar = c;
            }
            sb.Append(prevChar).Append(charCount);
            if (sb.Length >= str.Length)
                return str;
            return sb.ToString();
        }

        public static string Solution2(string str)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for(int i = 0; i< str.Length; i++)
            {
                count++;
                if(i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    sb.Append(str[i]).Append(count);
                    count = 0;
                }
                if (sb.Length >= str.Length)
                    return str;
            }
            return sb.ToString();
        }


    }
}
