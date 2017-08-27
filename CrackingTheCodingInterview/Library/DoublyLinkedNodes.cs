using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Library
{
    public class DoublyLinkedNodes<T>
    {
        public Node<T> head = new Node<T>();
        DoublyLinkedNodes(T[] values)
        {
            Node<T> current = new Node<T>(values[0], null, null);
            Node<T> next = current;
            Node<T> previous = current;

            for (int i = 1; i < values.Length; i++)
            {
                next = new Node<T>(values[i]);
                previous.Next = next;
                next.Previous = previous;
                previous = next;
            }

            head.Data = current.Data;
            head.Previous = current.Previous;
            head.Next = current.Next;
        }
    }
}
