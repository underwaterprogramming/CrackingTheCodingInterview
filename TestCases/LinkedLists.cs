using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CrackingTheCodingInterview.LinkedLists;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrackingTheCodingInterview.Library;

namespace TestCases
{
    [TestClass]
    public class LinkedLists
    {
        static string[] words = { "one", "two", "three", "one", "four", "three" };
        static string[] finalWords = { "one", "two", "three", "four" };

        [TestMethod]
        public void RemoveDupsTest1()
        {
            LinkedList<string> ll = new LinkedList<string>(words);
            RemoveDups.Solution1(ll);
            int i = 0;
            for(LinkedListNode<string> l = ll.First; l != null; l = l.Next)
            {
                Assert.AreEqual(l.Value, finalWords[i]);
                i++;
            }
        }

        [TestMethod]
        public void RemoveDupsTest2()
        {
            Node<string> node = new Node<string>(words);
            RemoveDups.Solution2(node);
            int i = 0;
            while(node != null)
            {
                Assert.AreEqual(node.Data, finalWords[i]);
                i++;
                node = node.Next;
            }
        }

        [TestMethod]
        public void ReturnKToLastNodeTest1()
        {
            SinglyLinkedNodes<String> singlyLinkedNodes = new SinglyLinkedNodes<string>(words);
            int index = 2;
            var result = ReturnKthToLastNode.Solution1(singlyLinkedNodes, index);
            Assert.AreEqual(result.Length, words.Length - index);
            for(int i = 0; i< words.Length - 2; i++)
            {
                Assert.AreEqual(words[i+index], result[i].Data);
            }
        }

        [TestMethod]
        public void ReturnKToLastNodeTest2()
        {
            Node<String> singlyLinkedNodes = new Node<string>(words);
            int index = 2;
            var result = ReturnKthToLastNode.Solution2(singlyLinkedNodes, index);
            Assert.AreNotEqual(result, new Node<string>(), "Node is empty");
            for (int i = 0; i < words.Length - 2; i++)
            {
                Assert.AreNotEqual(result, null, "Node is Null");
                Assert.AreEqual(words[i + index], result.Data, "Data are not equal");
                result = result.Next;
            }
        }
    }
}
