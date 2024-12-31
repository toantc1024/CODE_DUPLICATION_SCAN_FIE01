namespace DSA_project
{
    partial class Exc3
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
            this.InsertBttn = new System.Windows.Forms.Button();
            this.SearchBttn = new System.Windows.Forms.Button();
            this.DisplayBttn = new System.Windows.Forms.Button();
            this.listTree = new System.Windows.Forms.ListBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.Titllbl = new System.Windows.Forms.Label();
            this.TT = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.TextBox();
            this.MA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dilbl = new System.Windows.Forms.Label();
            this.Actlbl = new System.Windows.Forms.Label();
            this.StartY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartR = new System.Windows.Forms.TextBox();
            this.EndR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SY = new System.Windows.Forms.Button();
            this.SR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsertBttn
            // 
            this.InsertBttn.Location = new System.Drawing.Point(152, 307);
            this.InsertBttn.Name = "InsertBttn";
            this.InsertBttn.Size = new System.Drawing.Size(75, 23);
            this.InsertBttn.TabIndex = 0;
            this.InsertBttn.Text = "Insert";
            this.InsertBttn.UseVisualStyleBackColor = true;
            this.InsertBttn.Click += new System.EventHandler(this.InsertBttn_Click);
            // 
            // SearchBttn
            // 
            this.SearchBttn.Location = new System.Drawing.Point(418, 307);
            this.SearchBttn.Name = "SearchBttn";
            this.SearchBttn.Size = new System.Drawing.Size(75, 23);
            this.SearchBttn.TabIndex = 1;
            this.SearchBttn.Text = "Search";
            this.SearchBttn.UseVisualStyleBackColor = true;
            this.SearchBttn.Click += new System.EventHandler(this.SearchBttn_Click);
            // 
            // DisplayBttn
            // 
            this.DisplayBttn.Location = new System.Drawing.Point(701, 307);
            this.DisplayBttn.Name = "DisplayBttn";
            this.DisplayBttn.Size = new System.Drawing.Size(75, 23);
            this.DisplayBttn.TabIndex = 2;
            this.DisplayBttn.Text = "Display";
            this.DisplayBttn.UseVisualStyleBackColor = true;
            this.DisplayBttn.Click += new System.EventHandler(this.DisplayBttn_Click);
            // 
            // listTree
            // 
            this.listTree.FormattingEnabled = true;
            this.listTree.ItemHeight = 16;
            this.listTree.Location = new System.Drawing.Point(52, 376);
            this.listTree.Name = "listTree";
            this.listTree.Size = new System.Drawing.Size(1023, 308);
            this.listTree.TabIndex = 3;
            this.listTree.SelectedIndexChanged += new System.EventHandler(this.listTree_SelectedIndexChanged);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(152, 186);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(209, 22);
            this.Y.TabIndex = 4;
            // 
            // Titllbl
            // 
            this.Titllbl.AutoSize = true;
            this.Titllbl.Location = new System.Drawing.Point(49, 80);
            this.Titllbl.Name = "Titllbl";
            this.Titllbl.Size = new System.Drawing.Size(36, 16);
            this.Titllbl.TabIndex = 5;
            this.Titllbl.Text = "Title:";
            this.Titllbl.Click += new System.EventHandler(this.Inputlbl_Click);
            // 
            // TT
            // 
            this.TT.Location = new System.Drawing.Point(152, 80);
            this.TT.Name = "TT";
            this.TT.Size = new System.Drawing.Size(547, 22);
            this.TT.TabIndex = 6;
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(152, 127);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(547, 22);
            this.D.TabIndex = 7;
            // 
            // MA
            // 
            this.MA.Location = new System.Drawing.Point(152, 249);
            this.MA.Name = "MA";
            this.MA.Size = new System.Drawing.Size(547, 22);
            this.MA.TabIndex = 8;
            this.MA.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Year:";
            // 
            // Dilbl
            // 
            this.Dilbl.AutoSize = true;
            this.Dilbl.Location = new System.Drawing.Point(46, 130);
            this.Dilbl.Name = "Dilbl";
            this.Dilbl.Size = new System.Drawing.Size(57, 16);
            this.Dilbl.TabIndex = 10;
            this.Dilbl.Text = "Director:";
            // 
            // Actlbl
            // 
            this.Actlbl.AutoSize = true;
            this.Actlbl.Location = new System.Drawing.Point(49, 255);
            this.Actlbl.Name = "Actlbl";
            this.Actlbl.Size = new System.Drawing.Size(73, 16);
            this.Actlbl.TabIndex = 11;
            this.Actlbl.Text = "Main Actor:";
            // 
            // StartY
            // 
            this.StartY.Location = new System.Drawing.Point(797, 77);
            this.StartY.Name = "StartY";
            this.StartY.Size = new System.Drawing.Size(93, 22);
            this.StartY.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "By Year: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(904, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "to";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EndY
            // 
            this.EndY.Location = new System.Drawing.Point(931, 77);
            this.EndY.Name = "EndY";
            this.EndY.Size = new System.Drawing.Size(93, 22);
            this.EndY.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "By Rating:";
            // 
            // StartR
            // 
            this.StartR.Location = new System.Drawing.Point(797, 130);
            this.StartR.Name = "StartR";
            this.StartR.Size = new System.Drawing.Size(93, 22);
            this.StartR.TabIndex = 18;
            // 
            // EndR
            // 
            this.EndR.Location = new System.Drawing.Point(931, 130);
            this.EndR.Name = "EndR";
            this.EndR.Size = new System.Drawing.Size(93, 22);
            this.EndR.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Rating:";
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(527, 186);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(172, 22);
            this.R.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(904, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "to";
            // 
            // SY
            // 
            this.SY.Location = new System.Drawing.Point(1044, 80);
            this.SY.Name = "SY";
            this.SY.Size = new System.Drawing.Size(75, 23);
            this.SY.TabIndex = 23;
            this.SY.Text = "Search";
            this.SY.UseVisualStyleBackColor = true;
            this.SY.Click += new System.EventHandler(this.SY_Click);
            // 
            // SR
            // 
            this.SR.Location = new System.Drawing.Point(1044, 127);
            this.SR.Name = "SR";
            this.SR.Size = new System.Drawing.Size(75, 23);
            this.SR.TabIndex = 24;
            this.SR.Text = "Search";
            this.SR.UseVisualStyleBackColor = true;
            this.SR.Click += new System.EventHandler(this.SR_Click);
            // 
            // Exc3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 783);
            this.Controls.Add(this.SR);
            this.Controls.Add(this.SY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.R);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndR);
            this.Controls.Add(this.StartR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartY);
            this.Controls.Add(this.Actlbl);
            this.Controls.Add(this.Dilbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MA);
            this.Controls.Add(this.D);
            this.Controls.Add(this.TT);
            this.Controls.Add(this.Titllbl);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.listTree);
            this.Controls.Add(this.DisplayBttn);
            this.Controls.Add(this.SearchBttn);
            this.Controls.Add(this.InsertBttn);
            this.Name = "Exc3";
            this.Text = "Search Rating Films";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertBttn;
        private System.Windows.Forms.Button SearchBttn;
        private System.Windows.Forms.Button DisplayBttn;
        private System.Windows.Forms.ListBox listTree;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.Label Titllbl;
        private System.Windows.Forms.TextBox TT;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.TextBox MA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Dilbl;
        private System.Windows.Forms.Label Actlbl;
        private System.Windows.Forms.TextBox StartY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EndY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StartR;
        private System.Windows.Forms.TextBox EndR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SY;
        private System.Windows.Forms.Button SR;
    }
}