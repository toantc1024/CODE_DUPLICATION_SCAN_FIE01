namespace DSA_project
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
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.tTT = new System.Windows.Forms.TextBox();
            this.tD = new System.Windows.Forms.TextBox();
            this.tY = new System.Windows.Forms.TextBox();
            this.tMA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.SSort = new System.Windows.Forms.Button();
            this.GoExc2 = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.Button();
            this.SD = new System.Windows.Forms.TextBox();
            this.SY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Search2 = new System.Windows.Forms.Button();
            this.rmvF = new System.Windows.Forms.Button();
            this.rmvL = new System.Windows.Forms.Button();
            this.rmvD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ResetP = new System.Windows.Forms.Button();
            this.lstPotential = new System.Windows.Forms.ListBox();
            this.AddP = new System.Windows.Forms.Button();
            this.Merge = new System.Windows.Forms.Button();
            this.SortQ = new System.Windows.Forms.Button();
            this.rAF = new System.Windows.Forms.RadioButton();
            this.rAL = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(39, 312);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(1082, 42);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(1082, 101);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // tTT
            // 
            this.tTT.Location = new System.Drawing.Point(258, 46);
            this.tTT.Name = "tTT";
            this.tTT.Size = new System.Drawing.Size(293, 22);
            this.tTT.TabIndex = 3;
            // 
            // tD
            // 
            this.tD.Location = new System.Drawing.Point(258, 101);
            this.tD.Name = "tD";
            this.tD.Size = new System.Drawing.Size(293, 22);
            this.tD.TabIndex = 4;
            // 
            // tY
            // 
            this.tY.Location = new System.Drawing.Point(258, 164);
            this.tY.Name = "tY";
            this.tY.Size = new System.Drawing.Size(293, 22);
            this.tY.TabIndex = 5;
            // 
            // tMA
            // 
            this.tMA.Location = new System.Drawing.Point(258, 229);
            this.tMA.Name = "tMA";
            this.tMA.Size = new System.Drawing.Size(293, 22);
            this.tMA.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Director:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Main Actor:";
            // 
            // lstMovies
            // 
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.ItemHeight = 16;
            this.lstMovies.Location = new System.Drawing.Point(29, 384);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(577, 276);
            this.lstMovies.TabIndex = 11;
            // 
            // SSort
            // 
            this.SSort.Location = new System.Drawing.Point(660, 313);
            this.SSort.Name = "SSort";
            this.SSort.Size = new System.Drawing.Size(75, 23);
            this.SSort.TabIndex = 12;
            this.SSort.Text = "Sort Plist";
            this.SSort.UseVisualStyleBackColor = true;
            this.SSort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // GoExc2
            // 
            this.GoExc2.Location = new System.Drawing.Point(476, 691);
            this.GoExc2.Name = "GoExc2";
            this.GoExc2.Size = new System.Drawing.Size(290, 23);
            this.GoExc2.TabIndex = 13;
            this.GoExc2.Text = "Watchlist";
            this.GoExc2.UseVisualStyleBackColor = true;
            this.GoExc2.Click += new System.EventHandler(this.GoExc2_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(873, 311);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(75, 23);
            this.Display.TabIndex = 14;
            this.Display.Text = "Display";
            this.Display.UseVisualStyleBackColor = true;
            this.Display.Click += new System.EventHandler(this.Display_Click);
            // 
            // SD
            // 
            this.SD.Location = new System.Drawing.Point(814, 101);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(242, 22);
            this.SD.TabIndex = 15;
            // 
            // SY
            // 
            this.SY.Location = new System.Drawing.Point(814, 164);
            this.SY.Name = "SY";
            this.SY.Size = new System.Drawing.Size(242, 22);
            this.SY.TabIndex = 16;
            this.SY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search D:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(733, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search Y:";
            // 
            // Search2
            // 
            this.Search2.Location = new System.Drawing.Point(1082, 164);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(75, 23);
            this.Search2.TabIndex = 19;
            this.Search2.Text = "Search";
            this.Search2.UseVisualStyleBackColor = true;
            this.Search2.Click += new System.EventHandler(this.Search2_Click);
            // 
            // rmvF
            // 
            this.rmvF.AutoSize = true;
            this.rmvF.Location = new System.Drawing.Point(273, 309);
            this.rmvF.Name = "rmvF";
            this.rmvF.Size = new System.Drawing.Size(97, 26);
            this.rmvF.TabIndex = 20;
            this.rmvF.Text = "Remove First";
            this.rmvF.UseVisualStyleBackColor = true;
            this.rmvF.Click += new System.EventHandler(this.rmvF_Click);
            // 
            // rmvL
            // 
            this.rmvL.AutoSize = true;
            this.rmvL.Location = new System.Drawing.Point(404, 309);
            this.rmvL.Name = "rmvL";
            this.rmvL.Size = new System.Drawing.Size(97, 26);
            this.rmvL.TabIndex = 21;
            this.rmvL.Text = "Remove Last";
            this.rmvL.UseVisualStyleBackColor = true;
            this.rmvL.Click += new System.EventHandler(this.rmvL_Click);
            // 
            // rmvD
            // 
            this.rmvD.Location = new System.Drawing.Point(814, 49);
            this.rmvD.Name = "rmvD";
            this.rmvD.Size = new System.Drawing.Size(242, 22);
            this.rmvD.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(733, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Remove D:";
            // 
            // ResetP
            // 
            this.ResetP.Location = new System.Drawing.Point(1082, 313);
            this.ResetP.Name = "ResetP";
            this.ResetP.Size = new System.Drawing.Size(75, 23);
            this.ResetP.TabIndex = 24;
            this.ResetP.Text = "Reset P";
            this.ResetP.UseVisualStyleBackColor = true;
            this.ResetP.Click += new System.EventHandler(this.ResetP_Click);
            // 
            // lstPotential
            // 
            this.lstPotential.FormattingEnabled = true;
            this.lstPotential.ItemHeight = 16;
            this.lstPotential.Location = new System.Drawing.Point(651, 384);
            this.lstPotential.Name = "lstPotential";
            this.lstPotential.Size = new System.Drawing.Size(506, 276);
            this.lstPotential.TabIndex = 25;
            // 
            // AddP
            // 
            this.AddP.AutoSize = true;
            this.AddP.Location = new System.Drawing.Point(143, 310);
            this.AddP.Name = "AddP";
            this.AddP.Size = new System.Drawing.Size(97, 26);
            this.AddP.TabIndex = 26;
            this.AddP.Text = "Add Potential";
            this.AddP.UseVisualStyleBackColor = true;
            this.AddP.Click += new System.EventHandler(this.AddP_Click);
            // 
            // Merge
            // 
            this.Merge.Location = new System.Drawing.Point(762, 311);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(75, 23);
            this.Merge.TabIndex = 27;
            this.Merge.Text = "Merge";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.Click += new System.EventHandler(this.Merge_Click);
            // 
            // SortQ
            // 
            this.SortQ.AutoSize = true;
            this.SortQ.Location = new System.Drawing.Point(539, 311);
            this.SortQ.Name = "SortQ";
            this.SortQ.Size = new System.Drawing.Size(89, 26);
            this.SortQ.TabIndex = 28;
            this.SortQ.Text = "Sort Mainlist";
            this.SortQ.UseVisualStyleBackColor = true;
            this.SortQ.Click += new System.EventHandler(this.SortQ_Click);
            // 
            // rAF
            // 
            this.rAF.AutoSize = true;
            this.rAF.Location = new System.Drawing.Point(736, 232);
            this.rAF.Name = "rAF";
            this.rAF.Size = new System.Drawing.Size(53, 20);
            this.rAF.TabIndex = 29;
            this.rAF.TabStop = true;
            this.rAF.Text = "First";
            this.rAF.UseVisualStyleBackColor = true;
            // 
            // rAL
            // 
            this.rAL.AutoSize = true;
            this.rAL.Location = new System.Drawing.Point(873, 232);
            this.rAL.Name = "rAL";
            this.rAL.Size = new System.Drawing.Size(53, 20);
            this.rAL.TabIndex = 30;
            this.rAL.TabStop = true;
            this.rAL.Text = "Last";
            this.rAL.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(981, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Display P";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 744);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rAL);
            this.Controls.Add(this.rAF);
            this.Controls.Add(this.SortQ);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.AddP);
            this.Controls.Add(this.lstPotential);
            this.Controls.Add(this.ResetP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rmvD);
            this.Controls.Add(this.rmvL);
            this.Controls.Add(this.rmvF);
            this.Controls.Add(this.Search2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SY);
            this.Controls.Add(this.SD);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.GoExc2);
            this.Controls.Add(this.SSort);
            this.Controls.Add(this.lstMovies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tMA);
            this.Controls.Add(this.tY);
            this.Controls.Add(this.tD);
            this.Controls.Add(this.tTT);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Name = "Form1";
            this.Text = "MoviesNight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox tTT;
        private System.Windows.Forms.TextBox tD;
        private System.Windows.Forms.TextBox tY;
        private System.Windows.Forms.TextBox tMA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.Button SSort;
        private System.Windows.Forms.Button GoExc2;
        private System.Windows.Forms.Button Display;
        private System.Windows.Forms.TextBox SD;
        private System.Windows.Forms.TextBox SY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Search2;
        private System.Windows.Forms.Button rmvF;
        private System.Windows.Forms.Button rmvL;
        private System.Windows.Forms.TextBox rmvD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ResetP;
        private System.Windows.Forms.ListBox lstPotential;
        private System.Windows.Forms.Button AddP;
        private System.Windows.Forms.Button Merge;
        private System.Windows.Forms.Button SortQ;
        private System.Windows.Forms.RadioButton rAF;
        private System.Windows.Forms.RadioButton rAL;
        private System.Windows.Forms.Button button2;
    }
}