using BinarySearchTreeApp;
using System;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BinarySearchTreeApp
{
    public partial class MainForm : Form
    {
        private BinaryTree binaryTree;
        private int displayMode = 0; // 0: In-order, 1: Pre-order, 2: Post-order
        public MainForm()
        {
            InitializeComponent();
            binaryTree = new BinaryTree();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // Xóa các thông báo trước đó
            ClearStatusMessages();

            int maxLevel = 4; // Giới hạn độ sâu của cây

            // Kiểm tra đầu vào
            if (int.TryParse(txtInput.Text, out int value))
            {
                // Kiểm tra giá trị trùng lặp
                if (binaryTree.Find(value) != null)
                {
                    lblStatus.Text = $"Value {value} already exists in the tree.";
                    return;
                }

                // Chèn giá trị vào cây
                if (binaryTree.Insert(value, maxLevel))
                {
                    lblStatus.Text = $"Inserted {value} into the tree.";
                    DisplayTree(); // Hiển thị cây trên giao diện
                }
                else
                {
                    lblStatus.Text = $"Cannot insert {value}: Max depth ({maxLevel}) reached or position invalid.";
                }
            }
            else
            {
                lblStatus.Text = "Invalid input! Please enter an integer.";
            }
        }

        // Hàm xóa thông báo
        private void ClearStatusMessages()
        {
            lblStatus.Text = ""; // Xóa thông báo cũ
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                binaryTree.Remove(value);
                lblStatus.Text = $"Removed {value} from the tree.";
                DisplayTree();
            }
            else
            {
                lblStatus.Text = "Invalid input! Please enter an integer.";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                TreeNode node = binaryTree.Find(value);
                lblStatus.Text = node != null ? $"Found {value} " : $"{value} not found.";
            }
            else
            {
                lblStatus.Text = "Invalid input! Please enter an integer.";
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            switch (displayMode)
            {
                case 0:
                    lblStatus.Text = "In-order traversal: " + binaryTree.InOrderTraversal();
                    break;
                case 1:
                    lblStatus.Text = "Pre-order traversal: " + binaryTree.PreOrderTraversal();
                    break;
                case 2:
                    lblStatus.Text = "Post-order traversal: " + binaryTree.PostOrderTraversal();
                    break;
            }

            displayMode = (displayMode + 1) % 3;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            binaryTree = new BinaryTree();
            lblStatus.Text = "Tree has been reset.";
            ClearBSTBoxes();
        }

        private void btnFindMin_Click(object sender, EventArgs e)
        {
            int? min = binaryTree.Smallest();
            lblStatus.Text = min.HasValue ? $"Min value: {min.Value}" : "Tree is empty.";
        }

        private void btnFindMax_Click(object sender, EventArgs e)
        {
            int? max = binaryTree.Largest();
            lblStatus.Text = max.HasValue ? $"Max value: {max.Value}" : "Tree is empty.";
        }

        private void btnPredecessor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                TreeNode node = binaryTree.Find(value);
                if (node != null)
                {
                    TreeNode predecessor = FindPredecessor(binaryTree.Root, node);
                    lblStatus.Text = predecessor != null ? $"Predecessor of {value}: {predecessor.Data}" : $"No predecessor found for {value}.";
                }
                else
                {
                    lblStatus.Text = $"{value} not found in the tree.";
                }
            }
            else
            {
                lblStatus.Text = "Invalid input! Please enter an integer.";
            }
        }

        private void btnSuccessor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                TreeNode node = binaryTree.Find(value);
                if (node != null)
                {
                    TreeNode successor = FindSuccessor(binaryTree.Root, node);
                    lblStatus.Text = successor != null ? $"Successor of {value}: {successor.Data}" : $"No successor found for {value}.";
                }
                else
                {
                    lblStatus.Text = $"{value} not found in the tree.";
                }
            }
            else
            {
                lblStatus.Text = "Invalid input! Please enter an integer.";
            }
        }

        private void DisplayTree()
        {
            ClearBSTBoxes();

            StringBuilder displayMessage = new StringBuilder();

            if (!FillBSTBoxes(binaryTree.Root, 0, 14, 0, 0, displayMessage))
            {
                lblStatus.Text = displayMessage.ToString() + "\nSome values could not be displayed due to invalid positions.";
            }
            else
            {
                lblStatus.Text = displayMessage.ToString() + "\nTree displayed successfully.";
            }
        }


        private void ClearBSTBoxes()
        {
            txtBox0.Clear();
            txtBox1.Clear();
            txtBox2.Clear();
            txtBox3.Clear();
            txtBox4.Clear();
            txtBox5.Clear();
            txtBox6.Clear();
            txtBox7.Clear();
            txtBox8.Clear();
            txtBox9.Clear();
            txtBox10.Clear();
            txtBox11.Clear();
            txtBox12.Clear();
            txtBox13.Clear();
            txtBox14.Clear();
        }
        private bool FillBSTBoxes(TreeNode node, int start, int end, int level, int pos, StringBuilder displayMessage)
        {
            if (node == null) return true;

            int mid = (start + end) / 2;
            string positionMessage = $" (level {level}, position {pos})";

            if (!InsertValueInTextBox(node, mid, level, pos, displayMessage, positionMessage))
            {
                return false;
            }

            bool leftInsert = FillBSTBoxes(node.LeftNode, start, mid - 1, level + 1, pos * 2, displayMessage);
            bool rightInsert = FillBSTBoxes(node.RightNode, mid + 1, end, level + 1, pos * 2 + 1, displayMessage);

            return leftInsert && rightInsert;
        }

        private bool InsertValueInTextBox(TreeNode node, int mid, int level, int pos, StringBuilder displayMessage, string positionMessage)
        {
            System.Windows.Forms.TextBox[] textBoxes = {
        txtBox7, txtBox3, txtBox8, txtBox1, txtBox9, txtBox4, txtBox10, txtBox0,
        txtBox11, txtBox5, txtBox12, txtBox2, txtBox13, txtBox6, txtBox14
    };

            System.Windows.Forms.TextBox targetBox = textBoxes[mid];

            if (string.IsNullOrEmpty(targetBox.Text))
            {
                targetBox.Text = node == binaryTree.Root ? node.Data + "(root)" : node.Data.ToString();
                displayMessage.AppendLine($"Inserted {node.Data} at level {level}, position {pos}.");
                return true;
            }
            else
            {
                displayMessage.AppendLine($"Cannot insert {node.Data}, position already contains {targetBox.Text}{positionMessage}.");
                return false;
            }
        }

        private TreeNode FindPredecessor(TreeNode root, TreeNode node)
        {
            TreeNode predecessor = null;
            TreeNode current = root;

            while (current != null)
            {
                if (node.Data > current.Data)
                {
                    predecessor = current;
                    current = current.RightNode;
                }
                else if (node.Data < current.Data)
                {
                    current = current.LeftNode;
                }
                else
                {
                    if (current.LeftNode != null)
                    {
                        predecessor = current.LeftNode;
                        while (predecessor.RightNode != null)
                        {
                            predecessor = predecessor.RightNode;
                        }
                    }
                    break;
                }
            }
            return predecessor;
        }

        private TreeNode FindSuccessor(TreeNode root, TreeNode node)
        {
            TreeNode successor = null;
            TreeNode current = root;

            while (current != null)
            {
                if (node.Data < current.Data)
                {
                    successor = current;
                    current = current.LeftNode;
                }
                else if (node.Data > current.Data)
                {
                    current = current.RightNode;
                }
                else
                {
                    if (current.RightNode != null)
                    {
                        successor = current.RightNode;
                        while (successor.LeftNode != null)
                        {
                            successor = successor.LeftNode;
                        }
                    }
                    break;
                }
            }
            return successor;
        }
    }
}
