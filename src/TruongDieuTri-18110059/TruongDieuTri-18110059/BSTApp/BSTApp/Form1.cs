using System;
using System.Windows.Forms;

namespace BSTApp
{
    public partial class Form1 : Form
    {
        private BinarySearchTree bst;

        public Form1()
        {
            InitializeComponent();
            bst = new BinarySearchTree();
        }

        // Thêm giá trị vào BST
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtInput.Text);
                bst.Insert(value);
                txtInput.Clear();
                MessageBox.Show("Value inserted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        // Tìm kiếm giá trị trong BST
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtInput.Text);
                bool found = bst.Search(value);
                MessageBox.Show(found ? "Value found!" : "Value not found.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        // Duyệt cây theo thứ tự InOrder
        private void btnInOrder_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            bst.InOrderTraversal(bst.Root);
        }
    }
}
