using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList_C_
{
    public class Node
    {
        private Exercise data;
        private Node ptrNext;
        private Node ptrPre;

        public Exercise Data { get => data; set => data = value; }
        public Node PtrNext { get => ptrNext; set => ptrNext = value; }
        public Node PtrPre { get => ptrPre; set => ptrPre = value; }

        public Node(Exercise data)
        {
            Data = data;
            PtrNext = null;
            PtrPre = null;
        }

    }
}
