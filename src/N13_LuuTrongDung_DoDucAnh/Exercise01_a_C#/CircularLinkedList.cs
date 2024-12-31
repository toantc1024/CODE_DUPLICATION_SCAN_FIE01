using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Circular_linked_list
{
    public class CircularLinkedList
    {
        public Node pHead;
        public Node pTail;

        public CircularLinkedList()
        {

        }

        public void Init()
        {
            pHead = null;
            pTail = null;
        }

        public Node CreateNode(int x)
        {
            Node newNode = new Node();
            newNode.info = x;
            newNode.pNext = null;
            return newNode;
        }

        public void PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = pHead;
                while (temp != pTail)
                {
                    Console.Write($"{temp.info} ");
                    temp = temp.pNext;
                }
                Console.WriteLine(temp.info);
            }
        }

        public bool IsEmpty()
        {
            return pHead == null;
        }

        public void AddFirst(int x)
        {
            Node newNode = CreateNode(x);
            if (IsEmpty())
            {
                pHead = newNode;
                pTail = newNode;
            }
            else
            {
                newNode.pNext = pHead;
                pHead = newNode;
                pTail.pNext = pHead;
            }
        }

        public void AddLast(int x)
        {
            Node newNode = CreateNode(x);
            if (IsEmpty())
            {
                pHead = newNode;
                pTail = newNode;
            }
            else
            {
                pTail.pNext = newNode;
                pTail = newNode;
                pTail.pNext = pHead;
            }
        }

        public void AddAfter(Node p, Node q)
        {
            if (p == null || q == null)
                return;
            if (p == pTail)
            {
                q.pNext = pHead;
                pHead = q;
                pTail.pNext = pHead;
                return;
            }
            q.pNext = p.pNext;
            p.pNext = q;
            if (p == pTail)
            {
                pTail = q;
            }
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                pHead = pHead.pNext;
                pTail.pNext = pHead;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = pHead;
                while (pHead.pNext != pTail)
                    pHead = pHead.pNext;
                pTail = pHead;
                pHead = temp;
                pTail.pNext = pHead;
            }
        }

        public void RemoveAfter(Node p)
        {
            if (p == null || p.pNext == null)
                return;
            if (p == pTail)
            {
                RemoveFirst();
                return;
            }
            Node temp = p.pNext;
            p.pNext = temp.pNext;
            if (temp == pTail)
            {
                pTail = p;
            }
        }


        public Node SearchNode(int x)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return null;
            }
            else
            {
                Node temp = pHead;
                do
                {
                    if (temp.info == x)
                        return temp;
                    temp = temp.pNext;
                } while (temp != pHead);

                return null;
            }
        }

        public List<Node> SearchNodes(int x, int type)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return null;
            }
            else
            {
                List<Node> tempList = new List<Node>();
                Node temp = pHead;
                do
                {
                    if (type == 1 && temp.info == x)
                        tempList.Add(temp);
                    else if (type == 2 && temp.info < x)
                        tempList.Add(temp);
                    else if (type == 3 && temp.info > x)
                        tempList.Add(temp);
                    temp = temp.pNext;
                } while (temp != pHead);

                return tempList;
            }
        }

        public CircularLinkedList MergeTwoLists(CircularLinkedList list1, CircularLinkedList list2)
        {
            CircularLinkedList mergedList = new CircularLinkedList();

            if (list1.IsEmpty() && list2.IsEmpty())
                return mergedList;

            Node temp1 = list1.pHead;
            do
            {
                mergedList.AddLast(temp1.info);
                temp1 = temp1.pNext;
            } while (temp1 != list1.pHead);

            Node temp2 = list2.pHead;
            do
            {
                mergedList.AddLast(temp2.info);
                temp2 = temp2.pNext;
            } while (temp2 != list2.pHead);

            return mergedList;
        }

        public void RemoveNodes(int x, int type)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = pHead;
                while(pHead.pNext != pTail)
                {
                    if ((pHead.pNext.info == x && type == 1) || (pHead.pNext.info < x && type == 2) || (pHead.pNext.info > x && type == 3))
                        RemoveAfter(pHead);
                    else 
                        pHead = pHead.pNext;
                }
                pHead = temp;
                if ((pHead.info == x && type == 1) || (pHead.info < x && type == 2) || (pHead.info > x && type == 3))
                    RemoveFirst();
                if ((pTail.info == x && type == 1) || (pTail.info < x && type == 2) || (pTail.info > x && type == 3))
                    RemoveLast();
            }   
        }

        public Node FindMaxNode()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return null;
            }

            Node temp = pHead;
            Node maxNode = pHead;
            do
            {
                if (temp.info > maxNode.info)
                    maxNode = temp;
                temp = temp.pNext;
            } while (temp != pHead);

            return maxNode;
        }

        public void SelectionSort()
        {
            if (IsEmpty() || pHead == pTail)
                return;

            Node current = pHead;

            do
            {
                Node minNode = current;
                Node temp = current.pNext;

                while (temp != pHead)
                {
                    if (temp.info < minNode.info)
                    {
                        minNode = temp;
                    }
                    temp = temp.pNext;
                }


                if (minNode != current)
                {

                    Node prevCurrent = null, prevMin = null, t = pHead;

                    do
                    {
                        if (t.pNext == current)
                            prevCurrent = t;
                        if (t.pNext == minNode)
                            prevMin = t;
                        t = t.pNext;
                    } while (t != pHead);


                    if (current == pHead && minNode == pTail)
                    {
                        pHead = minNode;
                        pTail = current;
                        pHead.pNext = current.pNext;
                        prevMin.pNext = pTail;
                        pTail.pNext = pHead;
                        current = pHead;
                    }

                    else if (current == pHead && minNode != pTail)
                    {
                        pHead = minNode;
                        pHead.pNext = current.pNext;
                        pTail.pNext = pHead;
                        current.pNext = minNode.pNext;
                        prevMin.pNext = current;
                        current = pHead;
                    }
                    else if (current != pHead && minNode == pTail)
                    {
                        minNode.pNext = current.pNext;
                        prevCurrent.pNext = minNode;
                        pTail = current;
                        pTail.pNext = pHead;
                        prevMin.pNext = pTail;
                        current = minNode;
                    }
                    else
                    {
                        if (current.pNext == minNode)
                        {
                            prevCurrent.pNext = minNode;
                            current.pNext = minNode.pNext;
                            minNode.pNext = current;
                        }
                        else if (minNode.pNext == current)
                        {
                            prevMin.pNext = current;
                            minNode.pNext = current.pNext;
                            current.pNext = minNode;

                        }
                        else
                        {
                            Node tempNode = minNode.pNext;
                            minNode.pNext = current.pNext;
                            prevCurrent.pNext = minNode;
                            current.pNext = tempNode;
                            prevMin.pNext = current;
                        }
                        current = minNode;

                    }
                }
                current = current.pNext;
            } while (current != pHead) ;
            Console.WriteLine("Danh sach sau khi duoc sap xep (selectionsort):");
            PrintList();
        }
    }
}
