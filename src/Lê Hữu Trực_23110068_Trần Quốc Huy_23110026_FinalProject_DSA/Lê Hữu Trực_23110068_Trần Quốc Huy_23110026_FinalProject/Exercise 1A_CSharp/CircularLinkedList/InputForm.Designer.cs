namespace CircularLinkedList
{
    partial class InputForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.inputTB = new System.Windows.Forms.TextBox();
            this.inputLB = new System.Windows.Forms.Label();
            this.okBT = new System.Windows.Forms.Button();
            this.topPN = new System.Windows.Forms.Panel();
            this.minimizePIC = new System.Windows.Forms.PictureBox();
            this.closePIC = new System.Windows.Forms.PictureBox();
            this.addListLB = new System.Windows.Forms.Label();
            this.inputStatusLB = new System.Windows.Forms.Label();
            this.topPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePIC)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTB
            // 
            this.inputTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTB.Location = new System.Drawing.Point(137, 52);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(312, 27);
            this.inputTB.TabIndex = 0;
            // 
            // inputLB
            // 
            this.inputLB.AutoSize = true;
            this.inputLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLB.Location = new System.Drawing.Point(41, 52);
            this.inputLB.Name = "inputLB";
            this.inputLB.Size = new System.Drawing.Size(90, 20);
            this.inputLB.TabIndex = 1;
            this.inputLB.Text = "Enter value:";
            // 
            // okBT
            // 
            this.okBT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okBT.Location = new System.Drawing.Point(374, 101);
            this.okBT.Name = "okBT";
            this.okBT.Size = new System.Drawing.Size(75, 30);
            this.okBT.TabIndex = 2;
            this.okBT.Text = "OK";
            this.okBT.UseVisualStyleBackColor = true;
            this.okBT.Click += new System.EventHandler(this.okBT_Click);
            // 
            // topPN
            // 
            this.topPN.BackColor = System.Drawing.Color.AliceBlue;
            this.topPN.Controls.Add(this.minimizePIC);
            this.topPN.Controls.Add(this.closePIC);
            this.topPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPN.Location = new System.Drawing.Point(0, 0);
            this.topPN.Name = "topPN";
            this.topPN.Size = new System.Drawing.Size(474, 29);
            this.topPN.TabIndex = 3;
            this.topPN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseDown);
            this.topPN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseMove);
            this.topPN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseUp);
            // 
            // minimizePIC
            // 
            this.minimizePIC.Image = ((System.Drawing.Image)(resources.GetObject("minimizePIC.Image")));
            this.minimizePIC.Location = new System.Drawing.Point(36, -1);
            this.minimizePIC.Name = "minimizePIC";
            this.minimizePIC.Size = new System.Drawing.Size(30, 30);
            this.minimizePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minimizePIC.TabIndex = 2;
            this.minimizePIC.TabStop = false;
            this.minimizePIC.Click += new System.EventHandler(this.minimizePIC_Click);
            // 
            // closePIC
            // 
            this.closePIC.Image = ((System.Drawing.Image)(resources.GetObject("closePIC.Image")));
            this.closePIC.Location = new System.Drawing.Point(0, 0);
            this.closePIC.Name = "closePIC";
            this.closePIC.Size = new System.Drawing.Size(30, 30);
            this.closePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closePIC.TabIndex = 1;
            this.closePIC.TabStop = false;
            this.closePIC.Click += new System.EventHandler(this.closePIC_Click);
            // 
            // addListLB
            // 
            this.addListLB.AutoSize = true;
            this.addListLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addListLB.Location = new System.Drawing.Point(41, 91);
            this.addListLB.Name = "addListLB";
            this.addListLB.Size = new System.Drawing.Size(0, 20);
            this.addListLB.TabIndex = 3;
            // 
            // inputStatusLB
            // 
            this.inputStatusLB.AutoSize = true;
            this.inputStatusLB.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputStatusLB.Location = new System.Drawing.Point(12, 117);
            this.inputStatusLB.Name = "inputStatusLB";
            this.inputStatusLB.Size = new System.Drawing.Size(134, 17);
            this.inputStatusLB.TabIndex = 4;
            this.inputStatusLB.Text = "Note: enter a number";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(474, 143);
            this.Controls.Add(this.inputStatusLB);
            this.Controls.Add(this.addListLB);
            this.Controls.Add(this.topPN);
            this.Controls.Add(this.okBT);
            this.Controls.Add(this.inputLB);
            this.Controls.Add(this.inputTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INPUT";
            this.topPN.ResumeLayout(false);
            this.topPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label inputLB;
        public System.Windows.Forms.TextBox inputTB;
        public System.Windows.Forms.Button okBT;
        private System.Windows.Forms.Panel topPN;
        private System.Windows.Forms.PictureBox minimizePIC;
        private System.Windows.Forms.PictureBox closePIC;
        public System.Windows.Forms.Label addListLB;
        public System.Windows.Forms.Label inputStatusLB;
    }
}