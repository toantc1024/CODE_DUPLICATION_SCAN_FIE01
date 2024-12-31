using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quan_Li_Chi_Tieu_App
{
    public partial class Form1 : Form
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(users);
            addUserForm.Show();
        }

        private void btnSelectUser_Click(object sender, EventArgs e)
        {
            SelectUserForm selectUserForm = new SelectUserForm(users);
            selectUserForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}