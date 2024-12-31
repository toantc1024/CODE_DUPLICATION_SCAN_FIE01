namespace ques_2_21_12
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
            this.Queuestatic = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jobname = new System.Windows.Forms.TextBox();
            this.PageCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstJobs = new System.Windows.Forms.ListBox();
            this.DoubleSided = new System.Windows.Forms.CheckBox();
            this.lblCurrentJob = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.btnNextProcess = new System.Windows.Forms.Button();
            this.StopProcessing = new System.Windows.Forms.Button();
            this.Processjob = new System.Windows.Forms.Button();
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.Statistics = new System.Windows.Forms.ListBox();
            this.ContinueProcessing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Queuestatic
            // 
            this.Queuestatic.Location = new System.Drawing.Point(619, 289);
            this.Queuestatic.Name = "Queuestatic";
            this.Queuestatic.Size = new System.Drawing.Size(160, 25);
            this.Queuestatic.TabIndex = 10;
            this.Queuestatic.Text = "Queue Statistics";
            this.Queuestatic.UseVisualStyleBackColor = true;
            this.Queuestatic.Click += new System.EventHandler(this.Queuestatic_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete Current Print Job";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Deletecurrentprintjob);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add Print Job";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Addprintjob);
            // 
            // jobname
            // 
            this.jobname.Location = new System.Drawing.Point(228, 62);
            this.jobname.Name = "jobname";
            this.jobname.Size = new System.Drawing.Size(80, 20);
            this.jobname.TabIndex = 12;
            this.jobname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PageCount
            // 
            this.PageCount.Location = new System.Drawing.Point(355, 62);
            this.PageCount.Name = "PageCount";
            this.PageCount.Size = new System.Drawing.Size(80, 20);
            this.PageCount.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter Job Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter Page Count:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Is it Double-sided? :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lstJobs
            // 
            this.lstJobs.FormattingEnabled = true;
            this.lstJobs.Location = new System.Drawing.Point(33, 175);
            this.lstJobs.Name = "lstJobs";
            this.lstJobs.Size = new System.Drawing.Size(554, 420);
            this.lstJobs.TabIndex = 18;
            this.lstJobs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DoubleSided
            // 
            this.DoubleSided.AutoSize = true;
            this.DoubleSided.Location = new System.Drawing.Point(508, 62);
            this.DoubleSided.Name = "DoubleSided";
            this.DoubleSided.Size = new System.Drawing.Size(15, 14);
            this.DoubleSided.TabIndex = 19;
            this.DoubleSided.UseVisualStyleBackColor = true;
            // 
            // lblCurrentJob
            // 
            this.lblCurrentJob.AutoSize = true;
            this.lblCurrentJob.Location = new System.Drawing.Point(625, 118);
            this.lblCurrentJob.Name = "lblCurrentJob";
            this.lblCurrentJob.Size = new System.Drawing.Size(58, 13);
            this.lblCurrentJob.TabIndex = 20;
            this.lblCurrentJob.Text = "CurrentJob";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Location = new System.Drawing.Point(762, 118);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(109, 13);
            this.lblTimeRemaining.TabIndex = 21;
            this.lblTimeRemaining.Text = "Time Remaining: N/A";
            this.lblTimeRemaining.UseWaitCursor = true;
            // 
            // btnNextProcess
            // 
            this.btnNextProcess.Location = new System.Drawing.Point(947, 192);
            this.btnNextProcess.Name = "btnNextProcess";
            this.btnNextProcess.Size = new System.Drawing.Size(120, 25);
            this.btnNextProcess.TabIndex = 23;
            this.btnNextProcess.Text = "Process Next";
            this.btnNextProcess.UseVisualStyleBackColor = true;
            this.btnNextProcess.Click += new System.EventHandler(this.Processnext_Click);
            // 
            // StopProcessing
            // 
            this.StopProcessing.Location = new System.Drawing.Point(628, 192);
            this.StopProcessing.Name = "StopProcessing";
            this.StopProcessing.Size = new System.Drawing.Size(100, 25);
            this.StopProcessing.TabIndex = 24;
            this.StopProcessing.Text = "Stop Processing";
            this.StopProcessing.UseVisualStyleBackColor = true;
            this.StopProcessing.Click += new System.EventHandler(this.StopProcessing_Click);
            // 
            // Processjob
            // 
            this.Processjob.Location = new System.Drawing.Point(619, 55);
            this.Processjob.Name = "Processjob";
            this.Processjob.Size = new System.Drawing.Size(160, 25);
            this.Processjob.TabIndex = 25;
            this.Processjob.Text = "Proccess job";
            this.Processjob.UseVisualStyleBackColor = true;
            this.Processjob.Click += new System.EventHandler(this.ProcessJob_Click);
            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.AutoSize = true;
            this.lblEstimatedTime.Location = new System.Drawing.Point(944, 118);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(105, 13);
            this.lblEstimatedTime.TabIndex = 26;
            this.lblEstimatedTime.Text = "Estimated Time: N/A";
            this.lblEstimatedTime.Click += new System.EventHandler(this.label4_Click);
            // 
            // Statistics
            // 
            this.Statistics.FormattingEnabled = true;
            this.Statistics.Location = new System.Drawing.Point(619, 357);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(467, 238);
            this.Statistics.TabIndex = 27;
            // 
            // ContinueProcessing
            // 
            this.ContinueProcessing.Location = new System.Drawing.Point(765, 192);
            this.ContinueProcessing.Name = "ContinueProcessing";
            this.ContinueProcessing.Size = new System.Drawing.Size(131, 23);
            this.ContinueProcessing.TabIndex = 28;
            this.ContinueProcessing.Text = "Continue Processing";
            this.ContinueProcessing.UseVisualStyleBackColor = true;
            this.ContinueProcessing.Click += new System.EventHandler(this.ContinueProcessing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 615);
            this.Controls.Add(this.ContinueProcessing);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.lblEstimatedTime);
            this.Controls.Add(this.Processjob);
            this.Controls.Add(this.StopProcessing);
            this.Controls.Add(this.btnNextProcess);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblCurrentJob);
            this.Controls.Add(this.DoubleSided);
            this.Controls.Add(this.lstJobs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PageCount);
            this.Controls.Add(this.jobname);
            this.Controls.Add(this.Queuestatic);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Queuestatic;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox jobname;
        private System.Windows.Forms.TextBox PageCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstJobs;
        private System.Windows.Forms.CheckBox DoubleSided;
        private System.Windows.Forms.Label lblCurrentJob;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Button btnNextProcess;
        private System.Windows.Forms.Button StopProcessing;
        private System.Windows.Forms.Button Processjob;
        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.ListBox Statistics;
        private System.Windows.Forms.Button ContinueProcessing;
    }
}

