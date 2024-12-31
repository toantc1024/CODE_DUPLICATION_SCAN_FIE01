using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Linked_List
{
    public class Node
    {
        private Clothes data;
        private Node nextNode;
        private Node preNode;
        public Clothes Data
        {
            get => data;
            set => data = value;
        }
        public Node NextNode
        {
            get => nextNode;
            set => nextNode = value;
        }
        public Node PreNode
        {
            get => preNode;
            set => preNode = value;
        }
        public Node(Clothes data)
        {
            this.data = data;
            nextNode = null;
            preNode = null;
        }
    }
}
