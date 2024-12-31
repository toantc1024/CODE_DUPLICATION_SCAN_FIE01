using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectFinalDataStructure
{
    public class BSTNode
    {
        public int Key;
        public BSTNode Left;
        public BSTNode Right;

        public BSTNode(int key)
        {
            Key = key;
            Left = Right = null;
        }
    }

    internal class BinarySearchTree
    {
        public BSTNode Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int key)
        {
            Root = InsertRecursive(Root, key);
        }

        private BSTNode InsertRecursive(BSTNode node, int key)
        {
            if (node == null)
            {
                return new BSTNode(key);
            }

            if (key < node.Key)
            {
                node.Left = InsertRecursive(node.Left, key);
            }
            else if (key > node.Key)
            {
                node.Right = InsertRecursive(node.Right, key);
            }

            return node;
        }

        public bool Search(int key)
        {
            return SearchRecursive(Root, key);
        }

        private bool SearchRecursive(BSTNode node, int key)
        {
            if (node == null)
            {
                return false;
            }

            if (key == node.Key)
            {
                return true;
            }

            if (key < node.Key)
            {
                return SearchRecursive(node.Left, key);
            }
            else
            {
                return SearchRecursive(node.Right, key);
            }
        }

        
        public void InOrderTraversal(Action<string> addItemToList)
        {
            InOrderTraversalRecursive(Root, addItemToList);
        }

        private void InOrderTraversalRecursive(BSTNode node, Action<string> addItemToList)
        {
            if (node != null)
            {
                InOrderTraversalRecursive(node.Left, addItemToList);
                addItemToList(node.Key.ToString()); // Thêm vào ListBox hoặc Label
                InOrderTraversalRecursive(node.Right, addItemToList);
            }
        }

        
        public void Delete(int key)
        {
            Root = DeleteRecursive(Root, key);
        }

        private BSTNode DeleteRecursive(BSTNode root, int key)
        {
            if (root == null)
            {
                return root;
            }

            if (key < root.Key)
            {
                root.Left = DeleteRecursive(root.Left, key);
            }
            else if (key > root.Key)
            {
                root.Right = DeleteRecursive(root.Right, key);
            }
            else
            {
                if (root.Left == null)
                {
                    return root.Right;
                }
                else if (root.Right == null)
                {
                    return root.Left;
                }

                root.Key = MinValue(root.Right);
                root.Right = DeleteRecursive(root.Right, root.Key);
            }

            return root;
        }

        private int MinValue(BSTNode node)
        {
            int minValue = node.Key;
            while (node.Left != null)
            {
                minValue = node.Left.Key;
                node = node.Left;
            }
            return minValue;
        }

        
        public void DrawTree(Graphics g, BSTNode node, int x, int y, int deltaX)
        {
            if (node == null) return;

            g.FillEllipse(Brushes.LightBlue, x - 15, y - 15, 30, 30);
            g.DrawEllipse(Pens.Black, x - 15, y - 15, 30, 30);
            g.DrawString(node.Key.ToString(), new Font("Arial", 10), Brushes.Black, x - 10, y - 10);

            if (node.Left != null)
            {
                g.DrawLine(Pens.Black, x, y, x - deltaX, y + 50);
                DrawTree(g, node.Left, x - deltaX, y + 50, deltaX / 2);
            }

            if (node.Right != null)
            {
                g.DrawLine(Pens.Black, x, y, x + deltaX, y + 50);
                DrawTree(g, node.Right, x + deltaX, y + 50, deltaX / 2);
            }
        }

       
        public int CalculateHeight(BSTNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = CalculateHeight(node.Left);
            int rightHeight = CalculateHeight(node.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

        
        public int CountLeafNodes(BSTNode node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.Left == null && node.Right == null)
            {
                return 1; 
            }

            return CountLeafNodes(node.Left) + CountLeafNodes(node.Right);
        }

        public int CountBranchNodes(BSTNode node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.Left != null || node.Right != null)
            {
                return 1 + CountBranchNodes(node.Left) + CountBranchNodes(node.Right);
            }

            return 0;
        }

      
        public void PreOrderTraversal(Action<string> addItemToList)
        {
            PreOrderTraversalRecursive(Root, addItemToList);
        }

        private void PreOrderTraversalRecursive(BSTNode node, Action<string> addItemToList)
        {
            if (node != null)
            {
                addItemToList(node.Key.ToString());
                PreOrderTraversalRecursive(node.Left, addItemToList);
                PreOrderTraversalRecursive(node.Right, addItemToList);
            }
        }

        public void PostOrderTraversal(Action<string> addItemToList)
        {
            PostOrderTraversalRecursive(Root, addItemToList);
        }

        private void PostOrderTraversalRecursive(BSTNode node, Action<string> addItemToList)
        {
            if (node != null)
            {
                PostOrderTraversalRecursive(node.Left, addItemToList);
                PostOrderTraversalRecursive(node.Right, addItemToList);
                addItemToList(node.Key.ToString());
            }
        }
    }
}
