namespace MusicPlayerApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnPlaySong;
        private System.Windows.Forms.Button btnStopSong;
        private System.Windows.Forms.ListBox lstPlaylist;
        private System.Windows.Forms.Label lblCurrentSong;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Button btnNextSong;
        private System.Windows.Forms.ComboBox cmbPlaylist;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteSong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddSong = new System.Windows.Forms.Button();
            btnPlaySong = new System.Windows.Forms.Button();
            btnStopSong = new System.Windows.Forms.Button();
            lstPlaylist = new System.Windows.Forms.ListBox();
            lblCurrentSong = new System.Windows.Forms.Label();
            progressBar = new System.Windows.Forms.ProgressBar();
            pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            btnNextSong = new System.Windows.Forms.Button();
            cmbPlaylist = new System.Windows.Forms.ComboBox();
            btnAddPlaylist = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            btnDeleteSong = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbum).BeginInit();
            SuspendLayout();
            
            // txtSearch
            txtSearch.Location = new System.Drawing.Point(20, 300);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(200, 20);
            txtSearch.TabIndex = 6;

            // btnSearch
            btnSearch.Location = new System.Drawing.Point(240, 300);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(100, 30);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += BtnSearch_Click;

            // btnAddSong
            btnAddSong.Location = new System.Drawing.Point(20, 60);
            btnAddSong.Name = "btnAddSong";
            btnAddSong.Size = new System.Drawing.Size(100, 30);
            btnAddSong.TabIndex = 0;
            btnAddSong.Text = "Thêm bài hát";
            btnAddSong.Click += BtnAddSong_Click;

            // btnPlaySong
            btnPlaySong.Location = new System.Drawing.Point(140, 60);
            btnPlaySong.Name = "btnPlaySong";
            btnPlaySong.Size = new System.Drawing.Size(100, 30);
            btnPlaySong.TabIndex = 1;
            btnPlaySong.Text = "Phát nhạc";
            btnPlaySong.Click += BtnPlaySong_Click;

            // btnStopSong
            btnStopSong.Location = new System.Drawing.Point(260, 60);
            btnStopSong.Name = "btnStopSong";
            btnStopSong.Size = new System.Drawing.Size(100, 30);
            btnStopSong.TabIndex = 2;
            btnStopSong.Text = "Dừng nhạc";
            btnStopSong.Click += BtnStopSong_Click;

            // lstPlaylist
            lstPlaylist.Location = new System.Drawing.Point(20, 110);
            lstPlaylist.Name = "lstPlaylist";
            lstPlaylist.Size = new System.Drawing.Size(340, 144);
            lstPlaylist.TabIndex = 3;

            // lblCurrentSong
            lblCurrentSong.Location = new System.Drawing.Point(20, 270);
            lblCurrentSong.Name = "lblCurrentSong";
            lblCurrentSong.Size = new System.Drawing.Size(340, 30);
            lblCurrentSong.TabIndex = 4;
            lblCurrentSong.Text = "Chưa phát bài hát nào.";

            // progressBar
            progressBar.Location = new System.Drawing.Point(20, 330);
            progressBar.Name = "progressBar";
            progressBar.Size = new System.Drawing.Size(340, 20);
            progressBar.TabIndex = 5;

            // pictureBoxAlbum
            pictureBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBoxAlbum.Location = new System.Drawing.Point(380, 110);
            pictureBoxAlbum.Name = "pictureBoxAlbum";
            pictureBoxAlbum.Size = new System.Drawing.Size(120, 120);
            pictureBoxAlbum.TabIndex = 6;
            pictureBoxAlbum.TabStop = false;

            // btnNextSong
            btnNextSong.Location = new System.Drawing.Point(380, 60);
            btnNextSong.Name = "btnNextSong";
            btnNextSong.Size = new System.Drawing.Size(100, 30);
            btnNextSong.TabIndex = 7;
            btnNextSong.Text = "Bài tiếp theo";
            btnNextSong.Click += BtnNextSong_Click;

            // btnDeleteSong
            btnDeleteSong.Location = new System.Drawing.Point(380, 90);
            btnDeleteSong.Name = "btnDeleteSong";
            btnDeleteSong.Size = new System.Drawing.Size(100, 30);
            btnDeleteSong.TabIndex = 8;
            btnDeleteSong.Text = "Xóa bài";
            btnDeleteSong.Click += BtnDeleteSong_Click;

            // cmbPlaylist
            cmbPlaylist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPlaylist.Location = new System.Drawing.Point(20, 20);
            cmbPlaylist.Name = "cmbPlaylist";
            cmbPlaylist.Size = new System.Drawing.Size(220, 23);
            cmbPlaylist.TabIndex = 9;
            cmbPlaylist.SelectedIndexChanged += CmbPlaylist_SelectedIndexChanged;

            // btnAddPlaylist
            btnAddPlaylist.Location = new System.Drawing.Point(260, 20);
            btnAddPlaylist.Name = "btnAddPlaylist";
            btnAddPlaylist.Size = new System.Drawing.Size(100, 30);
            btnAddPlaylist.TabIndex = 10;
            btnAddPlaylist.Text = "Thêm Playlist";
            btnAddPlaylist.Click += BtnAddPlaylist_Click;

            // MainForm
            ClientSize = new System.Drawing.Size(700, 700);
            Controls.Add(btnAddPlaylist);
            Controls.Add(cmbPlaylist);
            Controls.Add(btnNextSong);
            Controls.Add(btnDeleteSong);
            Controls.Add(btnAddSong);
            Controls.Add(btnPlaySong);
            Controls.Add(btnStopSong);
            Controls.Add(lstPlaylist);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(lblCurrentSong);
            Controls.Add(progressBar);
            Controls.Add(pictureBoxAlbum);
            Text = "Music Player";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAlbum).EndInit();
            ResumeLayout(false);
        }
    }
}
