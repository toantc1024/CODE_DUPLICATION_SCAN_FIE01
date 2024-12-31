using System;
using System.Collections.Generic;

namespace CircularLinkedListDemo
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Title: {Title}, Author: {Author}, Price: ${Price:F2}";
        }
    }

    public class Node
    {
        public Book Data { get; set; }
        public Node Next { get; set; }

        public Node(Book book)
        {
            Data = book;
            Next = this; 
        }
    }

    public class CircularLinkedList
    {
        private Node head;

        // Initialize list
        public CircularLinkedList()
        {
            head = null;
        }

        // Check if empty
        public bool IsEmpty()
        {
            return head == null;
        }

        // Insert at beginning
        public void InsertAtBeginning(Book book)
        {
            Node newNode = new Node(book);

            if (IsEmpty())
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            newNode.Next = head;
            temp.Next = newNode;
            head = newNode;
        }

        // Insert at end
        public void InsertAtEnd(Book book)
        {
            if (IsEmpty())
            {
                InsertAtBeginning(book);
                return;
            }

            Node newNode = new Node(book);
            Node temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
            newNode.Next = head;
        }

        // Insert after node
        public void InsertAfterNode(Node prevNode, Book book)
        {
            if (prevNode == null)
                return;

            Node newNode = new Node(book);
            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
        }

        // Remove first node
        public void RemoveFirst()
        {
            if (IsEmpty())
                return;

            if (head.Next == head)
            {
                head = null;
                return;
            }

            Node temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }

            temp.Next = head.Next;
            head = head.Next;
        }

        // Remove last node
        public void RemoveLast()
        {
            if (IsEmpty())
                return;

            if (head.Next == head)
            {
                head = null;
                return;
            }

            Node temp = head;
            Node prev = null;

            while (temp.Next != head)
            {
                prev = temp;
                temp = temp.Next;
            }

            prev.Next = head;
        }

        // Remove after node
        public void RemoveAfterNode(Node prevNode)
        {
            if (prevNode == null || prevNode.Next == head)
                return;

            prevNode.Next = prevNode.Next.Next;
        }

        // Search by ID
        public Node SearchById(int id)
        {
            if (IsEmpty())
                return null;

            Node temp = head;
            do
            {
                if (temp.Data.Id == id)
                    return temp;
                temp = temp.Next;
            } while (temp != head);

            return null;
        }

        // Search by price range
        public List<Book> SearchByPriceRange(decimal minPrice, decimal maxPrice)
        {
            List<Book> results = new List<Book>();
            if (IsEmpty())
                return results;

            Node temp = head;
            do
            {
                if (temp.Data.Price >= minPrice && temp.Data.Price <= maxPrice)
                {
                    results.Add(temp.Data);
                }
                temp = temp.Next;
            } while (temp != head);

            return results;
        }

        // Print list
        public void PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node temp = head;
            do
            {
                Console.WriteLine(temp.Data.ToString());
                temp = temp.Next;
            } while (temp != head);
        }

        // Selection Sort
        public void SelectionSort()
        {
            if (IsEmpty() || head.Next == head)
                return;

            Node current = head;
            do
            {
                Node min = current;
                Node temp = current.Next;

                while (temp != head)
                {
                    if (temp.Data.Id < min.Data.Id)
                    {
                        min = temp;
                    }
                    temp = temp.Next;
                }

                if (min != current)
                {
                    Book tempBook = current.Data;
                    current.Data = min.Data;
                    min.Data = tempBook;
                }

                current = current.Next;
            } while (current != head);
        }
        //Quicksort
        public void QuickSort()
        {
            if (IsEmpty() || head.Next == head)
                return;

            Node tail = GetTail(head);
            QuickSortRecursive(head, tail);
        }

        private Node GetTail(Node start)
        {
            Node temp = start;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            return temp;
        }

        private void QuickSortRecursive(Node start, Node end)
        {
            if (start == null || start == end || end.Next == start)
                return;

            Node pivotPrev = Partition(start, end, out Node pivot);
            QuickSortRecursive(start, pivotPrev);

            if (pivot != null && pivot.Next != null && pivot.Next != start)
                QuickSortRecursive(pivot.Next, end);
        }

        private Node Partition(Node start, Node end, out Node pivot)
        {
            int pivotValue = end.Data.Id;
            Node pivotPrev = start;
            Node current = start;
            Node prev = null;

            while (current != end)
            {
                // Check if current node should move before the pivot
                if (current.Data.Id < pivotValue || (current.Data.Id == pivotValue && IsStable(current, end)))
                {
                    SwapData(pivotPrev, current);
                    prev = pivotPrev;
                    pivotPrev = pivotPrev.Next;
                }
                current = current.Next;
            }

            SwapData(pivotPrev, end);
            pivot = pivotPrev;
            return prev;
        }
        private bool IsStable(Node current, Node pivot)
        {
            
            return string.Compare(current.Data.Title, pivot.Data.Title, StringComparison.Ordinal) <= 0;
        }

        private void SwapData(Node a, Node b)
        {
            var temp = a.Data;
            a.Data = b.Data;
            b.Data = temp;
        }
 

        // 1. Merge two lists
        public void MergeWith(CircularLinkedList otherList)
        {
            if (otherList.IsEmpty())
                return;

            if (IsEmpty())
            {
                head = otherList.head;
                return;
            }

            Node tail1 = GetTail(head);
            Node tail2 = GetTail(otherList.head);

            tail1.Next = otherList.head;
            tail2.Next = head;
        }

        // 2. Remove books by price range
        public void RemoveByPriceRange(decimal minPrice, decimal maxPrice)
        {
            if (IsEmpty())
                return;

            // Remove from beginning if necessary
            while (!IsEmpty() && head.Data.Price >= minPrice && head.Data.Price <= maxPrice)
            {
                RemoveFirst();
            }

            if (IsEmpty())
                return;

            Node current = head;
            Node prev = null;

            do
            {
                if (current.Data.Price >= minPrice && current.Data.Price <= maxPrice)
                {
                    prev.Next = current.Next;
                    current = current.Next;
                }
                else
                {
                    prev = current;
                    current = current.Next;
                }
            } while (current != head);
        }

        // 3. Calculate average price
        public decimal CalculateAveragePrice()
        {
            if (IsEmpty())
                return 0;

            decimal total = 0;
            int count = 0;
            Node temp = head;

            do
            {
                total += temp.Data.Price;
                count++;
                temp = temp.Next;
            } while (temp != head);

            return total / count;
        }
    }

   
   
}