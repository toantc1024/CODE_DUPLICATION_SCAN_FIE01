using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectFinalDataStructure
{
    public partial class FormCircularlinkedlist : Form
    {
        private TextEditor textEditor;
        private bool isUndoRedoInProgress = false;
        public FormCircularlinkedlist()
        {
            InitializeComponent();
        }

        private void buttonBai1_Click(object sender, EventArgs e)
        {

        }

        private void FormCircularlinkedlist_Load(object sender, EventArgs e)
        {
            textEditor = new TextEditor();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (isUndoRedoInProgress)
            {
                return;  // Skip the event to prevent unnecessary changes during Undo/Redo
            }
            textEditor.TypeText(textBox1.Text);


        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (textEditor.Undo())
            {
                // Temporarily disable the TextChanged event to prevent it from being triggered
                isUndoRedoInProgress = true;
                textBox1.Text = textEditor.GetCurrentText();  // Update the TextBox after Undo
                isUndoRedoInProgress = false;

            }
            else
            {
                MessageBox.Show("No more actions to undo.");
            }
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            if (textEditor.Redo())
            {
                // Temporarily disable the TextChanged event to prevent it from being triggered
                isUndoRedoInProgress = true;
                textBox1.Text = textEditor.GetCurrentText();  // Update the TextBox after Redo
                isUndoRedoInProgress = false;


            }
            else
            {
                MessageBox.Show("No more actions to redo.");
            }

        }
    }
}
