using System;
using System.IO;
using System.Windows.Forms;
using NAudio.Wave;
using Exercise2;

namespace Exercise2
{
    public class Modify
    {
        private QUEUE playlist = new QUEUE();
        private Node currentSong;
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader;
        private bool isRepeatEnabled = false; // Flag to check if repeat is enabled
        public bool IsRepeatEnabled
        {
            get { return isRepeatEnabled; }
        }

        public Modify()
        {
        }

        public void AddSongs(ListBox listBox)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "MP3 Files (*.mp3)|*.mp3|All Files (*.*)|*.*",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in openFileDialog.FileNames)
                {
                    string title = Path.GetFileNameWithoutExtension(file);
                    playlist.Push(title, file);
                    listBox.Items.Add(title); // Update ListBox to display the song
                }
            }
        }
        public void RemoveSong(ListBox listBox)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a song to remove.");
                return;
            }

            string selectedSong = listBox.SelectedItem.ToString();

            // Check if the selected song is the currently playing song
            bool isCurrentSongRemoved = currentSong != null && currentSong.Title == selectedSong;

            // Find and remove the song from the queue
            Node current = playlist.Front;
            Node previous = null;

            while (current != null)
            {
                if (current.Title == selectedSong)
                {
                    // Update playlist pointers
                    if (current == playlist.Front)
                    {
                        playlist.Pop();
                    }
                    else
                    {
                        if (previous != null)
                        {
                            previous.next = current.next;
                            if (current.next == null)
                            {
                                playlist.Rear = previous; // Update Rear if the last node is removed
                            }
                        }
                    }

                    listBox.Items.Remove(selectedSong); // Remove from ListBox
                    MessageBox.Show($"Removed song: {selectedSong}");

                    // Update currentSong pointer if the removed song is the currently playing song
                    if (isCurrentSongRemoved)
                    {
                        if (current.next != null)
                        {
                            currentSong = current.next; // Move to the next song
                            PlayCurrentSong(null); // Start playing the next song
                        }
                        else if (previous != null)
                        {
                            currentSong = previous; // Move to the previous song if no next song exists
                            PlayCurrentSong(null); // Start playing the previous song
                        }
                        else
                        {
                            currentSong = null; // No songs left in the playlist
                            StopAudio();
                        }
                    }

                    return; // Exit after removing the song
                }

                previous = current;
                current = current.next;
            }

            MessageBox.Show("Song not found in the playlist.");
        }
        public void ShuffleSongs(ListBox listBox)
        {
            if (playlist.IsEmptyQueue())
            {
                MessageBox.Show("The playlist is empty. Add some songs before shuffling!");
                return;
            }

            // Shuffle the playlist queue
            playlist.ShuffleQueue();

            // Sync the currentSong with the first song in the shuffled list
            currentSong = playlist.Front;

            // Update the ListBox to reflect the new shuffled order
            UpdateListBox(listBox);

            MessageBox.Show("Playlist shuffled!");
        }
        private void UpdateListBox(ListBox listBox)
        {
            listBox.Items.Clear(); // Clear existing items

            Node current = playlist.Front; // Iterate through the queue
            while (current != null)
            {
                listBox.Items.Add(current.Title); // Add each song title to the ListBox
                current = current.next;
            }
        }
        public void PlaySelectedSong(ListBox listBox, Label lblPlaying)
        {
            if (listBox.SelectedItem == null)
            {
                MessageBox.Show("No song selected!");
                return;
            }

            string selectedSong = listBox.SelectedItem.ToString();

            // Find the node for the selected song in the queue
            Node current = playlist.Front;
            while (current != null && current.Title != selectedSong)
            {
                current = current.next;
            }

            if (current == null)
            {
                MessageBox.Show("Song not found in the playlist.");
                return;
            }

            // Update currentSong and play
            currentSong = current;
            PlayCurrentSong(lblPlaying);
        }

        private void StopAudio()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
        }
        public void PlayNextSong(Label lblPlaying)
        {
            if (currentSong == null)
            {
                MessageBox.Show("No song is currently playing!");
                return;
            }

            if (currentSong.next == null)
            {
                MessageBox.Show("No more songs in the playlist!");
                return;
            }

            currentSong = currentSong.next;
            PlayCurrentSong(lblPlaying);
        }
        public void PlayPreviousSong(Label lblPlaying)
        {
            if (currentSong == null)
            {
                MessageBox.Show("No song is currently playing!");
                return;
            }

            // Move to the previous song
            Node previousNode = currentSong.prev;
            while (previousNode != null && !playlist.Contains(previousNode.Title))
            {
                // Skip removed songs
                previousNode = previousNode.prev;
            }

            if (previousNode == null)
            {
                MessageBox.Show("No valid previous song in the playlist!");
                return;
            }

            currentSong = previousNode;
            PlayCurrentSong(lblPlaying);
        }
        // Extract common playback logic into a helper method
        private void PlayCurrentSong(Label lblPlaying)
        {
            string filePath = currentSong.FilePath;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("The file for the song does not exist.");
                return;
            }

            try
            {
                StopAudio(); // Stop any currently playing audio

                audioFileReader = new AudioFileReader(filePath);
                waveOut = new WaveOutEvent();
                waveOut.Init(audioFileReader);
                waveOut.Play();

                lblPlaying.Text = $"Now Playing: {currentSong.Title}";

                // Hook the PlaybackStopped event to repeat the song if repeat mode is enabled
                waveOut.PlaybackStopped += (sender, e) =>
                {
                    if (isRepeatEnabled)
                    {
                        audioFileReader.Position = 0; // Rewind to the start of the song
                        waveOut.Play(); // Restart the song
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while playing the song: {ex.Message}");
            }
        }
        public void ToggleRepeatMode()
        {
            isRepeatEnabled = !isRepeatEnabled; // Toggle the repeat flag
            string repeatStatus = isRepeatEnabled ? "enabled" : "disabled";
            MessageBox.Show($"Repeat mode is now {repeatStatus}.");
        }
        public bool IsPlaying()
        {
            return waveOut != null && waveOut.PlaybackState == PlaybackState.Playing;
        }

        public void TogglePlayPause(Label lblPlaying)
        {
            if (waveOut == null || audioFileReader == null)
            {
                MessageBox.Show("No song is currently loaded!");
                return;
            }

            if (IsPlaying())
            {
                waveOut.Pause();
                lblPlaying.Text = "Paused: " + currentSong.Title;
            }
            else
            {
                waveOut.Play();
                lblPlaying.Text = "Playing: " + currentSong.Title;
            }
        }

        public int GetCurrentPosition()
        {
            if (audioFileReader == null)
                return 0;

            return (int)audioFileReader.CurrentTime.TotalSeconds;
        }

        public int GetTotalDuration()
        {
            if (audioFileReader == null)
                return 0;

            return (int)audioFileReader.TotalTime.TotalSeconds;
        }

        public void SeekToPosition(int positionInSeconds)
        {
            if (audioFileReader == null)
                return;

            audioFileReader.CurrentTime = TimeSpan.FromSeconds(positionInSeconds);
        }
        public void SortPlaylistAscending(ListBox listBox)
        {
            if (playlist.IsEmptyQueue())
            {
                MessageBox.Show("The playlist is empty. Add some songs before sorting!");
                return;
            }

            playlist.QuickSortQueue(playlist); // Sort the queue in ascending order
            currentSong = playlist.Front; // Update currentSong to the first song
            UpdateListBox(listBox);
            MessageBox.Show("Playlist sorted in ascending order!");
        }

        public void SortPlaylistDescending(ListBox listBox)
        {
            if (playlist.IsEmptyQueue())
            {
                MessageBox.Show("The playlist is empty. Add some songs before sorting!");
                return;
            }

            playlist.QuickSortQueue(playlist); // Sort the queue in ascending order
            playlist.ReverseQueueForDesc(playlist); // Reverse the sorted queue for descending order
            currentSong = playlist.Front; // Update currentSong to the first song (now the last in the original order)
            UpdateListBox(listBox);
            MessageBox.Show("Playlist sorted in descending order!");
        }
    }
}