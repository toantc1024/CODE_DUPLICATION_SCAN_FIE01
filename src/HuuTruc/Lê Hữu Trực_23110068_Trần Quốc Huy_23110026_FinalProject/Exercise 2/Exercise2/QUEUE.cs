using Exercise2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class QUEUE
    {

        Node front = new Node();
        Node rear = new Node();
        public Node Front { get { return front; } set { front = value; } }
        public Node Rear { get { return rear; } set { rear = value; } }
        public QUEUE()
        {
            Front = null;
            Rear = null;
        }
        public void Push(string title, string filePath)
        {
            Node p = new Node(title, filePath);
            if (rear == null)
            {
                rear = front = p;
                return;
            }
            rear.next = p;
            p.prev = rear; // Set the prev pointer of the new node
            rear = p;
        }

        public Node Pop()
        {
            if (front != null)
            {
                Node temp = front;
                front = front.next;
                if (front == null)
                {
                    rear = null;
                }
                return temp;
            }
            else
            {
                return null; // Queue is empty
            }
        }
        public bool IsEmptyQueue()
        {
            return front == null;
        }
        public bool Contains(string title)
        {
            Node current = Front;
            while (current != null)
            {
                if (current.Title == title)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        public void ShuffleQueue()
        {
            if (IsEmptyQueue() || Front.next == null) return; // No need to shuffle if 0 or 1 item

            // Step 1: Extract all nodes into a list
            List<Node> nodes = new List<Node>();
            Node current = Front;
            while (current != null)
            {
                nodes.Add(current);
                current = current.next;
            }

            // Step 2: Shuffle the list
            Random random = new Random();
            nodes = nodes.OrderBy(x => random.Next()).ToList();

            // Step 3: Rebuild the queue with the shuffled nodes
            Front = nodes[0];
            Rear = nodes[nodes.Count - 1];
            for (int i = 0; i < nodes.Count; i++)
            {
                nodes[i].next = i < nodes.Count - 1 ? nodes[i + 1] : null;
                nodes[i].prev = i > 0 ? nodes[i - 1] : null;
            }
        }
        public void Partition(QUEUE myQueue, string pivot, QUEUE less, QUEUE greater)
        {
            while (myQueue.IsEmptyQueue() == false)
            {
                Node node = myQueue.Pop();
                if (string.Compare(node.Title, pivot, StringComparison.Ordinal) < 0)
                    less.Push(node.Title, node.FilePath);
                else
                    greater.Push(node.Title, node.FilePath);
            }
        }

        public void ReverseQueue(QUEUE myQueue)
        {
            QUEUE temp = new QUEUE();
            while (myQueue.IsEmptyQueue() == false)
            {
                Node tempNode = myQueue.Pop();
                temp.Push(tempNode.Title, tempNode.FilePath);
            }
            myQueue.front = temp.front;
        }
        public void QuickSortQueue(QUEUE myQueue)
        {
            if (myQueue.IsEmptyQueue()) return;

            Node pivotNode = myQueue.Pop();
            string pivot = pivotNode.Title;

            QUEUE less = new QUEUE();
            QUEUE greater = new QUEUE();

            Partition(myQueue, pivot, less, greater);

            QuickSortQueue(less);
            QuickSortQueue(greater);

            ReverseQueue(greater);
            ReverseQueue(less);

            while (!less.IsEmptyQueue())
            {
                Node tempNode = less.Pop();
                myQueue.Push(tempNode.Title, tempNode.FilePath);
            }
            myQueue.Push(pivotNode.Title, pivotNode.FilePath);
            while (!greater.IsEmptyQueue())
            {
                Node tempNode = greater.Pop();
                myQueue.Push(tempNode.Title, tempNode.FilePath);
            }
        }
        public void ReverseQueueForDesc(QUEUE myQueue)
        {
            Node current = myQueue.Front;
            Node temp;

            while (current != null)
            {
                temp = current.next;
                current.next = current.prev;
                current.prev = temp;
                current = temp;
            }

            // Swap front and rear
            temp = myQueue.Front;
            myQueue.Front = myQueue.Rear;
            myQueue.Rear = temp;
        }
    }
}