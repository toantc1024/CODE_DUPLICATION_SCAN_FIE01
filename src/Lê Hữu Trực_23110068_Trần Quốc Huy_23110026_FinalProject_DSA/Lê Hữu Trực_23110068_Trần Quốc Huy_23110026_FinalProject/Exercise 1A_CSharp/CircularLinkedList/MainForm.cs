using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TYPE = System.Int32;

namespace CircularLinkedList
{
    public partial class MainForm : Form
    {
        //FOR DRAGGING
        private bool dragging = false; //check if the mouse is in dragging state
        private Point dragCursorPoint; //save the current pos of the mouse
        private Point dragFormPoint;   //save the current pos of the form
        //DATA
        private CLinkedList linkedList;
        private Visualize visualizer;
        private Node choosenValue = null;
        public static TYPE findValue;
        public MainForm()
        {
            InitializeComponent();
            linkedList = new CLinkedList();
            visualizer = new Visualize(visualizePN);

            // Subscribe to the NodeClicked event
            visualizer.NodeClicked += OnNodeClicked;

            // Add test data
            linkedList.add_back(2);
            linkedList.add_back(3);
            linkedList.add_back(4);
            linkedList.add_back(5);

            visualizePN.Paint += (s, e) => visualizer.Redraw(linkedList.GetNodes());
        }

        private void OnNodeClicked(Node node, bool clicked)
        {
            if (clicked)
            {
                choosenValue = node;
                statusLB.Text = "Current: " + choosenValue.Info;
            }
            else
            {
                choosenValue = null;
                statusLB.Text = "Current: NONE";
            }
        }

        private void closePIC_Click(object sender, EventArgs e)
        {
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

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void addFirstBT_Click(object sender, EventArgs e)
        {
            try
            {
                TYPE newValue = Convert.ToInt32(addTB.Text);
                linkedList.add_first(newValue);
                visualizePN.Invalidate(); // Trigger redraw
            }
            catch
            {
                MessageBox.Show("Invalid input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addBackBT_Click(object sender, EventArgs e)
        {
            try
            {
                TYPE newValue = Convert.ToInt32(addTB.Text);
                linkedList.add_back(newValue);
                visualizePN.Invalidate(); // Trigger redraw
            }
            catch
            {
                MessageBox.Show("Invalid input!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addAfterBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (choosenValue == null) throw new Exception("Please choose a value!");
                TYPE newValue = Convert.ToInt32(addTB.Text);
                linkedList.add_after(choosenValue, new Node(newValue));
                visualizePN.Invalidate(); // Trigger redraw
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeFirstBT_Click(object sender, EventArgs e)
        {
            try
            {
                linkedList.remove_first();
                visualizePN.Invalidate(); // Trigger redraw
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeBackBT_Click(object sender, EventArgs e)
        {
            try
            {
                linkedList.remove_back();
                visualizePN.Invalidate(); // Trigger redraw
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeAfterBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (choosenValue == null) throw new Exception("Please choose a Node!");
                linkedList.remove_after(choosenValue);
                visualizePN.Invalidate(); // Trigger redraw
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearBT_Click(object sender, EventArgs e)
        {
            try
            {
                statusLB.Text = "";
                linkedList.remove_all();
                visualizer.ClearScreen();
                visualizePN.Invalidate(); // Trigger redraw
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void findLargerBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!linkedList.empty())
                    using (InputForm iForm = new InputForm())
                    {
                        var dialogResult = iForm.ShowDialog();

                        if (dialogResult == DialogResult.OK)
                        {
                            var tmp = linkedList.find_greater(findValue);
                            // Highlight nodes in the visualization
                            visualizer.Highlight(linkedList.find_greater_e(findValue));
                            MessageBox.Show("Found " + tmp.count() + " nodes, painted PINK!", "FOUND", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            visualizePN.Invalidate(); // Trigger redraw
                        }
                    }
                else
                    throw new Exception("Empty list");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void findValueBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!linkedList.empty())
                    using (InputForm iForm = new InputForm())
                    {
                       var dialogResult = iForm.ShowDialog();

                        if (dialogResult == DialogResult.OK)
                        {
                            if (linkedList.find(findValue) != null)
                            {
                                visualizePN.Invalidate(); // Trigger redraw
                                MessageBox.Show("Found " + linkedList.count(findValue) + 
                                    " Elements", "FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                else
                    throw new Exception("Empty list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetBT_Click(object sender, EventArgs e)
        {
            findValue = -Int32.MaxValue;
            visualizer.ClearFindValues();
            visualizePN.Invalidate(); // Trigger redraw
        }

        private void reverseBT_Click(object sender, EventArgs e)
        {
            try
            {
                linkedList.reverse();
                visualizePN.Invalidate(); // Trigger redraw
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mergeBT_Click(object sender, EventArgs e)
        {
            try
            {
                using (InputForm iForm = new InputForm()) 
                {
                    iForm.inputStatusLB.Text = "Add a list | Ex: 1 2 3 4 5 6";
                    iForm.merge = true;
                    var dialogResult = iForm.ShowDialog();
                    string text = iForm.inputTB.Text;

                    if (dialogResult == DialogResult.OK)
                    {
                        string[] values = text.Split(' ');
                        CLinkedList addList = new CLinkedList();
                        foreach (string value in values)
                        {
                            addList.add_back(Int32.Parse(value));
                        }
                        linkedList.merge(addList);
                        visualizePN.Invalidate(); // Trigger redraw
                    }
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeLargerBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!linkedList.empty())
                    using (InputForm iForm = new InputForm())
                    {
                        var dialogResult = iForm.ShowDialog();

                        if (dialogResult == DialogResult.OK)
                        {
                            linkedList.remove_larger(findValue);                            
                            visualizePN.Invalidate(); // Trigger redraw
                        }
                    }
                else
                    throw new Exception("Empty list");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sSortBT_Click(object sender, EventArgs e)
        {
            try
            {
                var list = linkedList.selection_sort_asc();
                if (!list.empty())
                {
                    visualizer.Redraw(list.GetNodes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void qSortBT_Click(object sender, EventArgs e)
        {
            try
            {
                var list = linkedList.quick_sort_des();
                if (!list.empty())
                {
                    visualizer.Redraw(list.GetNodes());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
