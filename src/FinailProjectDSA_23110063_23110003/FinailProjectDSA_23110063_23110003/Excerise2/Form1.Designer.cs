namespace QueueProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namedoctextBox = new System.Windows.Forms.TextBox();
            this.pagecounttextBox = new System.Windows.Forms.TextBox();
            this.mainlistBox = new System.Windows.Forms.ListBox();
            this.completedjoblistBox = new System.Windows.Forms.ListBox();
            this.totalcountlabel = new System.Windows.Forms.Label();
            this.totalprintlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.printbutton);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.addbutton);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 484);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Printer Office";
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(23, 344);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(164, 63);
            this.printbutton.TabIndex = 2;
            this.printbutton.Text = "Print";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(23, 246);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(164, 63);
            this.deletebutton.TabIndex = 1;
            this.deletebutton.Text = "Delete All Document";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(23, 147);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(164, 63);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "Add Document";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(226, 9);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(78, 16);
            this.namelabel.TabIndex = 3;
            this.namelabel.Text = "Name Doc: ";
            this.namelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number Copies:";
            // 
            // namedoctextBox
            // 
            this.namedoctextBox.Location = new System.Drawing.Point(335, 6);
            this.namedoctextBox.Name = "namedoctextBox";
            this.namedoctextBox.Size = new System.Drawing.Size(204, 22);
            this.namedoctextBox.TabIndex = 5;
            // 
            // pagecounttextBox
            // 
            this.pagecounttextBox.Location = new System.Drawing.Point(335, 47);
            this.pagecounttextBox.Name = "pagecounttextBox";
            this.pagecounttextBox.Size = new System.Drawing.Size(204, 22);
            this.pagecounttextBox.TabIndex = 6;
            // 
            // mainlistBox
            // 
            this.mainlistBox.FormattingEnabled = true;
            this.mainlistBox.ItemHeight = 16;
            this.mainlistBox.Location = new System.Drawing.Point(248, 93);
            this.mainlistBox.Name = "mainlistBox";
            this.mainlistBox.Size = new System.Drawing.Size(307, 148);
            this.mainlistBox.TabIndex = 7;
            // 
            // completedjoblistBox
            // 
            this.completedjoblistBox.FormattingEnabled = true;
            this.completedjoblistBox.ItemHeight = 16;
            this.completedjoblistBox.Location = new System.Drawing.Point(248, 264);
            this.completedjoblistBox.Name = "completedjoblistBox";
            this.completedjoblistBox.Size = new System.Drawing.Size(307, 148);
            this.completedjoblistBox.TabIndex = 8;
            // 
            // totalcountlabel
            // 
            this.totalcountlabel.AutoSize = true;
            this.totalcountlabel.Location = new System.Drawing.Point(217, 459);
            this.totalcountlabel.Name = "totalcountlabel";
            this.totalcountlabel.Size = new System.Drawing.Size(126, 16);
            this.totalcountlabel.TabIndex = 10;
            this.totalcountlabel.Text = "Total printed copies";
            // 
            // totalprintlabel
            // 
            this.totalprintlabel.AutoSize = true;
            this.totalprintlabel.Location = new System.Drawing.Point(217, 425);
            this.totalprintlabel.Name = "totalprintlabel";
            this.totalprintlabel.Size = new System.Drawing.Size(66, 16);
            this.totalprintlabel.TabIndex = 9;
            this.totalprintlabel.Text = "Total print";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(36, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Lương Thiện Thông 23110063";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(36, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Viên Ngọc Bảo 23110003";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Develop By";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 487);
            this.Controls.Add(this.totalcountlabel);
            this.Controls.Add(this.totalprintlabel);
            this.Controls.Add(this.completedjoblistBox);
            this.Controls.Add(this.mainlistBox);
            this.Controls.Add(this.pagecounttextBox);
            this.Controls.Add(this.namedoctextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "QueueMainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namedoctextBox;
        private System.Windows.Forms.TextBox pagecounttextBox;
        private System.Windows.Forms.ListBox mainlistBox;
        private System.Windows.Forms.ListBox completedjoblistBox;
        private System.Windows.Forms.Label totalcountlabel;
        private System.Windows.Forms.Label totalprintlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

