namespace Bai3_DSA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtID = new TextBox();
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnAddProduct = new Button();
            lstProducts = new ListBox();
            txtSearchID = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            txtDeleteID = new TextBox();
            label2 = new Label();
            btnDeleteProduct = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(46, 58);
            txtID.Name = "txtID";
            txtID.Size = new Size(118, 27);
            txtID.TabIndex = 0;
            txtID.Text = "ID";
            txtID.TextChanged += txtID_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 27);
            txtName.TabIndex = 1;
            txtName.Text = "Name";
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(346, 58);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 2;
            txtPrice.Text = "Price";
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(46, 91);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(118, 29);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(46, 137);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(425, 484);
            lstProducts.TabIndex = 5;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(568, 58);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(200, 27);
            txtSearchID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(568, 22);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 7;
            label1.Text = "ID search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(784, 55);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(120, 32);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDeleteID
            // 
            txtDeleteID.Location = new Point(568, 225);
            txtDeleteID.Name = "txtDeleteID";
            txtDeleteID.Size = new Size(200, 27);
            txtDeleteID.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(568, 181);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 9;
            label2.Text = "ID delete";
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(784, 220);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(120, 32);
            btnDeleteProduct.TabIndex = 10;
            btnDeleteProduct.Text = "Delete";
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(568, 349);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(568, 401);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 12;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 695);
            Controls.Add(btnDeleteProduct);
            Controls.Add(label2);
            Controls.Add(txtDeleteID);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtSearchID);
            Controls.Add(lstProducts);
            Controls.Add(btnAddProduct);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnAddProduct;
        private ListBox lstProducts;
        private TextBox txtSearchID;
        private Label label1;
        private Button btnSearch;
        private TextBox txtDeleteID;
        private Label label2;
        private Button btnDeleteProduct;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
