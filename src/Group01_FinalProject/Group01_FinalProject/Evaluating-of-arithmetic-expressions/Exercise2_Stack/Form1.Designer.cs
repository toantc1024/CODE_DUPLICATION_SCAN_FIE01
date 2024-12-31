namespace Exercise2_Stack
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
            label1 = new Label();
            btnSolve = new Button();
            txtInfix = new TextBox();
            label2 = new Label();
            txtPostfix = new TextBox();
            txtResult = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 9);
            label1.Name = "label1";
            label1.Size = new Size(530, 41);
            label1.TabIndex = 0;
            label1.Text = "Evaluating of arithmetic expressions";
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(573, 117);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(94, 29);
            btnSolve.TabIndex = 1;
            btnSolve.Text = "Solve";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // txtInfix
            // 
            txtInfix.Location = new Point(299, 117);
            txtInfix.Name = "txtInfix";
            txtInfix.Size = new Size(248, 27);
            txtInfix.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 124);
            label2.Name = "label2";
            label2.Size = new Size(156, 20);
            label2.TabIndex = 3;
            label2.Text = "Arithmetic expression ";
            // 
            // txtPostfix
            // 
            txtPostfix.Location = new Point(299, 162);
            txtPostfix.Name = "txtPostfix";
            txtPostfix.ReadOnly = true;
            txtPostfix.Size = new Size(248, 27);
            txtPostfix.TabIndex = 4;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(299, 207);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(248, 27);
            txtResult.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 169);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 6;
            label3.Text = "Postfix";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(137, 214);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 7;
            label4.Text = "Result";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(137, 274);
            label5.Name = "label5";
            label5.Size = new Size(388, 25);
            label5.TabIndex = 8;
            label5.Text = "Note: Only use operators like (, ), +, -, /, *, ^";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(573, 162);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtResult);
            Controls.Add(txtPostfix);
            Controls.Add(label2);
            Controls.Add(txtInfix);
            Controls.Add(btnSolve);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Exercise2_Stack_Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSolve;
        private TextBox txtInfix;
        private Label label2;
        private TextBox txtPostfix;
        private TextBox txtResult;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnClear;
    }
}