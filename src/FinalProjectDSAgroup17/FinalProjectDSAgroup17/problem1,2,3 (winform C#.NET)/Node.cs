using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalDataStructure
{
    internal class Node
    {
        public dynamic Data { get; set; }
        public Node Next { get; set; }

        public Node(dynamic data)
        {
            Data = data;
            Next = null;
        }
    }
}
