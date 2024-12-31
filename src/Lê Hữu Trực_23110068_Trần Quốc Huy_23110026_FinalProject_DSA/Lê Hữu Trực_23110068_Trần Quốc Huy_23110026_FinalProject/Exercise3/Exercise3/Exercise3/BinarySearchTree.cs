using System;
using System.Collections.Generic;

namespace Exercise3
{
    internal class BinarySearchTree
    {
        public Node Root { get; private set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(Book book)
        {
            Root = InsertRecursively(Root, book);
        }

        private Node InsertRecursively(Node root, Book book)
        {
            if (root == null)
                return new Node(book);

            if (string.Compare(book.Id, root.Data.Id, StringComparison.Ordinal) < 0)
                root.Left = InsertRecursively(root.Left, book);
            else if (string.Compare(book.Id, root.Data.Id, StringComparison.Ordinal) > 0)
                root.Right = InsertRecursively(root.Right, book);

            return root;
        }

        public Node Search(string id)
        {
            return SearchRecursively(Root, id);
        }

        private Node SearchRecursively(Node root, string id)
        {
            if (root == null || root.Data.Id == id)
                return root;

            if (string.Compare(id, root.Data.Id, StringComparison.Ordinal) < 0)
                return SearchRecursively(root.Left, id);

            return SearchRecursively(root.Right, id);
        }
        public void Delete(string id)
        {
            Root = DeleteRecursively(Root, id);
        }
        private Node DeleteRecursively(Node root, string id)
        {
            if (root == null)
                return root;

            if (string.Compare(id, root.Data.Id, StringComparison.Ordinal) < 0)
                root.Left = DeleteRecursively(root.Left, id);
            else if (string.Compare(id, root.Data.Id, StringComparison.Ordinal) > 0)
                root.Right = DeleteRecursively(root.Right, id);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Data = FindMin(root.Right).Data;
                root.Right = DeleteRecursively(root.Right, root.Data.Id);
            }

            return root;
        }
        private Node FindMin(Node root)
        {
            while (root.Left != null)
                root = root.Left;

            return root;
        }
    }
}