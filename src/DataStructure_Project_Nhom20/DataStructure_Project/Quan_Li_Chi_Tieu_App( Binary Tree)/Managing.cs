using System;
using System.Windows.Forms;

namespace Quan_Li_Chi_Tieu_App
{
    public partial class ManageUserForm : Form
    {
        private User selectedUser;

        public ManageUserForm(User user)
        {
            InitializeComponent();
            selectedUser = user;
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            AddTransactionForm addTransactionForm = new AddTransactionForm(selectedUser);
            addTransactionForm.Show();
        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            string transactions = selectedUser.Transactions.GetTransactionsText();
            MessageBox.Show(transactions);
        }

        private void btnViewTotalAmount_Click(object sender, EventArgs e)
        {
            decimal totalAmount = selectedUser.Transactions.CalculateTotalAmount();
            MessageBox.Show($"Total amount spent: {totalAmount:C}");
        }
    }
}