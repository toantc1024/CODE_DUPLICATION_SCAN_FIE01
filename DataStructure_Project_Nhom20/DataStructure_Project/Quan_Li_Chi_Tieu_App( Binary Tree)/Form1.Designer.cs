namespace Quan_Li_Chi_Tieu_App
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddUser;
        private Button btnSelectUser;
        private Button btnExit;

        private void InitializeComponent()
        {
            this.btnAddUser = new Button();
            this.btnSelectUser = new Button();
            this.btnExit = new Button();

            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(100, 50);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(120, 23);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new EventHandler(this.btnAddUser_Click);

            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Location = new System.Drawing.Point(100, 100);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(120, 23);
            this.btnSelectUser.TabIndex = 1;
            this.btnSelectUser.Text = "Select User";
            this.btnSelectUser.Click += new EventHandler(this.btnSelectUser_Click);

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(100, 150);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new EventHandler(this.btnExit_Click);

            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnSelectUser);
            this.Controls.Add(this.btnExit);
            this.Name = "MainForm";
            this.Text = "Expense Tracker";
        }
    }
}