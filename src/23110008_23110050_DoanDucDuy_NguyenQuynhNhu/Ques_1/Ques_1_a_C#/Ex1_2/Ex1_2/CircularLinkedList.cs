using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_2
{
    public class CircularLinkedList
    {
        public Node head;

        public CircularLinkedList()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void PrintList()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            Node current = head.next;
            do
            {
                Console.Write(current.data + " ");
                current = current.next;
            } while (current != head.next);
            Console.WriteLine();
        }

        public Node AddToEmpty(int data)
        {
            if (head != null) return head;

            Node newNode = new Node(data);
            head = newNode;
            return head;
        }

        public Node InsertAtBeginning(int data)
        {
            if (head == null) return AddToEmpty(data);

            Node newNode = new Node(data);
            newNode.next = head.next;
            head.next = newNode;
            return head;
        }

        public Node InsertAtEnd(int data)
        {
            if (head == null) return AddToEmpty(data);

            Node newNode = new Node(data);
            newNode.next = head.next;
            head.next = newNode;
            head = newNode;
            return head;
        }

        public Node InsertAfterNode(int data, int item)
        {
            if (head == null) return null;

            Node temp = head.next;
            do
            {
                if (temp.data == item)
                {
                    Node newNode = new Node(data);
                    newNode.next = temp.next;
                    temp.next = newNode;
                    if (temp == head) head = newNode;
                    return head;
                }
                temp = temp.next;
            } while (temp != head.next);

            Console.WriteLine("Node with value %d not found.", item);
            return head;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty, cannot remove the first node.");
                return;
            }

            if (head == head.next)
            {
                head = null;
                Console.WriteLine("First node removed. List is now empty.");
                return;
            }

            Node first = head.next;
            Node last = head;

            while (last.next != head)
            {
                last = last.next;
            }

            head.next = first.next;

            last.next = head;

            Console.WriteLine("First node removed.");
        }

        public void RemoveLast()
        {
            if (head == null) return;
            if (head.next == head)
            {
                head = null;
                return;
            }

            Node temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }

            temp.next = head.next;
            head = temp;
            Console.WriteLine("Last node removed.");
        }

        public void RemoveAfter(int key)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty, cannot remove after a node.");
                return;
            }

            Node temp = head;

            do
            {
                if (temp.data == key)
                {
                    if (temp.next != head)  
                    {
                        Node nodeToDelete = temp.next;
                        temp.next = nodeToDelete.next;

                        if (nodeToDelete == head)
                        {
                            head = temp.next;
                        }

                        Console.WriteLine($"Node after {key} removed.");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("No node after the specified key to remove.");
                        return;
                    }
                }
                temp = temp.next;
            } while (temp != head);  

            Console.WriteLine("Node with the specified key not found.");
        }

        public bool SearchNode(int target)
        {
            if (head == null) return false;

            Node temp = head;
            do
            {
                if (temp.data == target) return true;
                temp = temp.next;
            } while (temp != head);
            return false;
        }

        public void SearchNodesByCriteria(Func<int, bool> criteria)
        {
            if (head == null) return;

            Node temp = head;
            bool found = false;
            do
            {
                if (criteria(temp.data))
                {
                    Console.Write(temp.data + " ");
                    found = true;
                }
                temp = temp.next;
            } while (temp != head);

            if (!found) Console.WriteLine("No nodes match the criteria.");
        }

        public static bool IsEven(int value) => value % 2 == 0;

        public static bool IsGreaterThanFive(int value) => value > 5;

        public void SelectionSort()
        {
            if (head == null || head.next == head) return;

            Node i, j;
            int temp;

            for (i = head.next; i.next != head.next; i = i.next)
            {
                Node minNode = i;
                for (j = i.next; j != head.next; j = j.next)
                {
                    if (j.data < minNode.data)
                    {
                        minNode = j;
                    }
                }

                if (minNode != i)
                {
                    temp = i.data;
                    i.data = minNode.data;
                    minNode.data = temp;
                }
            }
        }

        public void RemoveDuplicates()
        {
            if (head == null) return;

            Node current = head;
            do
            {
                Node prev = current;
                Node temp = current.next;

                while (temp != head)
                {
                    if (current.data == temp.data)
                    {
                        prev.next = temp.next;
                        temp = prev.next;
                    }
                    else
                    {
                        prev = temp;
                        temp = temp.next;
                    }
                }

                current = current.next;
            } while (current != head);
        }

        public Node FindMiddle()
        {
            if (head == null || head.next == head) return head;

            Node slow = head.next;
            Node fast = head.next;
            while (fast != head && fast.next != head)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
        public void RemoveNodesByCriteria(Func<int, bool> criteria)
        {
            if (head == null) return;

            Node current = head.next;
            Node prev = head;

            do
            {
                if (criteria(current.data))
                {
                    prev.next = current.next;
                    current = prev.next;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
            } while (current != head.next);
        }

        public void ReverseList()
        {
            if (head == null || head.next == head) return;  

            Node prev = null;
            Node current = head;
            Node nextNode;

            do
            {
                nextNode = current.next;
                current.next = prev;
                prev = current;
                current = nextNode;
            } 
            while (current != head);

            head.next = prev;  
            head = prev;
            Console.WriteLine("List reversed.");
        }
    }

}
