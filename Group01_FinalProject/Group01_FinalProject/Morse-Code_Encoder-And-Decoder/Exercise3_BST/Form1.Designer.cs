namespace Exercise3_BST
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
            label2 = new Label();
            label3 = new Label();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            btnDecode = new Button();
            btnEncode = new Button();
            btnClear = new Button();
            lstMorse = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(148, 9);
            label1.Name = "label1";
            label1.Size = new Size(475, 41);
            label1.TabIndex = 0;
            label1.Text = "Morse code decoder and encoder";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 99);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Input";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 159);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 2;
            label3.Text = "Output";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(192, 97);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(300, 27);
            txtInput.TabIndex = 3;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(192, 159);
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(300, 27);
            txtOutput.TabIndex = 4;
            // 
            // btnDecode
            // 
            btnDecode.Location = new Point(192, 217);
            btnDecode.Name = "btnDecode";
            btnDecode.Size = new Size(94, 29);
            btnDecode.TabIndex = 5;
            btnDecode.Text = "Decode";
            btnDecode.UseVisualStyleBackColor = true;
            btnDecode.Click += btnDecode_Click;
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(292, 217);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(94, 29);
            btnEncode.TabIndex = 6;
            btnEncode.Text = "Encode";
            btnEncode.UseVisualStyleBackColor = true;
            btnEncode.Click += btnEncode_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(398, 217);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lstMorse
            // 
            lstMorse.FormattingEnabled = true;
            lstMorse.ItemHeight = 20;
            lstMorse.Location = new Point(524, 97);
            lstMorse.Name = "lstMorse";
            lstMorse.Size = new Size(234, 304);
            lstMorse.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 413);
            Controls.Add(lstMorse);
            Controls.Add(btnClear);
            Controls.Add(btnEncode);
            Controls.Add(btnDecode);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Morse code decoder and encoder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Button btnDecode;
        private Button btnEncode;
        private Button btnClear;
        private ListBox lstMorse;
    }
}