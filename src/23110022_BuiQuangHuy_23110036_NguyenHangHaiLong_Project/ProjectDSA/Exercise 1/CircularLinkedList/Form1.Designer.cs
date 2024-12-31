namespace CircularLinkedList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnAddAtBeginning = new System.Windows.Forms.Button();
            this.btnAddAtEnd = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblinput = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_logoandschoolname = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_schoolname = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnMergeLists = new System.Windows.Forms.Button();
            this.btnRemoveAllNodes = new System.Windows.Forms.Button();
            this.btnPrintList = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAfterNode = new System.Windows.Forms.TextBox();
            this.btnInsertAfterNode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAfter = new System.Windows.Forms.TextBox();
            this.btnRemoveAfterNode = new System.Windows.Forms.Button();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.panel_logoandschoolname.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 16;
            this.lstDisplay.Location = new System.Drawing.Point(3, 496);
            this.lstDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(1361, 260);
            this.lstDisplay.TabIndex = 37;
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.BackColor = System.Drawing.Color.LightGreen;
            this.btnRemoveFirst.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveFirst.Location = new System.Drawing.Point(15, 158);
            this.btnRemoveFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(224, 49);
            this.btnRemoveFirst.TabIndex = 36;
            this.btnRemoveFirst.Text = "Remove First";
            this.btnRemoveFirst.UseVisualStyleBackColor = false;
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.BackColor = System.Drawing.Color.LightGreen;
            this.btnRemoveLast.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveLast.Location = new System.Drawing.Point(269, 158);
            this.btnRemoveLast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(224, 49);
            this.btnRemoveLast.TabIndex = 35;
            this.btnRemoveLast.Text = "Remove Last";
            this.btnRemoveLast.UseVisualStyleBackColor = false;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(977, 56);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 30);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.LightGreen;
            this.btnSort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSort.Location = new System.Drawing.Point(269, 271);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(224, 49);
            this.btnSort.TabIndex = 33;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnAddAtBeginning
            // 
            this.btnAddAtBeginning.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddAtBeginning.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddAtBeginning.Location = new System.Drawing.Point(13, 103);
            this.btnAddAtBeginning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAtBeginning.Name = "btnAddAtBeginning";
            this.btnAddAtBeginning.Size = new System.Drawing.Size(224, 49);
            this.btnAddAtBeginning.TabIndex = 32;
            this.btnAddAtBeginning.Text = "Insert at beginning";
            this.btnAddAtBeginning.UseVisualStyleBackColor = false;
            this.btnAddAtBeginning.Click += new System.EventHandler(this.btnAddAtBeginning_Click);
            // 
            // btnAddAtEnd
            // 
            this.btnAddAtEnd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddAtEnd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddAtEnd.Location = new System.Drawing.Point(269, 103);
            this.btnAddAtEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAtEnd.Name = "btnAddAtEnd";
            this.btnAddAtEnd.Size = new System.Drawing.Size(224, 49);
            this.btnAddAtEnd.TabIndex = 31;
            this.btnAddAtEnd.Text = "Insert At End";
            this.btnAddAtEnd.UseVisualStyleBackColor = false;
            this.btnAddAtEnd.Click += new System.EventHandler(this.btnAddAtEnd_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(141, 56);
            this.txtData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(84, 22);
            this.txtData.TabIndex = 30;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput.Location = new System.Drawing.Point(9, 58);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(126, 23);
            this.lblinput.TabIndex = 29;
            this.lblinput.Text = "Nhập giá trị:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.flowLayoutPanel2.Controls.Add(this.pictureBox_logo);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 762);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1364, 28);
            this.flowLayoutPanel2.TabIndex = 28;
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.BackColor = System.Drawing.Color.White;
            this.pictureBox_logo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.ErrorImage")));
            this.pictureBox_logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.InitialImage")));
            this.pictureBox_logo.Location = new System.Drawing.Point(3, 2);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(77, 21);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 0;
            this.pictureBox_logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(754, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bui Quang Huy - 23110022  and  Nguyen Hang Hai Long - 23110036";
            // 
            // panel_logoandschoolname
            // 
            this.panel_logoandschoolname.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel_logoandschoolname.Controls.Add(this.lbl_schoolname);
            this.panel_logoandschoolname.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logoandschoolname.Location = new System.Drawing.Point(0, 0);
            this.panel_logoandschoolname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_logoandschoolname.Name = "panel_logoandschoolname";
            this.panel_logoandschoolname.Size = new System.Drawing.Size(1364, 30);
            this.panel_logoandschoolname.TabIndex = 27;
            // 
            // lbl_schoolname
            // 
            this.lbl_schoolname.AutoSize = true;
            this.lbl_schoolname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_schoolname.ForeColor = System.Drawing.Color.White;
            this.lbl_schoolname.Location = new System.Drawing.Point(3, 0);
            this.lbl_schoolname.Name = "lbl_schoolname";
            this.lbl_schoolname.Size = new System.Drawing.Size(212, 27);
            this.lbl_schoolname.TabIndex = 2;
            this.lbl_schoolname.Text = "Circular LinkedList";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(853, 62);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(84, 22);
            this.txtSearch.TabIndex = 38;
            // 
            // btnMergeLists
            // 
            this.btnMergeLists.BackColor = System.Drawing.Color.LightGreen;
            this.btnMergeLists.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnMergeLists.Location = new System.Drawing.Point(15, 212);
            this.btnMergeLists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMergeLists.Name = "btnMergeLists";
            this.btnMergeLists.Size = new System.Drawing.Size(224, 49);
            this.btnMergeLists.TabIndex = 42;
            this.btnMergeLists.Text = "Merge Lists";
            this.btnMergeLists.UseVisualStyleBackColor = false;
            this.btnMergeLists.Click += new System.EventHandler(this.btnMergeLists_Click);
            // 
            // btnRemoveAllNodes
            // 
            this.btnRemoveAllNodes.BackColor = System.Drawing.Color.LightGreen;
            this.btnRemoveAllNodes.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAllNodes.Location = new System.Drawing.Point(269, 212);
            this.btnRemoveAllNodes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveAllNodes.Name = "btnRemoveAllNodes";
            this.btnRemoveAllNodes.Size = new System.Drawing.Size(224, 49);
            this.btnRemoveAllNodes.TabIndex = 41;
            this.btnRemoveAllNodes.Text = "Remove All Nodes";
            this.btnRemoveAllNodes.UseVisualStyleBackColor = false;
            this.btnRemoveAllNodes.Click += new System.EventHandler(this.btnRemoveAllNodes_Click);
            // 
            // btnPrintList
            // 
            this.btnPrintList.BackColor = System.Drawing.Color.LightGreen;
            this.btnPrintList.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintList.Location = new System.Drawing.Point(15, 266);
            this.btnPrintList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintList.Name = "btnPrintList";
            this.btnPrintList.Size = new System.Drawing.Size(224, 49);
            this.btnPrintList.TabIndex = 40;
            this.btnPrintList.Text = "Print List";
            this.btnPrintList.UseVisualStyleBackColor = false;
            this.btnPrintList.Click += new System.EventHandler(this.btnPrintList_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.Color.LightGreen;
            this.btnReverse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnReverse.Location = new System.Drawing.Point(15, 338);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(224, 49);
            this.btnReverse.TabIndex = 39;
            this.btnReverse.Text = "Reverse List";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nhập giá trị cần tìm trong list:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(578, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Giá trị của node mà bạn muốn chèn node mới vào sau nó:";
            // 
            // txtAfterNode
            // 
            this.txtAfterNode.Location = new System.Drawing.Point(625, 413);
            this.txtAfterNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAfterNode.Name = "txtAfterNode";
            this.txtAfterNode.Size = new System.Drawing.Size(100, 22);
            this.txtAfterNode.TabIndex = 45;
            // 
            // btnInsertAfterNode
            // 
            this.btnInsertAfterNode.BackColor = System.Drawing.Color.LightGreen;
            this.btnInsertAfterNode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnInsertAfterNode.Location = new System.Drawing.Point(786, 405);
            this.btnInsertAfterNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertAfterNode.Name = "btnInsertAfterNode";
            this.btnInsertAfterNode.Size = new System.Drawing.Size(224, 28);
            this.btnInsertAfterNode.TabIndex = 46;
            this.btnInsertAfterNode.Text = "Insert After Node";
            this.btnInsertAfterNode.UseVisualStyleBackColor = false;
            this.btnInsertAfterNode.Click += new System.EventHandler(this.btnInsertAfterNode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "Giá trị của node mà bạn muốn xóa node phía sau nó:";
            // 
            // txtAfter
            // 
            this.txtAfter.Location = new System.Drawing.Point(625, 454);
            this.txtAfter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAfter.Name = "txtAfter";
            this.txtAfter.Size = new System.Drawing.Size(100, 22);
            this.txtAfter.TabIndex = 48;
            // 
            // btnRemoveAfterNode
            // 
            this.btnRemoveAfterNode.BackColor = System.Drawing.Color.LightGreen;
            this.btnRemoveAfterNode.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveAfterNode.Location = new System.Drawing.Point(786, 453);
            this.btnRemoveAfterNode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveAfterNode.Name = "btnRemoveAfterNode";
            this.btnRemoveAfterNode.Size = new System.Drawing.Size(224, 28);
            this.btnRemoveAfterNode.TabIndex = 49;
            this.btnRemoveAfterNode.Text = "Remove After Node";
            this.btnRemoveAfterNode.UseVisualStyleBackColor = false;
            this.btnRemoveAfterNode.Click += new System.EventHandler(this.btnRemoveAfterNode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 790);
            this.Controls.Add(this.btnRemoveAfterNode);
            this.Controls.Add(this.txtAfter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertAfterNode);
            this.Controls.Add(this.txtAfterNode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMergeLists);
            this.Controls.Add(this.btnRemoveAllNodes);
            this.Controls.Add(this.btnPrintList);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnRemoveFirst);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAddAtBeginning);
            this.Controls.Add(this.btnAddAtEnd);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblinput);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel_logoandschoolname);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.panel_logoandschoolname.ResumeLayout(false);
            this.panel_logoandschoolname.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnAddAtBeginning;
        private System.Windows.Forms.Button btnAddAtEnd;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panel_logoandschoolname;
        private System.Windows.Forms.Label lbl_schoolname;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnMergeLists;
        private System.Windows.Forms.Button btnRemoveAllNodes;
        private System.Windows.Forms.Button btnPrintList;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAfterNode;
        private System.Windows.Forms.Button btnInsertAfterNode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAfter;
        private System.Windows.Forms.Button btnRemoveAfterNode;
    }
}

