namespace CircularLinkedList_C_
{
    partial class GymApp
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
            this.components = new System.ComponentModel.Container();
            this.TimerCountdown = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lbExerciseName = new System.Windows.Forms.Label();
            this.lbExerciseNum = new System.Windows.Forms.Label();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.btnStopRepeat = new System.Windows.Forms.Button();
            this.btnGetBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCountdowm = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.lbTimeBreak = new System.Windows.Forms.Label();
            this.TimerTimeBreak = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerCountdown
            // 
            this.TimerCountdown.Interval = 1000;
            this.TimerCountdown.Tick += new System.EventHandler(this.TimerCountdown_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(147, 416);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 31);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbExerciseName
            // 
            this.lbExerciseName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExerciseName.AutoSize = true;
            this.lbExerciseName.BackColor = System.Drawing.Color.Teal;
            this.lbExerciseName.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExerciseName.Location = new System.Drawing.Point(12, 268);
            this.lbExerciseName.Name = "lbExerciseName";
            this.lbExerciseName.Size = new System.Drawing.Size(50, 19);
            this.lbExerciseName.TabIndex = 4;
            this.lbExerciseName.Text = "label1";
            this.lbExerciseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExerciseName.Visible = false;
            // 
            // lbExerciseNum
            // 
            this.lbExerciseNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExerciseNum.AutoSize = true;
            this.lbExerciseNum.BackColor = System.Drawing.Color.Teal;
            this.lbExerciseNum.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExerciseNum.Location = new System.Drawing.Point(12, 240);
            this.lbExerciseNum.Name = "lbExerciseNum";
            this.lbExerciseNum.Size = new System.Drawing.Size(50, 19);
            this.lbExerciseNum.TabIndex = 3;
            this.lbExerciseNum.Text = "label1";
            this.lbExerciseNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExerciseNum.Visible = false;
            // 
            // btnRepeat
            // 
            this.btnRepeat.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepeat.Location = new System.Drawing.Point(301, 286);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(75, 23);
            this.btnRepeat.TabIndex = 6;
            this.btnRepeat.Text = "Repeat";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnStopRepeat
            // 
            this.btnStopRepeat.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopRepeat.ForeColor = System.Drawing.Color.Red;
            this.btnStopRepeat.Location = new System.Drawing.Point(301, 325);
            this.btnStopRepeat.Name = "btnStopRepeat";
            this.btnStopRepeat.Size = new System.Drawing.Size(75, 23);
            this.btnStopRepeat.TabIndex = 7;
            this.btnStopRepeat.Text = "Stop";
            this.btnStopRepeat.UseVisualStyleBackColor = true;
            this.btnStopRepeat.Click += new System.EventHandler(this.btnStopRepeat_Click);
            // 
            // btnGetBack
            // 
            this.btnGetBack.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBack.Location = new System.Drawing.Point(336, 421);
            this.btnGetBack.Name = "btnGetBack";
            this.btnGetBack.Size = new System.Drawing.Size(75, 23);
            this.btnGetBack.TabIndex = 8;
            this.btnGetBack.Text = "Back";
            this.btnGetBack.UseVisualStyleBackColor = true;
            this.btnGetBack.Click += new System.EventHandler(this.btnGetBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lbCountdowm);
            this.panel1.Location = new System.Drawing.Point(12, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 58);
            this.panel1.TabIndex = 1;
            // 
            // lbCountdowm
            // 
            this.lbCountdowm.AutoSize = true;
            this.lbCountdowm.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountdowm.ForeColor = System.Drawing.Color.Red;
            this.lbCountdowm.Location = new System.Drawing.Point(40, 7);
            this.lbCountdowm.Name = "lbCountdowm";
            this.lbCountdowm.Size = new System.Drawing.Size(42, 46);
            this.lbCountdowm.TabIndex = 0;
            this.lbCountdowm.Text = "0";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnd.Location = new System.Drawing.Point(132, 69);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(158, 86);
            this.lbEnd.TabIndex = 9;
            this.lbEnd.Text = "End";
            this.lbEnd.Visible = false;
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BackColor = System.Drawing.Color.White;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(27, 12);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(359, 213);
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            // 
            // lbTimeBreak
            // 
            this.lbTimeBreak.AutoSize = true;
            this.lbTimeBreak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbTimeBreak.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeBreak.Location = new System.Drawing.Point(12, 69);
            this.lbTimeBreak.Name = "lbTimeBreak";
            this.lbTimeBreak.Size = new System.Drawing.Size(398, 86);
            this.lbTimeBreak.TabIndex = 10;
            this.lbTimeBreak.Text = "Time Break";
            this.lbTimeBreak.Visible = false;
            this.lbTimeBreak.Click += new System.EventHandler(this.lbTimeBreak_Click);
            // 
            // TimerTimeBreak
            // 
            this.TimerTimeBreak.Interval = 1000;
            this.TimerTimeBreak.Tick += new System.EventHandler(this.TimerTimeBreak_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(390, 234);
            this.panel2.TabIndex = 11;
            // 
            // GymApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(414, 459);
            this.Controls.Add(this.lbTimeBreak);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetBack);
            this.Controls.Add(this.btnStopRepeat);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.lbExerciseName);
            this.Controls.Add(this.lbExerciseNum);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Controls.Add(this.panel2);
            this.Name = "GymApp";
            this.Text = "GymApp";
            this.Load += new System.EventHandler(this.GymApp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.Timer TimerCountdown;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbExerciseName;
        private System.Windows.Forms.Label lbExerciseNum;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnStopRepeat;
        private System.Windows.Forms.Button btnGetBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCountdowm;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbTimeBreak;
        private System.Windows.Forms.Timer TimerTimeBreak;
        private System.Windows.Forms.Panel panel2;
    }
}