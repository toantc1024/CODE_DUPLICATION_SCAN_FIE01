using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quan_Li_Chi_Tieu_App
{
    public partial class SelectUserForm : Form
    {
        private Dictionary<string, User> users;

        public SelectUserForm(Dictionary<string, User> users)
        {
            InitializeComponent();
            this.users = users;

            // Populate combo box with users' names
            foreach (var user in users)
            {
                cmbUsers.Items.Add(user.Key);
            }
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            string selectedUserName = cmbUsers.SelectedItem.ToString();
            User selectedUser = users[selectedUserName];

            ManageUserForm manageUserForm = new ManageUserForm(selectedUser);
            manageUserForm.Show();
            this.Close();
        }
    }
}