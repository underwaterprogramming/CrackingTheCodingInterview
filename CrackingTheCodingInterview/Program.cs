using CrackingTheCodingInterview.ArraysAndString;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingTheCodingInterview.Personal;
using CrackingTheCodingInterview.Library;
using CrackingTheCodingInterview.LinkedLists;
using System.Threading;
using System.Numerics;

namespace CrackingTheCodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.ReadLine();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numsHashMap = new Dictionary<int, int>();
            for (int n = 0; n < nums.Length; n++)
            {
                int search = target - nums[n];
                if (numsHashMap.ContainsKey(search))
                {
                    var temp = numsHashMap.TryGetValue(search, out int ans);
                    return new int[] { ans, n };
                }
                else
                    numsHashMap.Add(nums[n], n);
            }
            return new int[] { };
        }
    }
}
