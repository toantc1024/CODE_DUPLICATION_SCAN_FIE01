using System;

public class LinkedList<T>
{
    private Node<T> head; 
    private Node<T> tail; 

  
    public void AddToTail(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (tail != null)
        {
            tail.Next = newNode;
        }
        tail = newNode;

        if (head == null)
        {
            head = newNode;
        }
    }


    public T RemoveFromHead()
    {
        if (head == null) return default(T); 

        T removedData = head.Data;
        head = head.Next;

        if (head == null)
        {
            tail = null;
        }
        return removedData;
    }

 
    public bool IsEmpty()
    {
        return head == null;
    }


    public void Clear()
    {
        head = null;
        tail = null;
    }

  
    public void Traverse(Action<T> action)
    {
        Node<T> current = head;

        while (current != null)
        {
            action(current.Data);
            current = current.Next;
        }
    }
}
