namespace ques_1_b_24_12
{
    partial class v
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
            this.Addbegining = new System.Windows.Forms.Button();
            this.Addend = new System.Windows.Forms.Button();
            this.Addaftersong = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.txtAfterTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnRemoveAfter = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnSearchByTitle = new System.Windows.Forms.Button();
            this.btnSearchByAuthor = new System.Windows.Forms.Button();
            this.btnSearchByIndex = new System.Windows.Forms.Button();
            this.lstbox2 = new System.Windows.Forms.ListBox();
            this.btnNextSong = new System.Windows.Forms.Button();
            this.btnPreviousSong = new System.Windows.Forms.Button();
            this.btnPlaysong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addbegining
            // 
            this.Addbegining.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Addbegining.Location = new System.Drawing.Point(12, 41);
            this.Addbegining.Name = "Addbegining";
            this.Addbegining.Size = new System.Drawing.Size(149, 23);
            this.Addbegining.TabIndex = 0;
            this.Addbegining.Text = " Add Song At Beginning ";
            this.Addbegining.UseVisualStyleBackColor = false;
            this.Addbegining.Click += new System.EventHandler(this.Addbegining_Click);
            // 
            // Addend
            // 
            this.Addend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Addend.Location = new System.Drawing.Point(12, 98);
            this.Addend.Name = "Addend";
            this.Addend.Size = new System.Drawing.Size(149, 23);
            this.Addend.TabIndex = 1;
            this.Addend.Text = " Add Song At End ";
            this.Addend.UseVisualStyleBackColor = false;
            this.Addend.Click += new System.EventHandler(this.Addend_Click);
            // 
            // Addaftersong
            // 
            this.Addaftersong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Addaftersong.Location = new System.Drawing.Point(12, 155);
            this.Addaftersong.Name = "Addaftersong";
            this.Addaftersong.Size = new System.Drawing.Size(149, 23);
            this.Addaftersong.TabIndex = 2;
            this.Addaftersong.Text = " Add Song After Song ";
            this.Addaftersong.UseVisualStyleBackColor = false;
            this.Addaftersong.Click += new System.EventHandler(this.Addaftersong_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(190, 101);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(187, 79);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(545, 79);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(44, 13);
            this.Position.TabIndex = 6;
            this.Position.Text = "Position";
            // 
            // txtAfterTitle
            // 
            this.txtAfterTitle.Location = new System.Drawing.Point(548, 101);
            this.txtAfterTitle.Name = "txtAfterTitle";
            this.txtAfterTitle.Size = new System.Drawing.Size(100, 20);
            this.txtAfterTitle.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(312, 79);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(315, 101);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 7;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(432, 79);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(435, 101);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 9;
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BackColor = System.Drawing.Color.White;
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.Location = new System.Drawing.Point(813, 12);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(353, 641);
            this.listBoxSongs.TabIndex = 11;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemoveFirst.Location = new System.Drawing.Point(658, 41);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(149, 23);
            this.btnRemoveFirst.TabIndex = 12;
            this.btnRemoveFirst.Text = "Remove First Song";
            this.btnRemoveFirst.UseVisualStyleBackColor = false;
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // btnRemoveAfter
            // 
            this.btnRemoveAfter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemoveAfter.Location = new System.Drawing.Point(658, 155);
            this.btnRemoveAfter.Name = "btnRemoveAfter";
            this.btnRemoveAfter.Size = new System.Drawing.Size(149, 23);
            this.btnRemoveAfter.TabIndex = 13;
            this.btnRemoveAfter.Text = "Remove Song After";
            this.btnRemoveAfter.UseVisualStyleBackColor = false;
            this.btnRemoveAfter.Click += new System.EventHandler(this.btnRemoveAfter_Click);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemoveLast.Location = new System.Drawing.Point(658, 98);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(149, 23);
            this.btnRemoveLast.TabIndex = 14;
            this.btnRemoveLast.Text = "Remove Last Song";
            this.btnRemoveLast.UseVisualStyleBackColor = false;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // btnSearchByTitle
            // 
            this.btnSearchByTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearchByTitle.Location = new System.Drawing.Point(169, 195);
            this.btnSearchByTitle.Name = "btnSearchByTitle";
            this.btnSearchByTitle.Size = new System.Drawing.Size(149, 23);
            this.btnSearchByTitle.TabIndex = 15;
            this.btnSearchByTitle.Text = " Search by Song Title";
            this.btnSearchByTitle.UseVisualStyleBackColor = false;
            this.btnSearchByTitle.Click += new System.EventHandler(this.btnSearchByTitle_Click);
            // 
            // btnSearchByAuthor
            // 
            this.btnSearchByAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearchByAuthor.Location = new System.Drawing.Point(347, 195);
            this.btnSearchByAuthor.Name = "btnSearchByAuthor";
            this.btnSearchByAuthor.Size = new System.Drawing.Size(149, 23);
            this.btnSearchByAuthor.TabIndex = 16;
            this.btnSearchByAuthor.Text = "Search by Author Name";
            this.btnSearchByAuthor.UseVisualStyleBackColor = false;
            this.btnSearchByAuthor.Click += new System.EventHandler(this.btnSearchByAuthor_Click);
            // 
            // btnSearchByIndex
            // 
            this.btnSearchByIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearchByIndex.Location = new System.Drawing.Point(526, 195);
            this.btnSearchByIndex.Name = "btnSearchByIndex";
            this.btnSearchByIndex.Size = new System.Drawing.Size(149, 23);
            this.btnSearchByIndex.TabIndex = 17;
            this.btnSearchByIndex.Text = "Search by Song Index";
            this.btnSearchByIndex.UseVisualStyleBackColor = false;
            this.btnSearchByIndex.Click += new System.EventHandler(this.btnSearchByIndex_Click);
            // 
            // lstbox2
            // 
            this.lstbox2.BackColor = System.Drawing.Color.White;
            this.lstbox2.FormattingEnabled = true;
            this.lstbox2.Location = new System.Drawing.Point(169, 245);
            this.lstbox2.Name = "lstbox2";
            this.lstbox2.Size = new System.Drawing.Size(506, 212);
            this.lstbox2.TabIndex = 18;
            // 
            // btnNextSong
            // 
            this.btnNextSong.Location = new System.Drawing.Point(548, 522);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(127, 23);
            this.btnNextSong.TabIndex = 19;
            this.btnNextSong.Text = "Next Song";
            this.btnNextSong.UseVisualStyleBackColor = true;
            this.btnNextSong.Click += new System.EventHandler(this.btnNextSong_Click);
            // 
            // btnPreviousSong
            // 
            this.btnPreviousSong.Location = new System.Drawing.Point(163, 522);
            this.btnPreviousSong.Name = "btnPreviousSong";
            this.btnPreviousSong.Size = new System.Drawing.Size(127, 23);
            this.btnPreviousSong.TabIndex = 20;
            this.btnPreviousSong.Text = "Previous Song";
            this.btnPreviousSong.UseVisualStyleBackColor = true;
            this.btnPreviousSong.Click += new System.EventHandler(this.btnPreviousSong_Click);
            // 
            // btnPlaysong
            // 
            this.btnPlaysong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPlaysong.Location = new System.Drawing.Point(357, 522);
            this.btnPlaysong.Name = "btnPlaysong";
            this.btnPlaysong.Size = new System.Drawing.Size(127, 23);
            this.btnPlaysong.TabIndex = 21;
            this.btnPlaysong.Text = "Play Song";
            this.btnPlaysong.UseVisualStyleBackColor = false;
            this.btnPlaysong.Click += new System.EventHandler(this.btnPlaysong_Click);
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 667);
            this.Controls.Add(this.btnPlaysong);
            this.Controls.Add(this.btnPreviousSong);
            this.Controls.Add(this.btnNextSong);
            this.Controls.Add(this.lstbox2);
            this.Controls.Add(this.btnSearchByIndex);
            this.Controls.Add(this.btnSearchByAuthor);
            this.Controls.Add(this.btnSearchByTitle);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnRemoveAfter);
            this.Controls.Add(this.btnRemoveFirst);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.txtAfterTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.Addaftersong);
            this.Controls.Add(this.Addend);
            this.Controls.Add(this.Addbegining);
            this.Name = "v";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addbegining;
        private System.Windows.Forms.Button Addend;
        private System.Windows.Forms.Button Addaftersong;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.TextBox txtAfterTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveAfter;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnSearchByTitle;
        private System.Windows.Forms.Button btnSearchByAuthor;
        private System.Windows.Forms.Button btnSearchByIndex;
        private System.Windows.Forms.ListBox lstbox2;
        private System.Windows.Forms.Button btnNextSong;
        private System.Windows.Forms.Button btnPreviousSong;
        private System.Windows.Forms.Button btnPlaysong;
    }
}

