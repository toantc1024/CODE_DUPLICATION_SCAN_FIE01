using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TYPE = System.Int32;

namespace CircularLinkedList
{
    public class Node
    {
        TYPE info;
        Node next;
        public TYPE Info { get => info; set => info = value; }
        public Node Next { get => next; set => next = value; }
        public Node() 
        {
            info = 0;
            next = null;
        }
        public Node(TYPE val)
        {
            info = val;
            next = null;
        }
        public Node(Node newNode)
        {
            info = newNode.info;
            next = newNode.next;
        }
    }
}
