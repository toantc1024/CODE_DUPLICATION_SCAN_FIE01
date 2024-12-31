using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
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
        public Node head;
        public Node tail;

        public CircularLinkedList()
        {
            head = null;
            tail = null;
        }

        public void InitializeList()
        {
            head = null;
            tail = null;
        }

        public Node CreateNewNode(int data)
        {
            return new Node(data);
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void InsertAtBeginning(int data)
        {
            Node newNode = CreateNewNode(data);
            if (head == null)
            {
                head = tail = newNode;
                tail.Next = head;
            }
            else
            {
                newNode.Next = head;
                tail.Next = newNode;
                head = newNode;
            }
        }

        public void InsertAtEnd(int data)
        {
            Node newNode = CreateNewNode(data);
            if (head == null)
            {
                head = tail = newNode;
                tail.Next = head;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
                tail.Next = head;
            }
        }

        public void InsertAfter(Node prevNode, int data)
        {
            if (prevNode == null) return;
            Node newNode = CreateNewNode(data);
            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
        }

        public void RemoveFirstNode()
        {
            if (head == null) return;
            Node temp = head;
            if (head.Next == head)
            {
                head = null;
            }
            else
            {
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = head.Next;
                head = head.Next;
            }
        }

        public void RemoveLastNode()
        {
            if (head == null) return;
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

        public void RemoveAfter(Node prevNode)
        {
            if (prevNode == null || prevNode.Next == null || prevNode.Next == head) return;
            prevNode.Next = prevNode.Next.Next;
        }

        public Node Search(int key)
        {
            Node temp = head;
            if (head != null)
            {
                do
                {
                    if (temp.Data == key) return temp;
                    temp = temp.Next;
                } while (temp != head);
            }
            return null;
        }

        public List<Node> SearchNodes(Func<Node, bool> criteria)
        {
            List<Node> result = new List<Node>();
            Node temp = head;
            if (head != null)
            {
                do
                {
                    if (criteria(temp))
                    {
                        result.Add(temp);
                    }
                    temp = temp.Next;
                } while (temp != head);
            }
            return result;
        }

        public void PrintList()
        {
            Node temp = head;
            if (head != null)
            {
                do
                {
                    Console.Write(temp.Data + " -> ");
                    temp = temp.Next;
                } while (temp != head);
                Console.WriteLine(temp.Data);
            }
        }

       
        public void SelectionSort()
        {
            if(IsEmpty()||head == null) return;
            CircularLinkedList sorted = new CircularLinkedList();
            sorted.InitializeList();
            while(!IsEmpty())
            {
                Node min = head;
                Node preMin = null;
                Node cur = head.Next;
                Node prev = head;
                do
                {
                    if(cur.Data<min.Data)
                    {
                        min = cur;
                        preMin = prev;
                    }
                    prev = cur;
                    cur = cur.Next;
                }while(cur!= head);
                if(min == head)
                {
                    if (head.Next == head) head = null;
                    else
                    {
                        Node last = head;
                        while(last.Next!=head)
                        {
                            last = last.Next;
                        }
                        head = min.Next;
                        last.Next = head;

                    }
                    
                }
                else
                {
                    preMin.Next=min.Next;
                }
                min.Next = null;
                sorted.InsertAtEnd(min.Data);
            }
            head = sorted.head;
            tail = sorted.tail;
        }
        public void QuickSort()
        {
            if (head == tail) return;

            tail.Next = null;

            CircularLinkedList l1 = new CircularLinkedList();
            CircularLinkedList l2 = new CircularLinkedList();
            l1.InitializeList();
            l2.InitializeList();
            Node pivot = head;
            head = head.Next;
            pivot.Next = null;

            while (head != null)
            {
                Node p = head;
                head = head.Next;
                p.Next = null;

                if (p.Data <= pivot.Data)
                {
                    l1.InsertAtBeginning(p.Data);
                }
                else
                {
                    l2.InsertAtBeginning(p.Data);
                }
            }

            l1.QuickSort();
            l2.QuickSort();

            if (l1.head != null)
            {
                head = l1.head;
                l1.tail.Next = pivot;
            }
            else
            {
                head = pivot;
            }

            pivot.Next = l2.head;

            if (l2.head != null)
            {
                tail = l2.tail;
            }
            else
            {
                tail = pivot;
            }
            tail.Next = head;
        }

        public void MergeLists(CircularLinkedList other)
        {
            if (other == null || other.head == null) return;
            if (this.head == null)
            {
                this.head = other.head;
                return;
            }
            Node temp = this.head;
            while (temp.Next != this.head)
            {
                temp = temp.Next;
            }
            temp.Next = other.head;
            Node otherTemp = other.head;
            while (otherTemp.Next != other.head)
            {
                otherTemp = otherTemp.Next;
            }
            otherTemp.Next = this.head;
        }

        public void RemoveAllNodes()
        {
            head = null; // Đặt head về null để xóa toàn bộ danh sách 
        }

        public CircularLinkedList Reverse()
        {
            if (head == null) return null;
            Node prev = null, current = head, next;
            do
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            } while (current != head);
            head.Next = prev;
            head = prev;
            return this;
        }
    }
}
