namespace MUSIC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlayNext = new System.Windows.Forms.Button();
            this.lblSongList = new System.Windows.Forms.Label();
            this.lstSongs = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 59);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(550, 46);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(90, 392);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(120, 23);
            this.btnAddSong.TabIndex = 1;
            this.btnAddSong.Text = "Add song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(511, 392);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(113, 23);
            this.btnRemoveSong.TabIndex = 2;
            this.btnRemoveSong.Text = "Remove Song";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "XiPotTifai";
            // 
            // btnPlayNext
            // 
            this.btnPlayNext.Location = new System.Drawing.Point(290, 392);
            this.btnPlayNext.Name = "btnPlayNext";
            this.btnPlayNext.Size = new System.Drawing.Size(128, 23);
            this.btnPlayNext.TabIndex = 4;
            this.btnPlayNext.Text = "Next Song";
            this.btnPlayNext.UseVisualStyleBackColor = true;
            this.btnPlayNext.Click += new System.EventHandler(this.btnPlayNext_Click);
            // 
            // lblSongList
            // 
            this.lblSongList.AutoSize = true;
            this.lblSongList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongList.Location = new System.Drawing.Point(315, 162);
            this.lblSongList.Name = "lblSongList";
            this.lblSongList.Size = new System.Drawing.Size(134, 25);
            this.lblSongList.TabIndex = 5;
            this.lblSongList.Text = "List of songs";
            // 
            // lstSongs
            // 
            this.lstSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colDuration,
            this.colPath});
            this.lstSongs.FullRowSelect = true;
            this.lstSongs.HideSelection = false;
            this.lstSongs.Location = new System.Drawing.Point(33, 190);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(711, 196);
            this.lstSongs.TabIndex = 6;
            this.lstSongs.UseCompatibleStateImageBehavior = false;
            this.lstSongs.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 137;
            // 
            // colDuration
            // 
            this.colDuration.Text = "Duration";
            this.colDuration.Width = 137;
            // 
            // colPath
            // 
            this.colPath.Text = "Path";
            this.colPath.Width = 649;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.lblSongList);
            this.Controls.Add(this.btnPlayNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Music player";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlayNext;
        private System.Windows.Forms.Label lblSongList;
        private System.Windows.Forms.ListView lstSongs;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colDuration;
        private System.Windows.Forms.ColumnHeader colPath;
    }
}

