namespace Queue_c_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;

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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add to Queue";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(130, 100);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove from Queue";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(30, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 20);
            this.txtInput.TabIndex = 2;

            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(30, 150);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(200, 100);
            this.txtOutput.TabIndex = 3;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Queue Example";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
