namespace Bai2_DSA
{
    partial class QuanLyChiTieu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPush = new Button();
            btnPop = new Button();
            Display = new ListBox();
            txtMaGD = new TextBox();
            btnTimKiem = new Button();
            btnThayDoi = new Button();
            txtTenGD = new TextBox();
            btnXemDinh = new Button();
            btnXoaHet = new Button();
            btn_Dem = new Button();
            txtAmount = new TextBox();
            cbTransactionType = new ComboBox();
            lblTotalChi = new Label();
            lblTotalThu = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPush
            // 
            btnPush.Location = new Point(236, 93);
            btnPush.Name = "btnPush";
            btnPush.RightToLeft = RightToLeft.No;
            btnPush.Size = new Size(94, 29);
            btnPush.TabIndex = 1;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnThem_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(336, 93);
            btnPop.Name = "btnPop";
            btnPop.RightToLeft = RightToLeft.No;
            btnPop.Size = new Size(94, 29);
            btnPop.TabIndex = 3;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnXoa_Click;
            // 
            // Display
            // 
            Display.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Display.FormattingEnabled = true;
            Display.Location = new Point(86, 157);
            Display.Name = "Display";
            Display.RightToLeft = RightToLeft.No;
            Display.Size = new Size(953, 504);
            Display.TabIndex = 4;
            Display.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtMaGD
            // 
            txtMaGD.Location = new Point(236, 47);
            txtMaGD.Name = "txtMaGD";
            txtMaGD.Size = new Size(125, 27);
            txtMaGD.TabIndex = 6;
            txtMaGD.Text = "ID";
            txtMaGD.TextChanged += textBox1_TextChanged_1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(743, 93);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(94, 29);
            btnTimKiem.TabIndex = 7;
            btnTimKiem.Text = "Find";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnThayDoi
            // 
            btnThayDoi.Location = new Point(843, 93);
            btnThayDoi.Name = "btnThayDoi";
            btnThayDoi.Size = new Size(94, 29);
            btnThayDoi.TabIndex = 8;
            btnThayDoi.Text = "Adjust";
            btnThayDoi.UseVisualStyleBackColor = true;
            btnThayDoi.Click += btnThayDoi_Click;
            // 
            // txtTenGD
            // 
            txtTenGD.Location = new Point(367, 47);
            txtTenGD.Name = "txtTenGD";
            txtTenGD.Size = new Size(203, 27);
            txtTenGD.TabIndex = 9;
            txtTenGD.Text = "Tên giao dịch";
            txtTenGD.TextChanged += txtTenGd_TextChanged;
            // 
            // btnXemDinh
            // 
            btnXemDinh.Location = new Point(436, 94);
            btnXemDinh.Name = "btnXemDinh";
            btnXemDinh.Size = new Size(94, 29);
            btnXemDinh.TabIndex = 11;
            btnXemDinh.Text = "Peek";
            btnXemDinh.UseVisualStyleBackColor = true;
            btnXemDinh.Click += btnXemDinh_Click_1;
            // 
            // btnXoaHet
            // 
            btnXoaHet.Location = new Point(536, 94);
            btnXoaHet.Name = "btnXoaHet";
            btnXoaHet.Size = new Size(94, 29);
            btnXoaHet.TabIndex = 12;
            btnXoaHet.Text = "Clear";
            btnXoaHet.UseVisualStyleBackColor = true;
            btnXoaHet.Click += btnXoaHet_Click_1;
            // 
            // btn_Dem
            // 
            btn_Dem.Location = new Point(636, 94);
            btn_Dem.Name = "btn_Dem";
            btn_Dem.Size = new Size(94, 29);
            btn_Dem.TabIndex = 13;
            btn_Dem.Text = "Count";
            btn_Dem.UseVisualStyleBackColor = true;
            btn_Dem.Click += btn_Dem_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(576, 47);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(118, 27);
            txtAmount.TabIndex = 14;
            txtAmount.Text = "Số tiền";
            txtAmount.TextChanged += textBox1_TextChanged_2;
            // 
            // cbTransactionType
            // 
            cbTransactionType.FormattingEnabled = true;
            cbTransactionType.Items.AddRange(new object[] { "Thu", "Chi" });
            cbTransactionType.Location = new Point(700, 46);
            cbTransactionType.Name = "cbTransactionType";
            cbTransactionType.Size = new Size(151, 28);
            cbTransactionType.TabIndex = 18;
            cbTransactionType.SelectedIndexChanged += cbTransactionType_SelectedIndexChanged;
            // 
            // lblTotalChi
            // 
            lblTotalChi.AutoSize = true;
            lblTotalChi.Location = new Point(682, 652);
            lblTotalChi.Name = "lblTotalChi";
            lblTotalChi.Size = new Size(9, 20);
            lblTotalChi.TabIndex = 19;
            lblTotalChi.Text = "\r\n";
            lblTotalChi.Click += label1_Click_1;
            // 
            // lblTotalThu
            // 
            lblTotalThu.AutoSize = true;
            lblTotalThu.Location = new Point(851, 652);
            lblTotalThu.Name = "lblTotalThu";
            lblTotalThu.Size = new Size(0, 20);
            lblTotalThu.TabIndex = 20;
            lblTotalThu.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UTE_LOGO;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // QuanLyChiTieu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1280, 724);
            Controls.Add(pictureBox1);
            Controls.Add(lblTotalThu);
            Controls.Add(lblTotalChi);
            Controls.Add(cbTransactionType);
            Controls.Add(txtAmount);
            Controls.Add(btn_Dem);
            Controls.Add(btnXoaHet);
            Controls.Add(btnXemDinh);
            Controls.Add(txtTenGD);
            Controls.Add(btnThayDoi);
            Controls.Add(btnTimKiem);
            Controls.Add(txtMaGD);
            Controls.Add(Display);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Name = "QuanLyChiTieu";
            Text = "Quản Lý Chi Tiêu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPush;
        private Button btnPop;
        protected ListBox Display;
        private TextBox txtMaGD;
        private Button btnTimKiem;
        private Button btnThayDoi;
        private TextBox txtTenGD;
        private Button btnXemDinh;
        private Button btnXoaHet;
        private Button btn_Dem;
        private TextBox txtAmount;
        private ComboBox cbTransactionType;
        private Label lblTotalChi;
        private Label lblTotalThu;
        private PictureBox pictureBox1;
    }
}
