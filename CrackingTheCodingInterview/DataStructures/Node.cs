using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCodingInterview.DataStructures
{
    public class Node<T>
    {
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
        T data;

        Node() { }

        Node (T data)
        {
            this.data = data;
        }

        Node(T[] value)
        {
            Previous = null;
            data = value[0];
            Next = new Node<T>(value[1]);
            
            for(var i = 1; i< value.Length; i++)
            {
                
            }
        }

        



    }
}
