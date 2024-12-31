using System;

namespace CircularLinkedList
{
public class Node {
    public int data;
    public Node next;

    public Node(int data){
        this.data = data;
        this.next = null;
    }
}

public class CirLinkedList {
    public Node head = null;
    public Node tail = null;

    public void AddNode(int data){
        Node newNode = new Node(data);

        if(head == null){
            head = newNode;
            tail = newNode;
            newNode.next = head;
        }
        else{
            tail.next = newNode;
            tail = newNode;
            tail.next = head;
        }
    }

    public void AddNodeAtBeginning(int data){
            Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            tail = newNode;
            newNode.next = head;
        } else {
            newNode.next = head;
            tail.next = newNode; // Update tail's next to the new head
            head = newNode;
        }
    }

    public void AddNodeAtEnd(int data){
        AddNode(data);
    }

    public void AddNodeAfterNode(int targetData, int newData) {
        if (head == null) {
            Console.WriteLine("List is empty");
            return;
        }

        Node current = head;
        do {
            if (current.data == targetData) {
                Node newNode = new Node(newData);
                newNode.next = current.next;
                current.next = newNode;
                if (current == tail)
                    tail = newNode; // Update tail if inserted after the last node
            return;
            }
            current = current.next;
        } while (current != head);

        Console.WriteLine("Node with data " + targetData + " not found.");
    }


    public void DeleteFirstNode() {
        if (head == null) {
            Console.WriteLine("List is empty");
            return;
        }

        if (head == tail) {
            head = null;
            tail = null;
        } else {
            head = head.next;
            tail.next = head; // Update tail's next pointer
        }
    }

    public void DeleteLastNode() {
        if (head == null) {
            Console.WriteLine("List is empty");
            return;
        }

        if (head == tail) {
            head = null;
            tail = null;
        } else {
            Node current = head;
            while (current.next != tail)
                current = current.next;
            current.next = head;
            tail = current; // Update tail
        }
    }


    public void DeleteNodeAfterNode(int targetData) {
        if (head == null) {
            Console.WriteLine("List is empty");
            return;
        }

        Node current = head;
        do {
            if (current.data == targetData) {
                if (current.next == head) {
                    Console.WriteLine("No node exists after the target node.");
                    return;
                }

                if (current.next == tail)
                    tail = current; // Update tail if the deleted node is the last node
                current.next = current.next.next;
                return;
            }
            current = current.next;
        } while (current != head);

        Console.WriteLine("Node with data " + targetData + " not found.");
    }


    public void SearchNode(int data) {
        if (head == null) {
            Console.WriteLine("List is empty");
            return;
        }

        Node current = head;
        do {
            if (current.data == data) {
                Console.WriteLine("Node with data " + data + " found.");
                return;
            }
            current = current.next;
        } while (current != head);

        Console.WriteLine("Node with data " + data + " not found.");
    }

    public void SearchNodeCondition(int data){

    }

    public void Display(){
        Node current = head;

        if(head == null){
            Console.WriteLine("List is empty");
            return;
        }
        else{
            Console.WriteLine("Nodes of the circular linked list: ");
            do {
                Console.Write(current.data + " ");
                current = current.next;
            } while(current != head);
            Console.WriteLine();
        }
    }

    public void SelectionSort() {
        if (head == null || head.next == head) return;

        Node current = head;
        do {
            Node min = current;
            Node temp = current.next;
            while (temp != head) {
                if (temp.data < min.data)
                    min = temp;
                temp = temp.next;
            }

            // Swap data
            int tempData = current.data;
            current.data = min.data;
            min.data = tempData;

            current = current.next;
        } while (current != head);
    }

    private void QuickSort(Node start, Node end)
    {
        if (start == null || start == end || start.next == end)
            return;

        Node pivotPrev = Partition(start, end);
        QuickSort(start, pivotPrev);

        // Recursively sort the right partition (after pivotPrev)
        if (pivotPrev != null && pivotPrev == start)
            QuickSort(pivotPrev.next, end);
        else if (pivotPrev != null && pivotPrev.next != null)
            QuickSort(pivotPrev.next.next, end);
    }

    private Node Partition(Node start, Node end)
    {
        if (start == end || start == null || end == null)
            return start;

        Node pivotPrev = start;
        Node current = start;
        int pivot = end.data;

        while (start != end)
        {
            if (start.data < pivot)
            {
                pivotPrev = current;
                int temp = current.data;
                current.data = start.data;
                start.data = temp;
                current = current.next;
            }
            start = start.next;
        }

        int temp1 = current.data;
        current.data = pivot;
        end.data = temp1;

        return pivotPrev;
    }

    public void QuickSort()
    {
        if (head != null && head.next != head)
        {
            QuickSort(head, tail);
        }
    }

    public void Merge(CirLinkedList otherList) {
        if (otherList.head == null) return;

        if (head == null) {
            head = otherList.head;
            tail = otherList.tail;
        } else {
            tail.next = otherList.head;
            otherList.tail.next = head;
            tail = otherList.tail;
        }
    }

    public void RemoveNodesCondition(Func<int, bool> condition) {
        if (head == null) return;

        Node current = head, prev = tail;
        bool found = false;

        do {
            if (condition(current.data)) {
                if (current == head) {
                    head = head.next;
                    tail.next = head;
                } else if (current == tail) {
                    tail = prev;
                    tail.next = head;
                } else 
                    prev.next = current.next;
                found = true;
            } else
                prev = current;
            current = current.next;
        } while (current != head);

        if (found && head == tail && condition(head.data)) {
            head = null;
            tail = null;
        }
    }

    public void Reverse() {
        if (head == null || head.next == head)
            return;

        Node prev = tail;
        Node current = head;
        Node next;

        do {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        } while (current != head);

        tail = head;
        head = prev;
        tail.next = head;
    }
}
}