using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA
{
    internal static class Program
    {
        public class Node
        {
            public string Name { get; set; }
            public string Number { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(string name, string number)
            {
                Name = name;
                Number = number;
                Left = null;
                Right = null;
            }
        }
        public class BinarySearchTree
        {
            private Node root;
            public void Delete(string name)
            {
                root = DeleteRec(root, name);
            }

            private Node DeleteRec(Node root, string name)
            {
                if (root == null) return null;

                // Tìm nút cần xóa
                if (string.Compare(name, root.Name, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    root.Left = DeleteRec(root.Left, name);
                }
                else if (string.Compare(name, root.Name, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    root.Right = DeleteRec(root.Right, name);
                }
                else
                {
                    // Nếu nút chỉ có một con hoặc không có con
                    if (root.Left == null) return root.Right;
                    if (root.Right == null) return root.Left;

                    // Nếu nút có hai con, tìm giá trị nhỏ nhất ở cây con bên phải
                    Node minNode = FindMin(root.Right);
                    root.Name = minNode.Name;
                    root.Number = minNode.Number;

                    // Xóa giá trị nhỏ nhất trong cây con bên phải
                    root.Right = DeleteRec(root.Right, minNode.Name);
                }

                return root;
            }

            private Node FindMin(Node root)
            {
                while (root.Left != null)
                {
                    root = root.Left;
                }
                return root;
            }
            public void Insert(string name, string number)
            {
                root = InsertRec(root, name, number);
            }

            private Node InsertRec(Node root, string name, string number)
            {
                if (root == null)
                {
                    return new Node(name, number); // Thêm nút mới
                }

                int comparison = string.Compare(name, root.Name, StringComparison.OrdinalIgnoreCase);

                if (comparison < 0)
                {
                    root.Left = InsertRec(root.Left, name, number); // Thêm vào cây con trái
                }
                else if (comparison > 0)
                {
                    root.Right = InsertRec(root.Right, name, number); // Thêm vào cây con phải
                }
                else
                {
                    // Tên trùng, tiếp tục so sánh số điện thoại
                    if (string.Compare(number, root.Number, StringComparison.Ordinal) < 0)
                    {
                        root.Left = InsertRec(root.Left, name, number);
                    }
                    else if (string.Compare(number, root.Number, StringComparison.Ordinal) > 0)
                    {
                        root.Right = InsertRec(root.Right, name, number);
                    }
                    else
                    {
                        // Nếu cả tên và số trùng, không làm gì thêm
                        Console.WriteLine("Tên và số điện thoại đã tồn tại, không thêm.");
                    }
                }

                return root;
            }

            public Node Search(string name)
            {
                return SearchRec(root, name);
            }

            private Node SearchRec(Node root, string name)
            {
                if (root == null || root.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return root;
                }

                if (string.Compare(name, root.Name, StringComparison.OrdinalIgnoreCase) < 0)
                {
                    return SearchRec(root.Left, name);
                }

                return SearchRec(root.Right, name);
            }

            public List<string> InOrderTraversal()
            {
                var result = new List<string>();
                InOrderRec(root, result);
                return result;
            }

            private void InOrderRec(Node root, List<string> result)
            {
                if (root != null)
                {
                    InOrderRec(root.Left, result);
                    result.Add($"{root.Name}: {root.Number}");
                    InOrderRec(root.Right, result);
                }
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
