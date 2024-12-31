using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using WMPLib;
namespace CircularLinkedList_CSharp
{
    public partial class Form1 : Form
    {
        private CircularLinkedList songList;
        private Node currentSongNode;
        private bool isFirstPlay = true;
        private bool isAutoPlaying = true;
        public Form1()
        {
            InitializeComponent();
            songList = new CircularLinkedList();
            currentSongNode = null;
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
            axWindowsMediaPlayer1.settings.autoStart = true;
        }

        private void btnAddsong_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TimeSpan duration = GetMediaDuration(openFileDialog.FileName);
                Song newSong = new Song(System.IO.Path.GetFileNameWithoutExtension(openFileDialog.FileName), openFileDialog.FileName, duration);
                Node newNode = Node.CreateNode(newSong);

                if (string.IsNullOrWhiteSpace(txtPosition.Text))
                {
                    songList.InsertLast(newNode);
                }
                else
                {
                    int position;
                    if (int.TryParse(txtPosition.Text, out position))
                    {
                        songList.InsertAfter(newNode, position);
                    }
                    else
                    {
                        MessageBox.Show("Invalid position. Please enter a valid number.");
                        return;
                    }
                }
                UpdateSongList();

                // Set currentSongNode if it's null
                if (currentSongNode == null)
                {
                    currentSongNode = songList.Head;
                    isFirstPlay = true;
                }
            }
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                songList.RemoveFirst();
            }
            else
            {
                int position;
                if (int.TryParse(txtPosition.Text, out position))
                {
                    songList.RemoveAfter(position - 1);
                }
                else
                {
                    MessageBox.Show("Invalid position. Please enter a valid number.");
                    return;
                }
            }
            UpdateSongList();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            songList.Reverse();
            UpdateSongList();
        }

        private void UpdateSongList()
        {
            dgvSongs.Rows.Clear();
            foreach (Node node in songList.ToList())
            {
                dgvSongs.Rows.Add(node.Data.Name, node.Data.Path, node.Data.Duration.ToString(@"hh\:mm\:ss"));
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

        private void PlayCurrentSong()
        {
            if (currentSongNode != null)
            {
                axWindowsMediaPlayer1.URL = currentSongNode.Data.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPPlayState)e.newState == WMPPlayState.wmppsMediaEnded)
            {
                if (isAutoPlaying && currentSongNode != null)
                {
                    BeginInvoke(new Action(() =>
                    {
                        currentSongNode = currentSongNode.Next;
                        if (currentSongNode != null)
                        {
                            axWindowsMediaPlayer1.URL = currentSongNode.Data.Path;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                    }));
                }
            }
        }
        private void PlayNextSong()
        {
            if (currentSongNode != null && !songList.IsEmpty())
            {
                if (isFirstPlay)
                {
                    currentSongNode = songList.Head;
                    isFirstPlay = false;
                }
                else
                {
                    currentSongNode = currentSongNode.Next;
                }
                PlayCurrentSong();
            }
        }
        private void btnNextSong_Click(object sender, EventArgs e)
        {
            PlayNextSong();
        }

        private void btnSortByName_Click(object sender, EventArgs e)
        {
            songList.SelectionSort();
            UpdateSongList();
        }

        private void btnSortByDuration_Click(object sender, EventArgs e)
        {
            songList.QuickSort();
            UpdateSongList();
        }                
        private void pictureBoxSearchByName_Click_1(object sender, EventArgs e)
        {
            string query = txtSearchByName.Text;

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a search query.");
                return;
            }

            Node result = songList.SearchSong(query);
            if (result != null)
            {
                dgvSongs.Rows.Clear();
                dgvSongs.Rows.Add(result.Data.Name, result.Data.Path, result.Data.Duration.ToString(@"hh\:mm\:ss"));
            }
            else
            {
                MessageBox.Show("No song found with the specified name.");
            }
        }

        private void pictureBoxSearchByDuration_Click(object sender, EventArgs e)
        {
            string query = txtSearchByDuration.Text;

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a search query.");
                return;
            }

            if (TimeSpan.TryParse(query, out TimeSpan duration))
            {
                CircularLinkedList result = songList.SearchSongsHaveDurationShorterOrEquals(duration);
                if (!result.IsEmpty())
                {
                    dgvSongs.Rows.Clear();
                    foreach (Node node in result.ToList())
                    {
                        dgvSongs.Rows.Add(node.Data.Name, node.Data.Path, node.Data.Duration.ToString(@"hh\:mm\:ss"));
                    }
                }
                else
                {
                    MessageBox.Show("No songs found with the specified duration.");
                }
            }
            else
            {
                MessageBox.Show("Invalid duration format. Please use hh:mm:ss.");
            }
        }
    }
}

