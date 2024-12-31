using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFinalDataStructure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExercise1_Click(object sender, EventArgs e)
        {
            MainForm formCircularlinkedlist = new MainForm();
            formCircularlinkedlist.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            FormCircularlinkedlist formCircularlinkedlist = new FormCircularlinkedlist();
            formCircularlinkedlist.Show();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            TreeForm treeForm = new TreeForm();
            treeForm.Show();
        }
    }
}
