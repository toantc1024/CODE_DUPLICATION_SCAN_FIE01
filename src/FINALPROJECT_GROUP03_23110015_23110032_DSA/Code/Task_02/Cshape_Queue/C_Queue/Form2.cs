using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace C_Queue
{
    public partial class Form2 : Form
    {
        public string CustomerName { get; private set; }
        public string SelectedCombos { get; private set; }
        public bool IsInfoProvided { get; private set; }

        public Form2()
        {
            InitializeComponent();
            IsInfoProvided = false;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            CustomerName = textBoxName.Text;
            if (CustomerName.Length <= 2 || CustomerName == "Enter your name...")
            {
                MessageBox.Show("Name must be more than 2 characters.");
                return;
            }

            SelectedCombos = GetSelectedCombos();
            if (string.IsNullOrEmpty(SelectedCombos))
            {
                MessageBox.Show("You must select at least one combo.");
                return;
            }

            IsInfoProvided = true;
            this.Close();
        }

        private string GetSelectedCombos()
        {
            var combos = checkedListBoxCombos.CheckedItems.Cast<string>().ToList();
            return string.Join(", ", combos);
        }

        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            if (textBoxName.Text == "Enter your name...")
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void SetPlaceholderText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                textBoxName.Text = "Enter your name...";
                textBoxName.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelChooseCombos_Click(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }
    }
}
