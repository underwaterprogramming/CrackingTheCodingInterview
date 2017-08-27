using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview
{

    /*
     * Write a method to replace all spaces in a string with '%20'. You may assume that the string
     * has sufficient space at the end to hld the additional characters, and that you are given the 'true' length
     * of the string. Try inplace
     */
    public class URLify
    {
        public static string ReplaceSpacesUsingStringBuilder(char[] str, int trueLength)
        {
            int spaceCount = 0, index = 0, i = 0;
            for (i = 0; i < trueLength; i++)
            {
                if (str[i] == ' ')
                    spaceCount++;
            }
            index = trueLength + 2 * spaceCount;

            StringBuilder sb = new StringBuilder(index); // making space complexity O(1)
            
            for(i = 0; i< trueLength; i++)
            {
                if (str[i] == ' ')
                    sb.Append("%20");
                else
                    sb.Append(str[i]);
            }
            return sb.ToString();
        }

        // soln implementation from CTCI book
        public static void ReplaceSpaces(char[] str, int trueLength)
        {
            int spaceCount = 0, index = 0, i = 0;
            for(i =0; i< trueLength; i++)
            {
                if (str[i] == ' ')
                    spaceCount++;
            }
            index = trueLength + 2 * spaceCount;
            for(i=trueLength - 1; i>=0; i--)
            {
                if(str[i] == ' ')
                {
                    str[index - 1] = '0';
                    str[index - 2] = '2';
                    str[index - 3] = '%';
                    index = index - 3;
                } else
                {
                    str[index - 1] = str[i];
                    index--;
                }
            }
        }
    }
}
