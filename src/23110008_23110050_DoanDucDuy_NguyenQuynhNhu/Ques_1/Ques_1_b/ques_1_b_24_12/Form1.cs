using b_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ques_1_b_24_12
{
    public partial class v : Form
    {
        private SongNode last;

        public v()
        {
            InitializeComponent();
        }

        private void Addbegining_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            double time = double.Parse(txtTime.Text);

            last = InsertAtBeginning(title, author, time);
            UpdateSongList();
            ClearTextBoxes();

        }

        private void Addaftersong_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            double time = double.Parse(txtTime.Text);
            string afterTitle = txtAfterTitle.Text;

            last = InsertAfterNode(title, author, time, afterTitle);
            UpdateSongList();
            ClearTextBoxes();

        }

        private void Addend_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            double time = double.Parse(txtTime.Text);

            last = InsertAtEnd(title, author, time);
            UpdateSongList();
            ClearTextBoxes();

        }
        private void UpdateSongList()
        {
            listBoxSongs.Items.Clear();

            if (last == null) return;

            SongNode temp = last.Next;
            do
            {
                listBoxSongs.Items.Add($"{temp.Title} - {temp.Author} - {temp.Time} mins");
                temp = temp.Next;
            } while (temp != last.Next);
        }
        public SongNode AddToEmpty(string title, string author, double time)
        {
            if (last != null) return last;

            SongNode newNode = new SongNode(title, author, time);
            last = newNode;
            last.Next = last;
            return last;
        }
        public SongNode InsertAtBeginning(string title, string author, double time)
        {
            if (last == null) return AddToEmpty(title, author, time);

            SongNode newNode = new SongNode(title, author, time);
            newNode.Next = last.Next;
            last.Next = newNode;
            return last;
        }
        public SongNode InsertAtEnd(string title, string author, double time)
        {
            if (last == null) return AddToEmpty(title, author, time);

            SongNode newNode = new SongNode(title, author, time);
            newNode.Next = last.Next;
            last.Next = newNode;
            last = newNode;
            return last;
        }
        public SongNode InsertAfterNode(string title, string author, double time, string afterTitle)
        {
            if (last == null) return null;

            SongNode temp = last.Next;
            do
            {
                if (temp.Title == afterTitle)
                {
                    SongNode newNode = new SongNode(title, author, time);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;

                    if (temp == last)
                        last = newNode;

                    return last;
                }
                temp = temp.Next;
            } while (temp != last.Next);

            MessageBox.Show($"Song with title '{afterTitle}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return last;
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ClearTextBoxes()
        {
            txtTitle.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtTime.Text = string.Empty;
            txtAfterTitle.Text = string.Empty;
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            if (last == null)
            {
                MessageBox.Show("The list is empty. Cannot remove the first song.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (last.Next == last)
            {
                MessageBox.Show($"Removed first song: {last.Title}. The list is now empty.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                last = null;
            }
            else
            {
                SongNode temp = last.Next;
                last.Next = temp.Next;
                MessageBox.Show($"Removed first song: {temp.Title}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateSongList();
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            if (last == null)
            {
                MessageBox.Show("The list is empty. Cannot remove the last song.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (last.Next == last)
            {
                MessageBox.Show($"Removed last song: {last.Title}. The list is now empty.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                last = null;
            }
            else
            {
                SongNode temp = last.Next;
                while (temp.Next != last)
                {
                    temp = temp.Next;
                }

                MessageBox.Show($"Removed last song: {last.Title}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temp.Next = last.Next;
                last = temp;
            }

            UpdateSongList();
        }

        private void btnRemoveAfter_Click(object sender, EventArgs e)
        {
            string title = txtAfterTitle.Text;

            if (last == null)
            {
                MessageBox.Show("The list is empty. Cannot remove any song.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SongNode temp = last.Next;
            do
            {
                if (temp.Title == title)
                {
                    if (temp.Next == last)
                    {
                        last = temp;
                    }

                    SongNode toRemove = temp.Next;
                    temp.Next = toRemove.Next;
                    MessageBox.Show($"Removed song after '{title}': {toRemove.Title}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateSongList();
                    return;
                }
                temp = temp.Next;
            } while (temp != last.Next);

            MessageBox.Show($"Song with title '{title}' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchByTitle_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;

            if (last == null)
            {
                MessageBox.Show("The playlist is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<SongNode> matchingSongs = SearchByTitle(title);

            lstbox2.Items.Clear();

            if (matchingSongs.Count > 0)
            {
                foreach (var song in matchingSongs)
                {
                    lstbox2.Items.Add($"{song.Title} - {song.Author} - {song.Time} mins");
                }
            }
            else
            {
                MessageBox.Show($"No songs found with title containing '{title}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClearTextBoxes();

        }
        private void btnSearchByAuthor_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text;

            if (last == null)
            {
                MessageBox.Show("The playlist is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<SongNode> matchingSongs = SearchByAuthor(author);

            lstbox2.Items.Clear();

            if (matchingSongs.Count > 0)
            {
                foreach (var song in matchingSongs)
                {
                    lstbox2.Items.Add($"{song.Title} - {song.Author} - {song.Time} mins");
                }
            }
            else
            {
                MessageBox.Show($"No songs found by author '{author}'.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ClearTextBoxes();

        }
        private void btnSearchByIndex_Click(object sender, EventArgs e)
        {
            if (last == null)
            {
                MessageBox.Show("The playlist is empty.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (int.TryParse(txtAfterTitle.Text, out int index))
            {
                SongNode song = SearchByIndex(index);

                lstbox2.Items.Clear(); 

                if (song != null)
                {
                    lstbox2.Items.Add($"Song at index {index}: {song.Title} - {song.Author} - {song.Time} mins");
                }
                else
                {
                    MessageBox.Show($"No song found at index {index}.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid index. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearTextBoxes();

        }

        private List<SongNode> SearchByTitle(string title)
        {
            List<SongNode> matchingSongs = new List<SongNode>();

            if (last == null) return matchingSongs;

            SongNode temp = last.Next;
            do
            {
                if (temp.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    matchingSongs.Add(temp);
                }
                temp = temp.Next;
            } while (temp != last.Next);

            return matchingSongs;
        }


        private List<SongNode> SearchByAuthor(string author)
        {
            List<SongNode> matchingSongs = new List<SongNode>();

            if (last == null) return matchingSongs;

            SongNode temp = last.Next;
            do
            {
                if (temp.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    matchingSongs.Add(temp);
                }
                temp = temp.Next;
            } while (temp != last.Next);

            return matchingSongs;
        }


        private SongNode SearchByIndex(int index)
        {
            if (last == null || index < 0) return null;

            SongNode temp = last.Next;
            int currentIndex = 0;
            do
            {
                if (currentIndex == index)
                {
                    return temp;
                }
                temp = temp.Next;
                currentIndex++;
            } while (temp != last.Next);

            return null;
        }
        private SongNode current;

        public void PlayMusic()
        {
            if (last == null)
            {
                MessageBox.Show("Playlist is empty. Add some songs first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (current == null)
            {
                current = last.Next;
            }

            lstbox2.Items.Clear();
            lstbox2.Items.Add($"Now Playing: {current.Title} - {current.Author} - {current.Time:F1} mins"); 
            lstbox2.Visible = true;
        }



        private void btnPreviousSong_Click(object sender, EventArgs e)
        {
            if (current == null) return;

            SongNode temp = last.Next;
            if (temp == current)
            {
                current = last;
            }
            else
            {
                while (temp.Next != current)
                {
                    temp = temp.Next;
                }

                current = temp;
            }

            lstbox2.Items.Clear(); 
            lstbox2.Items.Add($"Now Playing: {current.Title} - {current.Author} - {current.Time:F1} mins"); 
        }

        private void btnNextSong_Click(object sender, EventArgs e)
        {
            if (current == null) return;

            current = current.Next;

            lstbox2.Items.Clear(); 
            lstbox2.Items.Add($"Now Playing: {current.Title} - {current.Author} - {current.Time:F1} mins"); 
        }


        private void btnPlaysong_Click(object sender, EventArgs e)
        {
            if (last == null)
            {
                MessageBox.Show("Playlist is empty. Add some songs first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            current = last.Next; 
            lstbox2.Items.Clear(); 
            lstbox2.Items.Add($"Now Playing: {current.Title} - {current.Author} - {current.Time:F1} mins");
            lstbox2.Visible = true;
        }

    }
}
