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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EnglishWordApp_EX3
{
    public partial class AppCheckSpelling : Form
    {
        public OperationSystem dictionary;
        public OperationSystem yourOwnDic;

        //private List<Word> dictionary;
        private string[] filePathImage;
        private Random randomIndex;
        private List<string> Words = new List<string>();
        private List<string> yourOwnWords = new List<string>();

        //-------------------------------------------------------------------------------------------
        int RandomIndex;
        private int numClick = 0;
        public AppCheckSpelling()
        {
            InitializeComponent();
            dictionary = new OperationSystem();
            yourOwnDic = new OperationSystem();
            //dictionary = new List<Word>();

            ReadFileTxt("Noun.TXT");
            ReadFileTxt("Adjective.TXT");
            ReadFileTxt("Verb.TXT");

            TakeImage("Image");
            randomIndex = new Random();
        }
        public void TakeImage(string filePath)
        {
            if(Directory.Exists("Image"))
            {
                filePathImage = Directory.GetFiles("Image","*.*")
                                       .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png"))
                                       .ToArray();
                if (filePathImage.Length == 0)
                {
                    MessageBox.Show("No image or can't take any imange");
                }
                //else MessageBox.Show("Have dictionary");

            }
            else
            {
                MessageBox.Show("Image folder does not exist.");
            }
        }
        public void ReadFileTxt(string filePath)
        {
            try { using (StreamReader sr = new StreamReader(filePath)) {
                    
                    if(filePath == "Noun.TXT")
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Word word = new Word(line, "Noun");
                            //dictionary.Add(word);
                            dictionary.addWord(word);
                        }
                    }
                    else if (filePath == "Adjective.TXT")
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Word word = new Word(line, "Adjective");
                            //dictionary.Add(word);
                            dictionary.addWord(word);
                        }
                    }
                    else if (filePath == "Verb.TXT")
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            Word word = new Word(line, "Verb");
                            //dictionary.Add(word);
                            dictionary.addWord(word);
                        }
                    }
                }
            } 
            catch (Exception e) { 
                MessageBox.Show("Could not read the file:");
                MessageBox.Show(e.Message); 
            }
        }

        private void textBoxWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dictionary.FindWord(textBoxWord.Text);

            string textFromImage = filePathImage[RandomIndex];
            int indexDot = textFromImage.IndexOf("\\");
            string textResultImage = textFromImage.Substring(indexDot+1);
            indexDot = textResultImage.IndexOf(".");
            textResultImage = textResultImage.Substring(0, indexDot);

            MessageBox.Show(textResultImage , Convert.ToString(Words.Count));
            if (textResultImage == textBoxWord.Text)
            {
                Words.Add(textResultImage);
                MessageBox.Show("Congratulation");
            }
            else
            {
                MessageBox.Show("Something wrong");

            }
        }

        private void pictureBoxRamdon_Click(object sender, EventArgs e)
        {

        }

        private void AppCheckSpelling_Load(object sender, EventArgs e)
        {
            listViewResult.View = View.Details;
            listViewResult.Columns.Add("Word",150);
            listViewResult.Columns.Add("Type",150);

            listViewYourDic.View = View.Details;
            listViewYourDic.Columns.Add("Word", 150);
            listViewYourDic.Columns.Add("Type", 150);
        }

        private void btnRandomImage_Click(object sender, EventArgs e)
        {
            if (filePathImage == null || filePathImage.Length == 0)
            {
                MessageBox.Show("No images available. Please check the image folder.");
                return;
            }
            RandomIndex = randomIndex.Next(filePathImage.Length);
            pictureBoxRamdon.ImageLocation = filePathImage[RandomIndex];
            pictureBoxRamdon.SizeMode = PictureBoxSizeMode.StretchImage;
            lbHint.Visible = false;
            btnRandomImage.Text = "Continue";
            btnRandomImage.ForeColor = Color.Green;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            //dictionary.FindWord(textBoxWord.Text);
            string textFromImage = filePathImage[RandomIndex];
            int indexDot = textFromImage.IndexOf("\\");
            string textResultImage = textFromImage.Substring(indexDot + 1);
            indexDot = textResultImage.IndexOf(".");
            textResultImage = textResultImage.Substring(0, indexDot);

            string result = textResultImage;

            dictionary.findHint(ref textResultImage);
            lbHint.Text = textResultImage;
            lbHint.Visible = true;

            if (numClick == 0) 
            {
                btnHint.Text = "Hint(1)";
            }
            else if (numClick == 1) 
            {
                MessageBox.Show(dictionary.FindTypeForWord(result));
                btnHint.Text = "Hint(2)";
            }
            else if (numClick == 2) 
            {
                MessageBox.Show("Bạn đã nhận đủ gợi ý!");
                btnHint.Enabled = false; 
            }

            numClick++; 
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            listViewResult.Items.Clear();
            for (int i = 0; i < Words.Count; i++)
            {
                string typeOfWord = dictionary.FindTypeForWord(Words[i]);
                ListViewItem item1 = new ListViewItem(Words[i]);
                listViewResult.Items.Add(item1);
                item1.SubItems.Add(typeOfWord);
            }
            if(listViewResult.Visible == false)
            {
                listViewResult.Visible = true;
            }
            else { listViewResult.Visible = false; }
        }

        private void listViewResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

            private void btnMakeDic_Click(object sender, EventArgs e)
            {
                AddWord addWord = new AddWord();
                if (addWord.ShowDialog() == DialogResult.OK) {
                    Word addedWord = new Word(addWord.Word, addWord.TypeOfWord);
                    yourOwnDic.addWord(addedWord);
                    yourOwnWords.Add(addWord.Word);
                    MessageBox.Show("Have saved"+addWord.Word+" to your dictionary");
                }

                listViewYourDic.Items.Clear();
            for (int i = 0; i < yourOwnWords.Count; i++)
            {
                string typeOfWord = yourOwnDic.FindTypeForWord(yourOwnWords[i]);
                ListViewItem item2 = new ListViewItem(yourOwnWords[i]);
                item2.SubItems.Add(typeOfWord);
                listViewYourDic.Items.Add(item2);
            }
        }

        private void btnShowYourDic_Click(object sender, EventArgs e)
        {
            listViewYourDic.Items.Clear();
            for (int i = 0; i < yourOwnWords.Count; i++)
            {
                string typeOfWord = yourOwnDic.FindTypeForWord(yourOwnWords[i]);
                ListViewItem item1 = new ListViewItem(yourOwnWords[i]);
                listViewYourDic.Items.Add(item1);
                item1.SubItems.Add(typeOfWord);
            }
            if (listViewYourDic.Visible == false)
            {
                listViewYourDic.Visible = true;
            }
            else { listViewYourDic.Visible = false; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            string textFromImage = filePathImage[RandomIndex];
            int indexDot = textFromImage.IndexOf("\\");
            string textResultImage = textFromImage.Substring(indexDot + 1);
            indexDot = textResultImage.IndexOf(".");
            textResultImage = textResultImage.Substring(0, indexDot);
            MessageBox.Show($"Result: {textResultImage}");

            RandomIndex = randomIndex.Next(filePathImage.Length);
            pictureBoxRamdon.ImageLocation = filePathImage[RandomIndex];
            pictureBoxRamdon.SizeMode = PictureBoxSizeMode.StretchImage;

            btnHint.Enabled = true;
            btnHint.Text = "Hint";
            numClick = 0;
        }
    }
}
