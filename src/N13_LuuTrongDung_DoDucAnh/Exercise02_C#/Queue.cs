using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Structures
{
    public class Queue<T>
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

        public Node front;
        public Node rear;
        public int count;

        public Queue()
        {
            Init();
        }

        public void Init()
        {
            front = null;
            rear = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return rear == null;
        }

        public Node CreateNode(T x)
        {
            Node newNode = new Node(x);
            return newNode;
        }

        public void PrintQueue()
        {
            if (IsEmpty())
                return;

            Node p = front;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.pNext;
            }
            Console.WriteLine();
        }

        public void EnQueue(T x)
        {
            Node newNode = CreateNode(x);
            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                newNode.pPrev = rear;
                rear.pNext = newNode;
                rear = newNode;
            }
            count++;
        }

        public void DeQueue()
        {
            if (IsEmpty())
                return;

            front = front.pNext;
            if (front != null)
                front.pPrev = null;
            else
                rear = null;
            count--;
        }

        public Node Front()
        {
            return front;
        }
    }

}
