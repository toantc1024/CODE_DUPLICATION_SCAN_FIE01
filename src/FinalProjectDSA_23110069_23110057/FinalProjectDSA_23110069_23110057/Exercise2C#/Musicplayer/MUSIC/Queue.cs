using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSIC
{
    public class Node
    {
        private Song info;
        Node next;

        public Song Info { get => info; set => info = value; }
        public Node Next { get => next; set => next = value; }
        public Node(Song x)
        {
            Info = x;
            Next = null;
        }
    }
    public class Queue
    {
        private Node pfront;
        private Node prear;

        public Node pRear { get => prear; set => prear = value; }
        public Node pFront { get => pfront; set => pfront = value; }
        public bool Empty()
        {
            return pfront == null;
        }
        public void EnQueue(Song song)
        {
            Node p = new Node(song);
            if (Empty())
            {
                pFront = pRear = p;
                return;
            }
            pRear.Next = p;
            pRear = p;
        }
        public Song DeQueue()
        {
            if (Empty())
                return null;

            Node temp = pFront;
            pFront = pFront.Next;

            if (pFront == null)
            {
                pRear = null;
            }

            return temp.Info;
        }
        public Song Front()
        {
            if (Empty())
            {
                Console.WriteLine("Empty Queue");
                return null;
            }
            return pFront.Info;
        }
        public void Display()
        {
            if (Empty())
            {
                Console.WriteLine("Queue is empty!");
                return;
            }

            Node temp = pFront;
            while (temp != null)
            {
                Console.Write(temp.Info + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}
