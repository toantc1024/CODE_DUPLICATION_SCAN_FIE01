using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinal2
{
    internal class CircularLinkedList
    {
        private Node head;

        public CircularLinkedList()
        {
            head = null;
        }

        public void Initialize()
        {
            head = null;
        }

        public Node CreateNode(Book data)
        {
            return new Node(data);
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void InsertAtBeginning(Book data)
        {
            Node newNode = CreateNode(data);
            if (head == null)
            {
                head = newNode;
                head.next = head;
            }
            else
            {
                Node temp = head;
                while (temp.next != head)
                {
                    temp = temp.next;
                }
                newNode.next = head;
                temp.next = newNode;
                head = newNode;
            }
        }

        public void InsertAtEnd(Book data)
        {
            Node newNode = CreateNode(data);
            if (head == null)
            {
                head = newNode;
                head.next = head;
            }
            else
            {
                Node temp = head;
                while (temp.next != head)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                newNode.next = head;
            }
        }

        public void InsertAfter(Node prevNode, Book data)
        {
            if (prevNode == null)
            {
                MessageBox.Show("The given node cannot be null.");
                return;
            }
            Node newNode = CreateNode(data);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }

        public void RemoveFirst()
        {
            if (head == null) return;
            if (head.next == head)
            {
                head = null;
                return;
            }
            Node temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }
            head = head.next;
            temp.next = head;
        }

        public void RemoveLast()
        {
            if (head == null) return;
            if (head.next == head)
            {
                head = null;
                return;
            }
            Node temp = head;
            while (temp.next.next != head)
            {
                temp = temp.next;
            }
            temp.next = head;
        }

        public void RemoveAfter(Node prevNode)
        {
            if (prevNode == null || prevNode.next == head)
            {
                MessageBox.Show("Invalid operation.");
                return;
            }
            prevNode.next = prevNode.next.next;
        }

        public void RemoveAllByCriteria(Func<Book, bool> criteria)
        {
            if (head == null) return;

            while (head != null && criteria(head.data))
            {
                if (head.next == head)
                {
                    head = null;  
                    return;
                }
                Node last = head;
                while (last.next != head)
                {
                    last = last.next;
                }
                head = head.next;
                last.next = head;
            }

            if (head == null) return;  

         
            Node current = head;
            while (current.next != head)
            {
                if (criteria(current.next.data))
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
        }
        public Node Search(string title)
        {
            if (head == null) return null;
            Node temp = head;
            do
            {
                if (temp.data._title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    return temp;
                temp = temp.next;
            } while (temp != head);
            return null;
        }

        public void SearchByCriteria(Func<Book, bool> criteria, ListBox listBox)
        {
            listBox.Items.Clear();
            if (head == null) return;
            Node temp = head;
            do
            {
                if (criteria(temp.data))
                    listBox.Items.Add(temp.data);
                temp = temp.next;
            } while (temp != head);
        }


        public void PrintList(ListBox listBox)
        {
            listBox.Items.Clear();
            if (head == null)
            {
                listBox.Items.Add("List is empty.");
                return;
            }
            Node temp = head;
            do
            {
                listBox.Items.Add(temp.data);
                temp = temp.next;
            } while (temp != head);
        }

        public void SortByTitle()
        {
            if (head == null) return;
            Node current = head;
            do
            {
                Node index = current.next;
                while (index != head)
                {
                    if (string.Compare(current.data._title, index.data._title) > 0)
                    {
                        Book temp = current.data;
                        current.data = index.data;
                        index.data = temp;
                    }
                    index = index.next;
                }
                current = current.next;
            } while (current != head);
        }
    }
}