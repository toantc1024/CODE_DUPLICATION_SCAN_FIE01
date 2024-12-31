using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circular_Linked_List
{
    public class CircularList
    {
        private Node head;
        private Node tail;

        // Properties
        public Node Head
        {
            get => head;
            private set => head = value;
        }
        public Node Tail
        {
            get => tail;
            private set => tail = value;
        }
        public CircularList()
        {
            head = null;
            tail = null;
        }

        public CircularList(Node newNode)
        {
            head = newNode;
            tail = null;
            head.NextNode = head;
            head.PreNode = head;
        }
        public CircularList(Node headNode, Node tailNode)
        {
            head = headNode;
            tail = tailNode;
        }
        public bool IsEmpty()
        {
            return head == null;
        }

        public string PrintList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty! Please fill it.");
                return "";
            }
            string tmp = "";
            Node temp = head;
            do
            {
                tmp += temp.Data.ToString() + ";";
                temp = temp.NextNode;
            } while (temp != head);
            return tmp;
        }

        public void InsertAtBegin(Node newNode)
        {
            if (IsEmpty())
            {
                head = newNode;
                tail = null;
                head.NextNode = head;
                head.PreNode = head;
            }
            else if(head.NextNode == head)
            {
                head.PreNode = newNode;
                head.NextNode = newNode;
                tail = head;
                newNode.PreNode = tail;
                newNode.NextNode = tail;
                head = newNode;
            }
            else
            {
                tail.NextNode = newNode;
                head.PreNode = newNode;
                newNode.PreNode = tail;
                newNode.NextNode = head;
                head = newNode;
            }
        }

        public void InsertAtEnd(Node newNode)
        {
            if (IsEmpty())
            {
                head = newNode;
                tail = null;
                head.NextNode = head;
                head.PreNode = head;
            }
            else if (head.NextNode == head)
            {
                tail = newNode;
                tail.NextNode = head;
                tail.PreNode = head;
                head.NextNode = tail;
                head.PreNode = tail;
            }
            else
            {
                tail.NextNode = newNode;
                head.PreNode = newNode;
                newNode.NextNode = head;
                newNode.PreNode = tail;
                tail = newNode;
            }
        }

        public void InsertAfterNode(string id, Node newNode)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty! Do you want to insert the item to the list? Y/n");
                string choose = Console.ReadLine();
                if (choose.ToUpper() == "Y")
                {
                    InsertAtBegin(newNode);
                }
                return;
            }

            if (head.NextNode == head)
            {
                if (head.Data.ID == id)
                {
                    InsertAtEnd(newNode);
                }
                else
                {
                    Console.WriteLine("ID does not exist, please check again.");
                }
                return;
            }

            Node temp = head;
            do
            {
                if (temp.Data.ID == id)
                {
                    break;
                }
                temp = temp.NextNode;
            } while (temp != head);

            if (temp.Data.ID != id)
            {
                Console.WriteLine("ID does not exist, please check again.");
                return;
            }

            newNode.NextNode = temp.NextNode;
            newNode.PreNode = temp;
            temp.NextNode.PreNode = newNode;
            temp.NextNode = newNode;

            if (temp == tail)
            {
                tail = newNode;
            }
        }

        public void RemoveAtFirst()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty! Please check again.");
                return;
            }

            if (head.NextNode == head)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.NextNode;
                head.PreNode = null;
                head.PreNode = tail;
                tail.NextNode = head;
            }
        }

        public void RemoveAtLast()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty! Please check again.");
                return;
            }

            if (head.NextNode == head)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.PreNode;
                tail.NextNode = null;
                tail.NextNode = head;
                head.PreNode = tail;
            }
        }

        public void RemoveAfterNode(string id)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty! Please check again.");
                return;
            }

            Node temp = head;
            do
            {
                if (temp.Data.ID == id)
                {
                    break;
                }
                temp = temp.NextNode;
            } while (temp != head);

            if (temp.Data.ID != id)
            {
                Console.WriteLine("ID does not exist, please check again.");
                return;
            }

            if (temp.NextNode == temp)
            {
                Console.WriteLine("The list has only one node. Nothing to remove after this node.");
                return;
            }

            Node nodeToRemove = temp.NextNode;
            if (nodeToRemove == head)
            {
                head = nodeToRemove.NextNode;
            }
            if (nodeToRemove == tail)
            {
                tail = temp;
            }

            temp.NextNode = nodeToRemove.NextNode;
            nodeToRemove.NextNode.PreNode = temp;

            // Delete the node
            nodeToRemove = null;
        }

        public void RemoveAt(string id)
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty! Please check again.");
                return;
            }

            Node temp = head;
            do
            {
                if (temp.Data.ID == id)
                {
                    break;
                }
                temp = temp.NextNode;
            } while (temp != head);

            if (temp.Data.ID != id)
            {
                MessageBox.Show("ID does not exit, please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (temp.NextNode == temp)
            {
                temp = null;
                head = null;
                return;
            }

            if(temp == head)
            {
                head = temp.NextNode;
            }
            if(temp == tail)
            {
                tail = temp.PreNode;
            }
            temp.PreNode.NextNode = temp.NextNode;
            temp.NextNode.PreNode = temp.PreNode;
            temp = null;
        }
        private bool ClothesSmallerComparison(Clothes a, Clothes b, string criteria)
        {
            return (criteria == "id" && String.Compare(a.ID, b.ID, true) < 0) || (criteria == "type" && String.Compare(a.Type, b.Type, true) < 0)
            || (criteria == "size" && String.Compare(a.Size, b.Size, true) < 0 || (criteria == "price" && a.Price < b.Price)
            || (criteria == "name" && String.Compare(a.Name, b.Name, true) < 0));
        }

        private bool ClothesEqualComparison(Clothes a, Clothes b, string criteria) {
            return (criteria == "id" && String.Compare(a.ID, b.ID, true) == 0) || (criteria == "type" && String.Compare(a.Type, b.Type, true) == 0)
            || (criteria == "size" && String.Compare(a.Size, b.Size, true) == 0 || (criteria == "price" && a.Price == b.Price)
            || (criteria == "name" && String.Compare(a.Name, b.Name, true) == 0));
        }

        private Node Partition(Node left, Node right, string criteria)
        {
            Clothes pivot = right.Data;
            Node i = left.PreNode;
            for(Node j = left; j != right; j = j.NextNode)
            {
                if(ClothesSmallerComparison(j.Data, pivot, criteria))
                {
                    i = (i == null) ? left : i.NextNode;
                    Clothes Temp = i.Data;
                    i.Data = j.Data;
                    j.Data = Temp;
                }
            }

            i = (i == null) ? left : i.NextNode;
            Clothes temp = i.Data;
            i.Data = right.Data;
            right.Data = temp;
            return i;
        }

        private void QuickSort(Node left, Node right, string criteria)
        {
            if(left != null && right != null && left != right  && left != right.NextNode)
            {
                Node pivot = Partition(left, right, criteria);
                QuickSort(left, pivot.PreNode, criteria);
                QuickSort(pivot.NextNode, right, criteria);
            }
        }

        public void UseQuickSort(string criteria)
        {

        }

        public void SelectionSort(string criteria, string opt)
        {
            if(IsEmpty())
            {
                MessageBox.Show("List is empty! Check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Node begin = head;
            if(opt == "i")
            {
                if(begin.NextNode == head)
                {
                    begin = null;
                }
                else
                {
                    do
                    {
                        Node minNode = begin;
                        Node temp = begin.NextNode;
                        do
                        {
                            if (ClothesSmallerComparison(temp.Data, minNode.Data, criteria))
                            {
                                minNode = temp;
                            }
                            temp = temp.NextNode;
                        } while (temp != head);

                        if (minNode != begin)
                        {
                            Clothes beginData = begin.Data;
                            begin.Data = minNode.Data;
                            minNode.Data = beginData;
                        }
                        begin = begin.NextNode;
                    }
                    while (begin != tail);
                }
            }
            else
            {
                if(begin.NextNode == head)
                {
                    begin = null;
                }
                else
                {
                    do
                    {
                        Node maxNode = begin;
                        Node temp = begin.NextNode;
                        do
                        {
                            if (!ClothesSmallerComparison(temp.Data, maxNode.Data, criteria))
                            {
                                maxNode = temp;
                            }
                            temp = temp.NextNode;
                        } while (temp != head);

                        if (maxNode != begin)
                        {
                            Clothes beginData = begin.Data;
                            begin.Data = maxNode.Data;
                            maxNode.Data = beginData;
                        }
                        begin = begin.NextNode;
                    }
                    while (begin != tail) ;
                }
            }
        }

        public CircularList LinearSearch(string criteria, Clothes clothes)
        {
            try
            {
                CircularList newList = new CircularList();
                Node begin = head;
                do
                {
                    if (ClothesEqualComparison(begin.Data, clothes, criteria))
                    {
                        Node tmp = new Node(begin.Data);
                        newList.InsertAtEnd(tmp);
                    }
                    begin = begin.NextNode;
                } while (begin != head);
                if (newList.IsEmpty())
                {
                    return null;
                }
                return newList;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void RemoveAll(string criteria, string value)
        {
            if (IsEmpty())
            {
                
                MessageBox.Show("The list is empty! Nothing to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Node current = head;
            Node start = head;
            bool deletedFirst = false;

            do
            {
                Node nextNode = current.NextNode;
                if (current.Data.CheckValue(criteria, value))
                {
                    if (current == head)
                    {
                        if (current.NextNode == head)
                        {
                            current = null;
                            head = null;
                            tail = null;
                            break;
                        }
                        else
                        {
                            head = current.NextNode;
                            head.PreNode = tail;
                            tail.NextNode = head;
                            current = null;
                            start = head;
                            deletedFirst = true;
                            continue;
                        }
                    }
                    else if (current == tail)
                    {
                        tail = current.PreNode;
                        tail.NextNode = head;
                        head.PreNode = tail;
                        current = null;
                    }
                    else
                    {
                        current.PreNode.NextNode = current.NextNode;
                        current.NextNode.PreNode = current.PreNode;
                        current = null;
                    }
                }
                current = nextNode;
            } while (current != start);

            if(head != null && head.NextNode  == head && head.Data.CheckValue(criteria, value))
            {
                head = null;
                tail = null;
            }
        }

        public CircularList MergeWith(CircularList b, string criteria)
        {
            this.SelectionSort(criteria, "i");
            b.SelectionSort(criteria, "i");

            CircularList mergedList = new CircularList(
                new Node(ClothesSmallerComparison(this.head.Data, b.head.Data, criteria) ? this.head.Data : b.head.Data));
            if(this.IsEmpty() && b.IsEmpty())
            {
                mergedList.head = null;
                mergedList.tail = null;
                return mergedList;
            }

            if (this.IsEmpty()) return b;
            if (b.IsEmpty()) return this;

            Node currentA;
            Node currentB;
            if(ClothesEqualComparison(mergedList.head.Data, this.head.Data, criteria))
            {
                currentA = this.head.NextNode;
                currentB = b.head;
            }
            else
            {
                currentA = this.head;
                currentB = b.head.NextNode;
            }

            do
            {
                if (ClothesSmallerComparison(currentA.Data, currentB.Data, criteria))
                {
                    mergedList.InsertAtEnd(new Node(currentA.Data));
                    currentA = currentA.NextNode;
                }
                else
                {
                    mergedList.InsertAtEnd(new Node(currentB.Data));
                    currentB = currentB.NextNode;
                }
            } while (currentA != this.head && currentB != b.head);

            while(currentA != this.head)
            {
                mergedList.InsertAtEnd(new Node(currentA.Data));
                currentA = currentA.NextNode;
            }

            while (currentB != b.head)
            {
                mergedList.InsertAtEnd(new Node(currentB.Data));
                currentB = currentB.NextNode;
            }
            return mergedList;
        }
    }
}
