using CrackingTheCodingInterview.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LinkedLists
{
    /*
     * Write a code to remove duplicates from an unsorted list.
     */
    public class RemoveDups
    {
        public static void Solution1(LinkedList<string> linkedList)
        {
            HashSet<string> collection = new HashSet<string>();
            for (var it = linkedList.First; it != null; it = it.Next)
            {
                if (!collection.Contains(it.Value))
                    collection.Add(it.Value);
                else
                {
                    var prev = it.Previous;
                    linkedList.Remove(it);
                    it = prev;
                }
            }
        }

        public static void Solution2<T>(Node<T> node)
        {
            HashSet<T> collection = new HashSet<T>();
            while(node != null)
            {
                if (!collection.Contains(node.Data))
                    collection.Add(node.Data);
                else
                {
                    node.Previous.Next = node.Next;
                    if(node.Next != null)
                        node.Next.Previous = node.Previous;
                }
                node = node.Next;
            }
        }
    }

}
