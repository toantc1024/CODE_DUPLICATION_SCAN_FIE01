using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularLinkedList_C_
{
    public class CircularDoublyLinkedList
    {
        private Node pTail;

        public Node PTail { get => pTail; set => pTail = value; }

        public CircularDoublyLinkedList()
        {
            PTail = null;
        }
        //---------------------------------------Operation-------------------------------------
        public bool IsEmpty()
        {
            return PTail == null; // Returns true if the list is empty
        }
        //-------Insert-------
        public void InsertAtEnd(Exercise data)
        {
            Node newNode = new Node(data);
            if (PTail == null)
            {
                newNode.PtrNext = newNode;
                newNode.PtrPre = newNode;
                PTail = newNode;
            }
            else
            {
                Node head = PTail.PtrNext;
                PTail.PtrNext = newNode;
                newNode.PtrPre = PTail;
                PTail = newNode;
                PTail.PtrNext = head;
                head.PtrPre = PTail;
            }
        }
        private void InsertAtFirst(Node pTail, Exercise data)
        {
            Node newNode = new Node(data);
            if (pTail == null)
            {
                newNode.PtrNext = null;
                newNode.PtrPre = null;
                pTail = newNode;
            }
            else
            {
                Node head = pTail.PtrNext;

                newNode.PtrNext = head;
                newNode.PtrPre = pTail;

                head.PtrPre = newNode;

                pTail.PtrNext = newNode;

            }
        }
        private void InsertAtk(Node pTail, int index, Exercise data)
        {
            Node newNode = new Node(data);
            if (pTail == null)
            {
                newNode.PtrNext = null;
                newNode.PtrPre = null;
                pTail = newNode;
            }
            else
            {
                int countPos = 0;
                while (countPos != index)
                {
                    countPos += 1;
                    pTail = pTail.PtrNext;
                }
                if (countPos == index)
                {
                    newNode.PtrNext = pTail;
                    newNode.PtrPre = pTail.PtrPre;

                    pTail.PtrPre.PtrNext = newNode;
                    pTail.PtrPre = newNode;
                }
            }
        }
        //Delete
        private void DeleteAtFirst(Node pTail)
        {
            if (pTail == null) return;
            else
            {
                pTail.PtrNext = pTail.PtrNext.PtrNext;
            }
        }
        private void DeleteAtLass(Node pTail)
        {
            if (pTail == null) return;
            else
            {
                pTail = pTail.PtrPre;
            }
        }
        private void DeleteAtk(Node pTail, int index)
        {
            if (pTail == null) return;
            else
            {
                int countPos = 0;
                while (countPos != index)
                {
                    countPos += 1;
                    pTail = pTail.PtrNext;
                }
                if (countPos == index)
                {
                    pTail.PtrPre.PtrNext = pTail.PtrNext;
                    pTail.PtrNext.PtrPre = pTail.PtrPre;
                }
            }
        }
        //Find value
        private void FindValue(Node pTail, Exercise value)
        {
            Node head = pTail.PtrNext;
            while (pTail != head)
            {
                if (pTail.Data == value)
                {
                    MessageBox.Show(Convert.ToString(pTail.Data));
                    return;
                }
                pTail = pTail.PtrNext;
            }
        }
        private void FindValueWithSpecificCriteria(Node pTail, Exercise SpecificCriteria)
        {
            Node head = pTail.PtrNext;
            while (pTail != head)
            {
                if (pTail.Data == SpecificCriteria)
                {
                    MessageBox.Show(Convert.ToString(pTail.Data));
                }
                pTail = pTail.PtrNext;
            }
        }
        //----Sort-------------------
        public void SelectionSort(Node pTail)
        {
            if (pTail == null || pTail.PtrNext == pTail)
            {
                Console.WriteLine("The list is empty or has only one element.");
                return;
            }

            Node head = pTail.PtrNext;
            Node current = head;

            do
            {
                Node min = current;
                Node move = current.PtrNext;

                while (move != head)
                {
                    if (move.Data.Difficulty< min.Data.Difficulty)
                    {
                        min = move;
                    }
                    move = move.PtrNext;
                }

                if (min != current)
                {
                    SwapNodes(pTail, current, min);
                    if (pTail == current)
                        pTail = min;
                    else if (pTail == min)
                        pTail = current;
                }
                current = current.PtrNext;

            } while (current != head);
        }

        // Hàm hoán đổi toàn bộ hai node
        private void SwapNodes(Node pTail, Node node1, Node node2)
        {
            if (node1 == node2) return; // Không cần hoán đổi nếu là cùng một node

            // Cập nhật liên kết trước và sau của node1 và node2
            Node pre1 = node1.PtrPre;
            Node next1 = node1.PtrNext;
            Node pre2 = node2.PtrPre;
            Node next2 = node2.PtrNext;

            // Trường hợp node1 và node2 liền kề nhau
            if (next1 == node2)
            {
                pre1.PtrNext = node2;
                node2.PtrPre = pre1;
                node2.PtrNext = node1;
                node1.PtrPre = node2;
                node1.PtrNext = next2;
                next2.PtrPre = node1;
            }
            else if (next2 == node1)
            {
                pre2.PtrNext = node1;
                node1.PtrPre = pre2;
                node1.PtrNext = node2;
                node2.PtrPre = node1;
                node2.PtrNext = next1;
                next1.PtrPre = node2;
            }
            else // Trường hợp node1 và node2 không liền kề
            {
                pre1.PtrNext = node2;
                next1.PtrPre = node2;
                pre2.PtrNext = node1;
                next2.PtrPre = node1;

                node2.PtrPre = pre1;
                node2.PtrNext = next1;
                node1.PtrPre = pre2;
                node1.PtrNext = next2;
            }
        }
        private void QuickSort(ref Node pTail)
        {
            if (pTail == null || pTail.PtrNext == pTail)
                return;
            Node head = pTail.PtrNext;
            Recursive(ref pTail, head, pTail);
        }
        private void Recursive(ref Node pTail, Node Start, Node End)
        {
            if (Start == null && End == null && Start == End && Start == End.PtrNext) return;
            else
            {
                Node pivot = Partition(ref pTail, Start, End);
                Recursive(ref pTail, Start, pivot.PtrPre);
                Recursive(ref pTail, pivot.PtrNext, End);
            }
        }
        private Node Partition(ref Node pTail, Node Start, Node End)
        {
            Node pivot = End;
            Node i = Start.PtrPre;
            Node j = Start;
            while (j != End)
            {
                if (i.Data.Difficulty < pivot.Data.Difficulty)
                {
                    //Swap
                    SwapNodes(pTail, i, j);
                }
                j = j.PtrNext;
            }
            //Swap i and pivot
            SwapNodes(pTail, i, pivot);
            return i;
        }
        //--------------------------------------------------------------------------Other operations-----------------------------------------------------------------------------
        // Update 
        private void Update(Node pTail, Exercise data, int index)
        {
            int countPos = 0;
            Node current = pTail.PtrPre;
            while (countPos != index)
            {
                current = current.PtrNext;
                countPos += 1;
            }
            if (countPos == index)
            {
                current.Data = data;
            }
        }
        //Remove Duplicates
        private void RemoveDuplicates(Node pTail)
        {
            Node temp;
            Node head = pTail.PtrNext;
            Node current = pTail.PtrNext;
            int index = 1;
            do
            {
                Node move = current.PtrNext;
                while (move != head)
                {
                    if (move.Data == current.Data)
                    {
                        Node IfDupIsEnd = move;

                        move.PtrPre.PtrNext = move.PtrNext;
                        move.PtrNext.PtrPre = move.PtrPre;

                        if (IfDupIsEnd == pTail)
                        {
                            pTail = pTail.PtrPre;

                        }
                    }
                    move = move.PtrNext;
                }
                current = current.PtrNext;
            } while (current != head);
        }
        //Split 
        //Merge

        //--------Print Out---------------
        private void PrintOut(Node pTail)
        {
            Node pHead = pTail.PtrNext;
            while (pTail.PtrNext != pHead)
            {
                MessageBox.Show(Convert.ToString(pTail.Data));
                pTail = pTail.PtrNext;
            }
        }
    }
}