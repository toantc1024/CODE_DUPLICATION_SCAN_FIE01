namespace DoctorQueueApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnEnterRoom = new System.Windows.Forms.Button();
            this.btnBeginConsultation = new System.Windows.Forms.Button();
            this.btnClosingTime = new System.Windows.Forms.Button();
            this.btnPrioritySignUp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvQueue = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colConcern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDisplayRoomInfo = new System.Windows.Forms.TextBox();
            this.lblQueue = new System.Windows.Forms.Label();
            this.lblRoomInfo = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_logoandschoolname = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_schoolname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_logoandschoolname.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSignUp.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.Location = new System.Drawing.Point(18, 382);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(129, 40);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // btnEnterRoom
            // 
            this.btnEnterRoom.BackColor = System.Drawing.Color.LightGreen;
            this.btnEnterRoom.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnterRoom.Location = new System.Drawing.Point(504, 117);
            this.btnEnterRoom.Name = "btnEnterRoom";
            this.btnEnterRoom.Size = new System.Drawing.Size(140, 40);
            this.btnEnterRoom.TabIndex = 1;
            this.btnEnterRoom.Text = "Enter Room";
            this.btnEnterRoom.UseVisualStyleBackColor = false;
            this.btnEnterRoom.Click += new System.EventHandler(this.btnEnterRoom_Click);
            // 
            // btnBeginConsultation
            // 
            this.btnBeginConsultation.BackColor = System.Drawing.Color.Salmon;
            this.btnBeginConsultation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnBeginConsultation.Location = new System.Drawing.Point(808, 223);
            this.btnBeginConsultation.Name = "btnBeginConsultation";
            this.btnBeginConsultation.Size = new System.Drawing.Size(178, 40);
            this.btnBeginConsultation.TabIndex = 2;
            this.btnBeginConsultation.Text = "Begin Consultation";
            this.btnBeginConsultation.UseVisualStyleBackColor = false;
            this.btnBeginConsultation.Click += new System.EventHandler(this.btnBeginConsultation_Click);
            // 
            // btnClosingTime
            // 
            this.btnClosingTime.BackColor = System.Drawing.Color.Khaki;
            this.btnClosingTime.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClosingTime.Location = new System.Drawing.Point(504, 177);
            this.btnClosingTime.Name = "btnClosingTime";
            this.btnClosingTime.Size = new System.Drawing.Size(140, 40);
            this.btnClosingTime.TabIndex = 3;
            this.btnClosingTime.Text = "Closing Time";
            this.btnClosingTime.UseVisualStyleBackColor = false;
            this.btnClosingTime.Click += new System.EventHandler(this.btnClosingTime_Click);
            // 
            // btnPrioritySignUp
            // 
            this.btnPrioritySignUp.BackColor = System.Drawing.Color.Orchid;
            this.btnPrioritySignUp.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrioritySignUp.Location = new System.Drawing.Point(215, 382);
            this.btnPrioritySignUp.Name = "btnPrioritySignUp";
            this.btnPrioritySignUp.Size = new System.Drawing.Size(166, 40);
            this.btnPrioritySignUp.TabIndex = 4;
            this.btnPrioritySignUp.Text = "Priority Sign Up";
            this.btnPrioritySignUp.UseVisualStyleBackColor = false;
            this.btnPrioritySignUp.Click += new System.EventHandler(this.btnPrioritySignUp_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(898, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvQueue
            // 
            this.dgvQueue.AllowUserToAddRows = false;
            this.dgvQueue.AllowUserToDeleteRows = false;
            this.dgvQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colConcern});
            this.dgvQueue.Location = new System.Drawing.Point(22, 117);
            this.dgvQueue.Name = "dgvQueue";
            this.dgvQueue.ReadOnly = true;
            this.dgvQueue.RowHeadersWidth = 51;
            this.dgvQueue.RowTemplate.Height = 24;
            this.dgvQueue.Size = new System.Drawing.Size(363, 244);
            this.dgvQueue.TabIndex = 6;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // colConcern
            // 
            this.colConcern.HeaderText = "Concern";
            this.colConcern.MinimumWidth = 6;
            this.colConcern.Name = "colConcern";
            this.colConcern.ReadOnly = true;
            this.colConcern.Width = 200;
            // 
            // txtDisplayRoomInfo
            // 
            this.txtDisplayRoomInfo.Location = new System.Drawing.Point(779, 117);
            this.txtDisplayRoomInfo.Multiline = true;
            this.txtDisplayRoomInfo.Name = "txtDisplayRoomInfo";
            this.txtDisplayRoomInfo.Size = new System.Drawing.Size(228, 100);
            this.txtDisplayRoomInfo.TabIndex = 7;
            this.txtDisplayRoomInfo.TextChanged += new System.EventHandler(this.txtDisplayRoomInfo_TextChanged);
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblQueue.Location = new System.Drawing.Point(18, 87);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(154, 19);
            this.lblQueue.TabIndex = 8;
            this.lblQueue.Text = "Patients in Queue:";
            // 
            // lblRoomInfo
            // 
            this.lblRoomInfo.AutoSize = true;
            this.lblRoomInfo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblRoomInfo.Location = new System.Drawing.Point(775, 87);
            this.lblRoomInfo.Name = "lblRoomInfo";
            this.lblRoomInfo.Size = new System.Drawing.Size(155, 19);
            this.lblRoomInfo.TabIndex = 9;
            this.lblRoomInfo.Text = "Room Information:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.flowLayoutPanel2.Controls.Add(this.pictureBox_logo);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 466);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1050, 35);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.White;
            this.pictureBox_logo.Image = global::Queues__Linked_List_Implementation__Project.Properties.Resources.Logo_Trường_Đại_Học_Sư_Phạm_Kỹ_Thuật_TP_Hồ_Chí_Minh;
            this.pictureBox_logo.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(103, 26);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(824, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dr. Bui Quang Huy - 23110022  and  Dr. Nguyen Hang Hai Long - 23110036";
            // 
            // panel_logoandschoolname
            // 
            this.panel_logoandschoolname.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_logoandschoolname.Controls.Add(this.lbl_schoolname);
            this.panel_logoandschoolname.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logoandschoolname.Location = new System.Drawing.Point(0, 0);
            this.panel_logoandschoolname.Name = "panel_logoandschoolname";
            this.panel_logoandschoolname.Size = new System.Drawing.Size(1050, 60);
            this.panel_logoandschoolname.TabIndex = 11;
            // 
            // lbl_schoolname
            // 
            this.lbl_schoolname.AutoSize = true;
            this.lbl_schoolname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_schoolname.ForeColor = System.Drawing.Color.White;
            this.lbl_schoolname.Location = new System.Drawing.Point(3, 0);
            this.lbl_schoolname.Name = "lbl_schoolname";
            this.lbl_schoolname.Size = new System.Drawing.Size(929, 27);
            this.lbl_schoolname.TabIndex = 2;
            this.lbl_schoolname.Text = "Welcome to Doctor\'s Queue Management - Queues (Linked List Implementation)  ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 501);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel_logoandschoolname);
            this.Controls.Add(this.lblRoomInfo);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.txtDisplayRoomInfo);
            this.Controls.Add(this.dgvQueue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrioritySignUp);
            this.Controls.Add(this.btnClosingTime);
            this.Controls.Add(this.btnBeginConsultation);
            this.Controls.Add(this.btnEnterRoom);
            this.Controls.Add(this.btnSignUp);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor\'s Queue Management";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueue)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_logoandschoolname.ResumeLayout(false);
            this.panel_logoandschoolname.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnEnterRoom;
        private System.Windows.Forms.Button btnBeginConsultation;
        private System.Windows.Forms.Button btnClosingTime;
        private System.Windows.Forms.Button btnPrioritySignUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConcern;
        private System.Windows.Forms.TextBox txtDisplayRoomInfo;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label lblRoomInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panel_logoandschoolname;
        private System.Windows.Forms.Label lbl_schoolname;
        private System.Windows.Forms.PictureBox pictureBox_logo;
    }
}
