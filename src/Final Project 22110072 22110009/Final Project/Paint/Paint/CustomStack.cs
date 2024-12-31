using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Paint
{
    public class Node
    {
        public Bitmap Data;
        public Node Next;

        public Node(Bitmap data)
        {
            Data = data;
            Next = null;
        }
    }

    public class Stack
    {
        private Node top;

        public Stack()
        {
            top = null;
        }

        public void Push(Bitmap data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public Bitmap Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            Bitmap data = top.Data;
            top = top.Next;
            return data;
        }

        public Bitmap Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void Clear()
        {
            top = null;
        }
    }
}
