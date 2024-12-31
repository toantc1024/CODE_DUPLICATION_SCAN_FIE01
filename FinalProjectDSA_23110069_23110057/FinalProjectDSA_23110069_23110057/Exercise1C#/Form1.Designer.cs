namespace CircularLinkedList_CSharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddsong = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.txtSearchByDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnSortByDuration = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNextSong = new System.Windows.Forms.Button();
            this.pictureBoxSearchByName = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearchByDuration = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchByName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchByDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "XiPotTifai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "List of song";
            // 
            // dgvSongs
            // 
            this.dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnDuration,
            this.ColumnPath});
            this.dgvSongs.Location = new System.Drawing.Point(8, 120);
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.RowHeadersWidth = 51;
            this.dgvSongs.RowTemplate.Height = 24;
            this.dgvSongs.Size = new System.Drawing.Size(780, 150);
            this.dgvSongs.TabIndex = 3;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnDuration
            // 
            this.ColumnDuration.HeaderText = "Duration";
            this.ColumnDuration.MinimumWidth = 6;
            this.ColumnDuration.Name = "ColumnDuration";
            // 
            // ColumnPath
            // 
            this.ColumnPath.HeaderText = "Path";
            this.ColumnPath.MinimumWidth = 6;
            this.ColumnPath.Name = "ColumnPath";
            // 
            // btnAddsong
            // 
            this.btnAddsong.Location = new System.Drawing.Point(283, 370);
            this.btnAddsong.Name = "btnAddsong";
            this.btnAddsong.Size = new System.Drawing.Size(81, 25);
            this.btnAddsong.TabIndex = 4;
            this.btnAddsong.Text = "Add song";
            this.btnAddsong.UseVisualStyleBackColor = true;
            this.btnAddsong.Click += new System.EventHandler(this.btnAddsong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(370, 372);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(85, 23);
            this.btnRemoveSong.TabIndex = 5;
            this.btnRemoveSong.Text = "Remove\r\n";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Search by name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search by duration";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(210, 277);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(142, 22);
            this.txtSearchByName.TabIndex = 8;
            // 
            // txtSearchByDuration
            // 
            this.txtSearchByDuration.Location = new System.Drawing.Point(210, 319);
            this.txtSearchByDuration.Name = "txtSearchByDuration";
            this.txtSearchByDuration.Size = new System.Drawing.Size(142, 22);
            this.txtSearchByDuration.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(488, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "SORT";
            // 
            // btnSortByName
            // 
            this.btnSortByName.Location = new System.Drawing.Point(558, 274);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(85, 25);
            this.btnSortByName.TabIndex = 11;
            this.btnSortByName.Text = "By name";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnSortByDuration
            // 
            this.btnSortByDuration.Location = new System.Drawing.Point(649, 274);
            this.btnSortByDuration.Name = "btnSortByDuration";
            this.btnSortByDuration.Size = new System.Drawing.Size(97, 25);
            this.btnSortByDuration.TabIndex = 12;
            this.btnSortByDuration.Text = "By duration";
            this.btnSortByDuration.UseVisualStyleBackColor = true;
            this.btnSortByDuration.Click += new System.EventHandler(this.btnSortByDuration_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(461, 372);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(85, 23);
            this.btnReverse.TabIndex = 13;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(287, 404);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(77, 22);
            this.txtPosition.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Position to insert or delete song:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 41);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(579, 48);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            // 
            // btnNextSong
            // 
            this.btnNextSong.Location = new System.Drawing.Point(558, 371);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(85, 24);
            this.btnNextSong.TabIndex = 16;
            this.btnNextSong.Text = "Next Song";
            this.btnNextSong.UseVisualStyleBackColor = true;
            this.btnNextSong.Click += new System.EventHandler(this.btnNextSong_Click);
            // 
            // pictureBoxSearchByName
            // 
            this.pictureBoxSearchByName.BackgroundImage = global::CircularLinkedList_CSharp.Properties.Resources.images;
            this.pictureBoxSearchByName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSearchByName.Location = new System.Drawing.Point(370, 276);
            this.pictureBoxSearchByName.Name = "pictureBoxSearchByName";
            this.pictureBoxSearchByName.Size = new System.Drawing.Size(29, 23);
            this.pictureBoxSearchByName.TabIndex = 17;
            this.pictureBoxSearchByName.TabStop = false;
            this.pictureBoxSearchByName.Click += new System.EventHandler(this.pictureBoxSearchByName_Click_1);
            // 
            // pictureBoxSearchByDuration
            // 
            this.pictureBoxSearchByDuration.BackgroundImage = global::CircularLinkedList_CSharp.Properties.Resources.images;
            this.pictureBoxSearchByDuration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSearchByDuration.Location = new System.Drawing.Point(370, 319);
            this.pictureBoxSearchByDuration.Name = "pictureBoxSearchByDuration";
            this.pictureBoxSearchByDuration.Size = new System.Drawing.Size(29, 23);
            this.pictureBoxSearchByDuration.TabIndex = 18;
            this.pictureBoxSearchByDuration.TabStop = false;
            this.pictureBoxSearchByDuration.Click += new System.EventHandler(this.pictureBoxSearchByDuration_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.pictureBoxSearchByDuration);
            this.Controls.Add(this.pictureBoxSearchByName);
            this.Controls.Add(this.btnNextSong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnSortByDuration);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchByDuration);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnAddsong);
            this.Controls.Add(this.dgvSongs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XiPotTifai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchByName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchByDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPath;
        private System.Windows.Forms.Button btnAddsong;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.TextBox txtSearchByDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnSortByDuration;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNextSong;
        private System.Windows.Forms.PictureBox pictureBoxSearchByName;
        private System.Windows.Forms.PictureBox pictureBoxSearchByDuration;
    }
}

