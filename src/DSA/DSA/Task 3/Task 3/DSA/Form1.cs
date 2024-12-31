using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DSA.Program;

namespace DSA
{
    public partial class Form1 : Form
    {
        private BinarySearchTree contactTree = new BinarySearchTree();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string number = txtNumber.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(number))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên và Số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            contactTree.Insert(name, number);
            MessageBox.Show("Đã thêm liên hệ thành công.", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Clear();
            txtNumber.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên để tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Node found = contactTree.Search(name);

            if (found != null)
            {
                MessageBox.Show($"Tìm thấy: {found.Name} - {found.Number}", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy liên hệ.", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            listContacts.Items.Clear();
            List<string> contacts = contactTree.InOrderTraversal();
            foreach (var contact in contacts)
            {
                listContacts.Items.Add(contact);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Node found = contactTree.Search(name);

            if (found != null)
            {
                contactTree.Delete(name);
                MessageBox.Show($"Đã xóa liên hệ: {name}", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnViewAll_Click(sender, e); // Tự động cập nhật danh sách
            }
            else
            {
                MessageBox.Show("Không tìm thấy liên hệ để xóa.", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
