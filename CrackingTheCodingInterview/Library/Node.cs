using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Library
{
    public class Node<T>
    {
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        private bool HasNext { }

        public Node() { }

        public Node(T data)
        {
            Data = data;
            Previous = null;
            Next = null;
        }

        public Node(T data, Node<T> previous, Node<T> next)
        {
            Data = data;
            Previous = previous;
            Next = next;
        }

        public Node(T[] values, bool isSinglyLinkedList = false)
        {
            Node<T> current = new Node<T>(values[0], null, null);
            Node<T> next = current;
            Node<T> previous = current;
            
            for (int i = 1; i < values.Length; i++)
            {
                next = new Node<T>(values[i]);
                previous.Next = next;
                if(!isSinglyLinkedList)
                    next.Previous = previous;
                previous = next;
            }

            Data = current.Data;
            if (!isSinglyLinkedList)
                Previous = current.Previous;
            Next = current.Next;
        }

        public override bool Equals(object obj)
        {
            
            Node<T> node = (Node<T>)obj;
            if (node == null || node.Data == null)
                return false;
            if (node.Data.Equals(Data) &&
                node.Previous.Equals(Previous) &&
                node.Next.Equals(Next))
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 31;
            if (Previous != null)
                hash = hash * 7 + Previous.GetHashCode();
            if (Data != null)
                hash = hash * 7 + Data.GetHashCode();
            if (Next != null)
                hash = hash * 7 + Next.GetHashCode();
            return hash;
        }
    }
}
