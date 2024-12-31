using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CircularLinkedList
{
    public class Visualize
    {
        private Panel drawPanel;
        private const int NodeWidth = 60;
        private const int NodeHeight = 40;
        private const int CircleRadius = 200;

        // Store node bounds for detecting clicks
        private Dictionary<Node, Rectangle> nodeBounds;
        private Node selectedNode;
        private HashSet<Node> highlightedNodes; // Tracks highlighted nodes
        private bool clicked = false;

        public event Action<Node,bool> NodeClicked;

        public Visualize(Panel panel)
        {
            drawPanel = panel;
            nodeBounds = new Dictionary<Node, Rectangle>();
            highlightedNodes = new HashSet<Node>(); 

            // Attach MouseClick event
            drawPanel.MouseClick += DrawPanel_MouseClick;
        }

        private void DrawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var kvp in nodeBounds)
            {
                if (kvp.Value.Contains(e.Location))
                {
                    if (!clicked)
                    {
                        selectedNode = kvp.Key; // Set the selected node
                        clicked = true;
                    }
                    else
                    {
                        selectedNode = null;
                        clicked = false;
                    }
                    NodeClicked?.Invoke(kvp.Key, clicked); // Trigger NodeClicked event
                    drawPanel.Invalidate(); // Redraw to reflect color change
                    return;
                }
            }
        }
        public void Redraw(IEnumerable<Node> nodes)
        {
            if (nodes == null)
            {
                drawPanel.Controls.Clear(); // Clear previous drawings
                nodeBounds.Clear(); // Clear stored bounds
                return;
            }

            drawPanel.Controls.Clear(); // Clear previous drawings
            nodeBounds.Clear(); // Clear stored bounds

            Graphics graphics = drawPanel.CreateGraphics();
            int centerX = drawPanel.Width / 2;
            int centerY = drawPanel.Height / 2;

            var nodeList = new List<Node>(nodes);
            int count = nodeList.Count;

            if (count == 0) return;

            double angleStep = 360.0 / count;
            double angle = 0;

            Rectangle previousRect = Rectangle.Empty;
            Rectangle firstRect = Rectangle.Empty;

            for (int i = 0; i < nodeList.Count; i++)
            {
                int x = centerX + (int)(CircleRadius * Math.Cos(angle * Math.PI / 180)) - NodeWidth / 2;
                int y = centerY + (int)(CircleRadius * Math.Sin(angle * Math.PI / 180)) - NodeHeight / 2;

                // Draw rectangle for the node
                Rectangle nodeRect = new Rectangle(x, y, NodeWidth, NodeHeight);
                if (i == 0)
                    graphics.FillRectangle(Brushes.LightGreen, nodeRect);
                else if (i == count - 1)
                    graphics.FillRectangle(Brushes.Orange, nodeRect);
                else if (nodeList[i] == selectedNode)
                    graphics.FillRectangle(Brushes.Silver, nodeRect);
                else if (nodeList[i].Info == MainForm.findValue)
                    graphics.FillRectangle(Brushes.Yellow, nodeRect);
                else if (highlightedNodes.Contains(nodeList[i]))
                    graphics.FillRectangle(Brushes.Pink, nodeRect);
                else
                    graphics.FillRectangle(Brushes.LightBlue, nodeRect);

                graphics.DrawRectangle(Pens.Black, nodeRect);

                // Save the bounds of this node
                nodeBounds[nodeList[i]] = nodeRect;

                // Draw node value
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                graphics.DrawString(nodeList[i].Info.ToString(), new Font("Segoe UI Semibold", 10), Brushes.Black, nodeRect, stringFormat);

                if (i > 0)
                {
                    DrawArrow(graphics, previousRect, nodeRect);
                }
                else
                {
                    // Save the first node rectangle for final connection
                    firstRect = nodeRect;
                }

                // Update the previous rectangle for the next iteration
                previousRect = nodeRect;

                angle += angleStep;
            }

            // Draw arrow connecting the last node to the first
            if (count > 1)
            {
                DrawArrow(graphics, previousRect, firstRect);
            }
        }

        public void Highlight(IEnumerable<Node> greaterNodes)
        {
            // Update the highlighted nodes set
            highlightedNodes.Clear();
            foreach (var node in greaterNodes)
            {
                highlightedNodes.Add(node);
            }
            // Redraw only with updated highlights
            drawPanel.Invalidate(); // Redraw to reflect color change
        }
        private void DrawArrow(Graphics graphics, Point start, Point end)
        {
            Pen pen = new Pen(Color.Black, 2);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            graphics.DrawLine(pen, start, end);
        }

        public void ClearScreen()
        {
            drawPanel.Controls.Clear(); // Clear previous drawings
            nodeBounds.Clear(); // Clear stored bounds
            highlightedNodes.Clear();
            return;
        }

        public void ClearFindValues()
        {
            highlightedNodes.Clear();
            return;
        }

        private void DrawArrow(Graphics graphics, Rectangle startRect, Rectangle endRect)
        {
            // Create a pen with thicker width and a noticeable color
            Pen pen = new Pen(Color.DarkBlue, 2); // Red color, thickness of 2

            // Create a custom arrow cap with adjustable size
            System.Drawing.Drawing2D.AdjustableArrowCap bigArrow = new System.Drawing.Drawing2D.AdjustableArrowCap(4, 7, true);
            pen.CustomEndCap = bigArrow; // Assign the custom arrow cap to the pen

            // Calculate center points of the start and end rectangles
            Point startCenter = new Point(startRect.Left + startRect.Width / 2, startRect.Top + startRect.Height / 2);
            Point endCenter = new Point(endRect.Left + endRect.Width / 2, endRect.Top + endRect.Height / 2);

            // Calculate direction vector from start to end
            double dx = endCenter.X - startCenter.X;
            double dy = endCenter.Y - startCenter.Y;
            double distance = Math.Sqrt(dx * dx + dy * dy);

            // Avoid division by zero
            if (distance == 0) return;

            // Offset start and end points by the radius of the nodes (half the width or height)
            double offsetX = (dx / distance) * (startRect.Width / 2);
            double offsetY = (dy / distance) * (startRect.Height / 2);

            Point startEdge = new Point((int)(startCenter.X + offsetX), (int)(startCenter.Y + offsetY));
            Point endEdge = new Point((int)(endCenter.X - offsetX), (int)(endCenter.Y - offsetY));

            // Draw the line with the custom arrow
            graphics.DrawLine(pen, startEdge, endEdge);

            // Optional: Add a circle at the start of the arrow for extra clarity
            Brush brush = Brushes.DarkBlue;
            int circleRadius = 5;
            graphics.FillEllipse(brush, startEdge.X - circleRadius, startEdge.Y - circleRadius, circleRadius * 2, circleRadius * 2);
        }


        private Point GetEdgePoint(Rectangle rect, Point direction)
        {
            Point center = new Point(rect.Left + rect.Width / 2, rect.Top + rect.Height / 2);

            // Ratios for scaling direction vector to rectangle edges
            float scaleX = (direction.X > 0 ? rect.Right - center.X : rect.Left - center.X) / (float)direction.X;
            float scaleY = (direction.Y > 0 ? rect.Bottom - center.Y : rect.Top - center.Y) / (float)direction.Y;

            // Use the smaller scale factor to find the intersection point
            float scale = Math.Min(scaleX, scaleY);

            return new Point(
                center.X + (int)(direction.X * scale),
                center.Y + (int)(direction.Y * scale)
            );
        }
    }
}
