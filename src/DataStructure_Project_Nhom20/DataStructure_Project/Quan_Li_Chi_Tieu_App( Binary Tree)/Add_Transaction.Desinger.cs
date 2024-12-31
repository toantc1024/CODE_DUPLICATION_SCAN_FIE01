namespace Quan_Li_Chi_Tieu_App
{
    partial class AddTransactionForm
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtAmount;
        private TextBox txtDescription;
        private ComboBox cmbCategory;
        private Button btnAddTransaction;
        private Label lblAmount;
        private Label lblDescription;
        private Label lblCategory;

        private void InitializeComponent()
        {
            this.txtAmount = new TextBox();
            this.txtDescription = new TextBox();
            this.cmbCategory = new ComboBox();
            this.btnAddTransaction = new Button();
            this.lblAmount = new Label();
            this.lblDescription = new Label();
            this.lblCategory = new Label();

            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(150, 30);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 20);

            // 
            // lblAmount
            // 
            this.lblAmount.Location = new System.Drawing.Point(30, 30);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 20);
            this.lblAmount.Text = "Amount:";

            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 60);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(150, 20);

            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(30, 60);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.Text = "Description:";

            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(150, 90);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 21);

            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(30, 90);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 20);
            this.lblCategory.Text = "Category:";

            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(150, 120);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(150, 23);
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.Click += new EventHandler(this.btnAddTransaction_Click);

            // 
            // AddTransactionForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 180);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnAddTransaction);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Name = "AddTransactionForm";
            this.Text = "Add Transaction";
        }
    }
}