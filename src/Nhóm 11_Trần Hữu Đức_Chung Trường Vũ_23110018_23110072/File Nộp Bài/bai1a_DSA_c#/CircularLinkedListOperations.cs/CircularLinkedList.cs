using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListOperations.cs
{
    public class CircularLinkedList
    {
        private Node head;

        // Constructor:
        public CircularLinkedList()
        {
            head = null;
        }
        //  Initalize a list
        public void InitializeList()
        {
            Console.WriteLine("Enter the number of products: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number: ");
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for product {i + 1}:");

                Console.Write("Product name: ");
                string name = Console.ReadLine();

                float price;
                Console.Write("Product price: ");
                while (!float.TryParse(Console.ReadLine(), out price) || price < 0)
                {
                    Console.WriteLine("Invalid price. Please enter a non-negative number: ");
                }

                Product product = new Product(name, price);
                AddLast(CreateNode(product)); // Add product to the end of the list
            }

            Console.WriteLine("Product list has been initialized.");
        }


        // Check whether a node is empty or not
        public bool IsEmpty()
        {
            return head == null;
        }

        // Create a new node
        public Node CreateNode(Product product)
        {
            return new Node(product);
        }

        // Insert a new node at the beginning of the list
        public void AddFirst(Node newNode)
        {

            if (IsEmpty())
            {
                head = newNode;
                head.Next = head;
                head.Prev = head;
            }
            else
            {
                Node tail = head.Prev;
                newNode.Next = head;
                newNode.Prev = tail;
                head.Prev = newNode;
                tail.Next = newNode;
                head = newNode; // the difference
            }
        }

        // Insert a new node at the end of the list
        public void AddLast(Node newNode)
        {

            if (IsEmpty())
            {
                head = newNode;
                head.Next = head;
                head.Prev = head;
            }
            else
            {
                Node tail = head.Prev;
                newNode.Next = head;
                newNode.Prev = tail;
                tail.Next = newNode;
                head.Prev = newNode;
            }
        }

        // Insert a new node after a node of the list
        public void AddAfter(Node newNode, string afterProductName)
        {
            if (IsEmpty()) return;

            Node temp = head;
            do
            {
                if (temp.Data.Name == afterProductName)
                {
                    Node right = temp.Next;
                    temp.Next = newNode;
                    right.Prev = newNode;
                    newNode.Prev = temp;
                    newNode.Next = right;
                    return;
                }
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("The node to insert after was not found");
        }

        public void RemoveFirst()
        {
            if (IsEmpty()) return;

            if (head.Next == head)
            {

                head = null;
            }
            else
            {
                Node tail = head.Prev;
                head = head.Next;
                head.Prev = tail;
                tail.Next = head;
            }
        }
        public void RemoveLast()
        {
            if (IsEmpty()) return;

            if (head.Next == head)
            {
                head = null;
            }
            else
            {
                Node tail = head.Prev;
                Node newTail = tail.Prev;
                newTail.Next = head;
                head.Prev = newTail;
            }
        }
        //Remove a node after a node of the list
        public void RemoveAfter(string afterProductName)
        {
            Node temp = head;
            do
            {
                if (temp.Data.Name == afterProductName)
                {
                    Node nodeToRemove = temp.Next;

                    if (nodeToRemove == head) return; // doen not exist node after specific node

                    temp.Next = nodeToRemove.Next;
                    nodeToRemove.Next.Prev = temp;
                    return;
                }
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("The node to delete after was not found.");
        }
        // removenode
        public void RemoveNode(Node nodeToRemove)
        {
            if (IsEmpty() || nodeToRemove == null) return;


            if (nodeToRemove == head)
            {
                RemoveFirst();
            }

            else if (nodeToRemove == head.Prev)
            {
                RemoveLast();
            }
            else
            {
                nodeToRemove.Prev.Next = nodeToRemove.Next;
                nodeToRemove.Next.Prev = nodeToRemove.Prev;
            }
        }

        // Search a node by product name
        public Node SearchNode(string productName)
        {
            if (IsEmpty())
            {
                Console.WriteLine("the list is empty");
                return null;
            }

            Node temp = head;
            do
            {
                if (temp.Data.Name == productName)
                {
                    return temp;
                }
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine($"No product with the specified name was found.: {productName}");
            return null;
        }

        // Search nodes in the list satisfying a specific criteria. 
        public List<Node> SearchNodesByCriteria(Func<Product, bool> criteria) //Refer to Func<Product, bool> criteria from GPT.
        {
            List<Node> result = new List<Node>();
            Node temp = head;
            do
            {
                if (criteria(temp.Data))
                {
                    result.Add(temp);
                }
                temp = temp.Next;
            } while (temp != head);

            return result;
        }

        // Print the list
        public void PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("the list is empty");
                return;
            }

            Node temp = head;
            do
            {
                Console.WriteLine($"name: {temp.Data.Name}, price: {temp.Data.Price}");
                temp = temp.Next;
            } while (temp != head);
        }
        // sort the list------------------------------------------------------------------------------------------------------------
        // declare
        public int CompareByPrice(Product p1, Product p2)
        {
            return p2.Price.CompareTo(p1.Price);
        }
        public int CompareByName(Product p1, Product p2)
        {
                return string.Compare(p1.Name, p2.Name);
        }
        // selection sort
        public void SelectionSort()
        {
            if (head == null) return;

            CircularLinkedList sortedList = new CircularLinkedList();

            while (head != null)
            {
                Node min = head;
                Node current = head.Next;

                // find the min node
                while (current != head)
                {
                    if (compareMethod(min.Data, current.Data) > 0)
                    {
                        min = current;
                    }
                    current = current.Next;
                }
                // throw this node to other list
                RemoveNode(min);
                sortedList.AddFirst(min);
            }
            // update
            this.head = sortedList.head;
        }
        // quicksort
        private int distance (Node p)
        {
            int count = 0;
            for (Node i = head; i != p; i = i.Next) count++;
            return count;
        }

        private Node back ( int step)
        {
            Node runner = head;
            for (int i = 1; i <=step; i++) runner = runner.Next;
            return runner;
        }
        private  Node Partition(Node low, Node high)
        {
            Node pivot = high;
            Node i = low;
            while (i != pivot)
            {
                if  (i.Data.Price < pivot.Data.Price)
                {
                    Node j = i.Next;
                    RemoveNode(i);
                    AddAfter(i, pivot.Data.Name);
                    i = j;
                }
                else i = i.Next;
            }

            return pivot;
        }

        public void QuickSortRecursive(Node low, Node high)
        {

            if (low != high) 
            {
                if (low.Next == high && low.Data.Price > high.Data.Price) return; // loại trường hợp kề đúng vị trí 4 3
                int dislow = distance(low);
                int dishigh = distance(high);
                Node pivot = Partition(low, high);
                low = back(dislow);
                high = back(dishigh);
                if (pivot != high)
                {
                    QuickSortRecursive(low, pivot);
                    QuickSortRecursive(pivot.Next, high);
                }
                else
                {
                    pivot = pivot.Prev;
                    QuickSortRecursive(low, pivot);
                    QuickSortRecursive(pivot.Next, high);
                }
            }
        }
        public  void QuickSort()
        {

            if (head == null) return;

            Node tail = head.Prev;
            QuickSortRecursive(head, tail);
        }

        // 3 operations -------------------------------------------------------------------------------------------------------------
        // Merge 2 lists
        public void MergeSortedLists(CircularLinkedList otherList)
        {
            if (otherList.IsEmpty()) return; // other list is empty

            if (this.IsEmpty())// this list is empty
            {
                this.head = otherList.head;
                return;
            }
            // 2 list is not empty
            Node tail = this.head.Prev;
            Node othertail = otherList.head.Prev;

            tail.Next = otherList.head;
            otherList.head.Prev = tail;
            othertail.Next = head;
            head.Prev = othertail;
        }
        // remove all nodes satisfying a specific criteria
        public void RemoveNodesByCondition(Func<Product, bool> condition)
        {
            if (IsEmpty()) return;
            CircularLinkedList otherList = new CircularLinkedList();
            Node current = head;

            do
            {
                if (condition(current.Data))
                {
                    
                    current = current.Next;
                }
                else
                {
                    
                    Node tmp = current.Next;
                    RemoveNode(current);
                    otherList.AddFirst(current);
                    current = tmp;
                }
            } while (!IsEmpty() && current != head);
            head = otherList.head;
        }



        // Reverse the list
        public void ReverseList()
        {
            CircularLinkedList otherList = new CircularLinkedList();
            if (IsEmpty()) return;
            Node runner = head;
            do 
            {
                Node tmp = runner.Next;
                RemoveNode(runner);
                otherList.AddFirst(runner);
                runner = tmp;
            }
            while (!IsEmpty());
            head = otherList.head;
        }


    }
}