using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Advance_Exercise
{
    public partial class MainWindow : Window
    {
        private CircularLinkedList linkedList = new CircularLinkedList();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddFirst_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputTextBox.Text, out int value))
            {
                linkedList.AddFirst(value);
                MessageBox.Show($"Thêm {value} vào đầu danh sách.");
                InputTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void AddLast_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputTextBox.Text, out int value))
            {
                linkedList.AddLast(value);
                MessageBox.Show($"Thêm {value} vào cuối danh sách.");
                InputTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void RemoveFirst_Click(object sender, RoutedEventArgs e)
        {
            linkedList.RemoveFirst();
            MessageBox.Show("Đã xóa phần tử đầu.");
        }

        private void RemoveLast_Click(object sender, RoutedEventArgs e)
        {
            linkedList.RemoveLast();
            MessageBox.Show("Đã xóa phần tử cuối.");
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(InputTextBox.Text, out int value))
            {
                bool found = linkedList.Search(value);
                MessageBox.Show(found ? $"{value} có trong danh sách." : $"{value} không có trong danh sách.");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }
        }

        private void PrintList_Click(object sender, RoutedEventArgs e)
        {
            OutputListBox.Items.Clear();
            var items = linkedList.PrintList();
            foreach (var item in items)
            {
                OutputListBox.Items.Add(item);
            }
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class CircularLinkedList
    {
        private Node head;

        public CircularLinkedList()
        {
            head = null;
        }

        public void AddFirst(int data)
        {
            var newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
            }
            else
            {
                var temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = head;
                head = newNode;
            }
        }

        public void AddLast(int data)
        {
            var newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
            }
            else
            {
                var temp = head;
                while (temp.Next != head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = head;
            }
        }

        public void RemoveFirst()
        {
            if (head == null) return;

            if (head.Next == head)
            {
                head = null;
                return;
            }

            var temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = head.Next;
            head = head.Next;
        }

        public void RemoveLast()
        {
            if (head == null) return;

            if (head.Next == head)
            {
                head = null;
                return;
            }

            var temp = head;
            while (temp.Next.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = head;
        }

        public bool Search(int key)
        {
            if (head == null) return false;

            var temp = head;
            do
            {
                if (temp.Data == key)
                {
                    return true;
                }
                temp = temp.Next;
            } while (temp != head);

            return false;
        }

        public string[] PrintList()
        {
            if (head == null) return new string[] { "Danh sách rỗng." };

            var items = new System.Collections.Generic.List<string>();
            var temp = head;
            do
            {
                string data = temp.Data.ToString() + "->";
                items.Add(data);
                temp = temp.Next;
            } while (temp != head);

            return items.ToArray();
        }
    }
}
