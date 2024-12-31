using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordApp_EX3
{
    public partial class AddWord : Form
    {
        private string word;
        public string Word { get => word; set => word = value; }

        private string typeOfWord;
        public string TypeOfWord { get => typeOfWord; set => typeOfWord = value; }
        public AddWord()
        {
            InitializeComponent();
        }

        private void AddWord_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNewWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Word = textBoxNewWord.Text;
            TypeOfWord = textBoxTypeOfWord.Text;
            if (TypeOfWord == "" || Word == "")
            {
                MessageBox.Show("Please input missing textbox");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
