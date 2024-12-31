using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListOperations.cs
{
    public class Node
    {
        // private fields
        private Product data;
        private Node next;
        private Node prev;

        // public properties với cả getter và setter
        public Product Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        // Constructor
        public Node(Product product)
        {
            data = product;
            next = null; 
            prev = null; 
        }
    }


}
