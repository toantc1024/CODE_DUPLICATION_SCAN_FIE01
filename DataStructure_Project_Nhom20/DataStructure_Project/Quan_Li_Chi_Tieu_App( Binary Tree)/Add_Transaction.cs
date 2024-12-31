using System;
using System.Windows.Forms;

namespace Quan_Li_Chi_Tieu_App
{
    public partial class AddTransactionForm : Form
    {
        private User selectedUser;

        public AddTransactionForm(User user)
        {
            InitializeComponent();
            selectedUser = user;

            // Populate categories dropdown
            cmbCategory.Items.AddRange(new string[] { "Electricity", "Casual", "Shopping" });
            cmbCategory.SelectedIndex = 0;
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txtAmount.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy giá trị từ các input
                if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid positive amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string description = txtDescription.Text.Trim();
                string category = cmbCategory.SelectedItem.ToString();

                // Kiểm tra hạn mức chi tiêu
                if (selectedUser.SpendingLimits.TryGetValue(category, out decimal limit) && amount > limit)
                {
                    MessageBox.Show($"The amount exceeds the spending limit for {category}. Limit: {limit:C}.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi hàm AddTransaction của Transactions
                selectedUser.Transactions.AddTransaction(amount, description, category);

                MessageBox.Show("Transaction added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi thêm giao dịch thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}