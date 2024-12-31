using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quan_Li_Chi_Tieu_App
{
    public partial class AddUserForm : Form
    {
        private Dictionary<string, User> users; 
        public AddUserForm(Dictionary<string, User> users)
        {
            InitializeComponent();
            this.users = users;


            // Đặt mặc định cho ComboBox
            comboBoxCategory.SelectedIndex = 0;
        }
        private void comboBoxCategory_Index(object sender, EventArgs e)
{
    // Khi chọn category mới, làm sạch textbox để nhập lại giá trị limit
    txtSpendingLimit.Clear();
}

        private void btnSave_Click(object sender, EventArgs e)
{
    string userName = txtUserName.Text;
    if (string.IsNullOrEmpty(userName))
    {
        MessageBox.Show("Please enter a valid user name.");
        return;
    }

    // Kiểm tra nếu người dùng đã tồn tại, nếu chưa thì tạo mới
    if (!users.ContainsKey(userName))
    {
        // Tạo người dùng mới nếu chưa tồn tại
        User newUser = new User(userName);
        users[userName] = newUser;
    }

    // Lấy category và giới hạn chi tiêu từ người dùng
    string selectedCategory = comboBoxCategory.SelectedItem.ToString();
    if (decimal.TryParse(txtSpendingLimit.Text, out decimal spendingLimit))
    {
        // Cập nhật giới hạn chi tiêu cho người dùng và danh mục đã chọn
        users[userName].SetSpendingLimit(selectedCategory, spendingLimit);
        MessageBox.Show($"User '{userName}' updated successfully with a limit for {selectedCategory}!");
    }
    else
    {
        MessageBox.Show("Please enter a valid spending limit.");
        return;
    }
}
    private void btnExit_Click(object sender, EventArgs e)
{
    // Đóng form hiện tại và quay lại Form1
    this.Close();
}
    }
}