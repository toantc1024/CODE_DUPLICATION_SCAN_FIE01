using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI3_Advanced
{
    public class BST
    {
        private Node root;

        public Node Root { get => root; set => root = value; }

        public void Insert(Node node, Student student)
        {
            if (node == null)
            {
                Root = new Node(student);
                return;
            }
            if (string.Compare(student.Id, node.Data.Id) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(student);
                }
                else
                {
                    Insert(node.Left, student);
                }
            }
            if (string.Compare(student.Id, node.Data.Id) > 0)
            {
                if (node.Right == null)
                {
                    node.Right = new Node(student);
                }
                else
                {
                    Insert(node.Right, student);
                }
            }
        }

        private Node MoveLeftMostNode(Node p, Node root)
        {
            if (p.Left != null)
            {
                p.Left = MoveLeftMostNode(p.Left, root);
                return p;
            }
            else
            {
                root.Data = p.Data;
                return p.Right;
            }
        }

        public Node Delete(Node root, Student student)
        {
            if (root == null) return null;

            if (string.Compare(student.Id, root.Data.Id) < 0)
            {
                root.Left = Delete(root.Left, student);
            }
            else if (string.Compare(student.Id, root.Data.Id) > 0)
            {
                root.Right = Delete(root.Right, student);
            }
            else
            {
                if (root.Left == null && root.Right == null)
                {
                    root = null;
                    return null;
                }
                else if (root.Left == null)
                {
                    Node temp = root.Right;
                    root = null;
                    return temp;
                }
                else if (root.Right == null)
                {
                    Node temp = root.Left;
                    root = null;
                    return temp;
                }
                else
                {
                    root.Right = MoveLeftMostNode(root.Right, root);
                }
            }
            return root;
        }
        //Search khi nhập chính xác id
        public Student Search(Node root, string id)
        {
            if (root == null) return null;
            if (string.Compare(root.Data.Id, id) == 0) return root.Data;
            if (string.Compare(id, root.Data.Id) < 0)
            {
                return Search(root.Left, id);
            }
            return Search(root.Right, id);
        }               
        //tìm chuỗi con
        public List<Student> Inorder(Node root, string substring)
        {
            List<Student> result = new List<Student>();
            if (root == null) return result;

            result.AddRange(Inorder(root.Left, substring));
            if (root.Data.Id.Contains(substring))
            {
                result.Add(root.Data);
            }
            result.AddRange(Inorder(root.Right, substring));
            return result;
        }

        public List<Student> Inorder(Node root)
        {
            List<Student> result = new List<Student>();
            if (root == null)
                return result;
            result.AddRange(Inorder(root.Left));
            result.Add(root.Data);
            result.AddRange(Inorder(root.Right));
            return result;
        }

        public List<Student> Preorder(Node root)
        {
            List<Student> result = new List<Student>();
            if (root == null) return result;

            result.Add(root.Data);
            result.AddRange(Preorder(root.Left));
            result.AddRange(Preorder(root.Right));
            return result;
        }

        public List<Student> Postorder(Node root)
        {
            List<Student> result = new List<Student>();
            if (root == null) return result;

            result.AddRange(Postorder(root.Left));
            result.AddRange(Postorder(root.Right));
            result.Add(root.Data);
            return result;
        }
    }
}
