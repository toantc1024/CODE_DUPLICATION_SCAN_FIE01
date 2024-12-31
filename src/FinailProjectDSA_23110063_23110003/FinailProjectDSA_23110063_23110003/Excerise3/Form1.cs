using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BSTFinalProject
{
    public partial class Form1 : Form
    {
        private BinaryTree bankTree;
        public Form1()
        {
            InitializeComponent();
            bankTree = new BinaryTree();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
               
                int accountId = int.Parse(accidtextBox.Text);
                string name = nametextBox.Text;
                decimal balance = decimal.Parse(balancetextBox.Text);

               
                Account newAccount = new Account(accountId, name, balance);

               
                if (bankTree.GetHeight(bankTree.Root) >= 5)
                {
                    MessageBox.Show(
                        "Cannot add account. Maximum tree height (5) reached.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                 
                    bankTree.InsertNode(newAccount);
                    MessageBox.Show(
                        "Account added successfully!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                ClearInputs();
                DisplayAccounts();
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid input format. Please ensure all fields are filled correctly.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An unexpected error occurred: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void DisplayAccounts()
        {
            mainlistBox.Items.Clear();
            if (preoderradioButton.Checked)
            {
                bankTree.PreOrder(bankTree.Root, account =>
                {
                    mainlistBox.Items.Add(account.ToString());
                });
            }
            else if (inoerderradioButton.Checked)
            {
                bankTree.InOrder(bankTree.Root, account =>
                {
                    mainlistBox.Items.Add(account.ToString());
                });
            }
            else if (postoderradioButton.Checked)
            {
                bankTree.PostOrder(bankTree.Root, account =>
                {
                    mainlistBox.Items.Add(account.ToString());
                });
            }
            else MessageBox.Show("Please choose the arrangement", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ClearInputs()
        {
            accidtextBox.Clear();
            nametextBox.Clear();
            balancetextBox.Clear();
        }

        private void displaybutton_Click(object sender, EventArgs e)
        {
            DisplayAccounts();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int deleteId = int.Parse(accidtextBox.Text);
            if (bankTree.SearchNode(bankTree.Root, deleteId) != null)
            {
                bankTree.DeleteNode(deleteId);

                MessageBox.Show("Account deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Account is not exist", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DisplayAccounts();
            ClearInputs();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id= int.Parse(accidtextBox.Text);
            BinaryTree temp=bankTree;
           
            if (bankTree.SearchNode(temp.Root, Id) != null)
            {
                nametextBox.Text = bankTree.SearchNode(temp.Root, Id).Key.Name;
                balancetextBox.Text = Convert.ToString(bankTree.SearchNode(temp.Root, Id).Key.Balance);
            }
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            bankTree = new BinaryTree();
            mainlistBox.Items.Clear();
            MessageBox.Show("Tree has been reset", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void findminbutton_Click(object sender, EventArgs e)
        {
            BinaryTree temp = bankTree;
            if (temp.FindMin(temp.Root)!=null)
            {
                nametextBox.Text = temp.FindMin(temp.Root).Key.Name;
                balancetextBox.Text = Convert.ToString(temp.FindMin(temp.Root).Key.Balance);
                accidtextBox.Text = Convert.ToString(temp.FindMin(temp.Root).Key.AccountID);

            }
        }

        private void findmaxbutton_Click(object sender, EventArgs e)
        {
            BinaryTree temp = bankTree;
            if (temp.FindMax(temp.Root) != null)
            {
                nametextBox.Text = temp.FindMax(temp.Root).Key.Name;
                balancetextBox.Text = Convert.ToString(temp.FindMax(temp.Root).Key.Balance);
                accidtextBox.Text = Convert.ToString(temp.FindMax(temp.Root).Key.AccountID);

            }
        }
    }
}

