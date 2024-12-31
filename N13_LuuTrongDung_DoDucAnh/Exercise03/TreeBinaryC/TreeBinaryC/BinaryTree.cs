using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeBinaryC
{
    public class BinaryTree
    {
        public Node CreateNode(string value) => new Node(value);

        public void InsertNode(ref Node root, Node node)
        {
            if (root == null)
            {
                root = node;
            }
            else if (string.Compare(root.Key, node.Key, StringComparison.OrdinalIgnoreCase) > 0)
            {
                InsertNode(ref root.Left, node);
            }
            else
            {
                InsertNode(ref root.Right, node);
            }
        }

        public Node SearchNode(Node root, string value)
        {
            if (root == null || root.Key.Equals(value, StringComparison.OrdinalIgnoreCase))
                return root;

            return string.Compare(root.Key, value, StringComparison.OrdinalIgnoreCase) > 0
                ? SearchNode(root.Left, value)
                : SearchNode(root.Right, value);
        }

        public Node FindMin(Node root)
        {
            while (root.Left != null)
                root = root.Left;
            return root;
        }

        public void DeleteNode(ref Node root, string key)
        {
            if (root == null) return;

            if (string.Compare(key, root.Key, StringComparison.OrdinalIgnoreCase) < 0)
            {
                DeleteNode(ref root.Left, key);
            }
            else if (string.Compare(key, root.Key, StringComparison.OrdinalIgnoreCase) > 0)
            {
                DeleteNode(ref root.Right, key);
            }
            else
            {
                if (root.Left == null && root.Right == null)
                    root = null;
                else if (root.Left == null)
                    root = root.Right;
                else if (root.Right == null)
                    root = root.Left;
                else
                {
                    Node temp = FindMin(root.Right);
                    root.Key = temp.Key;
                    DeleteNode(ref root.Right, temp.Key);
                }
            }
        }

        public void PreOrder(Node root, Action<string> action)
        {
            if (root == null) return;

            action(root.Key);
            PreOrder(root.Left, action);
            PreOrder(root.Right, action);
        }

        public void InOrder(Node root, Action<string> action)
        {
            if (root == null) return;

            InOrder(root.Left, action);
            action(root.Key);
            InOrder(root.Right, action);
        }

        public void PostOrder(Node root, Action<string> action)
        {
            if (root == null) return;

            PostOrder(root.Left, action);
            PostOrder(root.Right, action);
            action(root.Key);
        }
    }
}
