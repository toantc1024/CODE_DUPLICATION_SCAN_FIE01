namespace ProjectFinalDataStructure
{
    partial class Form1
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
            label1 = new Label();
            btnExercise1 = new Button();
            btnEx2 = new Button();
            btnEx3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 24);
            label1.Name = "label1";
            label1.Size = new Size(278, 27);
            label1.TabIndex = 0;
            label1.Text = "Final Project Data Structure";
            // 
            // btnExercise1
            // 
            btnExercise1.Location = new Point(38, 183);
            btnExercise1.Name = "btnExercise1";
            btnExercise1.Size = new Size(94, 29);
            btnExercise1.TabIndex = 1;
            btnExercise1.Text = "Exercise 1";
            btnExercise1.UseVisualStyleBackColor = true;
            btnExercise1.Click += btnExercise1_Click;
            // 
            // btnEx2
            // 
            btnEx2.Location = new Point(168, 183);
            btnEx2.Name = "btnEx2";
            btnEx2.Size = new Size(94, 29);
            btnEx2.TabIndex = 2;
            btnEx2.Text = "Exercise 2";
            btnEx2.UseVisualStyleBackColor = true;
            btnEx2.Click += btnEx2_Click;
            // 
            // btnEx3
            // 
            btnEx3.Location = new Point(289, 183);
            btnEx3.Name = "btnEx3";
            btnEx3.Size = new Size(94, 29);
            btnEx3.TabIndex = 3;
            btnEx3.Text = "Exercise 3";
            btnEx3.UseVisualStyleBackColor = true;
            btnEx3.Click += btnEx3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 263);
            Controls.Add(btnEx3);
            Controls.Add(btnEx2);
            Controls.Add(btnExercise1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Main";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnExercise1;
        private Button btnEx2;
        private Button btnEx3;
    }
}