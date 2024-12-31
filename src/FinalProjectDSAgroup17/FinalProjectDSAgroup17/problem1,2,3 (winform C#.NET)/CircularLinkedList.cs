using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalDataStructure
{
    internal class CircularLinkedList
    {
         private Node tail;

        public CircularLinkedList()
        {
            tail = null;
        }

        public bool IsEmpty() => tail == null;


        public Node GetTail()
        {
            return this.tail; // Return the tail node
        }


        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                newNode.Next = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = tail.Next;
                tail.Next = newNode;
            }
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                newNode.Next = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = tail.Next;
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public void InsertAfter(int afterValue, int data)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node current = tail.Next;
            do
            {
                if (current.Data == afterValue)
                {
                    Node newNode = new Node(data);
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    if (current == tail)
                        tail = newNode; 
                    return;
                }
                current = current.Next;
            } while (current != tail.Next);

            Console.WriteLine($"Node with value {afterValue} not found.");
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (tail.Next == tail) 
            {
                tail = null;
            }
            else
            {
                tail.Next = tail.Next.Next;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (tail.Next == tail) 
            {
                tail = null;
            }
            else
            {
                Node current = tail.Next;
                while (current.Next != tail)
                {
                    current = current.Next;
                }
                current.Next = tail.Next;
                tail = current;
            }
        }

        public void RemoveAfter(int afterValue)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node current = tail.Next;
            do
            {
                if (current.Data == afterValue)
                {
                    if (current.Next == tail)
                        tail = current; 
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            } while (current != tail.Next);

            Console.WriteLine($"Node with value {afterValue} not found.");
        }

        public Node Search(int value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return null;
            }

            Node current = tail.Next;
            do
            {
                if (current.Data == value)
                    return current;
                current = current.Next;
            } while (current != tail.Next);

            Console.WriteLine($"Node with value {value} not found.");
            return null;
        }

        public void PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node current = tail.Next;
            do
            {
                Console.Write($"{current.Data} -> ");
                current = current.Next;
            } while (current != tail.Next);
            Console.WriteLine("(Back to Head)");
        }

        public void SelectionSort()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node current = tail.Next;
            do
            {
                Node minNode = current;
                Node next = current.Next;

                while (next != tail.Next)
                {
                    if (next.Data < minNode.Data)
                        minNode = next;
                    next = next.Next;
                }

                // Swap data
                int temp = current.Data;
                current.Data = minNode.Data;
                minNode.Data = temp;

                current = current.Next;
            } while (current != tail.Next);
        }
    }
}
