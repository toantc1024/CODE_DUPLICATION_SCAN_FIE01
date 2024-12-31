namespace BSTApp
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }

    public class BinarySearchTree
    {
        public TreeNode Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        // Thêm giá trị vào cây
        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private TreeNode InsertRec(TreeNode root, int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return root;
            }

            if (value < root.Value)
            {
                root.Left = InsertRec(root.Left, value);
            }
            else if (value > root.Value)
            {
                root.Right = InsertRec(root.Right, value);
            }

            return root;
        }

        // Tìm kiếm giá trị
        public bool Search(int value)
        {
            return SearchRec(Root, value);
        }

        private bool SearchRec(TreeNode root, int value)
        {
            if (root == null) return false;
            if (root.Value == value) return true;
            return value < root.Value ? SearchRec(root.Left, value) : SearchRec(root.Right, value);
        }

        // Duyệt cây theo thứ tự InOrder
        public string InOrderTraversal(TreeNode root)
        {
            if (root == null) return string.Empty;
            return InOrderTraversal(root.Left) + root.Value + " " + InOrderTraversal(root.Right);
        }

        public string InOrderTraversal()
        {
            return InOrderTraversal(Root).Trim();
        }
    }
}
