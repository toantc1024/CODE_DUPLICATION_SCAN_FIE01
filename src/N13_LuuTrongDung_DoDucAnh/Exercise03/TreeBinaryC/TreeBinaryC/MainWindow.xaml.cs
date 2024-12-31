using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace TreeBinaryC
{
    public partial class MainWindow : Window
    {
        private BinaryTree tree = new BinaryTree();
        private Node root = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            string value = txtValue.Text.Trim();
            if (!string.IsNullOrEmpty(value))
            {
                var newNode = tree.CreateNode(value);
                tree.InsertNode(ref root, newNode);
                txtValue.Clear();
                MessageBox.Show($"Inserted {value}");
                DrawTree();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string value = txtValue.Text.Trim();
            if (!string.IsNullOrEmpty(value))
            {
                tree.DeleteNode(ref root, value);
                txtValue.Clear();
                MessageBox.Show($"Deleted {value}");
                DrawTree();
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string value = txtValue.Text.Trim();
            if (!string.IsNullOrEmpty(value))
            {
                var node = tree.SearchNode(root, value);
                MessageBox.Show(node != null ? $"Found {value}" : $"{value} not found");
                txtValue.Clear();
            }
        }

        private void btnPreOrder_Click(object sender, RoutedEventArgs e)
        {
            lstOutput.Items.Clear();
            tree.PreOrder(root, value => lstOutput.Items.Add(value));
        }

        private void btnInOrder_Click(object sender, RoutedEventArgs e)
        {
            lstOutput.Items.Clear();
            tree.InOrder(root, value => lstOutput.Items.Add(value));
        }

        private void btnPostOrder_Click(object sender, RoutedEventArgs e)
        {
            lstOutput.Items.Clear();
            tree.PostOrder(root, value => lstOutput.Items.Add(value));
        }

        private void DrawTree()
        {
            TreeCanvas.Children.Clear();
            if (root != null)
            {
                DrawNode(root, TreeCanvas, 400, 50, 200);
            }
        }

        private void DrawNode(Node node, Canvas canvas, double x, double y, double offsetX)
        {
            Ellipse ellipse = new Ellipse
            {
                Width = 40,
                Height = 40,
                Stroke = Brushes.Black,
                Fill = Brushes.LightBlue
            };
            Canvas.SetLeft(ellipse, x - 20);
            Canvas.SetTop(ellipse, y - 20);
            canvas.Children.Add(ellipse);

            TextBlock textBlock = new TextBlock
            {
                Text = node.Key.ToString(),
                VerticalAlignment = VerticalAlignment.Center,
                HorizontalAlignment = HorizontalAlignment.Center
            };
            Canvas.SetLeft(textBlock, x - 10);
            Canvas.SetTop(textBlock, y - 10);
            canvas.Children.Add(textBlock);

            if (node.Left != null)
            {
                Line leftLine = new Line
                {
                    X1 = x,
                    Y1 = y,
                    X2 = x - offsetX,
                    Y2 = y + 80,
                    Stroke = Brushes.Black
                };
                canvas.Children.Add(leftLine);
                DrawNode(node.Left, canvas, x - offsetX, y + 80, offsetX / 2);
            }

            if (node.Right != null)
            {
                Line rightLine = new Line
                {
                    X1 = x,
                    Y1 = y,
                    X2 = x + offsetX,
                    Y2 = y + 80,
                    Stroke = Brushes.Black
                };
                canvas.Children.Add(rightLine);
                DrawNode(node.Right, canvas, x + offsetX, y + 80, offsetX / 2);
            }
        }
    }
}
