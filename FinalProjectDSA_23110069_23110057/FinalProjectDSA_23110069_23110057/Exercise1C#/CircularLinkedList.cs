using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularLinkedList_CSharp
{
    public class CircularLinkedList
    {
        private Node head;
        private Node tail;
        public Node Head { get => head; set => head = value; }
        public Node Tail { get => tail; set => tail = value; }
        public CircularLinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void InitList()
        {
            Head = null;
            Tail = null;
        }
        public bool IsEmpty()
        {
            return Head == null;
        }
        public void InsertFirst(Node p)
        {
            if (IsEmpty())
            {
                Head = Tail = p;
                Head.Next = Tail;
                Tail.Next = Head;
                return;
            }
            p.Next = Head;
            Head = p;
            Tail.Next = Head;
        }
        public void InsertLast(Node p)
        {
            if (IsEmpty())
            {
                Head = Tail = p;
                Head.Next = Tail;
                Tail.Next = Head;
                return;
            }
            Tail.Next = p;
            Tail = p;
            Tail.Next = Head;
        }
        public void InsertAfter(Node p, int pos)
        {
            if (IsEmpty())
            {
                return;
            }
            if(Head == Tail)
            {
                InsertLast(p);
                return;
            }
            Node temp = Head;
            while (pos > 0)
            {
                temp = temp.Next;
                pos--;
            }
            if(temp == Tail)
            {
                InsertLast(p);
                return;
            }
            p.Next = temp.Next;
            temp.Next = p;
        }
        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                return;
            }
            if (Head == Tail)
            {
                Head = Tail = null;
                return;
            }
            Head = Head.Next;
            Tail.Next = Head;
        }
        public void RemoveLast()
        {
            if (IsEmpty())
            {
                return;
            }
            if (Head == Tail)
            {
                Head = Tail = null;
                return;
            }
            Node temp = Head;
            while (temp.Next != Tail)
            {
                temp = temp.Next;
            }
            temp.Next = Head;
            Tail = temp;
        }
        public void RemoveAfter(int pos)
        {
            if (IsEmpty())
            {
                return;
            }
            if(Head == Tail)
            {
                RemoveFirst();
                return;
            }
            Node temp = Head;
            while (pos > 0)
            {
                temp = temp.Next;
                pos--;
            }
            if(temp.Next == Tail)
            {
                RemoveLast();
                return;
            }
            if(temp.Next == Head)
            {
                RemoveFirst();
                return;
            }
            temp.Next = temp.Next.Next;
        }
        public Node SearchNode(Song x)
        {
            Node temp = Head;
            while (temp.Data != x)
            {
                temp = temp.Next;
                if (temp == Head)
                {
                    return null;
                }
            }
            return temp;
        }
        public Node SearchSong(string name)
        {
            Node temp = Head;
            while (true)
            {
                temp = temp.Next;
                if(temp.Data.Name.ToLower().Contains(name.ToLower()))
                {
                    return temp;
                }
                if (temp == Head)
                {
                    return null;
                }
            }
        }
        public CircularLinkedList SearchSongsHaveDurationShorterOrEquals(TimeSpan duration)
        {
            CircularLinkedList list = new CircularLinkedList();
            list.InitList();
            if (IsEmpty())
            {
                return list;
            }
            Node temp = Head;
            do
            {
                if (temp.Data.Duration <= duration)
                {
                    list.InsertLast(Node.CreateNode(temp.Data));
                }
                temp = temp.Next;
            } while (temp != Head);
            return list;
        }
        public List<Node> ToList()
        {
            List<Node> list = new List<Node>();
            if (IsEmpty())
            {
                return list;
            }
            Node temp = Head;
            do
            {
                list.Add(temp);
                temp = temp.Next;
            }while(temp != Head);
            return list;
        }
        public void PrintList()
        {
            if (IsEmpty())
            {
                return;
            }
            Node temp = Head;
            while (temp != Tail)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine(Tail.Data);
        }
        public void SelectionSort()
        {
            if (IsEmpty() || Head == Tail)
            {
                return;
            }
            CircularLinkedList sorted = new CircularLinkedList();
            sorted.InitList();
            while (!IsEmpty())
            {
                Node min = Head;
                Node prevMin = null;
                Node cur = Head.Next;
                Node prev = Head;
                do
                {
                    if (String.Compare(cur.Data.Name, min.Data.Name) < 0)
                    {
                        min = cur;
                        prevMin = prev;
                    }
                    prev = cur;
                    cur = cur.Next;
                } while (cur != Head);

                if (min == Head)
                {
                    if (Head.Next == Head)
                    {
                        Head = null;
                    }
                    else
                    {
                        Node last = Head;
                        while (last.Next != Head)
                        {
                            last = last.Next;
                        }
                        Head = min.Next;
                        last.Next = Head;
                    }
                }
                else
                {
                    prevMin.Next = min.Next;
                }
                min.Next = null;
                sorted.InsertLast(min);
            }
            Head = sorted.Head;
            Tail = sorted.Tail;
        }
        public void QuickSort()
        {
            if (Head == Tail) return;

            Tail.Next = null;

            CircularLinkedList l1 = new CircularLinkedList();
            CircularLinkedList l2 = new CircularLinkedList();
            l1.InitList();
            l2.InitList();
            Node pivot = Head;
            Head = Head.Next;
            pivot.Next = null;

            while (Head != null)
            {
                Node p = Head;
                Head = Head.Next;
                p.Next = null;

                if (p.Data.Duration <= pivot.Data.Duration)
                {
                    l1.InsertFirst(p);
                }
                else
                {
                    l2.InsertFirst(p);
                }
            }

            l1.QuickSort();
            l2.QuickSort();

            if (l1.Head != null)
            {
                Head = l1.Head;
                l1.Tail.Next = pivot;
            }
            else
            {
                Head = pivot;
            }

            pivot.Next = l2.Head;

            if (l2.Head != null)
            {
                Tail = l2.Tail;
            }
            else
            {
                Tail = pivot;
            }
            Tail.Next = Head;
        }
        public void MergeList(CircularLinkedList sourceList)
        {
            if (sourceList.IsEmpty())
            {
                return;
            }
            if (IsEmpty())
            {
                Head = sourceList.Head;
                Tail = sourceList.Tail;
                return;
            }
            Tail.Next = sourceList.Head;
            sourceList.Tail.Next = Head;
            Tail = sourceList.Tail;
        }
        public void RemoveSongsHaveDurationShorterOrEquals(TimeSpan duration)
        {
            if (IsEmpty()) return;

            Node temp = Head;
            do
            {
                if (temp.Data.Duration <= duration)
                {
                    if (temp == Head) RemoveFirst();
                    else if (temp == Tail) RemoveLast();
                    else
                    {
                        Node prev = Head;
                        while (prev.Next != temp) prev = prev.Next;
                        prev.Next = temp.Next;
                    }
                    temp = Head;
                }
                else temp = temp.Next;
            } while (temp != Head);
        }

        public void Reverse()
        {
            if (IsEmpty() || Head.Next == Head)
            {
                return;
            }

            Node prev = null;
            Node cur = Head;
            Node next;
            do
            {
                next = cur.Next;  
                cur.Next = prev;  
                prev = cur;       
                cur = next;       
            } while (cur != Head);

            Tail = Head;
            Tail.Next = prev;  
            Head = prev;      
        }
    }
}