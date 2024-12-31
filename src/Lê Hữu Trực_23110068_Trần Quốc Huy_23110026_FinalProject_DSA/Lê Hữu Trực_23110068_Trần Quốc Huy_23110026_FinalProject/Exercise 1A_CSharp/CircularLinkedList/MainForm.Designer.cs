namespace CircularLinkedList
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPN = new System.Windows.Forms.Panel();
            this.minimizePIC = new System.Windows.Forms.PictureBox();
            this.closePIC = new System.Windows.Forms.PictureBox();
            this.createGB = new System.Windows.Forms.GroupBox();
            this.addBackBT = new System.Windows.Forms.Button();
            this.addAfterBT = new System.Windows.Forms.Button();
            this.addTB = new System.Windows.Forms.TextBox();
            this.addFirstBT = new System.Windows.Forms.Button();
            this.removeCB = new System.Windows.Forms.GroupBox();
            this.removeBackBT = new System.Windows.Forms.Button();
            this.removeAfterBT = new System.Windows.Forms.Button();
            this.removeFirstBT = new System.Windows.Forms.Button();
            this.findCB = new System.Windows.Forms.GroupBox();
            this.findLargerBT = new System.Windows.Forms.Button();
            this.findValueBT = new System.Windows.Forms.Button();
            this.resetBT = new System.Windows.Forms.Button();
            this.clearBT = new System.Windows.Forms.Button();
            this.visualizePN = new System.Windows.Forms.Panel();
            this.statusLB = new System.Windows.Forms.Label();
            this.qSortBT = new System.Windows.Forms.Button();
            this.sSortBT = new System.Windows.Forms.Button();
            this.otherGB = new System.Windows.Forms.GroupBox();
            this.reverseBT = new System.Windows.Forms.Button();
            this.mergeBT = new System.Windows.Forms.Button();
            this.removeLargerBT = new System.Windows.Forms.Button();
            this.colorLB = new System.Windows.Forms.Label();
            this.topPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePIC)).BeginInit();
            this.createGB.SuspendLayout();
            this.removeCB.SuspendLayout();
            this.findCB.SuspendLayout();
            this.otherGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPN
            // 
            this.topPN.BackColor = System.Drawing.Color.AliceBlue;
            this.topPN.Controls.Add(this.minimizePIC);
            this.topPN.Controls.Add(this.closePIC);
            this.topPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPN.Location = new System.Drawing.Point(0, 0);
            this.topPN.Name = "topPN";
            this.topPN.Size = new System.Drawing.Size(1115, 29);
            this.topPN.TabIndex = 0;
            this.topPN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseDown);
            this.topPN.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseMove);
            this.topPN.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPN_MouseUp);
            // 
            // minimizePIC
            // 
            this.minimizePIC.Image = ((System.Drawing.Image)(resources.GetObject("minimizePIC.Image")));
            this.minimizePIC.Location = new System.Drawing.Point(36, -1);
            this.minimizePIC.Name = "minimizePIC";
            this.minimizePIC.Size = new System.Drawing.Size(30, 30);
            this.minimizePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minimizePIC.TabIndex = 2;
            this.minimizePIC.TabStop = false;
            this.minimizePIC.Click += new System.EventHandler(this.minimizePIC_Click);
            // 
            // closePIC
            // 
            this.closePIC.Image = ((System.Drawing.Image)(resources.GetObject("closePIC.Image")));
            this.closePIC.Location = new System.Drawing.Point(0, 0);
            this.closePIC.Name = "closePIC";
            this.closePIC.Size = new System.Drawing.Size(30, 30);
            this.closePIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.closePIC.TabIndex = 1;
            this.closePIC.TabStop = false;
            this.closePIC.Click += new System.EventHandler(this.closePIC_Click);
            // 
            // createGB
            // 
            this.createGB.Controls.Add(this.addBackBT);
            this.createGB.Controls.Add(this.addAfterBT);
            this.createGB.Controls.Add(this.addTB);
            this.createGB.Controls.Add(this.addFirstBT);
            this.createGB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createGB.Location = new System.Drawing.Point(12, 36);
            this.createGB.Name = "createGB";
            this.createGB.Size = new System.Drawing.Size(380, 64);
            this.createGB.TabIndex = 1;
            this.createGB.TabStop = false;
            this.createGB.Text = "Create";
            // 
            // addBackBT
            // 
            this.addBackBT.Location = new System.Drawing.Point(175, 26);
            this.addBackBT.Name = "addBackBT";
            this.addBackBT.Size = new System.Drawing.Size(94, 27);
            this.addBackBT.TabIndex = 3;
            this.addBackBT.Text = "Add Back";
            this.addBackBT.UseVisualStyleBackColor = true;
            this.addBackBT.Click += new System.EventHandler(this.addBackBT_Click);
            // 
            // addAfterBT
            // 
            this.addAfterBT.Location = new System.Drawing.Point(275, 26);
            this.addAfterBT.Name = "addAfterBT";
            this.addAfterBT.Size = new System.Drawing.Size(94, 27);
            this.addAfterBT.TabIndex = 1;
            this.addAfterBT.Text = "Add After";
            this.addAfterBT.UseVisualStyleBackColor = true;
            this.addAfterBT.Click += new System.EventHandler(this.addAfterBT_Click);
            // 
            // addTB
            // 
            this.addTB.Location = new System.Drawing.Point(6, 26);
            this.addTB.Name = "addTB";
            this.addTB.Size = new System.Drawing.Size(63, 27);
            this.addTB.TabIndex = 0;
            this.addTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addFirstBT
            // 
            this.addFirstBT.Location = new System.Drawing.Point(75, 26);
            this.addFirstBT.Name = "addFirstBT";
            this.addFirstBT.Size = new System.Drawing.Size(94, 27);
            this.addFirstBT.TabIndex = 1;
            this.addFirstBT.Text = "Add First";
            this.addFirstBT.UseVisualStyleBackColor = true;
            this.addFirstBT.Click += new System.EventHandler(this.addFirstBT_Click);
            // 
            // removeCB
            // 
            this.removeCB.Controls.Add(this.removeBackBT);
            this.removeCB.Controls.Add(this.removeAfterBT);
            this.removeCB.Controls.Add(this.removeFirstBT);
            this.removeCB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCB.Location = new System.Drawing.Point(398, 36);
            this.removeCB.Name = "removeCB";
            this.removeCB.Size = new System.Drawing.Size(440, 64);
            this.removeCB.TabIndex = 2;
            this.removeCB.TabStop = false;
            this.removeCB.Text = "Remove";
            // 
            // removeBackBT
            // 
            this.removeBackBT.Location = new System.Drawing.Point(147, 26);
            this.removeBackBT.Name = "removeBackBT";
            this.removeBackBT.Size = new System.Drawing.Size(144, 27);
            this.removeBackBT.TabIndex = 3;
            this.removeBackBT.Text = "Remove Back";
            this.removeBackBT.UseVisualStyleBackColor = true;
            this.removeBackBT.Click += new System.EventHandler(this.removeBackBT_Click);
            // 
            // removeAfterBT
            // 
            this.removeAfterBT.Location = new System.Drawing.Point(297, 26);
            this.removeAfterBT.Name = "removeAfterBT";
            this.removeAfterBT.Size = new System.Drawing.Size(136, 27);
            this.removeAfterBT.TabIndex = 1;
            this.removeAfterBT.Text = "Remove After";
            this.removeAfterBT.UseVisualStyleBackColor = true;
            this.removeAfterBT.Click += new System.EventHandler(this.removeAfterBT_Click);
            // 
            // removeFirstBT
            // 
            this.removeFirstBT.Location = new System.Drawing.Point(5, 26);
            this.removeFirstBT.Name = "removeFirstBT";
            this.removeFirstBT.Size = new System.Drawing.Size(136, 27);
            this.removeFirstBT.TabIndex = 1;
            this.removeFirstBT.Text = "Remove First";
            this.removeFirstBT.UseVisualStyleBackColor = true;
            this.removeFirstBT.Click += new System.EventHandler(this.removeFirstBT_Click);
            // 
            // findCB
            // 
            this.findCB.Controls.Add(this.findLargerBT);
            this.findCB.Controls.Add(this.findValueBT);
            this.findCB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findCB.Location = new System.Drawing.Point(844, 35);
            this.findCB.Name = "findCB";
            this.findCB.Size = new System.Drawing.Size(259, 64);
            this.findCB.TabIndex = 3;
            this.findCB.TabStop = false;
            this.findCB.Text = "Searching";
            // 
            // findLargerBT
            // 
            this.findLargerBT.Location = new System.Drawing.Point(132, 26);
            this.findLargerBT.Name = "findLargerBT";
            this.findLargerBT.Size = new System.Drawing.Size(120, 27);
            this.findLargerBT.TabIndex = 4;
            this.findLargerBT.Text = "Find Larger";
            this.findLargerBT.UseVisualStyleBackColor = true;
            this.findLargerBT.Click += new System.EventHandler(this.findLargerBT_Click);
            // 
            // findValueBT
            // 
            this.findValueBT.Location = new System.Drawing.Point(6, 26);
            this.findValueBT.Name = "findValueBT";
            this.findValueBT.Size = new System.Drawing.Size(120, 27);
            this.findValueBT.TabIndex = 3;
            this.findValueBT.Text = "Find Value";
            this.findValueBT.UseVisualStyleBackColor = true;
            this.findValueBT.Click += new System.EventHandler(this.findValueBT_Click);
            // 
            // resetBT
            // 
            this.resetBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBT.Location = new System.Drawing.Point(11, 483);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(79, 27);
            this.resetBT.TabIndex = 5;
            this.resetBT.Text = "Reset";
            this.resetBT.UseVisualStyleBackColor = true;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // clearBT
            // 
            this.clearBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBT.Location = new System.Drawing.Point(11, 409);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(79, 68);
            this.clearBT.TabIndex = 4;
            this.clearBT.Text = "Clear";
            this.clearBT.UseVisualStyleBackColor = true;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // visualizePN
            // 
            this.visualizePN.Location = new System.Drawing.Point(12, 106);
            this.visualizePN.Name = "visualizePN";
            this.visualizePN.Size = new System.Drawing.Size(989, 494);
            this.visualizePN.TabIndex = 5;
            // 
            // statusLB
            // 
            this.statusLB.AutoSize = true;
            this.statusLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLB.Location = new System.Drawing.Point(9, 606);
            this.statusLB.Name = "statusLB";
            this.statusLB.Size = new System.Drawing.Size(72, 23);
            this.statusLB.TabIndex = 6;
            this.statusLB.Text = "Current:";
            // 
            // qSortBT
            // 
            this.qSortBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qSortBT.Location = new System.Drawing.Point(11, 261);
            this.qSortBT.Name = "qSortBT";
            this.qSortBT.Size = new System.Drawing.Size(79, 68);
            this.qSortBT.TabIndex = 7;
            this.qSortBT.Text = "Quick Sort (DES)";
            this.qSortBT.UseVisualStyleBackColor = true;
            this.qSortBT.Click += new System.EventHandler(this.qSortBT_Click);
            // 
            // sSortBT
            // 
            this.sSortBT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sSortBT.Location = new System.Drawing.Point(11, 335);
            this.sSortBT.Name = "sSortBT";
            this.sSortBT.Size = new System.Drawing.Size(79, 68);
            this.sSortBT.TabIndex = 8;
            this.sSortBT.Text = "Selection Sort (ASC)";
            this.sSortBT.UseVisualStyleBackColor = true;
            this.sSortBT.Click += new System.EventHandler(this.sSortBT_Click);
            // 
            // otherGB
            // 
            this.otherGB.Controls.Add(this.resetBT);
            this.otherGB.Controls.Add(this.clearBT);
            this.otherGB.Controls.Add(this.sSortBT);
            this.otherGB.Controls.Add(this.reverseBT);
            this.otherGB.Controls.Add(this.qSortBT);
            this.otherGB.Controls.Add(this.mergeBT);
            this.otherGB.Controls.Add(this.removeLargerBT);
            this.otherGB.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherGB.Location = new System.Drawing.Point(1007, 105);
            this.otherGB.Name = "otherGB";
            this.otherGB.Size = new System.Drawing.Size(100, 523);
            this.otherGB.TabIndex = 4;
            this.otherGB.TabStop = false;
            this.otherGB.Text = "Others";
            // 
            // reverseBT
            // 
            this.reverseBT.Location = new System.Drawing.Point(11, 184);
            this.reverseBT.Name = "reverseBT";
            this.reverseBT.Size = new System.Drawing.Size(79, 71);
            this.reverseBT.TabIndex = 5;
            this.reverseBT.Text = "Reverse";
            this.reverseBT.UseVisualStyleBackColor = true;
            this.reverseBT.Click += new System.EventHandler(this.reverseBT_Click);
            // 
            // mergeBT
            // 
            this.mergeBT.Location = new System.Drawing.Point(11, 107);
            this.mergeBT.Name = "mergeBT";
            this.mergeBT.Size = new System.Drawing.Size(79, 71);
            this.mergeBT.TabIndex = 4;
            this.mergeBT.Text = "Merge";
            this.mergeBT.UseVisualStyleBackColor = true;
            this.mergeBT.Click += new System.EventHandler(this.mergeBT_Click);
            // 
            // removeLargerBT
            // 
            this.removeLargerBT.Location = new System.Drawing.Point(11, 30);
            this.removeLargerBT.Name = "removeLargerBT";
            this.removeLargerBT.Size = new System.Drawing.Size(79, 71);
            this.removeLargerBT.TabIndex = 3;
            this.removeLargerBT.Text = "Remove Larger";
            this.removeLargerBT.UseVisualStyleBackColor = true;
            this.removeLargerBT.Click += new System.EventHandler(this.removeLargerBT_Click);
            // 
            // colorLB
            // 
            this.colorLB.AutoSize = true;
            this.colorLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLB.Location = new System.Drawing.Point(677, 608);
            this.colorLB.Name = "colorLB";
            this.colorLB.Size = new System.Drawing.Size(324, 23);
            this.colorLB.TabIndex = 7;
            this.colorLB.Text = "Green: head | Orange: tail | Grey: Choose";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1115, 640);
            this.Controls.Add(this.colorLB);
            this.Controls.Add(this.otherGB);
            this.Controls.Add(this.statusLB);
            this.Controls.Add(this.visualizePN);
            this.Controls.Add(this.findCB);
            this.Controls.Add(this.removeCB);
            this.Controls.Add(this.createGB);
            this.Controls.Add(this.topPN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Circular Linked List";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topPN.ResumeLayout(false);
            this.topPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePIC)).EndInit();
            this.createGB.ResumeLayout(false);
            this.createGB.PerformLayout();
            this.removeCB.ResumeLayout(false);
            this.findCB.ResumeLayout(false);
            this.otherGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPN;
        private System.Windows.Forms.PictureBox minimizePIC;
        private System.Windows.Forms.PictureBox closePIC;
        private System.Windows.Forms.GroupBox createGB;
        private System.Windows.Forms.TextBox addTB;
        private System.Windows.Forms.Button addAfterBT;
        private System.Windows.Forms.Button addFirstBT;
        private System.Windows.Forms.Button addBackBT;
        private System.Windows.Forms.GroupBox removeCB;
        private System.Windows.Forms.Button removeBackBT;
        private System.Windows.Forms.Button removeAfterBT;
        private System.Windows.Forms.Button removeFirstBT;
        private System.Windows.Forms.GroupBox findCB;
        private System.Windows.Forms.Button findValueBT;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Panel visualizePN;
        private System.Windows.Forms.Label statusLB;
        private System.Windows.Forms.Button findLargerBT;
        private System.Windows.Forms.Button qSortBT;
        private System.Windows.Forms.Button sSortBT;
        private System.Windows.Forms.Button resetBT;
        private System.Windows.Forms.GroupBox otherGB;
        private System.Windows.Forms.Button reverseBT;
        private System.Windows.Forms.Button mergeBT;
        private System.Windows.Forms.Button removeLargerBT;
        private System.Windows.Forms.Label colorLB;
    }
}

