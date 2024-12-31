using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excerise1_B
{
    public partial class Form1 : Form
    {
        public CoffeeList coffeeList;
        public Form1()
        {
            InitializeComponent();
            coffeeList = new CoffeeList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int cost = int.Parse(txtCost.Text);
            coffeeList.InsertAtTheEnd(name, cost);
            UpdateList();
        }

        private void btAddFirst_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int cost = int.Parse(txtCost.Text);
            coffeeList.InsertAtTheBeginning(name, cost);
            UpdateList();
        }

        private void btAddLast_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int cost = int.Parse(txtCost.Text);
            coffeeList.InsertAtTheEnd(name, cost);
            UpdateList();
        }

        private void btRemoveLast_Click(object sender, EventArgs e)
        {

            coffeeList.RemoveLast();
            UpdateList();
        }

        private void btRemoveFirst_Click(object sender, EventArgs e)
        {
            coffeeList.RemoveFirst();
            UpdateList();
        }

        private void btAddAfter_Click(object sender, EventArgs e)
        {
            string afterName = txtAdd.Text;
            string name = txtName.Text;
            int cost = int.Parse(txtCost.Text);
            coffeeList.InsertAfter(afterName, name, cost);
            UpdateList();
        }

        private void btRemoveAfter_Click(object sender, EventArgs e)
        {
            string afterName = txtRemove.Text;
            coffeeList.RemoveAfter(afterName);
            if (!int.TryParse(txtCost.Text, out int cost))
            {
                MessageBox.Show("Please enter a valid cost.");
                return;
            }
            UpdateList();
        }

        private void btSearchName_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text;
            mainBox.Items.Clear();
            Coffee coffee = coffeeList.Head;
            bool found = false;
            do
            {
                if (coffee.Name == name)
                {
                    mainBox.Items.Add($"Coffee found: {coffee.Name}, Cost: {coffee.Cost}");
                    found = true;
                    break;
                }
                coffee = coffee.Next;
            } while (coffee != coffeeList.Head);

            if (!found)
            {
                mainBox.Items.Add("Not found!");
            }
        }

        private void btSearchCost_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSearchCost.Text, out int cost))
            {
                MessageBox.Show("Please enter a valid cost.");
                return;
            }

            mainBox.Items.Clear();
            Coffee coffee = coffeeList.Head;
            bool found = false;
            do
            {
                if (coffee.Cost == cost)
                {
                    mainBox.Items.Add($"Coffee found: {coffee.Name}, Cost: {coffee.Cost}");
                    found = true;
                }
                coffee = coffee.Next;
            } while (coffee != coffeeList.Head);

            if (!found)
            {
                mainBox.Items.Add("No Coffees found with this Cost!");
            }
        }

        private void btLtoH_Click(object sender, EventArgs e)
        {
            coffeeList.SelectionSort();
            mainBox.Items.Clear();
            mainBox.Items.Add("List sorted by cost.");
        }

        private void btReverse_Click(object sender, EventArgs e)
        {
            coffeeList.ReverseList();
            mainBox.Items.Clear();
            mainBox.Items.Add("List reversed.");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            coffeeList.DeleteList();
            mainBox.Items.Clear();
            mainBox.Items.Add("List deleted.");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string filePath = txtFile.Text;
            coffeeList.SaveList(filePath);
            mainBox.Items.Clear();
            mainBox.Items.Add($"List saved to {filePath}.");
        }
        private void UpdateList()
        {
            mainBox.Items.Clear();
            Coffee temp = coffeeList.Head;
            if (temp != null)
            {
                do
                {
                    mainBox.Items.Add($"Name: {temp.Name}, Cost: {temp.Cost}");
                    temp = temp.Next;
                } while (temp != coffeeList.Head);
            }
        }
        private void lbFile_Click(object sender, EventArgs e)
        {

        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
