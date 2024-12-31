namespace Quan_Li_Chi_Tieu_App
{
    public partial class AddUserForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox txtSpendingLimit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        // Các TextBox và Label


        private void InitializeComponent()
        {
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.txtSpendingLimit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(150, 50);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 0;

            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Location = new System.Drawing.Point(150, 100);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategory.TabIndex = 1;
            this.comboBoxCategory.Items.Add("Electricity");
            this.comboBoxCategory.Items.Add("Casual");
            this.comboBoxCategory.Items.Add("Shopping");
            this.comboBoxCategory.SelectedIndex = 0;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_Index);

            // 
            // txtSpendingLimit
            // 
            this.txtSpendingLimit.Location = new System.Drawing.Point(150, 150);
            this.txtSpendingLimit.Name = "txtSpendingLimit";
            this.txtSpendingLimit.Size = new System.Drawing.Size(200, 20);
            this.txtSpendingLimit.TabIndex = 2;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(250, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // AddUserForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.txtSpendingLimit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Name = "AddUserForm";
            this.Text = "Add User";
        }
    }
}