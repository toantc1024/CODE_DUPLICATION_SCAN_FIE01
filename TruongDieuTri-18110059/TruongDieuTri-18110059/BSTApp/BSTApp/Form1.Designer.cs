namespace BSTApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInOrder;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInOrder = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(30, 100);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(120, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // btnInOrder
            // 
            this.btnInOrder.Location = new System.Drawing.Point(210, 100);
            this.btnInOrder.Name = "btnInOrder";
            this.btnInOrder.Size = new System.Drawing.Size(75, 23);
            this.btnInOrder.TabIndex = 2;
            this.btnInOrder.Text = "In Order";
            this.btnInOrder.UseVisualStyleBackColor = true;
            this.btnInOrder.Click += new System.EventHandler(this.btnInOrder_Click);

            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(30, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 20);
            this.txtInput.TabIndex = 3;

            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(30, 150);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(255, 95);
            this.lstOutput.TabIndex = 4;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(314, 261);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnInOrder);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Binary Search Tree";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
