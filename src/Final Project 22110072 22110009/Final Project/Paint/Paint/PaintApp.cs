using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class PaintApp : Form
    {
        private Bitmap canvasBitmap;
        private Graphics canvasGraphics;
        private Stack undoStack;
        private Stack redoStack;
        private Point? previousPoint; //nullable

        public PaintApp()
        {
            InitializeComponent();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            undoStack = new Stack();
            redoStack = new Stack();

            drawingPanel.MouseDown += StartDrawing;
            drawingPanel.MouseMove += ContinueDrawing;
            drawingPanel.MouseUp += EndDrawing;

            toolUndo.Click += UndoDrawing;
            toolRedo.Click += RedoDrawing;

            canvasBitmap = new Bitmap(drawingPanel.ClientSize.Width, drawingPanel.ClientSize.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);

            typeof(Panel).InvokeMember( //stops glitchy invalidate effect
                "DoubleBuffered", 
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null,
                drawingPanel,
                new object[] { true });

            drawingPanel.Paint += (s, e) => e.Graphics.DrawImage(canvasBitmap, Point.Empty);
        }

        private void StartDrawing(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                undoStack.Push(new Bitmap(canvasBitmap));
                redoStack.Clear();
                previousPoint = e.Location;
            }
        }

        private void ContinueDrawing(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && previousPoint.HasValue)
            {
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    canvasGraphics.DrawLine(pen, previousPoint.Value, e.Location);
                }
                previousPoint = e.Location;
                drawingPanel.Invalidate(); //redraw
            }
        }

        private void EndDrawing(object sender, MouseEventArgs e)
        {
            previousPoint = null;
        }

        private void UndoDrawing(object sender, EventArgs e)
        {
            if (!undoStack.IsEmpty())
            {
                redoStack.Push(new Bitmap(canvasBitmap)); // save to redo stack

                canvasBitmap = undoStack.Pop(); // undo 
                canvasGraphics = Graphics.FromImage(canvasBitmap);
                drawingPanel.Invalidate();
            }
        }

        private void RedoDrawing(object sender, EventArgs e)
        {
            if (!redoStack.IsEmpty())
            {
                undoStack.Push(new Bitmap(canvasBitmap)); // save to undo stack

                canvasBitmap = redoStack.Pop(); // redo
                canvasGraphics = Graphics.FromImage(canvasBitmap);
                drawingPanel.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvasBitmap, Point.Empty);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                UndoDrawing(null, EventArgs.Empty);
                return true;
            }

            if (keyData == (Keys.Control | Keys.Y))
            {
                RedoDrawing(null, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
