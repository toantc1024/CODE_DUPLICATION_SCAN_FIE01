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
    public partial class MainForm : Form
    {
        CircularLinkedList list;
        public MainForm()
        {
            InitializeComponent();
            list = new CircularLinkedList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Call the method to draw the circular linked list
            DrawCircularLinkedList(e.Graphics);
        }
        private void btnInsertBeginning_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtData.Text, out int value))
            {
                list.InsertAtBeginning(value);

                txtData.Clear();
                Refresh(); // Trigger a redraw
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }
        private void DrawCircularLinkedList(Graphics g, int? searchedValue = null)
        {
            if (list.IsEmpty())
            {
                g.DrawString("The list is empty.", new Font("Arial", 14), Brushes.Black, this.ClientSize.Width / 2 - 50, this.ClientSize.Height / 2);
                return;
            }

            // Set up drawing parameters
            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int radius = 150;
            int nodeRadius = 30;
            Pen pen = new Pen(Color.Black, 2);
            Pen arrowPen = new Pen(Color.Black, 2) { EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor };
            Brush nodeBrush = new SolidBrush(Color.LightBlue);
            Brush headBrush = new SolidBrush(Color.Green); // Brush for head node
            Brush tailBrush = new SolidBrush(Color.Red);   // Brush for tail node
            Brush highlightBrush = new SolidBrush(Color.Yellow); // Brush for the searched node
            Font font = new Font("Arial", 10, FontStyle.Bold);

            // Get the list of nodes
            Node tail = list.GetTail();
            Node head = tail.Next;
            Node current = head;
            int nodeCount = 0;

            // Count the number of nodes
            do
            {
                nodeCount++;
                current = current.Next;
            } while (current != head);

            // Calculate node positions
            PointF[] positions = new PointF[nodeCount];
            for (int i = 0; i < nodeCount; i++)
            {
                float angle = (float)(2 * Math.PI * i / nodeCount); // Divide circle into equal parts
                float x = centerX + radius * (float)Math.Cos(angle);
                float y = centerY + radius * (float)Math.Sin(angle);
                positions[i] = new PointF(x, y);
            }

            // Draw nodes and connections
            current = head;
            for (int i = 0; i < nodeCount; i++)
            {
                // Draw connection to the next node
                int nextIndex = (i + 1) % nodeCount;
                DrawArrow(g, arrowPen, positions[i], positions[nextIndex]);

                // Choose the brush based on node type
                Brush currentBrush = (current.Data == searchedValue) ? highlightBrush :
                                     (current == head) ? headBrush :
                                     (current == tail) ? tailBrush :
                                     nodeBrush;

                // Draw node circle
                g.FillEllipse(currentBrush, positions[i].X - nodeRadius, positions[i].Y - nodeRadius, nodeRadius * 2, nodeRadius * 2);
                g.DrawEllipse(pen, positions[i].X - nodeRadius, positions[i].Y - nodeRadius, nodeRadius * 2, nodeRadius * 2);

                // Draw node data
                string data = current.Data.ToString();
                SizeF textSize = g.MeasureString(data, font);
                g.DrawString(data, font, Brushes.Black, positions[i].X - textSize.Width / 2, positions[i].Y - textSize.Height / 2);

                // Add labels for head and tail
                if (current == head)
                {
                    g.DrawString("Head", font, Brushes.Green, positions[i].X + nodeRadius, positions[i].Y - nodeRadius);
                }
                else if (current == tail)
                {
                    g.DrawString("Tail", font, Brushes.Red, positions[i].X + nodeRadius, positions[i].Y - nodeRadius);
                }

                current = current.Next;
            }
        }


        private void DrawArrow(Graphics g, Pen pen, PointF start, PointF end)
        {
            const float arrowSize = 8.0f; // Arrowhead size

            // Calculate the midpoint
            PointF mid = new PointF(
                (start.X + end.X) / 2,
                (start.Y + end.Y) / 2
            );

            // Calculate the angle of the line
            float angle = (float)Math.Atan2(end.Y - start.Y, end.X - start.X);

            // Draw the line
            g.DrawLine(pen, start, end);

            // Calculate points for the arrowhead at the midpoint
            PointF arrowPoint1 = new PointF(
                mid.X - arrowSize * (float)Math.Cos(angle - Math.PI / 6),
                mid.Y - arrowSize * (float)Math.Sin(angle - Math.PI / 6));

            PointF arrowPoint2 = new PointF(
                mid.X - arrowSize * (float)Math.Cos(angle + Math.PI / 6),
                mid.Y - arrowSize * (float)Math.Sin(angle + Math.PI / 6));

            // Draw the arrowhead
            g.DrawLine(pen, mid, arrowPoint1);
            g.DrawLine(pen, mid, arrowPoint2);
        }

        private void btnInsertAtEnd_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtData.Text, out int value))
            {
                list.InsertAtEnd(value);
                Refresh();
                txtData.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void InsertAfter_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtData.Text, out int value))
            {
                Node found = list.Search(value);
                if (found != null)
                {
                    MessageBox.Show($"Value {value} found in the list.");
                    Refresh(); // Redraw the list with the highlighted node
                }
                else
                {
                    MessageBox.Show($"Value {value} not found in the list.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            if (list.IsEmpty())
            {
                MessageBox.Show("List is empty.");
                return;
            }

            list.RemoveLast();
            Refresh();
            txtData.Clear();
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            if (list.IsEmpty())
            {
                MessageBox.Show("List is empty.");
                return;
            }
            list.RemoveFirst();
            Refresh();

        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            list.SelectionSort();
            Refresh();
        }

        private void btnRemoveAfter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtData.Text, out int value))
            {
                list.RemoveAfter(value);
                Refresh();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnInsertAfter_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtData.Text, out int newValue) && int.TryParse(textBoxInsertAfter.Text, out int afterValue))
            {
                // Insert the new node after the specified value
                list.InsertAfter(afterValue, newValue);

                // Refresh the form to update the visualization
                Refresh();

                // Clear the input fields
                txtData.Clear();
                textBoxInsertAfter.Clear();
            }
            else
            {
                MessageBox.Show("Please enter valid integers for both the new value and the 'insert after' value.");
            }
        }
    }
}
