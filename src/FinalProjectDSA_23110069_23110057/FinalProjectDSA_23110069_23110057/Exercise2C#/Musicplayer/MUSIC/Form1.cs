using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace MUSIC
{
    public partial class Form1 : Form
    {
        private Queue songQueue;
        public Form1()
        {
            InitializeComponent();
            songQueue = new Queue();
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChanged;
        }

        private void axWindowsMediaPlayer1_PlayStateChanged(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8) // MediaEnded
            {
                this.Invoke(new Action(() => PlayNextSong()));
            }
            else if (e.newState == 10) // Ready
            {
                // Media is ready to play
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TimeSpan duration = GetMediaDuration(openFileDialog.FileName);
                Song newSong = new Song(System.IO.Path.GetFileName(openFileDialog.FileName), openFileDialog.FileName, duration);
                songQueue.EnQueue(newSong);
                ListViewItem item = new ListViewItem(new[] { newSong.Name, newSong.Duration.ToString(@"hh\:mm\:ss"), newSong.Path });
                lstSongs.Items.Add(item);
            }
        }

        private TimeSpan GetMediaDuration(string filePath)
        {
            try
            {
                var file = TagLib.File.Create(filePath);
                return file.Properties.Duration;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting media duration: " + ex.Message);
                return TimeSpan.Zero;
            }
        }

        private void btnPlayNext_Click(object sender, EventArgs e)
        {
            PlayNextSong();
        }

        private void PlayNextSong()
        {
            if (!songQueue.Empty())
            {
                Song nextSong = songQueue.DeQueue();
                axWindowsMediaPlayer1.URL = nextSong.Path;
                lstSongs.Items.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("Empty playlist!");
            }
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (lstSongs.SelectedIndices.Count > 0)
            {
                int selectedIndex = lstSongs.SelectedIndices[0];
                songQueue.DeQueue();
                lstSongs.Items.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a song to delete!");
            }
        }
    }
}

