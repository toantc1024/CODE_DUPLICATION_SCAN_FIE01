using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ProjectFInal
{
    public partial class Form1 : Form
    {
        private Queue<string> playListQueue;
        private Stack<string> playHistory;
        private Dictionary<string, string> trackPath;
        private int currentTrackIndex = -1;
        string[] paths, files;

        private Random random = new Random();
        private bool isShuffel = false;
        private bool isRepeat = false;
        private List<string> shuffedPlayList;

        [Serializable]
        public class Playlist
        {
            public List<string> trackNames { get; set; }
            public List<string> trackPaths { get; set; }
            public string name { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            player.uiMode = "none";
            player.stretchToFit = true;
            playListQueue = new Queue<string>();
            playHistory = new Stack<string>();
            trackPath = new Dictionary<string, string>();
            player.PlayStateChange += player_PlayStateChange;
        }


        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0)
            {
                currentTrackIndex = track_list.SelectedIndex;
                string selectedTrack = files[currentTrackIndex];
                if (trackPath.ContainsKey(selectedTrack))
                {
                    PlayTrack(trackPath[selectedTrack]);
                    playHistory.Push(selectedTrack);
                }
            }
        }

        private void PlayTrack(string path)
        {
            if (File.Exists(path))
            {
                player.URL = path;
                player.Ctlcontrols.stop(); 
                player.Ctlcontrols.play();
                lbl_msg.Text = $"Playing: {Path.GetFileName(path)}";
                timer1.Start();
            }
            else
            {
                MessageBox.Show($"File not found: {path}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            lbl_msg.Text = "Playing....";
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            lbl_msg.Text = "Pause";
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            lbl_msg.Text = "Stop";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState== WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;
            }
            lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
            lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            lbl_volume.Text = trackBar1.Value.ToString();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (playHistory.Count > 1)
            {
                playHistory.Pop();
                string prevTrack = playHistory.Peek();


                int prevIndex = Array.IndexOf(files, prevTrack);
                if(prevIndex >=0)
                {
                    track_list.SelectedIndex = prevIndex;
                }
            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (playListQueue.Count > 0)
            {
                string nextTrack = playListQueue.Dequeue();
                string nextPath = trackPath[nextTrack];
                PlayTrack(nextPath);

                if (currentTrackIndex >= 0 && currentTrackIndex < files.Length)
                {
                    playHistory.Push(files[currentTrackIndex]);
                }
            }
            else
            {
                PlayNextTrack();
            }
        }
        private void PlayNextTrack()
        {
            if (files == null || files.Length == 0) return;

            string nextTrack = null;

            if (isShuffel)
            {
                if (shuffedPlayList == null || shuffedPlayList.Count == 0)
                {
                    ShuffelCurrentPlaylist();
                }

                nextTrack = shuffedPlayList[0];
                shuffedPlayList.RemoveAt(0);
                currentTrackIndex = Array.IndexOf(files, nextTrack);
            }
            else if (currentTrackIndex < files.Length - 1)
            {
                currentTrackIndex++;
                nextTrack = files[currentTrackIndex];
            }
            else if (isRepeat)
            {
                currentTrackIndex = 0;
                nextTrack = files[currentTrackIndex];
            }

            if (nextTrack != null && trackPath.ContainsKey(nextTrack))
            {
                PlayTrack(trackPath[nextTrack]);
                track_list.SelectedIndex = currentTrackIndex; 
            }
            else
            {
                lbl_msg.Text = "End of playlist.";
            }
        }



        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void ProgressBar1_MouseUp(object sender, MouseEventArgs e)
        {
            int mouseX = e.X;
            double percent = (double)mouseX / progressBar1.Width;
            double newPosition = percent * player.currentMedia.duration;

            player.Ctlcontrols.currentPosition = newPosition;
            timer1.Start();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                track_list.Items.Clear();
                trackPath.Clear();
                for(int x = 0; x<files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                    trackPath[files[x]] = paths[x];
                }
                track_list.SelectedIndex = 0;
                PlayTrack(paths[0]);

            }
        }

        private void btn_shuffel_Click(object sender, EventArgs e)
        {
            isShuffel = !isShuffel;
            Button btn = (Button)sender;
            btn.Text = $"Shuffel: {(isShuffel ? "On" : "Off")}";

            if (isShuffel)
            {
                ShuffelCurrentPlaylist();
            }
        }

        private void ShuffelCurrentPlaylist()
        {
            shuffedPlayList = new List<string>(files);
            int n = shuffedPlayList.Count;
            while(n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string temp = shuffedPlayList[k];
                shuffedPlayList[k] = shuffedPlayList[n];
                shuffedPlayList[n] = temp;
            }
        }

        private void btn_repeat_Click(object sender, EventArgs e)
        {
            isRepeat = !isRepeat;
            Button btn = (Button)sender;
            btn.Text = $"Repeat: {(isRepeat ? "ON" : "Off")}";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Playlist Files (*.playlist)|*.playlist";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Playlist playlist = new Playlist
                    {
                        trackNames = new List<string>(files), // Save track names
                        trackPaths = new List<string>(paths), // Save full paths
                        name = Path.GetFileNameWithoutExtension(sfd.FileName)
                    };

                    XmlSerializer serializer = new XmlSerializer(typeof(Playlist));
                    using (StreamWriter writer = new StreamWriter(sfd.FileName))
                    {
                        serializer.Serialize(writer, playlist);
                    }
                    MessageBox.Show("Playlist saved successfully!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Playlist Files (*.playlist)|*.playlist";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Playlist));
                    using (StreamReader reader = new StreamReader(ofd.FileName))
                    {
                        Playlist playlist = (Playlist)serializer.Deserialize(reader);

                        // Assign loaded tracks
                        files = playlist.trackNames.ToArray();
                        paths = playlist.trackPaths.ToArray();

                        track_list.Items.Clear();
                        trackPath.Clear();

                        for (int i = 0; i < files.Length; i++)
                        {
                            track_list.Items.Add(files[i]);
                            trackPath[files[i]] = paths[i];
                        }

                        MessageBox.Show("Playlist loaded successfully!");
                        track_list.SelectedIndex = 0;
                        PlayTrack(paths[0]);
                    }
                }
            }
        }

        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                player.Ctlcontrols.stop();

                this.BeginInvoke(new Action(() =>
                {
                    PlayNextTrack();
                    if (player.URL != null && player.URL != "")
                    {
                        player.Ctlcontrols.play();
                    }
                }));
            }
        }

    }
}
