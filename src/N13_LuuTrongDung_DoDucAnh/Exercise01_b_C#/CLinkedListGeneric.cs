using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_linked_list_generic
{

    public class CLinkedListGeneric<T>
    {
        public Node<T> pHead;
        public Node<T> pTail;

        public CLinkedListGeneric()
        {
            Init();
        }

        public void Init()
        {
            pHead = null;
            pTail = null;
        }

        public Node<T> CreateNode(T value)
        {
            Node<T> newNode = new Node<T>
            {
                info = value,
                pNext = null
            };
            return newNode;
        }

        public bool IsEmpty()
        {
            return pHead == null;
        }

        public void PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node<T> temp = pHead;
                do
                {
                    Console.WriteLine(temp.info);
                    temp = temp.pNext;
                } while (temp != pHead);
            }
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = CreateNode(value);
            if (IsEmpty())
            {
                pHead = newNode;
                pTail = newNode;
                pTail.pNext = pHead;
            }
            else
            {
                newNode.pNext = pHead;
                pHead = newNode;
                pTail.pNext = pHead;
            }
        }

        public void AddLast(T value)
        {
            Node<T> newNode = CreateNode(value);
            if (IsEmpty())
            {
                pHead = newNode;
                pTail = newNode;
                pTail.pNext = pHead;
            }
            else
            {
                pTail.pNext = newNode;
                pTail = newNode;
                pTail.pNext = pHead;
            }
        }

        public void AddAfter(Node<T> p, Node<T> q)
        {
            if (p == null || q == null)
                return;

            q.pNext = p.pNext;
            p.pNext = q;

            if (p == pTail)
            {
                pTail = q;
                pTail.pNext = pHead;
            }
        }

        public void RemoveFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (pHead == pTail)
            {
                pHead = null;
                pTail = null;
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
                return;
            }

            if (pHead == pTail)
            {
                pHead = null;
                pTail = null;
            }
            else
            {
                Node<T> temp = pHead;
                while (temp.pNext != pTail)
                {
                    temp = temp.pNext;
                }
                temp.pNext = pHead;
                pTail = temp;
            }
        }

        public void RemoveAfter(Node<T> p)
        {
            if (p == null || p.pNext == null)
                return;

            Node<T> temp = p.pNext;
            p.pNext = temp.pNext;

            if (temp == pTail)
            {
                pTail = p;
                pTail.pNext = pHead;
            }
        }

        public List<T> FindNodes(Func<T, bool> predicate)
        {
            List<T> result = new List<T>();

            if (IsEmpty()) return result;

            Node<T> temp = pHead;
            do
            {
                if (predicate(temp.info))
                    result.Add(temp.info);
                temp = temp.pNext;
            } while (temp != pHead);

            return result;
        }

        public void SelectionSort()
        {
            if (IsEmpty() || pHead == pTail)
                return;

            Node<T> current = pHead;

            do
            {
                Node<T> minNode = current;
                Node<T> temp = current.pNext;

                while (temp != pHead)
                {
                    if ((temp.info as Student).age < (minNode.info as Student).age)
                    {
                        minNode = temp;
                    }
                    temp = temp.pNext;

                }

                if (minNode != current)
                {
                    Node<T> prevCurrent = null, prevMin = null, t = pHead;
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
                            Node<T> tempNode = minNode.pNext;
                            minNode.pNext = current.pNext;
                            prevCurrent.pNext = minNode;
                            current.pNext = tempNode;
                            prevMin.pNext = current;
                        }
                        current = minNode;
                    }
                }
                current = current.pNext;
            } while (current != pHead);

            Console.WriteLine("Danh sach sau khi duoc sap xep theo ten (a-z):");
            PrintList();
        }

        public CLinkedListGeneric<T> MergeTwoLists(CLinkedListGeneric<T> list1, CLinkedListGeneric<T> list2)
        {
            CLinkedListGeneric<T> mergedList = new CLinkedListGeneric<T>();

            if (list1.IsEmpty() && list2.IsEmpty())
                return mergedList;

            Node<T> temp1 = list1.pHead;
            do
            {
                mergedList.AddLast(temp1.info);
                temp1 = temp1.pNext;
            } while (temp1 != list1.pHead);

            Node<T> temp2 = list2.pHead;
            do
            {
                mergedList.AddLast(temp2.info);
                temp2 = temp2.pNext;
            } while (temp2 != list2.pHead);

            return mergedList;
        }

        public List<T> FindNodesByAge(Func<T, bool> condition)
        {
            List<T> result = new List<T>();

            if (IsEmpty()) return result;

            Node<T> temp = pHead;
            do
            {
                if (condition(temp.info))
                    result.Add(temp.info);

                temp = temp.pNext;
            } while (temp != pHead);

            return result;
        }
    }
}
