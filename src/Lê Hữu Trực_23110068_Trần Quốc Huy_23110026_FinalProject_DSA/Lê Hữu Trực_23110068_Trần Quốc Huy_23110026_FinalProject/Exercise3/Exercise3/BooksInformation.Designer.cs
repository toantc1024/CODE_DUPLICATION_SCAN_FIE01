﻿namespace Exercise3
{
    partial class BooksInformation
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
            this.BooksInformationLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BooksInformationLB
            // 
            this.BooksInformationLB.AutoSize = true;
            this.BooksInformationLB.Location = new System.Drawing.Point(62, 27);
            this.BooksInformationLB.Name = "BooksInformationLB";
            this.BooksInformationLB.Size = new System.Drawing.Size(128, 16);
            this.BooksInformationLB.TabIndex = 0;
            this.BooksInformationLB.Text = "Information of Books";
            // 
            // BooksInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BooksInformationLB);
            this.Name = "BooksInformation";
            this.Text = "Books Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BooksInformationLB;
    }
}