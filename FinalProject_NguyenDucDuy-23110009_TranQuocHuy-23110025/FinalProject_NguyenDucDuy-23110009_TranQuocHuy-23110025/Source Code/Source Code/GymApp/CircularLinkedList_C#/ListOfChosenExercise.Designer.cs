namespace CircularLinkedList_C_
{
    partial class ListOfChosenExercise
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNameMainPic = new System.Windows.Forms.Label();
            this.pictureBoxMainPic = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Location = new System.Drawing.Point(13, 140);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(317, 298);
            this.panelContainer.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.lbNameMainPic);
            this.panel2.Controls.Add(this.pictureBoxMainPic);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 100);
            this.panel2.TabIndex = 1;
            // 
            // lbNameMainPic
            // 
            this.lbNameMainPic.AutoSize = true;
            this.lbNameMainPic.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameMainPic.ForeColor = System.Drawing.Color.IndianRed;
            this.lbNameMainPic.Location = new System.Drawing.Point(35, 10);
            this.lbNameMainPic.Name = "lbNameMainPic";
            this.lbNameMainPic.Size = new System.Drawing.Size(105, 36);
            this.lbNameMainPic.TabIndex = 3;
            this.lbNameMainPic.Text = "Name ";
            // 
            // pictureBoxMainPic
            // 
            this.pictureBoxMainPic.Location = new System.Drawing.Point(168, 10);
            this.pictureBoxMainPic.Name = "pictureBoxMainPic";
            this.pictureBoxMainPic.Size = new System.Drawing.Size(133, 82);
            this.pictureBoxMainPic.TabIndex = 0;
            this.pictureBoxMainPic.TabStop = false;
            this.pictureBoxMainPic.Click += new System.EventHandler(this.pictureBoxMainPic_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(31, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 37);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(255, 116);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // ListOfChosenExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelContainer);
            this.Name = "ListOfChosenExercise";
            this.Text = "ListOfChosenExercise";
            this.Load += new System.EventHandler(this.ListOfChosenExercise_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNameMainPic;
        private System.Windows.Forms.PictureBox pictureBoxMainPic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSort;
    }
}