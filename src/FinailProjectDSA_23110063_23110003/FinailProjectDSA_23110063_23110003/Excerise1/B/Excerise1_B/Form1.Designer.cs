namespace Excerise1_B
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btAddLast = new System.Windows.Forms.Button();
            this.btAddFirst = new System.Windows.Forms.Button();
            this.mainBox = new System.Windows.Forms.ListBox();
            this.btAddAfter = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lbAdd = new System.Windows.Forms.Label();
            this.btRemoveFirst = new System.Windows.Forms.Button();
            this.btRemoveLast = new System.Windows.Forms.Button();
            this.lbRemove = new System.Windows.Forms.Label();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btRemoveAfter = new System.Windows.Forms.Button();
            this.btSearchName = new System.Windows.Forms.Button();
            this.btSearchCost = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchCost = new System.Windows.Forms.TextBox();
            this.btLtoH = new System.Windows.Forms.Button();
            this.btReverse = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lbFile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.txtCost);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btCreate);
            this.panel1.Controls.Add(this.lbCost);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Location = new System.Drawing.Point(10, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 104);
            this.panel1.TabIndex = 0;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(62, 59);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(193, 22);
            this.txtCost.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 22);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(261, 16);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(71, 65);
            this.btCreate.TabIndex = 4;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(12, 59);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(34, 16);
            this.lbCost.TabIndex = 1;
            this.lbCost.Text = "Cost";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // btAddLast
            // 
            this.btAddLast.Location = new System.Drawing.Point(167, 18);
            this.btAddLast.Name = "btAddLast";
            this.btAddLast.Size = new System.Drawing.Size(108, 38);
            this.btAddLast.TabIndex = 6;
            this.btAddLast.Text = "AddLast";
            this.btAddLast.UseVisualStyleBackColor = true;
            this.btAddLast.Click += new System.EventHandler(this.btAddLast_Click);
            // 
            // btAddFirst
            // 
            this.btAddFirst.Location = new System.Drawing.Point(26, 18);
            this.btAddFirst.Name = "btAddFirst";
            this.btAddFirst.Size = new System.Drawing.Size(113, 38);
            this.btAddFirst.TabIndex = 5;
            this.btAddFirst.Text = "AddFirst";
            this.btAddFirst.UseVisualStyleBackColor = true;
            this.btAddFirst.Click += new System.EventHandler(this.btAddFirst_Click);
            // 
            // mainBox
            // 
            this.mainBox.FormattingEnabled = true;
            this.mainBox.ItemHeight = 16;
            this.mainBox.Location = new System.Drawing.Point(8, 12);
            this.mainBox.Name = "mainBox";
            this.mainBox.Size = new System.Drawing.Size(347, 196);
            this.mainBox.TabIndex = 0;
            // 
            // btAddAfter
            // 
            this.btAddAfter.Location = new System.Drawing.Point(167, 97);
            this.btAddAfter.Name = "btAddAfter";
            this.btAddAfter.Size = new System.Drawing.Size(128, 38);
            this.btAddAfter.TabIndex = 7;
            this.btAddAfter.Text = "AddAfter";
            this.btAddAfter.UseVisualStyleBackColor = true;
            this.btAddAfter.Click += new System.EventHandler(this.btAddAfter_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(26, 105);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(135, 22);
            this.txtAdd.TabIndex = 7;
            // 
            // lbAdd
            // 
            this.lbAdd.AutoSize = true;
            this.lbAdd.Location = new System.Drawing.Point(0, 69);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(275, 16);
            this.lbAdd.TabIndex = 7;
            this.lbAdd.Text = "Choose The Product You Want To Add After :";
            this.lbAdd.Click += new System.EventHandler(this.label1_Click);
            // 
            // btRemoveFirst
            // 
            this.btRemoveFirst.Location = new System.Drawing.Point(26, 14);
            this.btRemoveFirst.Name = "btRemoveFirst";
            this.btRemoveFirst.Size = new System.Drawing.Size(109, 38);
            this.btRemoveFirst.TabIndex = 8;
            this.btRemoveFirst.Text = "RemoveFirst";
            this.btRemoveFirst.UseVisualStyleBackColor = true;
            this.btRemoveFirst.Click += new System.EventHandler(this.btRemoveFirst_Click);
            // 
            // btRemoveLast
            // 
            this.btRemoveLast.Location = new System.Drawing.Point(167, 14);
            this.btRemoveLast.Name = "btRemoveLast";
            this.btRemoveLast.Size = new System.Drawing.Size(111, 38);
            this.btRemoveLast.TabIndex = 9;
            this.btRemoveLast.Text = "RemoveLast";
            this.btRemoveLast.UseVisualStyleBackColor = true;
            this.btRemoveLast.Click += new System.EventHandler(this.btRemoveLast_Click);
            // 
            // lbRemove
            // 
            this.lbRemove.AutoSize = true;
            this.lbRemove.Location = new System.Drawing.Point(0, 71);
            this.lbRemove.Name = "lbRemove";
            this.lbRemove.Size = new System.Drawing.Size(302, 16);
            this.lbRemove.TabIndex = 10;
            this.lbRemove.Text = "Choose The Product You Want To Remove After :";
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(26, 108);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(135, 22);
            this.txtRemove.TabIndex = 11;
            // 
            // btRemoveAfter
            // 
            this.btRemoveAfter.Location = new System.Drawing.Point(167, 100);
            this.btRemoveAfter.Name = "btRemoveAfter";
            this.btRemoveAfter.Size = new System.Drawing.Size(128, 38);
            this.btRemoveAfter.TabIndex = 12;
            this.btRemoveAfter.Text = "RemoveAfter";
            this.btRemoveAfter.UseVisualStyleBackColor = true;
            this.btRemoveAfter.Click += new System.EventHandler(this.btRemoveAfter_Click);
            // 
            // btSearchName
            // 
            this.btSearchName.Location = new System.Drawing.Point(188, 12);
            this.btSearchName.Name = "btSearchName";
            this.btSearchName.Size = new System.Drawing.Size(142, 38);
            this.btSearchName.TabIndex = 13;
            this.btSearchName.Text = "SearchByName";
            this.btSearchName.UseVisualStyleBackColor = true;
            this.btSearchName.Click += new System.EventHandler(this.btSearchName_Click);
            // 
            // btSearchCost
            // 
            this.btSearchCost.Location = new System.Drawing.Point(188, 56);
            this.btSearchCost.Name = "btSearchCost";
            this.btSearchCost.Size = new System.Drawing.Size(142, 38);
            this.btSearchCost.TabIndex = 14;
            this.btSearchCost.Text = "SearchByCost";
            this.btSearchCost.UseVisualStyleBackColor = true;
            this.btSearchCost.Click += new System.EventHandler(this.btSearchCost_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(15, 20);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(158, 22);
            this.txtSearchName.TabIndex = 15;
            // 
            // txtSearchCost
            // 
            this.txtSearchCost.Location = new System.Drawing.Point(15, 64);
            this.txtSearchCost.Name = "txtSearchCost";
            this.txtSearchCost.Size = new System.Drawing.Size(158, 22);
            this.txtSearchCost.TabIndex = 16;
            // 
            // btLtoH
            // 
            this.btLtoH.Location = new System.Drawing.Point(13, 103);
            this.btLtoH.Name = "btLtoH";
            this.btLtoH.Size = new System.Drawing.Size(317, 45);
            this.btLtoH.TabIndex = 18;
            this.btLtoH.Text = "LowToHigh";
            this.btLtoH.UseVisualStyleBackColor = true;
            this.btLtoH.Click += new System.EventHandler(this.btLtoH_Click);
            // 
            // btReverse
            // 
            this.btReverse.Location = new System.Drawing.Point(5, 16);
            this.btReverse.Name = "btReverse";
            this.btReverse.Size = new System.Drawing.Size(144, 39);
            this.btReverse.TabIndex = 19;
            this.btReverse.Text = "Reverse";
            this.btReverse.UseVisualStyleBackColor = true;
            this.btReverse.Click += new System.EventHandler(this.btReverse_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(155, 16);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(142, 39);
            this.btDelete.TabIndex = 20;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(8, 61);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(77, 39);
            this.btSave.TabIndex = 21;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(361, 448);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(327, 39);
            this.btExit.TabIndex = 22;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.btRemoveFirst);
            this.panel2.Controls.Add(this.btRemoveLast);
            this.panel2.Controls.Add(this.lbRemove);
            this.panel2.Controls.Add(this.txtRemove);
            this.panel2.Controls.Add(this.btRemoveAfter);
            this.panel2.Location = new System.Drawing.Point(361, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 156);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.btAddLast);
            this.panel3.Controls.Add(this.btAddFirst);
            this.panel3.Controls.Add(this.lbAdd);
            this.panel3.Controls.Add(this.btAddAfter);
            this.panel3.Controls.Add(this.txtAdd);
            this.panel3.Location = new System.Drawing.Point(361, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 146);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.btLtoH);
            this.panel4.Controls.Add(this.txtSearchName);
            this.panel4.Controls.Add(this.btSearchName);
            this.panel4.Controls.Add(this.btSearchCost);
            this.panel4.Controls.Add(this.txtSearchCost);
            this.panel4.Location = new System.Drawing.Point(10, 326);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 160);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.txtFile);
            this.panel5.Controls.Add(this.lbFile);
            this.panel5.Controls.Add(this.btReverse);
            this.panel5.Controls.Add(this.btDelete);
            this.panel5.Controls.Add(this.btSave);
            this.panel5.Location = new System.Drawing.Point(361, 326);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(327, 110);
            this.panel5.TabIndex = 25;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(123, 69);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(172, 22);
            this.txtFile.TabIndex = 23;
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Location = new System.Drawing.Point(89, 72);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(35, 16);
            this.lbFile.TabIndex = 22;
            this.lbFile.Text = "File: ";
            this.lbFile.Click += new System.EventHandler(this.lbFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 499);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ListBox mainBox;
        private System.Windows.Forms.Button btAddLast;
        private System.Windows.Forms.Button btAddFirst;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btAddAfter;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lbAdd;
        private System.Windows.Forms.Button btRemoveFirst;
        private System.Windows.Forms.Button btRemoveLast;
        private System.Windows.Forms.Label lbRemove;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btRemoveAfter;
        private System.Windows.Forms.Button btSearchName;
        private System.Windows.Forms.Button btSearchCost;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtSearchCost;
        private System.Windows.Forms.Button btLtoH;
        private System.Windows.Forms.Button btReverse;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbFile;
        private System.Windows.Forms.TextBox txtFile;
    }
}

