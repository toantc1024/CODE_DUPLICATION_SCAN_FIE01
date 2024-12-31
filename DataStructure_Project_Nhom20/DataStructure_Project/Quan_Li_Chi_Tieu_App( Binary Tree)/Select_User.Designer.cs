namespace Quan_Li_Chi_Tieu_App
{
    partial class SelectUserForm
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbUsers;
        private Button btnManageUser;

        private void InitializeComponent()
        {
            this.cmbUsers = new ComboBox();
            this.btnManageUser = new Button();

            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(150, 50);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(150, 21);

            // 
            // btnManageUser
            // 
            this.btnManageUser.Location = new System.Drawing.Point(150, 100);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(150, 23);
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.Click += new EventHandler(this.btnManageUser_Click);

            // 
            // SelectUserForm
            // 
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.btnManageUser);
            this.Name = "SelectUserForm";
            this.Text = "Select User";
        }
    }
}