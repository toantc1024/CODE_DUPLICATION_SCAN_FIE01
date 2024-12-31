using System;
using System.Collections.Generic;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class CircularLinkedList
{
    private Node tail;

    public CircularLinkedList()
    {
        tail = null;
    }

    // Initialize the list
    public void InitializeList()
    {
        tail = null;
    }

    // Check if the list is empty
    public bool IsEmpty()
    {
        return tail == null;
    }

    // Insert at the beginning
    public void InsertAtBeginning(int data)
    {
        Node newNode = new Node(data);
        if (IsEmpty())
        {
            tail = newNode;
            tail.Next = tail;
        }
        else
        {
            newNode.Next = tail.Next;
            tail.Next = newNode;
        }
    }

    // Insert at the end
    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);
        if (IsEmpty())
        {
            tail = newNode;
            tail.Next = tail;
        }
        else
        {
            newNode.Next = tail.Next;
            tail.Next = newNode;
            tail = newNode;
        }
    }

    // Insert after a node with specific value
    public void InsertAfter(int afterValue, int data)
    {
        if (IsEmpty()) return;

        Node current = tail.Next;
        do
        {
            if (current.Data == afterValue)
            {
                Node newNode = new Node(data);
                newNode.Next = current.Next;
                current.Next = newNode;
                if (current == tail) tail = newNode;
                return;
            }
            current = current.Next;
        } while (current != tail.Next);
    }

    // Remove the first node
    public void RemoveFirst()
    {
        if (IsEmpty()) return;

        Node first = tail.Next;
        if (first == tail)
        {
            tail = null;
        }
        else
        {
            tail.Next = first.Next;
        }
    }

    // Remove the last node
    public void RemoveLast()
    {
        if (IsEmpty()) return;

        Node current = tail.Next;
        if (current == tail)
        {
            tail = null;
        }
        else
        {
            while (current.Next != tail)
            {
                current = current.Next;
            }
            current.Next = tail.Next;
            tail = current;
        }
    }

    // Remove a node after a specific value
    public void RemoveAfter(int afterValue)
    {
        if (IsEmpty()) return;

        Node current = tail.Next;
        do
        {
            if (current.Data == afterValue && current.Next != tail.Next)
            {
                Node temp = current.Next;
                current.Next = temp.Next;
                if (temp == tail) tail = current;
                return;
            }
            current = current.Next;
        } while (current != tail.Next);
    }

    // Search for a node with a specific value
    public Node Search(int value)
    {
        if (IsEmpty()) return null;

        Node current = tail.Next;
        do
        {
            if (current.Data == value)
            {
                return current;
            }
            current = current.Next;
        } while (current != tail.Next);

        return null;
    }

    // Search for nodes satisfying a specific criteria
    public List<int> SearchByCriteria(Predicate<int> criteria)
    {
        List<int> result = new List<int>();
        if (IsEmpty()) return result;

        Node current = tail.Next;
        do
        {
            if (criteria(current.Data))
            {
                result.Add(current.Data);
            }
            current = current.Next;
        } while (current != tail.Next);

        return result;
    }

    // Print the list
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
            Console.Write(current.Data + " ");
            current = current.Next;
        } while (current != tail.Next);
        Console.WriteLine();
    }

    // Selection sort
    public void SelectionSort()
    {
        if (IsEmpty()) return;

        Node current = tail.Next;
        do
        {
            Node minNode = current;
            Node inner = current.Next;
            while (inner != tail.Next)
            {
                if (inner.Data < minNode.Data)
                {
                    minNode = inner;
                }
                inner = inner.Next;
            }
            int temp = current.Data;
            current.Data = minNode.Data;
            minNode.Data = temp;

            current = current.Next;
        } while (current != tail.Next);
    }

    // Quick sort
    public void QuickSort(Node start, Node end)
    {
        if (start == null || start == end || start.Next == end)
            return;

        Node pivotPrev = Partition(start, end);
        QuickSort(start, pivotPrev);
        if (pivotPrev != null && pivotPrev == start)
            QuickSort(pivotPrev.Next, end);
        else if (pivotPrev != null && pivotPrev.Next != null)
            QuickSort(pivotPrev.Next.Next, end);
    }

    private Node Partition(Node start, Node end)
    {
        if (start == end || start == null || end == null)
            return start;

        Node pivotPrev = start;
        Node current = start;
        int pivot = end.Data;

        while (start != end)
        {
            if (start.Data < pivot)
            {
                pivotPrev = current;
                int temp = current.Data;
                current.Data = start.Data;
                start.Data = temp;
                current = current.Next;
            }
            start = start.Next;
        }

        int temp1 = current.Data;
        current.Data = pivot;
        end.Data = temp1;

        return pivotPrev;
    }

    public void QuickSort()
    {
        if (!IsEmpty())
        {
            QuickSort(tail.Next, tail);
        }
    }

    // Proposed operations
    public void Merge(CircularLinkedList other)
    {
        if (other.IsEmpty()) return;

        if (IsEmpty())
        {
            tail = other.tail;
        }
        else
        {
            Node temp = tail.Next;
            tail.Next = other.tail.Next;
            other.tail.Next = temp;
            tail = other.tail;
        }
        other.tail = null;
    }

    public void RemoveByCriteria(Predicate<int> criteria)
    {
        if (IsEmpty()) return;

        Node current = tail.Next;
        Node prev = tail;
        do
        {
            if (criteria(current.Data))
            {
                if (current == tail)
                {
                    tail = prev;
                }
                prev.Next = current.Next;
                current = prev.Next;
            }
            else
            {
                prev = current;
                current = current.Next;
            }
        } while (current != tail.Next);
    }

    public CircularLinkedList CopyList()
    {
        CircularLinkedList newList = new CircularLinkedList();
        if (IsEmpty()) return newList;

        Node current = tail.Next;
        do
        {
            newList.InsertAtEnd(current.Data);
            current = current.Next;
        } while (current != tail.Next);

        return newList;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CircularLinkedList list = new CircularLinkedList();
        int choice;

        do
        {
            Console.WriteLine("\n--- Circular Linked List Menu ---");
            Console.WriteLine("1. Initialize list");
            Console.WriteLine("2. Insert at beginning");
            Console.WriteLine("3. Insert at end");
            Console.WriteLine("4. Insert after a specific value");
            Console.WriteLine("5. Remove first node");
            Console.WriteLine("6. Remove last node");
            Console.WriteLine("7. Remove a node after a specific value");
            Console.WriteLine("8. Search for a value");
            Console.WriteLine("9. Search nodes by criteria (greater than a value)");
            Console.WriteLine("10. Print list");
            Console.WriteLine("11. Sort list (Selection sort)");
            Console.WriteLine("12. Sort list (Quick sort)");
            Console.WriteLine("13. Merge another list");
            Console.WriteLine("14. Remove nodes by criteria (less than a value)");
            Console.WriteLine("15. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    list.InitializeList();
                    Console.WriteLine("List initialized.");
                    break;

                case 2:
                    Console.Write("Enter value to insert at the beginning: ");
                    int valueAtBeginning = int.Parse(Console.ReadLine());
                    list.InsertAtBeginning(valueAtBeginning);
                    break;

                case 3:
                    Console.Write("Enter value to insert at the end: ");
                    int valueAtEnd = int.Parse(Console.ReadLine());
                    list.InsertAtEnd(valueAtEnd);
                    break;

                case 4:
                    Console.Write("Enter the value after which to insert: ");
                    int afterValue = int.Parse(Console.ReadLine());
                    Console.Write("Enter the value to insert: ");
                    int valueAfter = int.Parse(Console.ReadLine());
                    list.InsertAfter(afterValue, valueAfter);
                    break;

                case 5:
                    list.RemoveFirst();
                    Console.WriteLine("First node removed.");
                    break;

                case 6:
                    list.RemoveLast();
                    Console.WriteLine("Last node removed.");
                    break;

                case 7:
                    Console.Write("Enter the value after which to remove a node: ");
                    int removeAfterValue = int.Parse(Console.ReadLine());
                    list.RemoveAfter(removeAfterValue);
                    break;

                case 8:
                    Console.Write("Enter the value to search: ");
                    int searchValue = int.Parse(Console.ReadLine());
                    var node = list.Search(searchValue);
                    Console.WriteLine(node != null ? "Value found in the list." : "Value not found.");
                    break;

                case 9:
                    Console.Write("Enter the value to find nodes greater than: ");
                    int criteriaValue = int.Parse(Console.ReadLine());
                    var result = list.SearchByCriteria(x => x > criteriaValue);
                    Console.WriteLine("Nodes satisfying the criteria: " + string.Join(", ", result));
                    break;

                case 10:
                    Console.WriteLine("Current list:");
                    list.PrintList();
                    break;

                case 11:
                    list.SelectionSort();
                    Console.WriteLine("List sorted using Selection Sort.");
                    break;

                case 12:
                    list.QuickSort();
                    Console.WriteLine("List sorted using Quick Sort.");
                    break;

                case 13:
                    CircularLinkedList otherList = new CircularLinkedList();
                    Console.Write("Enter the number of elements in the other list: ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter elements of the other list:");
                    for (int i = 0; i < n; i++)
                    {
                        int element = int.Parse(Console.ReadLine());
                        otherList.InsertAtEnd(element);
                    }
                    list.Merge(otherList);
                    Console.WriteLine("Lists merged.");
                    break;

                case 14:
                    Console.Write("Enter the value to remove nodes less than: ");
                    int lessThanValue = int.Parse(Console.ReadLine());
                    list.RemoveByCriteria(x => x < lessThanValue);
                    Console.WriteLine("Nodes removed based on criteria.");
                    break;

                case 15:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 15);
    }
}