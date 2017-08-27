using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Personal
{
    public class LongestPalindromeSubstring
    {


        public static int longestSubString(String str)
        {
            int subLen = 1;
            int[] myArr = new int[str.Length];
            myArr[0] = 1;
            int left;
            int right;
            for (int i = 1; i < str.Length; i++)
            {
                subLen = 1;
                left = i;
                right = i;
                while (left > 0 && right < str.Length - 1 && str[(left - 1)] == str[(right + 1)])
                {
                    subLen += 2;
                    left--;
                    right++;
                }
                myArr[i] = subLen;
            }
            int max = 0;
            for (int i = 0; i < myArr.Length; i++)
            {
                if (max < myArr[i])
                {
                    max = myArr[i];
                }
            }
            return max;
        }


        public static int BestSolution(string str)
        {
            bool skipNext = false;
            int max = 0;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;
                if (skipNext)
                {
                    skipNext = false;
                    continue;
                }

                int circularColumnIndex = i > str.Length / 2 ? str.Length - i : i;
                if (1 + circularColumnIndex * 2 < max)
                {
                    Console.WriteLine("loop break because future substing lenght will be lower than max");
                    break;
                }
                var total = 1 + GetPastSum(str, str.Length - 1 - i, i) + GetFutureSum(str, str.Length - 1 - i, i);
                if (total == 1)
                    total = 1 + GetPastSum(str, str.Length - 1 - i, i - 1) + GetFutureSum(str, str.Length - 1 - i, i - 1);
                if (total > max)
                {
                    max = total;
                    skipNext = true;
                }
            }
            Console.WriteLine("loop: " + count);
            return max;
        }

        private static int GetPastSum(string str, int org, int rev)
        {
            int sum = 0;
            while (true)
            {
                org--;
                rev--;
                if (org > 0 && rev > 0 && str[org] == str[str.Length - 1 - rev])
                    sum++;
                else
                    break;
            }
            return sum;
        }

        private static int GetFutureSum(string str, int org, int rev)
        {
            int sum = 0;
            while (true)
            {
                org++;
                rev++;
                if ((org < str.Length - 1) && (rev < str.Length - 1) && str[org] == str[str.Length - 1 - rev])
                    sum++;
                else
                    break;
            }
            return sum;
        }

        public static int GetLPSLenght(string str)
        {
            Dictionary<int, int> collection = new Dictionary<int, int>();
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] != str[str.Length - j - 1])
                        continue;
                    int index = 10 * i + j;
                    if (collection.ContainsKey(index - 11))
                        collection[index] = collection[index - 11] + 1;
                    else
                        collection.Add(index, 1);
                    if (collection[index] > result)
                        result = collection[index];
                }
            }

            return result;
        }
    }
}
