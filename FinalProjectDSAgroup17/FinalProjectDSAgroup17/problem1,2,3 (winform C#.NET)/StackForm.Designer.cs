namespace ProjectFinalDataStructure
{
    partial class FormCircularlinkedlist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            undoButton = new Button();
            textBox1 = new TextBox();
            redoButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // undoButton
            // 
            undoButton.Location = new Point(22, 202);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(94, 29);
            undoButton.TabIndex = 2;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 88);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 98);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // redoButton
            // 
            redoButton.Location = new Point(262, 202);
            redoButton.Name = "redoButton";
            redoButton.Size = new Size(94, 29);
            redoButton.TabIndex = 4;
            redoButton.Text = "Redo";
            redoButton.UseVisualStyleBackColor = true;
            redoButton.Click += redoButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(180, 31);
            label1.TabIndex = 5;
            label1.Text = "Text Editor App";
            // 
            // FormCircularlinkedlist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 276);
            Controls.Add(label1);
            Controls.Add(redoButton);
            Controls.Add(textBox1);
            Controls.Add(undoButton);
            Name = "FormCircularlinkedlist";
            Text = "Stack";
            Load += FormCircularlinkedlist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button undoButton;
        private TextBox textBox1;
        private Button redoButton;
        private Label label1;
    }
}