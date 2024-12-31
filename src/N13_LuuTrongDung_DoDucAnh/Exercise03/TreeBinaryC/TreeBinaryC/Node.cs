using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBinaryC
{
    public class Node
    {
        public string Key;
        public Node Left;
        public Node Right;

        public Node(string key)
        {
            Key = key;
            Left = Right = null;
        }
    }
}

