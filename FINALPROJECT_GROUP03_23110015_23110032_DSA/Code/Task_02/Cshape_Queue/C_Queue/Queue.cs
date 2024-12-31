using System.Collections.Generic;
using System.Windows.Forms;

namespace C_Queue
{
  
    public class LinkedListQueue
    {
        private Node head;
        private Node tail;

        public LinkedListQueue()
        {
            head = null;
            tail = null;
        }

        public void AddLast(string customerName, string selectedCombos)
        {
            Node newNode = new Node(customerName, selectedCombos);
            if (tail != null)
            {
                tail.Next = newNode;
                tail = newNode;
            }
            else
            {
                head = tail = newNode;
            }
        }

        public bool IsEmptyList()
        {
            return head == null;            
        }

        public Node RemoveFirst()
        {
            if (IsEmptyList()) {
                MessageBox.Show("List is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            string customerName = head.CustomerName;
            string selectedCombos = head.SelectedCombos;
            head = head.Next;
            if (head == null) tail = null;
            Node newNode = new Node(customerName, selectedCombos);
            return newNode;
        }

        public List<(string CustomerName, string SelectedCombos)> GetListValues()
        {
            List<(string CustomerName, string SelectedCombos)> values = new List<(string CustomerName, string SelectedCombos)>();
            Node current = head;
            while (current != null)
            {
                values.Add((current.CustomerName, current.SelectedCombos));
                current = current.Next;
            }
            return values;
        }
    }
}
