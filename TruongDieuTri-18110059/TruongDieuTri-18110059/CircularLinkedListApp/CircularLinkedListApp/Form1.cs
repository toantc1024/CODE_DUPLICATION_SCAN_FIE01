using System;
using System.Windows.Forms;

namespace CircularLinkedListApp
{
    public partial class Form1 : Form
    {
        private CircularLinkedList list;

        public Form1()
        {
            InitializeComponent();
            list = new CircularLinkedList();
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                list.InsertAtBeginning(value);
                DisplayList();
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                list.InsertAtEnd(value);
                DisplayList();
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            list.RemoveFirst();
            DisplayList();
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            list.RemoveLast();
            DisplayList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int value))
            {
                bool found = list.Search(value);
                MessageBox.Show(found ? "Tìm thấy giá trị." : "Không tìm thấy giá trị.");
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void DisplayList()
        {
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add(list.PrintList());
        }
    }
}
