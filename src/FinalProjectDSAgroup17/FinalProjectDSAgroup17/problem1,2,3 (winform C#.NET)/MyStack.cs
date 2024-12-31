using System;

namespace ProjectFinalDataStructure
{
    public class MyStack<T>
    {
        private Node<T> top;  
        private int count;    

        private class Node<U>
        {
            public U Data;  
            public Node<U> Next;  

            public Node(U data)
            {
                Data = data;
                Next = null;
            }
        }

        public MyStack()
        {
            top = null;
            count = 0;
        }

       
        public bool IsEmpty()
        {
            return top == null;
        }

        
        public void Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }

    
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T item = top.Data;
            top = top.Next;
            count--;
            return item;
        }

       
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return top.Data;
        }

       
        public void Clear()
        {
            top = null;
            count = 0;
        }

        
        public int Size()
        {
            return count;
        }
    }
}
