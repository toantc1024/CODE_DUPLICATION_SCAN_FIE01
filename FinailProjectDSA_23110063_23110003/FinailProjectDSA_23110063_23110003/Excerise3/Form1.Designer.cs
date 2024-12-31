namespace BSTFinalProject
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
            this.namelabel = new System.Windows.Forms.Label();
            this.acclabel = new System.Windows.Forms.Label();
            this.balancelabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.displaybutton = new System.Windows.Forms.Button();
            this.findmaxbutton = new System.Windows.Forms.Button();
            this.findminbutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.balancetextBox = new System.Windows.Forms.TextBox();
            this.accidtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.mainlistBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.preoderradioButton = new System.Windows.Forms.RadioButton();
            this.inoerderradioButton = new System.Windows.Forms.RadioButton();
            this.postoderradioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(27, 78);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(47, 16);
            this.namelabel.TabIndex = 0;
            this.namelabel.Text = "Name:";
            // 
            // acclabel
            // 
            this.acclabel.AutoSize = true;
            this.acclabel.Location = new System.Drawing.Point(27, 117);
            this.acclabel.Name = "acclabel";
            this.acclabel.Size = new System.Drawing.Size(71, 16);
            this.acclabel.TabIndex = 1;
            this.acclabel.Text = "AccountID:";
            // 
            // balancelabel
            // 
            this.balancelabel.AutoSize = true;
            this.balancelabel.Location = new System.Drawing.Point(27, 162);
            this.balancelabel.Name = "balancelabel";
            this.balancelabel.Size = new System.Drawing.Size(60, 16);
            this.balancelabel.TabIndex = 2;
            this.balancelabel.Text = "Balance:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.postoderradioButton);
            this.panel1.Controls.Add(this.inoerderradioButton);
            this.panel1.Controls.Add(this.preoderradioButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchbutton);
            this.panel1.Controls.Add(this.displaybutton);
            this.panel1.Controls.Add(this.findmaxbutton);
            this.panel1.Controls.Add(this.findminbutton);
            this.panel1.Controls.Add(this.resetbutton);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.addbutton);
            this.panel1.Controls.Add(this.balancetextBox);
            this.panel1.Controls.Add(this.accidtextBox);
            this.panel1.Controls.Add(this.nametextBox);
            this.panel1.Controls.Add(this.namelabel);
            this.panel1.Controls.Add(this.balancelabel);
            this.panel1.Controls.Add(this.acclabel);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 507);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(52, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lương Thiện Thông 23110063";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(52, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Viên Ngọc Bảo 23110003";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(31, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Develop By";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Management Bank Account";
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(266, 207);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(93, 47);
            this.searchbutton.TabIndex = 12;
            this.searchbutton.Text = "Search Account";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // displaybutton
            // 
            this.displaybutton.Location = new System.Drawing.Point(141, 324);
            this.displaybutton.Name = "displaybutton";
            this.displaybutton.Size = new System.Drawing.Size(93, 47);
            this.displaybutton.TabIndex = 11;
            this.displaybutton.Text = "Display";
            this.displaybutton.UseVisualStyleBackColor = true;
            this.displaybutton.Click += new System.EventHandler(this.displaybutton_Click);
            // 
            // findmaxbutton
            // 
            this.findmaxbutton.Location = new System.Drawing.Point(24, 324);
            this.findmaxbutton.Name = "findmaxbutton";
            this.findmaxbutton.Size = new System.Drawing.Size(93, 47);
            this.findmaxbutton.TabIndex = 10;
            this.findmaxbutton.Text = "Find Max";
            this.findmaxbutton.UseVisualStyleBackColor = true;
            this.findmaxbutton.Click += new System.EventHandler(this.findmaxbutton_Click);
            // 
            // findminbutton
            // 
            this.findminbutton.Location = new System.Drawing.Point(141, 265);
            this.findminbutton.Name = "findminbutton";
            this.findminbutton.Size = new System.Drawing.Size(93, 47);
            this.findminbutton.TabIndex = 9;
            this.findminbutton.Text = "Find Min";
            this.findminbutton.UseVisualStyleBackColor = true;
            this.findminbutton.Click += new System.EventHandler(this.findminbutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(24, 265);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(93, 47);
            this.resetbutton.TabIndex = 8;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(141, 207);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(93, 47);
            this.deletebutton.TabIndex = 7;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(24, 207);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(93, 47);
            this.addbutton.TabIndex = 6;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // balancetextBox
            // 
            this.balancetextBox.Location = new System.Drawing.Point(114, 158);
            this.balancetextBox.Name = "balancetextBox";
            this.balancetextBox.Size = new System.Drawing.Size(164, 22);
            this.balancetextBox.TabIndex = 5;
            // 
            // accidtextBox
            // 
            this.accidtextBox.Location = new System.Drawing.Point(114, 113);
            this.accidtextBox.Name = "accidtextBox";
            this.accidtextBox.Size = new System.Drawing.Size(164, 22);
            this.accidtextBox.TabIndex = 4;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(114, 74);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(164, 22);
            this.nametextBox.TabIndex = 3;
            // 
            // mainlistBox
            // 
            this.mainlistBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mainlistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainlistBox.FormattingEnabled = true;
            this.mainlistBox.ItemHeight = 16;
            this.mainlistBox.Location = new System.Drawing.Point(380, 36);
            this.mainlistBox.Name = "mainlistBox";
            this.mainlistBox.Size = new System.Drawing.Size(312, 450);
            this.mainlistBox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(380, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 39);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account List";
            // 
            // preoderradioButton
            // 
            this.preoderradioButton.AutoSize = true;
            this.preoderradioButton.Location = new System.Drawing.Point(265, 269);
            this.preoderradioButton.Name = "preoderradioButton";
            this.preoderradioButton.Size = new System.Drawing.Size(83, 20);
            this.preoderradioButton.TabIndex = 22;
            this.preoderradioButton.TabStop = true;
            this.preoderradioButton.Text = "PreOrder";
            this.preoderradioButton.UseVisualStyleBackColor = true;
            // 
            // inoerderradioButton
            // 
            this.inoerderradioButton.AutoSize = true;
            this.inoerderradioButton.Location = new System.Drawing.Point(265, 302);
            this.inoerderradioButton.Name = "inoerderradioButton";
            this.inoerderradioButton.Size = new System.Drawing.Size(72, 20);
            this.inoerderradioButton.TabIndex = 23;
            this.inoerderradioButton.TabStop = true;
            this.inoerderradioButton.Text = "InOrder";
            this.inoerderradioButton.UseVisualStyleBackColor = true;
            // 
            // postoderradioButton
            // 
            this.postoderradioButton.AutoSize = true;
            this.postoderradioButton.Location = new System.Drawing.Point(265, 338);
            this.postoderradioButton.Name = "postoderradioButton";
            this.postoderradioButton.Size = new System.Drawing.Size(89, 20);
            this.postoderradioButton.TabIndex = 24;
            this.postoderradioButton.TabStop = true;
            this.postoderradioButton.Text = "PostOrder";
            this.postoderradioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 478);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mainlistBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label acclabel;
        private System.Windows.Forms.Label balancelabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button findminbutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.TextBox balancetextBox;
        private System.Windows.Forms.TextBox accidtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Button displaybutton;
        private System.Windows.Forms.Button findmaxbutton;
        private System.Windows.Forms.ListBox mainlistBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton postoderradioButton;
        private System.Windows.Forms.RadioButton inoerderradioButton;
        private System.Windows.Forms.RadioButton preoderradioButton;
    }
}

