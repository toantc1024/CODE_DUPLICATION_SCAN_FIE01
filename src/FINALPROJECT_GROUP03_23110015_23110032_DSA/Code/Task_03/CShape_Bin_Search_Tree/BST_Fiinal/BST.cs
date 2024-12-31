using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST_Fiinal
{
    class BinarySearchTree
    {
        private Node root;
        public Node Root {
            get { return root; }
            set { root = value; }
        }

        public BinarySearchTree()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }
        public void Insert(string word, string meaning)
        {
            Node newNode = new Node(word, meaning);
            root = InsertRec(root, word, meaning);
        }

        Node InsertRec(Node root, string word, string meaning)
        {
            if (root == null)
            {
                return new Node(word, meaning);
            }

            if (string.Compare(word, root.Word, true) < 0)
            {
                root.Left = InsertRec(root.Left, word, meaning);
            }
            else if (string.Compare(word, root.Word, true) > 0)
            {
                root.Right = InsertRec(root.Right, word, meaning);
            }

            return root;
        }

        public string DisplayInOrder()
        {
            string infor = "";
            InOrderRec(root, ref infor);
            return infor;
        }

        public void InOrderRec(Node root, ref string infor)
        {           
            if (root != null)
            {
                InOrderRec(root.Left, ref infor);
                infor += (root.Word + ": " + root.Meaning + ";");
                InOrderRec(root.Right, ref infor);
            }
        }

        public string Search(string word)
        {
            Node newNode = SearchRec(root, word);
            return newNode != null ? newNode.Meaning : "empty";
        }

        Node SearchRec(Node root, string word)
        {
            if (root == null || String.Compare(root.Word, word, true) == 0)
            {
                return root;
            }

            if (string.Compare(word, root.Word, true) < 0)
            {
                return SearchRec(root.Left, word);
            }

            else
            {
                return SearchRec(root.Right, word);
            }
        }

        public void Delete(string word)
        {
            if(Search(word) == "empty")
            {
                MessageBox.Show("The word does not exit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                root = DeleteRec(root, word);
            }
        }

        private Node DeleteRec(Node root, string word)
        {
            if (root == null) return null;

            if(String.Compare(word, root.Word, true) < 0)
            {
                root.Left = DeleteRec(root.Left, word);
            }
            else if(String.Compare(word, root.Word, true) > 0) {
                root.Right = DeleteRec(root.Right, word);
            }
            else
            {
                if (root.Left == null && root.Right == null) return null;

                if (root.Left == null) return root.Right;

                if (root.Right == null) return root.Left;

                Node minNode = FindMin(root.Right);
                root.Word = minNode.Word;
                root.Meaning = minNode.Meaning;
                root.Right = DeleteRec(root.Right, minNode.Word);
            }
            return root;
        }

        private Node FindMin(Node root)
        {
            root = root.Right;
            while (root != null && root.Left != null)
            {
                root = root.Left;
            }
            return root;
        }
    }
}

