using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalDataStructure
{
    public partial class TreeForm : Form
    {
        private BinarySearchTree bst;
        public TreeForm()
        {
            InitializeComponent();
        }

        private void TreeForm_Load(object sender, EventArgs e)
        {
            bst = new BinarySearchTree();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInsert.Text, out int value))
            {
                bst.Insert(value);

                textBoxInsert.Clear();
                this.Invalidate(); // Yêu cầu vẽ lại cây sau khi chèn node
                int leafNodes = bst.CountLeafNodes(bst.Root);
                lblLeafNodes.Text = "Leaf Nodes: " + leafNodes;
                int height = bst.CalculateHeight(bst.Root);
                lblHeight.Text = "Tree Height: " + height;
                int branchNodes = bst.CountBranchNodes(bst.Root);
                lblBranchNodes.Text = "Branch Nodes: " + branchNodes;

            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            bst.DrawTree(e.Graphics, bst.Root, 400, 50, 150);
        }

        private void textBoxInsert_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(textBoxInsert.Text);
            bool found = bst.Search(key);
            MessageBox.Show(found ? "Node found!" : "Node not found!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int leafNodes = bst.CountLeafNodes(bst.Root);
            lblLeafNodes.Text = "Leaf Nodes: " + leafNodes; ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int branchNodes = bst.CountBranchNodes(bst.Root);
            lblBranchNodes.Text = "Branch Nodes: " + branchNodes;
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            lstTraversalResults.Items.Clear();
            bst.PreOrderTraversal(item => lstTraversalResults.Items.Add(item));
        }

        private void btnInOrder_Click(object sender, EventArgs e)
        {
            lstTraversalResults.Items.Clear();
            bst.InOrderTraversal(item => lstTraversalResults.Items.Add(item));
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            lstTraversalResults.Items.Clear();
            bst.PostOrderTraversal(item => lstTraversalResults.Items.Add(item));
        }

        private void button3_Click(object sender, EventArgs e)
        {



            if (int.TryParse(textBoxInsert.Text, out int value))
            {
                bst.Delete(value);

                textBoxInsert.Clear();
                this.Invalidate(); // Yêu cầu vẽ lại cây sau khi chèn node
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }

        }

        private void Height_Click(object sender, EventArgs e)
        {
            int height = bst.CalculateHeight(bst.Root);
            lblHeight.Text = "Tree Height: " + height;
        }
    }
}
