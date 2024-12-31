namespace ProjectFinalDataStructure
{
    partial class TreeForm
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
            textBoxInsert = new TextBox();
            btnInsert = new Button();
            btnSearch = new Button();
            lblHeight = new Label();
            lblLeafNodes = new Label();
            lblBranchNodes = new Label();
            lstTraversalResults = new ListBox();
            btnPreOrder = new Button();
            btnInOrder = new Button();
            btnPostOrder = new Button();
            button3 = new Button();
            Data = new Label();
            SuspendLayout();
            // 
            // textBoxInsert
            // 
            textBoxInsert.Location = new Point(99, 461);
            textBoxInsert.Name = "textBoxInsert";
            textBoxInsert.Size = new Size(125, 27);
            textBoxInsert.TabIndex = 0;
            textBoxInsert.TextChanged += textBoxInsert_TextChanged;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(242, 458);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 1;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(342, 461);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(31, 384);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(89, 20);
            lblHeight.TabIndex = 3;
            lblHeight.Text = "Tree Height:";
            // 
            // lblLeafNodes
            // 
            lblLeafNodes.AutoSize = true;
            lblLeafNodes.Location = new Point(169, 384);
            lblLeafNodes.Name = "lblLeafNodes";
            lblLeafNodes.Size = new Size(91, 20);
            lblLeafNodes.TabIndex = 4;
            lblLeafNodes.Text = "Leaf Nodes: ";
            // 
            // lblBranchNodes
            // 
            lblBranchNodes.AutoSize = true;
            lblBranchNodes.Location = new Point(292, 384);
            lblBranchNodes.Name = "lblBranchNodes";
            lblBranchNodes.Size = new Size(108, 20);
            lblBranchNodes.TabIndex = 5;
            lblBranchNodes.Text = "Branch Nodes: ";
            // 
            // lstTraversalResults
            // 
            lstTraversalResults.FormattingEnabled = true;
            lstTraversalResults.Location = new Point(850, 355);
            lstTraversalResults.Name = "lstTraversalResults";
            lstTraversalResults.Size = new Size(150, 184);
            lstTraversalResults.TabIndex = 8;
            // 
            // btnPreOrder
            // 
            btnPreOrder.Location = new Point(463, 460);
            btnPreOrder.Name = "btnPreOrder";
            btnPreOrder.Size = new Size(115, 29);
            btnPreOrder.TabIndex = 9;
            btnPreOrder.Text = "Pre Order";
            btnPreOrder.UseVisualStyleBackColor = true;
            btnPreOrder.Click += btnPreOrder_Click;
            // 
            // btnInOrder
            // 
            btnInOrder.Location = new Point(342, 494);
            btnInOrder.Name = "btnInOrder";
            btnInOrder.Size = new Size(115, 29);
            btnInOrder.TabIndex = 10;
            btnInOrder.Text = "In Order";
            btnInOrder.UseVisualStyleBackColor = true;
            btnInOrder.Click += btnInOrder_Click;
            // 
            // btnPostOrder
            // 
            btnPostOrder.Location = new Point(463, 494);
            btnPostOrder.Name = "btnPostOrder";
            btnPostOrder.Size = new Size(115, 29);
            btnPostOrder.TabIndex = 11;
            btnPostOrder.Text = "Post Order";
            btnPostOrder.UseVisualStyleBackColor = true;
            btnPostOrder.Click += btnPostOrder_Click;
            // 
            // button3
            // 
            button3.Location = new Point(242, 495);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Data
            // 
            Data.AutoSize = true;
            Data.Location = new Point(12, 459);
            Data.Name = "Data";
            Data.Size = new Size(79, 20);
            Data.TabIndex = 13;
            Data.Text = "Input Data";
            // 
            // TreeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 561);
            Controls.Add(Data);
            Controls.Add(button3);
            Controls.Add(btnPostOrder);
            Controls.Add(btnInOrder);
            Controls.Add(btnPreOrder);
            Controls.Add(lstTraversalResults);
            Controls.Add(lblBranchNodes);
            Controls.Add(lblLeafNodes);
            Controls.Add(lblHeight);
            Controls.Add(btnSearch);
            Controls.Add(btnInsert);
            Controls.Add(textBoxInsert);
            Name = "TreeForm";
            Text = "TreeForm";
            Load += TreeForm_Load;
            Paint += MainForm_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInsert;
        private Button btnInsert;
        private Button btnSearch;
        private Label lblHeight;
        private Label lblLeafNodes;
        private Label lblBranchNodes;
        private ListBox lstTraversalResults;
        private Button btnPreOrder;
        private Button btnInOrder;
        private Button btnPostOrder;
        private Button button3;
        private Label Data;
    }
}