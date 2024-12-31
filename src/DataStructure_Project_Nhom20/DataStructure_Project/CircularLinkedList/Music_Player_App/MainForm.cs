using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NAudio.Wave;

namespace MusicPlayerApp
{
    public partial class MainForm : Form
    {
        private Dictionary<string, CircularLinkedList> playlists; // Quản lý các playlist
        private CircularLinkedList currentPlaylist;
        private WaveOutEvent waveOutEvent;
        private AudioFileReader audioFileReader;
        private System.Windows.Forms.Timer timer;

        public MainForm()
        {
            InitializeComponent();
            InitializeTimer();

            // Khởi tạo playlist
            playlists = new Dictionary<string, CircularLinkedList>();
            currentPlaylist = new CircularLinkedList();

            // Thêm playlist mặc định
            AddPlaylist("Default");
            SelectPlaylist("Default");
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer { Interval = 1000 }; // Cập nhật mỗi giây
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null && waveOutEvent != null && waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                progressBar.Value = Math.Min((int)(audioFileReader.CurrentTime.TotalSeconds / audioFileReader.TotalTime.TotalSeconds * 100), 100);
            }
        }

        // Thêm playlist mới
        private void BtnAddPlaylist_Click(object sender, EventArgs e)
        {
            string playlistName = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập tên playlist mới:", 
                "Thêm Playlist", 
                "New Playlist");

            if (!string.IsNullOrWhiteSpace(playlistName) && !playlists.ContainsKey(playlistName))
            {
                AddPlaylist(playlistName);
                MessageBox.Show($"Playlist '{playlistName}' đã được thêm.", "Thành công");
            }
            else
            {
                MessageBox.Show("Tên playlist không hợp lệ hoặc đã tồn tại.", "Lỗi");
            }
        }

        // Chọn playlist từ combobox
        private void CmbPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlaylist.SelectedItem != null)
            {
                string selectedPlaylist = cmbPlaylist.SelectedItem.ToString();
                SelectPlaylist(selectedPlaylist);
            }
        }

        // Thêm bài hát vào playlist hiện tại
        private void BtnAddSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Audio Files (*.mp3)|*.mp3|All Files (*.*)|*.*",
                Title = "Chọn bài hát"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string title = System.IO.Path.GetFileNameWithoutExtension(filePath);

                // Thêm bài hát vào danh sách liên kết và giao diện
                currentPlaylist.AddSong(title, filePath);
                lstPlaylist.Items.Add(new Song(title, filePath)); // Lưu trữ đối tượng Song

                MessageBox.Show($"Đã thêm bài hát: {title}", "Thành công");
            }
        }

        private void BtnNextSong_Click(object sender, EventArgs e)
        {
            if (lstPlaylist.Items.Count == 0)
            {
                MessageBox.Show("Danh sách phát trống!", "Thông báo");
                return;
            }

            int currentIndex = lstPlaylist.SelectedIndex;
            int nextIndex = (currentIndex + 1) % lstPlaylist.Items.Count;
            lstPlaylist.SelectedIndex = nextIndex;

            // Phát bài hát mới
            BtnPlaySong_Click(sender, e);
        }

        // Phát bài hát đã chọn
        private void BtnPlaySong_Click(object sender, EventArgs e)
{
    if (lstPlaylist.SelectedItem == null)
    {
        MessageBox.Show("Hãy chọn một bài hát để phát!", "Thông báo");
        return;
    }

    Song selectedSong = (Song)lstPlaylist.SelectedItem; // Lấy đối tượng Song từ ListBox
    string filePath = selectedSong.FilePath;

    // Dừng nhạc trước đó nếu có
    StopCurrentSong();

    try
    {
        // Phát nhạc
        audioFileReader = new AudioFileReader(filePath);
        waveOutEvent = new WaveOutEvent();
        waveOutEvent.Init(audioFileReader);
        waveOutEvent.Play();

        lblCurrentSong.Text = $"Đang phát: {selectedSong.Title}";
        progressBar.Value = 0;

        // Bắt đầu cập nhật thanh tiến trình
        timer.Start();
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Lỗi khi phát nhạc: {ex.Message}", "Lỗi");
    }
}

        // Dừng phát bài hát hiện tại
        private void BtnStopSong_Click(object sender, EventArgs e)
        {
            StopCurrentSong();
        }

        // Hàm trợ giúp: Dừng bài hát hiện tại
        private void StopCurrentSong()
        {
            if (waveOutEvent != null)
            {
                waveOutEvent.Stop();
                waveOutEvent.Dispose();
                audioFileReader.Dispose();

                lblCurrentSong.Text = "Đã dừng.";
                progressBar.Value = 0;

                // Dừng cập nhật thanh tiến trình
                timer.Stop();
            }
        }

        // Thêm một playlist mới
        private void AddPlaylist(string playlistName)
        {
            playlists[playlistName] = new CircularLinkedList();
            cmbPlaylist.Items.Add(playlistName);

            if (cmbPlaylist.SelectedIndex == -1)
            {
                cmbPlaylist.SelectedIndex = 0; // Chọn playlist đầu tiên
            }
        }

        // Chọn playlist hiện tại và hiển thị danh sách bài hát
        private void SelectPlaylist(string playlistName)
        {
            if (playlists.ContainsKey(playlistName))
            {
                currentPlaylist = playlists[playlistName];
                UpdateSongList();
            }
        }

        // Cập nhật danh sách bài hát trong ListBox
        private void UpdateSongList()
        {
            lstPlaylist.Items.Clear();

            foreach (var song in currentPlaylist.GetPlaylist())
{
    lstPlaylist.Items.Add(song); // Sử dụng ToString của Song tự động
}
        }

        private void BtnDeleteSong_Click(object sender, EventArgs e)
        {
            if (lstPlaylist.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn một bài hát để xóa!", "Thông báo");
                return;
            }

            // Lấy đối tượng Song từ mục được chọn
            Song selectedSong = (Song)lstPlaylist.SelectedItem;
            string title = selectedSong.Title;

            // Gọi phương thức DeleteSong từ đối tượng CircularLinkedList
            string result = currentPlaylist.DeleteSong(title);

            // Hiển thị thông báo và cập nhật giao diện
            MessageBox.Show(result, "Thông báo");

            if (result == "Song deleted successfully.")
            {
                lstPlaylist.Items.Remove(lstPlaylist.SelectedItem); // Xóa bài hát khỏi giao diện
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
{
    string searchTerm = txtSearch.Text.Trim();
    if (string.IsNullOrEmpty(searchTerm))
    {
        MessageBox.Show("Hãy nhập từ khóa tìm kiếm!", "Thông báo");
        return;
    }

    // Tìm kiếm các bài hát theo tiêu chí
    string[] results = currentPlaylist.SearchByCriteria(searchTerm);

    if (results.Length > 0)
    {
        lstPlaylist.Items.Clear();
        
        // Chuyển các chuỗi kết quả tìm kiếm thành đối tượng Song và thêm vào ListBox
        foreach (var result in results)
        {
            string[] parts = result.Split('|');
            string title = parts[0].Trim();
            string filePath = parts[1].Trim();
            
            // Tạo đối tượng Song từ các kết quả tìm kiếm và thêm vào ListBox
            lstPlaylist.Items.Add(new Song(title, filePath));
        }

        MessageBox.Show($"{results.Length} bài hát được tìm thấy!", "Kết quả");
    }
    else
    {
        MessageBox.Show("Không tìm thấy bài hát nào.", "Kết quả");
    }
}

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Khởi tạo playlist mặc định
            cmbPlaylist.Items.Add("Playlist Mặc Định");
            cmbPlaylist.SelectedIndex = 0;
        }
    }
}
