using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal2
{
    internal class Node
    {
        public Book data;
        public Node next;

        public Node(Book data) 
        {
            this.data = data;
            next = null;
        }
    }
}
