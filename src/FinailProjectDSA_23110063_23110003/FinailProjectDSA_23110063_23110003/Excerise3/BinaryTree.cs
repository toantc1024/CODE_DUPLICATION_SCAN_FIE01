using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSTFinalProject
{
    internal class BinaryTree
    {
        public TreeNode Root { get; private set; }

        private const int MaxHeight = 5; 
        public BinaryTree()
        {
            Root = null;
        }

        //Check BTS is empty
        public int IsEmptyTree(TreeNode root)
        {
            if (root == null) return 1;
            if (IsEmptyTree(root.Left) * IsEmptyTree(root.Right) == 0)
                return 1;
            return 0;
        }

        // Insert the node to BST
        
        public void InsertNode(Account account)
        {
            if (GetHeight(Root) >= MaxHeight)
            {
                MessageBox.Show($"Cannot insert {account.AccountID}. Maximum tree height of {MaxHeight} reached.", "Error");
                return;
            }

            Root = InsertNodeInternal(Root, new TreeNode(account));
        }
        private TreeNode InsertNodeInternal(TreeNode root, TreeNode newNode)
        {
            if (root == null) return newNode;

            if (newNode.Key.AccountID  < root.Key.AccountID)
            {
                root.Left = InsertNodeInternal(root.Left, newNode);
            }
            else if (newNode.Key.AccountID > root.Key.AccountID)
            {
                root.Right = InsertNodeInternal(root.Right, newNode);
            }
            return root;
        }

        // The Height of BST
        public int GetHeight(TreeNode root)
        {
            if (root == null)
                return 0;

            int leftHeight = GetHeight(root.Left);
            int rightHeight = GetHeight(root.Right);

            return Math.Max(leftHeight, rightHeight) + 1;
        }
        // Delete the node of the BST
        public void DeleteNode(int accountId)
        {
            Root = DeleteNodeInternal(Root, accountId);
        }

        private TreeNode DeleteNodeInternal(TreeNode root, int accountId)
        {
            if (root == null) return null;

            if (accountId < root.Key.AccountID)
            {
                root.Left = DeleteNodeInternal(root.Left, accountId);
            }
            else if (accountId > root.Key.AccountID)
            {
                root.Right = DeleteNodeInternal(root.Right, accountId);
            }
            else
            {
                if (root.Left == null) return root.Right;
                if (root.Right == null) return root.Left;

                TreeNode minNode = FindMin(root.Right);
                root.Key = minNode.Key;
                root.Right = DeleteNodeInternal(root.Right, minNode.Key.AccountID);
            }
            return root;
        }

        //Search node in BST
        public TreeNode SearchNode(TreeNode root, int accountId)
        {
            if (root == null || root.Key.AccountID == accountId) return root;

            if (accountId < root.Key.AccountID)
            {
                return SearchNode(root.Left, accountId);
            }
            else
            {
                return SearchNode(root.Right, accountId);
            }
        }

        // Some ways to arrange trees
        public void PreOrder(TreeNode root, Action<Account> action )
        {
            if (root != null)
            {
                action(root.Key); 
                PreOrder(root.Left, action); 
                PreOrder(root.Right, action); 
            }
        }
        public void InOrder(TreeNode root, Action<Account> action)
        {
            if (root != null)
            {
                InOrder(root.Left, action); 
                action(root.Key);           
                InOrder(root.Right, action); 
            }
        }

        public void PostOrder(TreeNode root, Action<Account> action)
        {
            if (root != null)
            {
                PostOrder(root.Left, action); 
                PostOrder(root.Right, action); 
                action(root.Key);              
            }
        }

        // Find Min Node in BST
        public TreeNode FindMin(TreeNode root)
        {
            while (root.Left != null)
            {
                root = root.Left;
            }
            return root;
        }
        // Find Max Node in BST

        public TreeNode FindMax(TreeNode root)
        {
            while (root.Right != null)
            {
                root = root.Right;
            }
            return root;
        }

    }
}
