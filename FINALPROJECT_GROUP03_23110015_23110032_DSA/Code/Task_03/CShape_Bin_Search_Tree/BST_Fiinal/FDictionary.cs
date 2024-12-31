using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BST_Fiinal
{
    public partial class FDictionary : Form
    {
        BinarySearchTree dictionary = new BinarySearchTree();
        public FDictionary()
        {
            InitializeComponent();
            dictionary.Insert("Apple", "A fruit thtat is red, green, or yellow");
            dictionary.Insert("Banana", "A long yellow fruit");
            dictionary.Insert("Cherry", "A small, round, and red fruit");
            dictionary.Insert("Date", "A sweet brown fruit");
            DisplayData(dictionary);
        }

        void DisplayData(BinarySearchTree dicToDisplay)
        {
            liboxData.Items.Clear();
            if (dictionary.Root != null)
            {
                string input = dicToDisplay.DisplayInOrder();
                string[] words = input.Split(';');
                foreach (string word in words)
                {
                    liboxData.Items.Add(word);
                }
            }
        }
        private void FDictionary_Load(object sender, EventArgs e)
        {

        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            string word = tbWord.Text;
            string meaning = tbMeaning.Text;
            dictionary.Insert(word, meaning);
            DisplayData(dictionary);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string word = tbWord.Text;
            if(word == "")
            {
                MessageBox.Show("Choose a word to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dictionary.Delete(word);
                DisplayData(dictionary); 
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string word = tbWord.Text;
            string searchWord = dictionary.Search(word);
            tbMeaning.Text = searchWord == "empty" ? "The word does not exits" : searchWord;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
