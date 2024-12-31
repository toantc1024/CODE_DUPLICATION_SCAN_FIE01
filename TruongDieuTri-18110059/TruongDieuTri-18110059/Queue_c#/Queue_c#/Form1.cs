using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Queue_c_
{
    public partial class Form1 : Form
    {
        // Định nghĩa Queue
        private Queue<int> queue;

        public Form1()
        {
            InitializeComponent();
            // Khởi tạo Queue
            queue = new Queue<int>();
        }

        // Xử lý thêm phần tử vào Queue
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtInput.Text);
                queue.Enqueue(value);  // Thêm phần tử vào Queue
                txtInput.Clear();      // Làm sạch TextBox
                DisplayQueue();        // Cập nhật hiển thị
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        // Xử lý xóa phần tử từ Queue
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (queue.Count > 0)
            {
                queue.Dequeue();      // Xóa phần tử đầu tiên
                DisplayQueue();        // Cập nhật hiển thị
            }
            else
            {
                MessageBox.Show("Queue is empty.");
            }
        }

        // Hiển thị tất cả các phần tử trong Queue
        private void DisplayQueue()
        {
            txtOutput.Clear();  // Xóa TextBox trước khi hiển thị lại
            foreach (int item in queue)
            {
                txtOutput.AppendText(item.ToString() + Environment.NewLine); // Hiển thị phần tử
            }
        }
    }
}
