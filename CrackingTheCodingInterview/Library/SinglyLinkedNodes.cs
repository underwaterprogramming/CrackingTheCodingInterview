using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.Library
{
    public class SinglyLinkedNodes<T>
    {
        public Node<T> Head = new Node<T>();
        public int Length { get; set; }

        public SinglyLinkedNodes(T[] values)
        {
            Length = values.Length;
            Node<T> current = new Node<T>(values[0], null, null);
            Node<T> next = current;
            Node<T> previous = current;

            for (int i = 1; i < values.Length; i++)
            {
                next = new Node<T>(values[i]);
                previous.Next = next;
                previous = next;
            }

            Head.Data = current.Data;
            Head.Next = current.Next;
        }
    }
}
