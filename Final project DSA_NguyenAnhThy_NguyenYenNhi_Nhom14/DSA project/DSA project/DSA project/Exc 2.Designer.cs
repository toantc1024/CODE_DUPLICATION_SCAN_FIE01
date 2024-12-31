namespace DSA_project
{
    partial class Exc2
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
            this.Peakbttn = new System.Windows.Forms.Button();
            this.Pushbttn = new System.Windows.Forms.Button();
            this.Popbttn = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.listStack = new System.Windows.Forms.ListBox();
            this.Inputlbl = new System.Windows.Forms.Label();
            this.Goexc3 = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMActor = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Peakbttn
            // 
            this.Peakbttn.AutoSize = true;
            this.Peakbttn.Location = new System.Drawing.Point(792, 262);
            this.Peakbttn.Name = "Peakbttn";
            this.Peakbttn.Size = new System.Drawing.Size(75, 26);
            this.Peakbttn.TabIndex = 0;
            this.Peakbttn.Text = "Watch";
            this.Peakbttn.UseVisualStyleBackColor = true;
            this.Peakbttn.Click += new System.EventHandler(this.Peakbttn_Click);
            // 
            // Pushbttn
            // 
            this.Pushbttn.Location = new System.Drawing.Point(109, 262);
            this.Pushbttn.Name = "Pushbttn";
            this.Pushbttn.Size = new System.Drawing.Size(75, 23);
            this.Pushbttn.TabIndex = 1;
            this.Pushbttn.Text = "Add";
            this.Pushbttn.UseVisualStyleBackColor = true;
            this.Pushbttn.Click += new System.EventHandler(this.Pushbttn_Click);
            // 
            // Popbttn
            // 
            this.Popbttn.Location = new System.Drawing.Point(456, 262);
            this.Popbttn.Name = "Popbttn";
            this.Popbttn.Size = new System.Drawing.Size(75, 23);
            this.Popbttn.TabIndex = 2;
            this.Popbttn.Text = "Remove";
            this.Popbttn.UseVisualStyleBackColor = true;
            this.Popbttn.Click += new System.EventHandler(this.Popbttn_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(257, 39);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(473, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // listStack
            // 
            this.listStack.FormattingEnabled = true;
            this.listStack.ItemHeight = 16;
            this.listStack.Location = new System.Drawing.Point(54, 319);
            this.listStack.Name = "listStack";
            this.listStack.Size = new System.Drawing.Size(920, 244);
            this.listStack.TabIndex = 4;
            // 
            // Inputlbl
            // 
            this.Inputlbl.AutoSize = true;
            this.Inputlbl.Location = new System.Drawing.Point(91, 39);
            this.Inputlbl.Name = "Inputlbl";
            this.Inputlbl.Size = new System.Drawing.Size(76, 16);
            this.Inputlbl.TabIndex = 5;
            this.Inputlbl.Text = "Movie Title:";
            this.Inputlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // Goexc3
            // 
            this.Goexc3.AutoSize = true;
            this.Goexc3.Location = new System.Drawing.Point(456, 618);
            this.Goexc3.Name = "Goexc3";
            this.Goexc3.Size = new System.Drawing.Size(131, 26);
            this.Goexc3.TabIndex = 6;
            this.Goexc3.Text = "SearchRatingFilms";
            this.Goexc3.UseVisualStyleBackColor = true;
            this.Goexc3.Click += new System.EventHandler(this.Goexc3_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(257, 154);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(199, 22);
            this.txtYear.TabIndex = 7;
            // 
            // txtMActor
            // 
            this.txtMActor.Location = new System.Drawing.Point(257, 208);
            this.txtMActor.Name = "txtMActor";
            this.txtMActor.Size = new System.Drawing.Size(473, 22);
            this.txtMActor.TabIndex = 8;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(257, 96);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(473, 22);
            this.txtDirector.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Main Actor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Release Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Director:";
            // 
            // Exc2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 687);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtMActor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.Goexc3);
            this.Controls.Add(this.Inputlbl);
            this.Controls.Add(this.listStack);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.Popbttn);
            this.Controls.Add(this.Pushbttn);
            this.Controls.Add(this.Peakbttn);
            this.Name = "Exc2";
            this.Text = "Watchlist";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Peakbttn;
        private System.Windows.Forms.Button Pushbttn;
        private System.Windows.Forms.Button Popbttn;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ListBox listStack;
        private System.Windows.Forms.Label Inputlbl;
        private System.Windows.Forms.Button Goexc3;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMActor;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

