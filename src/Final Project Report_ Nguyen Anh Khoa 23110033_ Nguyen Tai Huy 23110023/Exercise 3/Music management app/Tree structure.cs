using System;

namespace MusicTree
{

    class Node
    {
        public int Key; // Song length
        public string Title;
        public string Artist;
        public Node Left, Right;

        public Node(int key, string title, string artist)
        {
            Key = key;
            Title = title;
            Artist = artist;
            Left = Right = null;
        }
    }

    class MusicBST
    {
        private Node root;

        public void Insert(int key, string title, string artist)
        {
            root = InsertRec(root, key, title, artist);
        }

        private Node InsertRec(Node root, int key, string title, string artist)
        {
            if (root == null)
                return new Node(key, title, artist);

            if (key < root.Key)
                root.Left = InsertRec(root.Left, key, title, artist);
            else if (key > root.Key)
                root.Right = InsertRec(root.Right, key, title, artist);

            return root;
        }

        public bool Remove(int key)
        {
            if (Search(key) == null)
                return false;

            root = RemoveRec(root, key);
            return true;
        }

        private Node RemoveRec(Node root, int key)
        {
            if (root == null) return root;

            if (key < root.Key)
                root.Left = RemoveRec(root.Left, key);
            else if (key > root.Key)
                root.Right = RemoveRec(root.Right, key);
            else
            {
                // Node with only one child or no child
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                // Node with two children: Get the inorder successor (smallest in the right subtree)
                root.Key = MinValue(root.Right);
                root.Right = RemoveRec(root.Right, root.Key);
            }
            return root;
        }

        private int MinValue(Node root)
        {
            int minValue = root.Key;
            while (root.Left != null)
            {
                minValue = root.Left.Key;
                root = root.Left;
            }
            return minValue;
        }

        public void InOrder()
        {
            InOrderRec(root);
        }

        public Node Search(int key)
        {
            return SearchRec(root, key);
        }

        private Node SearchRec(Node root, int key)
        {
            if (root == null || root.Key == key)
                return root;

            if (key < root.Key)
                return SearchRec(root.Left, key);

            return SearchRec(root.Right, key);
        }

        private void InOrderRec(Node root)
        {
            if (root != null)
            {
                InOrderRec(root.Left);
                string formattedLength = ConvertLengthToMinutes(root.Key);
                Console.WriteLine($"Length: {formattedLength} | Title: {root.Title} | Artist: {root.Artist}");
                InOrderRec(root.Right);
            }
        }

        private string ConvertLengthToMinutes(int totalSeconds)
        {
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            return $"{minutes}:{seconds:D2}";
        }
    }
}
