using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Queue
{
    public class Node
    {

        private string customerName;
        private string selectedCombos;
        public Node next;
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string SelectedCombos
        {
            get { return selectedCombos; }
            set { selectedCombos = value; }
        }
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public Node(string customerName, string selectedCombos)
        {
            CustomerName = customerName;
            SelectedCombos = selectedCombos;
            Next = null;
        }
    }
}
