using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI3_Advanced
{
    public partial class Form1 : Form
    {
        BST bst = new BST();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMajor.Text) || string.IsNullOrEmpty(txtPhoneNum.Text))
                {
                    MessageBox.Show("Please fill all fields", "Error");
                    return;
                }

                string id = txtID.Text;
                if (bst.Search(bst.Root, id) != null)
                {
                    MessageBox.Show("Student ID already exists", "Error");
                    return;
                }
               
                string name = txtName.Text;
                string major = txtMajor.Text;
                string phoneNum = txtPhoneNum.Text;
                Student student = new Student(id, name, major, phoneNum);
                bst.Insert(bst.Root, student);
                dataGridView1.Rows.Add(student.Id, student.Name, student.Major, student.PhoneNum);
                // Clear fields after success
                txtID.Clear();
                txtName.Clear();
                txtMajor.Clear();
                txtPhoneNum.Clear();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error");
            }
        }

     

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Please enter a valid ID", "Error");
                    return;
                }

                string id = txtID.Text;
                // Create temporary student object with ID to delete
                Student studentToDelete = bst.Search(bst.Root, id);
                if (studentToDelete == null)
                {
                    MessageBox.Show("Student ID not found. Please enter a valid ID.", "Error");
                    return;
                }
                
                bst.Root = bst.Delete(bst.Root, studentToDelete);

               
                txtID.Clear();
                MessageBox.Show("Student deleted successfully", "Success");
                btnDisplay_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}", "Error");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Student> result = bst.Inorder(bst.Root);

            foreach (var student in result)
            {
                dataGridView1.Rows.Add(student.Id, student.Name, student.Major, student.PhoneNum);
            }
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Please enter an ID or prefix or subtring", "Error");
                    return;
                }

                string id = txtID.Text;
                List<Student> students = bst.Inorder(bst.Root, id);
                // If no students found with prefix, perform exact search
                if (students.Count == 0)
                {
                    Student student = bst.Search(bst.Root, id);
                    if (student != null)
                    {
                        students.Add(student);
                    }
                }
                dataGridView1.Rows.Clear();
                if (students.Count > 0)
                {
                    foreach (var student in students)
                    {
                        dataGridView1.Rows.Add(student.Id, student.Name, student.Major, student.PhoneNum);
                    }
                }
                else
                {
                    MessageBox.Show("Student not found", "Search Result");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching student: {ex.Message}", "Error");
            }
        }
    }
}
