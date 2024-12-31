using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularLinkedList_CSharp
{
    public class Node
    {
        private Node next;
        private Song data;
        public Node Next { get => next; set => next = value; }
        public Song Data { get => data; set => data = value; }
        public Node()
        {
            Data = null;
            Next = null;
        }
        public Node(Song data)
        {
            Data = data;
            Next = null;
        }
        public static Node CreateNode(Song data)
        {
            return new Node(data);
        }
        public bool IsEmpty()
        {
            return Data == null;
        }   
    }
}