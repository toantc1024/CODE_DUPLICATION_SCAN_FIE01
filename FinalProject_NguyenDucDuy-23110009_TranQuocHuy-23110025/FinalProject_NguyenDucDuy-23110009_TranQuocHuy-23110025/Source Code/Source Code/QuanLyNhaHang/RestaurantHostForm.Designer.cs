namespace DSA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelTables = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxQueue = new System.Windows.Forms.ListBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnSeatCustomer = new System.Windows.Forms.Button();
            this.btnReserveTable = new System.Windows.Forms.Button();
            this.btnTransferCustomer = new System.Windows.Forms.Button();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnCheckTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelTables
            // 
            this.flowLayoutPanelTables.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.flowLayoutPanelTables.Location = new System.Drawing.Point(12, 9);
            this.flowLayoutPanelTables.Name = "flowLayoutPanelTables";
            this.flowLayoutPanelTables.Size = new System.Drawing.Size(337, 426);
            this.flowLayoutPanelTables.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBoxQueue);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Controls.Add(this.btnSeatCustomer);
            this.panel1.Controls.Add(this.btnReserveTable);
            this.panel1.Controls.Add(this.btnTransferCustomer);
            this.panel1.Controls.Add(this.btnRemoveCustomer);
            this.panel1.Controls.Add(this.btnCheckTable);
            this.panel1.Controls.Add(this.btnAddTable);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(375, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 426);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 44);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh Sách Khách Hàng \r\nTrong Hàng Chờ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Họ Tên Khách Hàng";
            // 
            // listBoxQueue
            // 
            this.listBoxQueue.FormattingEnabled = true;
            this.listBoxQueue.Location = new System.Drawing.Point(25, 143);
            this.listBoxQueue.Name = "listBoxQueue";
            this.listBoxQueue.Size = new System.Drawing.Size(212, 264);
            this.listBoxQueue.TabIndex = 8;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(38, 56);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(177, 20);
            this.txtCustomerName.TabIndex = 7;
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomerName_KeyDown);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCustomer.Location = new System.Drawing.Point(265, 3);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(123, 49);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Thêm khách vào hàng chờ";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnSeatCustomer
            // 
            this.btnSeatCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSeatCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeatCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeatCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSeatCustomer.Location = new System.Drawing.Point(265, 58);
            this.btnSeatCustomer.Name = "btnSeatCustomer";
            this.btnSeatCustomer.Size = new System.Drawing.Size(123, 33);
            this.btnSeatCustomer.TabIndex = 5;
            this.btnSeatCustomer.Text = "Xếp chỗ";
            this.btnSeatCustomer.UseVisualStyleBackColor = false;
            this.btnSeatCustomer.Click += new System.EventHandler(this.btnSeatCustomer_Click);
            // 
            // btnReserveTable
            // 
            this.btnReserveTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReserveTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReserveTable.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReserveTable.Location = new System.Drawing.Point(265, 97);
            this.btnReserveTable.Name = "btnReserveTable";
            this.btnReserveTable.Size = new System.Drawing.Size(123, 29);
            this.btnReserveTable.TabIndex = 4;
            this.btnReserveTable.Text = "Đặt bàn";
            this.btnReserveTable.UseVisualStyleBackColor = false;
            this.btnReserveTable.Click += new System.EventHandler(this.btnReserveTable_Click);
            // 
            // btnTransferCustomer
            // 
            this.btnTransferCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTransferCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransferCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTransferCustomer.Location = new System.Drawing.Point(265, 344);
            this.btnTransferCustomer.Name = "btnTransferCustomer";
            this.btnTransferCustomer.Size = new System.Drawing.Size(123, 35);
            this.btnTransferCustomer.TabIndex = 3;
            this.btnTransferCustomer.Text = "Chuyển bàn";
            this.btnTransferCustomer.UseVisualStyleBackColor = false;
            this.btnTransferCustomer.Click += new System.EventHandler(this.btnTransferCustomer_Click);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRemoveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(265, 308);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(126, 30);
            this.btnRemoveCustomer.TabIndex = 2;
            this.btnRemoveCustomer.Text = "Xoá";
            this.btnRemoveCustomer.UseVisualStyleBackColor = false;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // btnCheckTable
            // 
            this.btnCheckTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCheckTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckTable.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCheckTable.Location = new System.Drawing.Point(265, 271);
            this.btnCheckTable.Name = "btnCheckTable";
            this.btnCheckTable.Size = new System.Drawing.Size(123, 31);
            this.btnCheckTable.TabIndex = 1;
            this.btnCheckTable.Text = "Kiểm tra";
            this.btnCheckTable.UseVisualStyleBackColor = false;
            this.btnCheckTable.Click += new System.EventHandler(this.btnCheckTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddTable.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddTable.Location = new System.Drawing.Point(265, 229);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(123, 27);
            this.btnAddTable.TabIndex = 0;
            this.btnAddTable.Text = "Thêm bàn";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::DSA.Properties.Resources._360_F_324739203_keeq8udvv0P2h1MLYJ0GLSlTBagoXS48;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(829, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanelTables);
            this.Name = "Form1";
            this.Text = "RestaurantHostForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTables;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxQueue;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnSeatCustomer;
        private System.Windows.Forms.Button btnReserveTable;
        private System.Windows.Forms.Button btnTransferCustomer;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Button btnCheckTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

