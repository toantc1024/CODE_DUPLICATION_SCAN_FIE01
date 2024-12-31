namespace Quan_Li_Chi_Tieu_App
{
    partial class ManageUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddTransaction;
        private Button btnViewTransactions;
        private Button btnViewTotalAmount;

        private void InitializeComponent()
        {
            this.btnAddTransaction = new Button();
            this.btnViewTransactions = new Button();
            this.btnViewTotalAmount = new Button();

            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(100, 50);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(150, 23);
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.Click += new EventHandler(this.btnAddTransaction_Click);

            // 
            // btnViewTransactions
            // 
            this.btnViewTransactions.Location = new System.Drawing.Point(100, 100);
            this.btnViewTransactions.Name = "btnViewTransactions";
            this.btnViewTransactions.Size = new System.Drawing.Size(150, 23);
            this.btnViewTransactions.Text = "View Transactions";
            this.btnViewTransactions.Click += new EventHandler(this.btnViewTransactions_Click);

            // 
            // btnViewTotalAmount
            // 
            this.btnViewTotalAmount.Location = new System.Drawing.Point(100, 150);
            this.btnViewTotalAmount.Name = "btnViewTotalAmount";
            this.btnViewTotalAmount.Size = new System.Drawing.Size(150, 23);
            this.btnViewTotalAmount.Text = "View Total Amount";
            this.btnViewTotalAmount.Click += new EventHandler(this.btnViewTotalAmount_Click);

            // 
            // ManageUserForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.btnViewTransactions);
            this.Controls.Add(this.btnViewTotalAmount);
            this.Name = "ManageUserForm";
            this.Text = "Manage User Transactions";
        }
    }
}