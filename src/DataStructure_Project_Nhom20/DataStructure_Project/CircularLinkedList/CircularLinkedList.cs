using System;
using System.Collections.Generic;

public class CircularLinkedList<T> where T : IComparable<T>
{
    public Node<T> head;
    private Node<T> tail;
    public static List<CircularLinkedList<string>> AllLists { get; set; } = new List<CircularLinkedList<string>>();
    public static CircularLinkedList<string> CurrentList { get; set; }

    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public CircularLinkedList()
    {
        head = null;
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    // Insert a new node at the beginning
    public void InsertAtBeginning(T value)
    {
        Node<T> newNode = new Node<T>(value);
        if (head == null)
        {
            newNode.Next = newNode;
            head = newNode;
            tail = newNode; // Set tail when the first node is added
        }
        else
        {
            newNode.Next = head;
            tail.Next = newNode; // Make the tail point to the new node
            head = newNode;
        }
    }

    // Insert a new node at the end
    public void InsertAtEnd(T value)
    {
        Node<T> newNode = new Node<T>(value);
        if (head == null)
        {
            newNode.Next = newNode;
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Next = head;
            tail = newNode;
        }
    }

    // Insert a new node after a specific node
    public void InsertAfter(T target, T value)
    {
        if (head == null) return;

        Node<T> temp = head;
        do
        {
            if (EqualityComparer<T>.Default.Equals(temp.Data, target))
            {
                Node<T> newNode = new Node<T>(value);
                newNode.Next = temp.Next;
                temp.Next = newNode;
                if (temp == tail) tail = newNode; // Update tail if inserted at the end
                return;
            }
            temp = temp.Next;
        } while (temp != head);
    }

    // Remove the first node
    public void RemoveFirst()
    {
        if (head == null) return;

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            tail.Next = head.Next;
            head = head.Next;
        }
    }

    // Remove the last node
    public void RemoveLast()
    {
        if (head == null) return;

        if (head == tail)
        {
            head = null;
            tail = null;
        }
        else
        {
            Node<T> temp = head;
            while (temp.Next != tail) temp = temp.Next;
            temp.Next = head;
            tail = temp;
        }
    }

    // Remove a node after a specific node
    public void RemoveAfter(T target)
    {
        if (head == null) return;

        Node<T> temp = head;
        do
        {
            if (EqualityComparer<T>.Default.Equals(temp.Data, target))
            {
                Node<T> toDelete = temp.Next;
                if (toDelete == head) return; // Don't delete the head node
                temp.Next = toDelete.Next;
                if (toDelete == tail) tail = temp; // Update tail if last node was deleted
                return;
            }
            temp = temp.Next;
        } while (temp != head);
    }

    // Search for a specific node
    public Node<T> Search(T value)
    {
        if (head == null) return null;

        Node<T> temp = head;
        do
        {
            if (EqualityComparer<T>.Default.Equals(temp.Data, value)) return temp;
            temp = temp.Next;
        } while (temp != head);
        return null;
    }
    public List<T> Search_From_Criteria(Func<T, bool> criteria)
{
    List<T> results = new List<T>();

    if (head == null) return results;

    Node<T> current = head;
    do
    {
        if (criteria(current.Data))
        {
            results.Add(current.Data);
        }
        current = current.Next;
    } while (current != head);

    return results;
    }
    public void RemoveAll_Criteria(Func<T, bool> criteria)
{
    if (head == null) return;

    Node<T> current = head;
    Node<T> previous = null;

    do
    {
        if (criteria(current.Data))
        {
            if (current == head) // Nếu xóa node đầu tiên
            {
                head = head.Next;
            }
            if (previous != null)
            {
                previous.Next = current.Next;
            }
            current = current.Next;

            // Nếu xóa node cuối cùng
            if (current == head)
            {
                head = null;
                break;
            }
        }
        else
        {
            previous = current;
            current = current.Next;
        }
    } while (current != head);
}


    // Print the list
    public void PrintList()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Node<T> temp = head;
        do
        {
            Console.WriteLine(temp.Data);
            temp = temp.Next;
        } while (temp != head);
    }

    // Sort the list using selection sort
    public void SelectionSort()
    {
        if (head == null) return;

        Node<T> start = head;
        do
        {
            Node<T> min = start;
            Node<T> current = start.Next;
            do
            {
                if (Comparer<T>.Default.Compare(current.Data, min.Data) < 0)
                {
                    min = current;
                }
                current = current.Next;
            } while (current != head);

            if (min != start)
            {
                T tempData = start.Data;
                start.Data = min.Data;
                min.Data = tempData;
            }
            start = start.Next;
        } while (start != head);
    }

    // QuickSort (with adjustments)
    public void QuickSort()
    {
        if (head == null || head.Next == head) return; // If the list is empty or has only one element

        QuickSortRecursive(ref head, ref tail);
    }

    private void QuickSortRecursive(ref Node<T> head, ref Node<T> tail)
    {
        if (head == tail || head == null || head.Next == head) return;

        Node<T> pivot = Partition(ref head, ref tail);
        QuickSortRecursive(ref head, ref pivot);
        QuickSortRecursive(ref pivot.Next, ref tail);
    }

    private Node<T> Partition(ref Node<T> head, ref Node<T> tail)
    {
        Node<T> pivot = head;
        Node<T> prev = null;
        Node<T> current = head;
        Node<T> last = head;

        // Move tail to the last node
        while (last.Next != head)
        {
            last = last.Next;
        }

        while (current != last)
        {
            if (current.Data.CompareTo(pivot.Data) < 0)
            {
                if (prev == null)
                {
                    head = current;
                }
                prev = current;
            }
            current = current.Next;
        }

        return pivot;
    }

    // Merge two circular linked lists
    public void MergeLists(CircularLinkedList<T> otherList)
    {
        if (this.head == null)
        {
            this.head = otherList.head;
        }
        else if (otherList.head != null)
        {
            Node<T> current = this.head;
            while (current.Next != this.head)
            {
                current = current.Next;
            }

            current.Next = otherList.head;

            Node<T> otherCurrent = otherList.head;
            while (otherCurrent.Next != otherList.head)
            {
                otherCurrent = otherCurrent.Next;
            }

            otherCurrent.Next = this.head;
        }
    }
    public List<T> GetAllNodes()
{
    List<T> nodes = new List<T>();
    
    if (this.head == null) 
        return nodes;  // Nếu danh sách rỗng, trả về danh sách trống.

    Node<T> current = this.head;
    
    do
    {
        nodes.Add(current.Data);  // Thêm dữ liệu của node vào danh sách.
        current = current.Next;  // Di chuyển đến node tiếp theo.
    } while (current != this.head);  // Duyệt qua tất cả các node trong danh sách vòng tròn.

    return nodes;  // Trả về danh sách tất cả các phần tử.
}
}