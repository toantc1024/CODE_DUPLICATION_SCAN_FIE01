using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Node
    {
        public Book Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(Book data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}
