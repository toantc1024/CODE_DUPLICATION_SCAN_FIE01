namespace Display
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dfs = new System.Windows.Forms.Button();
            this.bfs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 783);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dfs
            // 
            this.dfs.BackColor = System.Drawing.Color.Yellow;
            this.dfs.Location = new System.Drawing.Point(839, 32);
            this.dfs.Name = "dfs";
            this.dfs.Size = new System.Drawing.Size(110, 56);
            this.dfs.TabIndex = 1;
            this.dfs.Text = "Dfs";
            this.dfs.UseVisualStyleBackColor = false;
            this.dfs.Click += new System.EventHandler(this.dfs_Click);
            // 
            // bfs
            // 
            this.bfs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bfs.Location = new System.Drawing.Point(839, 154);
            this.bfs.Name = "bfs";
            this.bfs.Size = new System.Drawing.Size(110, 63);
            this.bfs.TabIndex = 2;
            this.bfs.Text = "Bfs";
            this.bfs.UseVisualStyleBackColor = false;
            this.bfs.Click += new System.EventHandler(this.bfs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 803);
            this.Controls.Add(this.bfs);
            this.Controls.Add(this.dfs);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Maze";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dfs;
        private System.Windows.Forms.Button bfs;
    }
}

