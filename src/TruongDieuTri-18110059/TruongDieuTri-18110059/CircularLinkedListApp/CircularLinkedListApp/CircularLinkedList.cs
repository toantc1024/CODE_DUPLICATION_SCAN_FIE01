using System;

namespace CircularLinkedListApp
{
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
        private Node head;

        public CircularLinkedList()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void InsertAtBeginning(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                Node temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                newNode.Next = head;
                temp.Next = newNode;
                head = newNode;
            }
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                head = newNode;
                head.Next = head;
            }
            else
            {
                Node temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = head;
            }
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
                Node temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                head = head.Next;
                temp.Next = head;
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
                Node temp = head;
                while (temp.Next.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = head;
            }
        }

        public bool Search(int key)
        {
            if (IsEmpty()) return false;

            Node temp = head;
            do
            {
                if (temp.Data == key) return true;
                temp = temp.Next;
            } while (temp != head);

            return false;
        }

        public string PrintList()
        {
            if (IsEmpty())
            {
                return "Danh sách rỗng.";
            }

            Node temp = head;
            string result = "";
            do
            {
                result += temp.Data + " ";
                temp = temp.Next;
            } while (temp != head);
            return result.Trim();
        }
    }
}
