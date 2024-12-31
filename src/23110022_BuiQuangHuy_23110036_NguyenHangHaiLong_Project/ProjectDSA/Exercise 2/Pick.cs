using System;
using System.Windows.Forms;

namespace DoctorQueueApp
{
    public partial class PatientInformation : Form
    {
        public string PatientName { get; private set; }
        public string PatientConcern { get; private set; }

        public PatientInformation()
        {
            InitializeComponent();
        }

        // Sự kiện nút OK
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                PatientName = txtName.Text.Trim(); // Lấy tên, loại bỏ khoảng trắng thừa
                PatientConcern = txtConcern.Text.Trim(); // Lấy lý do khám, loại bỏ khoảng trắng thừa
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // Sự kiện nút Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Kiểm tra dữ liệu đầu vào
        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Please enter the patient's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus(); // Đặt con trỏ vào ô nhập tên
                return false;
            }

            if (string.IsNullOrEmpty(txtConcern.Text.Trim()))
            {
                MessageBox.Show("Please enter the patient's concern.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConcern.Focus(); // Đặt con trỏ vào ô nhập lý do khám
                return false;
            }

            if (txtName.Text.Trim().Length < 2)
            {
                MessageBox.Show("The patient's name must be at least 2 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (txtConcern.Text.Trim().Length < 5)
            {
                MessageBox.Show("The patient's concern must be at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConcern.Focus();
                return false;
            }

            return true;
        }

        // Xử lý khi form load (nếu cần)
        private void PatientInformation_Load(object sender, EventArgs e)
        {
            txtName.Text = ""; // Đặt tên mặc định rỗng
            txtConcern.Text = ""; // Đặt lý do khám mặc định rỗng
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
