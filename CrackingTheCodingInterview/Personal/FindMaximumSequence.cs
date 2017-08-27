using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Personal
{
    public class FindMaximumSequence
    {
        /*
         * 1,9,3,10,4,20,2
         */
        public static int Solution1(int[] values)
        {
            int max = 1;
            Array.Sort(values);
            for (var c = 1; c < values.Length; c++)
            {
                if ((values[c] - values[c - 1]) > 1)
                    max = 1;
                else
                    max++;
            }
            return max;
        }

        public static int Solution2(int[] values)
        {
            int max = 1;

            Dictionary<int, int> store = new Dictionary<int, int>();

            foreach (var v in values)
            {
                store.TryGetValue(v, out int temp);
                store[v] = 1 + temp;
            }

            foreach (var v in values)
            {
                int count = 1;
                if (!store.ContainsKey(v - 1))
                {
                    // this value v is the starting index
                    store.TryGetValue(v, out int x);
                    count = x;
                    int temp = v + 1;
                    while (store.ContainsKey(temp))
                    {
                        store.TryGetValue(temp, out int y);
                        count += y;
                        temp = temp + 1;
                    }
                }
                if (count > max)
                    max = count;
            }
            return max;
        }
    }
}
