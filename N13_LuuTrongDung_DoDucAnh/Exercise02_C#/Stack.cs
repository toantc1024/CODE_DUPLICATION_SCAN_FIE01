using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class Stack<T>
    {
        public class Node
        {
            public T info;
            public Node pNext;
            public Node pPrev;

            public Node(T info)
            {
                this.info = info;
                pNext = null;
                pPrev = null;
            }
        }

        public Node head;
        public Node tail;
        public int count;

        public Stack()
        {
            Init();
        }

        public void Init()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public Node CreateNode(T x)
        {
            Node newNode = new Node(x);
            newNode.info = x;
            newNode.pNext = null;
            newNode.pPrev = null;
            return newNode;
        }

        public void Push(T x)
        {
            Node newNode = CreateNode(x);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.pPrev = tail;
                tail.pNext = newNode;
                tail = newNode;
            }
            count++;
        }

        public void Pop()
        {
            if (IsEmpty())
                return;

            tail = tail.pPrev;

            if (tail != null)
                tail.pNext = null;
            else
                head = null;
            count--;
        }

        public Node Peek()
        {
            if (!IsEmpty())
                return tail;
            return null;
        }

        public void PrintStack()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.pNext;
            }
            Console.WriteLine();
        }
    }

}
