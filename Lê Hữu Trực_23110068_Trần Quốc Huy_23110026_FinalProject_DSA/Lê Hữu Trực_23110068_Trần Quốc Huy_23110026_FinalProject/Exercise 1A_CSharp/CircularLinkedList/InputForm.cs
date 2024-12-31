using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularLinkedList
{
    public partial class InputForm : Form
    {
        //FOR DRAGGING
        private bool dragging = false; //check if the mouse is in dragging state
        private Point dragCursorPoint; //save the current pos of the mouse
        private Point dragFormPoint;   //save the current pos of the form

        public bool merge = false;
        public InputForm()
        {
            InitializeComponent();
        }

        private void okBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!merge)
                    MainForm.findValue = Convert.ToInt32(inputTB.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closePIC_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }

        private void minimizePIC_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void topPN_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true; //in dragging state
            dragCursorPoint = System.Windows.Forms.Cursor.Position; //update cursor pos
            dragFormPoint = this.Location; //update form pos
        }

        private void topPN_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                //calculate the displacement between init pos and current pos
                Point dif = Point.Subtract(System.Windows.Forms.Cursor.Position, new Size(dragCursorPoint));
                //add the displacement into the location of the form
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void topPN_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

    }
}
