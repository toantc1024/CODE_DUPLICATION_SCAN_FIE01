namespace Exercise2
{
    partial class ListMusic
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
            this.components = new System.ComponentModel.Container();
            this.ListMusicLB = new System.Windows.Forms.ListBox();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblPlayCurrentSong = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.guna2ProgressBarMusic = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.ProgressTime = new System.Windows.Forms.Timer(this.components);
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnAsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListMusicLB
            // 
            this.ListMusicLB.FormattingEnabled = true;
            this.ListMusicLB.ItemHeight = 16;
            this.ListMusicLB.Location = new System.Drawing.Point(12, 12);
            this.ListMusicLB.Name = "ListMusicLB";
            this.ListMusicLB.Size = new System.Drawing.Size(776, 324);
            this.ListMusicLB.TabIndex = 0;
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(364, 403);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPause.TabIndex = 1;
            this.btnPlayPause.Text = "P";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(463, 403);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(265, 403);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(165, 403);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(75, 23);
            this.btnShuffle.TabIndex = 4;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Location = new System.Drawing.Point(565, 403);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(112, 23);
            this.btnRepeat.TabIndex = 5;
            this.btnRepeat.Text = "Repeat";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(121, 432);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(38, 16);
            this.lblCurrentTime.TabIndex = 7;
            this.lblCurrentTime.Text = "00:00";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(646, 432);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(38, 16);
            this.lblTotalTime.TabIndex = 8;
            this.lblTotalTime.Text = "00:00";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(626, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblPlayCurrentSong
            // 
            this.lblPlayCurrentSong.AutoSize = true;
            this.lblPlayCurrentSong.Location = new System.Drawing.Point(12, 345);
            this.lblPlayCurrentSong.Name = "lblPlayCurrentSong";
            this.lblPlayCurrentSong.Size = new System.Drawing.Size(55, 16);
            this.lblPlayCurrentSong.TabIndex = 11;
            this.lblPlayCurrentSong.Text = "Playing:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(707, 342);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // guna2ProgressBarMusic
            // 
            this.guna2ProgressBarMusic.Location = new System.Drawing.Point(165, 432);
            this.guna2ProgressBarMusic.Name = "guna2ProgressBarMusic";
            this.guna2ProgressBarMusic.Size = new System.Drawing.Size(475, 16);
            this.guna2ProgressBarMusic.TabIndex = 13;
            this.guna2ProgressBarMusic.Text = "guna2ProgressBarMusic";
            this.guna2ProgressBarMusic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBarMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2ProgressBarMusic_MouseDown);
            // 
            // ProgressTime
            // 
            this.ProgressTime.Tick += new System.EventHandler(this.ProgressTime_Tick);
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(707, 371);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(75, 23);
            this.btnDesc.TabIndex = 14;
            this.btnDesc.Text = "Desc";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnAsc
            // 
            this.btnAsc.Location = new System.Drawing.Point(626, 371);
            this.btnAsc.Name = "btnAsc";
            this.btnAsc.Size = new System.Drawing.Size(75, 23);
            this.btnAsc.TabIndex = 15;
            this.btnAsc.Text = "Asc";
            this.btnAsc.UseVisualStyleBackColor = true;
            this.btnAsc.Click += new System.EventHandler(this.btnAsc_Click);
            // 
            // ListMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.btnAsc);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.guna2ProgressBarMusic);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblPlayCurrentSong);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.ListMusicLB);
            this.Name = "ListMusic";
            this.Text = " ListMusic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListMusicLB;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblPlayCurrentSong;
        private System.Windows.Forms.Button btnRemove;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBarMusic;
        private System.Windows.Forms.Timer ProgressTime;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnAsc;
    }
}

