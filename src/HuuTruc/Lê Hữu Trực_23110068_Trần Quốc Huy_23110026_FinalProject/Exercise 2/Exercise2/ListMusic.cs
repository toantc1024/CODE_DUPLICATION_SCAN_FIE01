using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Exercise2;
using NAudio.Wave;

namespace Exercise2
{
    public partial class ListMusic : Form
    {
        private Modify modify = new Modify();
        private Timer progressTimer;
        public ListMusic()
        {
            InitializeComponent();
            ListMusicLB.DoubleClick += LstPlaylist_DoubleClick;

            // Attach MouseDown event for guna2ProgressBarMusic
            guna2ProgressBarMusic.MouseDown += guna2ProgressBarMusic_MouseDown;

            progressTimer = new Timer();
            progressTimer.Interval = 500; // Update every 500ms
            progressTimer.Tick += ProgressTime_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LstPlaylist_DoubleClick(object sender, EventArgs e)
        {
            if (ListMusicLB.SelectedItem != null)
            {
                // Play selected song and start the progress timer
                modify.PlaySelectedSong(ListMusicLB, lblPlayCurrentSong);

                // Start updating the progress bar
                progressTimer.Start();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            modify.AddSongs(ListMusicLB);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            modify.PlayNextSong(lblPlayCurrentSong);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            modify.RemoveSong(ListMusicLB);
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            modify.ShuffleSongs(ListMusicLB);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            modify.PlayPreviousSong(lblPlayCurrentSong);
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            modify.ToggleRepeatMode();
            btnRepeat.Text = modify.IsRepeatEnabled ? "Repeat: ON" : "Repeat: OFF";
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            modify.TogglePlayPause(lblPlayCurrentSong);

            // Start or stop the timer based on the playback state
            if (modify.IsPlaying())
                progressTimer.Start();
            else
                progressTimer.Stop();
        }
        private void guna2ProgressBarMusic_MouseDown(object sender, MouseEventArgs e)
        {
            if (guna2ProgressBarMusic.Maximum > 0)
            {
                int newPosition = (int)((e.X / (float)guna2ProgressBarMusic.Width) * guna2ProgressBarMusic.Maximum);
                modify.SeekToPosition(newPosition);
                guna2ProgressBarMusic.Value = newPosition;
            }
        }

        private void ProgressTime_Tick(object sender, EventArgs e)
        {
            if (modify.IsPlaying())
            {
                int currentPosition = modify.GetCurrentPosition();
                int totalDuration = modify.GetTotalDuration();

                if (totalDuration > 0)
                {
                    guna2ProgressBarMusic.Maximum = totalDuration;
                    guna2ProgressBarMusic.Value = currentPosition;

                    // Optionally, update a label with the current time
                    lblCurrentTime.Text = TimeSpan.FromSeconds(currentPosition).ToString(@"mm\:ss");
                    lblTotalTime.Text = TimeSpan.FromSeconds(totalDuration).ToString(@"mm\:ss");
                }
            }
            else
            {
                progressTimer.Stop(); // Stop the timer when playback ends
            }
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            modify.SortPlaylistAscending(ListMusicLB);
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            modify.SortPlaylistDescending(ListMusicLB);
        }
    }
}
