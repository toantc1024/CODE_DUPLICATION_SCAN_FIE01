using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BST_Fiinal
{
    public class Node
    {
        private string word;
        private string meaning;
        private Node left, right;
        
        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        public string Meaning
        {
            get { return meaning; }
            set { meaning = value; }
        }

        public Node Left
        {
            get { return left;}
            set { left = value;}   
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

        public Node()
        {

        }
        public Node(string word, string meaning)
        {
            Word = word;
            Meaning = meaning;
            Left = Right = null;
        }
    }
}
