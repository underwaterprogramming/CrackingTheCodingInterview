using CrackingTheCodingInterview.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.LinkedLists
{
    /*
     * Implement an algorithm to find the Kth to the last element of a singly linked list.
     */ 
    public class ReturnKthToLastNode
    {
        public static Node<T>[] Solution1<T>(SinglyLinkedNodes<T> singlyLinkedNodes, int startIndex)
        {
            int length = singlyLinkedNodes.Length;
            Node<T>[] result = new Node<T>[length - startIndex];
            Node<T> node = singlyLinkedNodes.Head;
            int count = 0, index = 0; ;
            while(node != null)
            {
                if (count >= startIndex)
                {
                    result[index] = node;
                    index++;
                }
                node = node.Next;
                count++;
            }
            return result;
        }

        // incase we do not have length of all the available nodes, with space complexity of O(1)
        public static Node<T> Solution2<T>(Node<T> singlyLinkedNodes, int startIndex)
        {
            if (singlyLinkedNodes == null)
                return new Node<T>();
            int count = 0;
            while(singlyLinkedNodes != null)
            {
                if(count == startIndex)
                {
                    singlyLinkedNodes.Previous = null;
                    break;
                }
                singlyLinkedNodes = singlyLinkedNodes.Next;
                count++;
            }
            return singlyLinkedNodes;
        }
    }
}
