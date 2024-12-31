namespace CircularLinkedList_C_
{
    partial class UserInformation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCalender = new System.Windows.Forms.Button();
            this.btnExercises = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.lbSetBMI = new System.Windows.Forms.Label();
            this.lbKcal = new System.Windows.Forms.Label();
            this.lbNumberOfExercises = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Histories = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbSetBMI);
            this.panel1.Controls.Add(this.lbKcal);
            this.panel1.Controls.Add(this.lbNumberOfExercises);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Histories);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 495);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCalender);
            this.panel3.Controls.Add(this.btnExercises);
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Location = new System.Drawing.Point(2, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 42);
            this.panel3.TabIndex = 9;
            // 
            // btnCalender
            // 
            this.btnCalender.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalender.Location = new System.Drawing.Point(223, 0);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.Size = new System.Drawing.Size(108, 42);
            this.btnCalender.TabIndex = 2;
            this.btnCalender.Text = "Calender";
            this.btnCalender.UseVisualStyleBackColor = true;
            this.btnCalender.Click += new System.EventHandler(this.btnCalender_Click);
            // 
            // btnExercises
            // 
            this.btnExercises.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercises.ForeColor = System.Drawing.Color.Red;
            this.btnExercises.Location = new System.Drawing.Point(113, 0);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Size = new System.Drawing.Size(108, 42);
            this.btnExercises.TabIndex = 1;
            this.btnExercises.Text = "Exercises";
            this.btnExercises.UseVisualStyleBackColor = true;
            this.btnExercises.Click += new System.EventHandler(this.btnExercises_Click);
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUser.Location = new System.Drawing.Point(1, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(108, 42);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // lbSetBMI
            // 
            this.lbSetBMI.AutoSize = true;
            this.lbSetBMI.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetBMI.Location = new System.Drawing.Point(246, 49);
            this.lbSetBMI.Name = "lbSetBMI";
            this.lbSetBMI.Size = new System.Drawing.Size(43, 19);
            this.lbSetBMI.TabIndex = 7;
            this.lbSetBMI.Text = "65Kg";
            this.lbSetBMI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKcal
            // 
            this.lbKcal.AutoSize = true;
            this.lbKcal.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKcal.Location = new System.Drawing.Point(156, 49);
            this.lbKcal.Name = "lbKcal";
            this.lbKcal.Size = new System.Drawing.Size(50, 19);
            this.lbKcal.TabIndex = 6;
            this.lbKcal.Text = "label6";
            this.lbKcal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNumberOfExercises
            // 
            this.lbNumberOfExercises.AutoSize = true;
            this.lbNumberOfExercises.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumberOfExercises.Location = new System.Drawing.Point(39, 49);
            this.lbNumberOfExercises.Name = "lbNumberOfExercises";
            this.lbNumberOfExercises.Size = new System.Drawing.Size(50, 19);
            this.lbNumberOfExercises.TabIndex = 5;
            this.lbNumberOfExercises.Text = "label5";
            this.lbNumberOfExercises.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(246, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "BMI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kcal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Times Workout";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Profile";
            // 
            // Histories
            // 
            this.Histories.AutoScroll = true;
            this.Histories.BackColor = System.Drawing.Color.White;
            this.Histories.Location = new System.Drawing.Point(11, 232);
            this.Histories.Name = "Histories";
            this.Histories.Size = new System.Drawing.Size(314, 215);
            this.Histories.TabIndex = 0;
            this.Histories.Paint += new System.Windows.Forms.PaintEventHandler(this.Histories_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(11, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 107);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(2, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(311, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "My Playlist";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(2, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save - Recover";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Setting";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 495);
            this.Controls.Add(this.panel1);
            this.Name = "UserInformation";
            this.Text = "UserInformation";
            this.Load += new System.EventHandler(this.UserInformation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Histories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSetBMI;
        private System.Windows.Forms.Label lbKcal;
        private System.Windows.Forms.Label lbNumberOfExercises;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCalender;
        private System.Windows.Forms.Button btnExercises;
        private System.Windows.Forms.Button btnUser;
    }
}

