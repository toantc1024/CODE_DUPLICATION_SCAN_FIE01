namespace CircularLinkedList_C_
{
    partial class UserChoices
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShoulder = new System.Windows.Forms.Button();
            this.btnChest = new System.Windows.Forms.Button();
            this.btnLeg = new System.Windows.Forms.Button();
            this.btnBurnFat = new System.Windows.Forms.Button();
            this.btnBurnCalo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCalender = new System.Windows.Forms.Button();
            this.btnExercises = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 52);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your own exercise";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.btnShoulder);
            this.panel2.Controls.Add(this.btnChest);
            this.panel2.Controls.Add(this.btnLeg);
            this.panel2.Controls.Add(this.btnBurnFat);
            this.panel2.Controls.Add(this.btnBurnCalo);
            this.panel2.Location = new System.Drawing.Point(12, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 376);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnShoulder
            // 
            this.btnShoulder.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoulder.Image = global::CircularLinkedList_C_.Properties.Resources.shoulder;
            this.btnShoulder.Location = new System.Drawing.Point(14, 497);
            this.btnShoulder.Name = "btnShoulder";
            this.btnShoulder.Size = new System.Drawing.Size(314, 115);
            this.btnShoulder.TabIndex = 4;
            this.btnShoulder.Text = "Shoulder";
            this.btnShoulder.UseVisualStyleBackColor = true;
            this.btnShoulder.Click += new System.EventHandler(this.btnShoulder_Click);
            // 
            // btnChest
            // 
            this.btnChest.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChest.Image = global::CircularLinkedList_C_.Properties.Resources.chest;
            this.btnChest.Location = new System.Drawing.Point(14, 376);
            this.btnChest.Name = "btnChest";
            this.btnChest.Size = new System.Drawing.Size(314, 115);
            this.btnChest.TabIndex = 3;
            this.btnChest.Text = "Chest";
            this.btnChest.UseVisualStyleBackColor = true;
            this.btnChest.Click += new System.EventHandler(this.btnChest_Click);
            // 
            // btnLeg
            // 
            this.btnLeg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLeg.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeg.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLeg.Image = global::CircularLinkedList_C_.Properties.Resources.TapCoInterface;
            this.btnLeg.Location = new System.Drawing.Point(14, 13);
            this.btnLeg.Name = "btnLeg";
            this.btnLeg.Size = new System.Drawing.Size(314, 115);
            this.btnLeg.TabIndex = 0;
            this.btnLeg.Text = "Leg";
            this.btnLeg.UseVisualStyleBackColor = false;
            this.btnLeg.Click += new System.EventHandler(this.btnMuscle_Click);
            // 
            // btnBurnFat
            // 
            this.btnBurnFat.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurnFat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBurnFat.Image = global::CircularLinkedList_C_.Properties.Resources.TapCoBungInterface;
            this.btnBurnFat.Location = new System.Drawing.Point(14, 134);
            this.btnBurnFat.Name = "btnBurnFat";
            this.btnBurnFat.Size = new System.Drawing.Size(314, 115);
            this.btnBurnFat.TabIndex = 1;
            this.btnBurnFat.Text = "Belly";
            this.btnBurnFat.UseVisualStyleBackColor = true;
            this.btnBurnFat.Click += new System.EventHandler(this.btnBurnFat_Click);
            // 
            // btnBurnCalo
            // 
            this.btnBurnCalo.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurnCalo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBurnCalo.Image = global::CircularLinkedList_C_.Properties.Resources.burncalo;
            this.btnBurnCalo.Location = new System.Drawing.Point(14, 255);
            this.btnBurnCalo.Name = "btnBurnCalo";
            this.btnBurnCalo.Size = new System.Drawing.Size(314, 115);
            this.btnBurnCalo.TabIndex = 2;
            this.btnBurnCalo.Text = "Burn Calo";
            this.btnBurnCalo.UseVisualStyleBackColor = true;
            this.btnBurnCalo.Click += new System.EventHandler(this.btnBurnCalo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.btnCalender);
            this.panel3.Controls.Add(this.btnExercises);
            this.panel3.Controls.Add(this.btnUser);
            this.panel3.Location = new System.Drawing.Point(4, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 42);
            this.panel3.TabIndex = 10;
            // 
            // btnCalender
            // 
            this.btnCalender.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalender.Location = new System.Drawing.Point(253, 0);
            this.btnCalender.Name = "btnCalender";
            this.btnCalender.Size = new System.Drawing.Size(108, 42);
            this.btnCalender.TabIndex = 2;
            this.btnCalender.Text = "Calender";
            this.btnCalender.UseVisualStyleBackColor = true;
            this.btnCalender.Click += new System.EventHandler(this.btnCalender_Click);
            // 
            // btnExercises
            // 
            this.btnExercises.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExercises.ForeColor = System.Drawing.Color.Red;
            this.btnExercises.Location = new System.Drawing.Point(125, 0);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Size = new System.Drawing.Size(108, 42);
            this.btnExercises.TabIndex = 1;
            this.btnExercises.Text = "Exercises";
            this.btnExercises.UseVisualStyleBackColor = true;
            this.btnExercises.Click += new System.EventHandler(this.btnExercises_Click);
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUser.Location = new System.Drawing.Point(1, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(108, 42);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // UserChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 490);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserChoices";
            this.Text = "UserChoices";
            this.Load += new System.EventHandler(this.UserChoices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLeg;
        private System.Windows.Forms.Button btnBurnFat;
        private System.Windows.Forms.Button btnBurnCalo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChest;
        private System.Windows.Forms.Button btnShoulder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCalender;
        private System.Windows.Forms.Button btnExercises;
        private System.Windows.Forms.Button btnUser;
    }
}