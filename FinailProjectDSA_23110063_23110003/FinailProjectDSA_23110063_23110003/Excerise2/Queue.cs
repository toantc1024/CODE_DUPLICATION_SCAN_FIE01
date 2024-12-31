using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueProject
{
    public class Node
    {
        public PrintJob Info { get; set; } // Node information
        public Node Next { get; set; } // Pointer to the next node
    }

    public class Queue
    {
        private Node front; // Points to the front of the queue
        private Node rear;  // Points to the rear of the queue

        
        public Queue()
        {
            front = null;
            rear = null;
        }

        // Create the node of queue
        public Node CreateNode(PrintJob data)
        {
            Node newNode = new Node();
            newNode.Info = data;
            newNode.Next = null;
            return newNode;
        }

        // Initialize queue
        public void InitQueue()
        {
            front = null;
            rear = null;
        }

        // Add node to the queue (The generated node will be added at the end of queue)
        public void EnQueue(PrintJob data)
        {
            Node newNode = CreateNode(data);
            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
           
        }

        // Delete node to the queue (The first node of the queue will be dequeued)
        public Node DeQueue()
        {
            if (front == null)
            {
                return null;
            }
            Node temp = front;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            return temp;
            
        }

        // Returns the first node of the queue
        public Node FrontNode()
        {
            return front; 
        }

        //Check the queue is empty
        public bool IsEmptyQueue()
        {
            return front == null;
        }

        // Print all node of the queue
        public void PrintQueue()
        {
            Node temp = front;
            string output = "";
            while (temp != null)
            {
                output += temp.Info + "\n";
                temp = temp.Next;
            }
            MessageBox.Show(output);
        }

        // Reset queue
        public void Clear()
        {
            front = null;
            rear = null;
        }
    }
}
