using System;
using System.Text;

namespace BinarySearchTreeApp
{
    public class TreeNode
    {
        //property to store the nodes data could be a key and object pair
        public int Data { get; private set; }

        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        } //Right Child

        private TreeNode leftNode;
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        } //Left Child

        private bool isDeleted; //soft delete variable
        public bool IsDeleted
        {
            get { return isDeleted; }
        }

        //Node constructor
        public TreeNode(int value)
        {
            Data = value;
        }

        //Method to set soft delete
        public void Delete()
        {
            isDeleted = true;
        }

        public TreeNode Find(int value)
        {
            TreeNode currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.Data && !isDeleted)
                {
                    return currentNode;
                }
                else if (value > currentNode.Data)
                {
                    currentNode = currentNode.RightNode;
                }
                else
                {
                    currentNode = currentNode.LeftNode;
                }
            }
            return null;
        }

        public TreeNode FindRecursive(int value)
        {
            //value passed in matches nodes data return the node
            if (value == Data && isDeleted == false)
            {
                return this;
            }
            else if (value < Data && leftNode != null) //if the value passed in is less than the current data then go to the left child
            {
                return leftNode.FindRecursive(value);
            }
            else if (rightNode != null) //if it's greater, then go to the right child node
            {
                return rightNode.FindRecursive(value);
            }
            else
            {
                return null;
            }
        }

        //recursively calls insert down the tree until it finds an open spot
        public bool Insert(int value, int maxLevel, int currentLevel)
        {
            // Kiểm tra mức giới hạn
            if (currentLevel >= maxLevel)
            {
                return false; // Không thể thêm nếu đã đạt đến giới hạn mức
            }

            // Kiểm tra trùng lặp
            if (value == Data)
            {
                return false; // Giá trị đã tồn tại
            }

            // Chèn vào cây con bên phải
            if (value > Data)
            {
                if (RightNode == null)
                {
                    RightNode = new TreeNode(value);
                    return true; // Chèn thành công
                }
                else
                {
                    return RightNode.Insert(value, maxLevel, currentLevel + 1); // Đệ quy tăng mức
                }
            }
            // Chèn vào cây con bên trái
            else
            {
                if (LeftNode == null)
                {
                    LeftNode = new TreeNode(value);
                    return true; // Chèn thành công
                }
                else
                {
                    return LeftNode.Insert(value, maxLevel, currentLevel + 1); // Đệ quy tăng mức
                }
            }
        }

        private int GetLevel(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftLevel = GetLevel(node.LeftNode);
            int rightLevel = GetLevel(node.RightNode);

            return Math.Max(leftLevel, rightLevel) + 1;
        }


        public Nullable<int> SmallestValue()
        {
            // once we reach the last left node we return its data
            if (leftNode == null)
            {
                return Data;
            }
            else
            {
                //otherwise keep calling the next left node
                return leftNode.SmallestValue();
            }
        }

        internal Nullable<int> LargestValue()
        {
            // once we reach the last right node we return its data
            if (rightNode == null)
            {
                return Data;
            }
            else
            {
                //otherwise keep calling the next right node
                return rightNode.LargestValue();
            }
        }

        //Number return in ascending order
        //Left->Root->Right Nodes recursively of each subtree 
        public void InOrderTraversal(StringBuilder result, bool isRoot)
        {
            if (LeftNode != null)
                LeftNode.InOrderTraversal(result, false);

            result.Append(isRoot ? Data + "(root) " : Data + " ");

            if (RightNode != null)
                RightNode.InOrderTraversal(result, false);
        }

        //Root->Left->Right Nodes recursively of each subtree 
        public void PreOrderTraversal(StringBuilder result, bool isRoot)
        {
            result.Append(isRoot ? Data + "(root) " : Data + " ");

            if (LeftNode != null)
                LeftNode.PreOrderTraversal(result, false);

            if (RightNode != null)
                RightNode.PreOrderTraversal(result, false);
        }

        //Left->Right->Root Nodes recursively of each subtree 
        public void PostOrderTraversal(StringBuilder result, bool isRoot)
        {
            if (LeftNode != null)
                LeftNode.PostOrderTraversal(result, false);

            if (RightNode != null)
                RightNode.PostOrderTraversal(result, false);

            result.Append(isRoot ? Data + "(root) " : Data + " ");
        }

        public int Height()
        {
            //return 1 when leaf node is found
            if (this.LeftNode == null && this.RightNode == null)
            {
                return 1; //found a leaf node
            }

            int left = 0;
            int right = 0;

            //recursively go through each branch
            if (this.LeftNode != null)
                left = this.LeftNode.Height();
            if (this.RightNode != null)
                right = this.RightNode.Height();

            //return the greater height of the branch
            if (left > right)
            {
                return (left + 1);
            }
            else
            {
                return (right + 1);
            }
        }

        public int NumberOfLeafNodes()
        {
            //return 1 when leaf node is found
            if (this.LeftNode == null && this.RightNode == null)
            {
                return 1; //found a leaf node
            }

            int leftLeaves = 0;
            int rightLeaves = 0;

            //recursively call NumOfLeafNodes returning 1 for each leaf found
            if (this.LeftNode != null)
            {
                leftLeaves = LeftNode.NumberOfLeafNodes();
            }
            if (this.RightNode != null)
            {
                rightLeaves = RightNode.NumberOfLeafNodes();
            }

            //add values together 
            return leftLeaves + rightLeaves;
        }

        public bool IsBalanced()
        {
            int leftHeight = LeftNode != null ? LeftNode.Height() : 0;
            int rightHeight = RightNode != null ? RightNode.Height() : 0;
            int heightDifference = leftHeight - rightHeight;

            if (Math.Abs(heightDifference) > 1)
            {
                return false;
            }
            else
            {
                return ((LeftNode != null ? LeftNode.IsBalanced() : true) && (RightNode != null ? RightNode.IsBalanced() : true));
            }
        }
    }
}
