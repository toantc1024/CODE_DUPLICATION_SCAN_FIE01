namespace ProjectFinalDataStructure
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
            txtData = new TextBox();
            btnInsertBeginning = new Button();
            btnInsertAtEnd = new Button();
            label1 = new Label();
            label2 = new Label();
            btnRemoveFirst = new Button();
            btnRemoveLast = new Button();
            btnSearch = new Button();
            btnSelectionSort = new Button();
            btnRemoveAfter = new Button();
            btnInsertAfter = new Button();
            textBoxInsertAfter = new TextBox();
            SuspendLayout();
            // 
            // txtData
            // 
            txtData.Location = new Point(59, 90);
            txtData.Name = "txtData";
            txtData.Size = new Size(198, 27);
            txtData.TabIndex = 0;
            // 
            // btnInsertBeginning
            // 
            btnInsertBeginning.Location = new Point(233, 487);
            btnInsertBeginning.Name = "btnInsertBeginning";
            btnInsertBeginning.Size = new Size(135, 48);
            btnInsertBeginning.TabIndex = 1;
            btnInsertBeginning.Text = "Insert Beginning";
            btnInsertBeginning.UseVisualStyleBackColor = true;
            btnInsertBeginning.Click += btnInsertBeginning_Click;
            // 
            // btnInsertAtEnd
            // 
            btnInsertAtEnd.Location = new Point(374, 485);
            btnInsertAtEnd.Name = "btnInsertAtEnd";
            btnInsertAtEnd.Size = new Size(118, 48);
            btnInsertAtEnd.TabIndex = 3;
            btnInsertAtEnd.Text = "Insert At End";
            btnInsertAtEnd.UseVisualStyleBackColor = true;
            btnInsertAtEnd.Click += btnInsertAtEnd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(59, 55);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 5;
            label1.Text = "Input Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 140);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 6;
            label2.Text = "Output Data";
            // 
            // btnRemoveFirst
            // 
            btnRemoveFirst.Location = new Point(498, 539);
            btnRemoveFirst.Name = "btnRemoveFirst";
            btnRemoveFirst.Size = new Size(135, 48);
            btnRemoveFirst.TabIndex = 7;
            btnRemoveFirst.Text = "Remove First";
            btnRemoveFirst.UseVisualStyleBackColor = true;
            btnRemoveFirst.Click += btnRemoveFirst_Click;
            // 
            // btnRemoveLast
            // 
            btnRemoveLast.Location = new Point(374, 541);
            btnRemoveLast.Name = "btnRemoveLast";
            btnRemoveLast.Size = new Size(118, 48);
            btnRemoveLast.TabIndex = 8;
            btnRemoveLast.Text = "Remove Last";
            btnRemoveLast.UseVisualStyleBackColor = true;
            btnRemoveLast.Click += btnRemoveLast_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(263, 84);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 43);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSelectionSort
            // 
            btnSelectionSort.Location = new Point(498, 485);
            btnSelectionSort.Name = "btnSelectionSort";
            btnSelectionSort.Size = new Size(135, 48);
            btnSelectionSort.TabIndex = 10;
            btnSelectionSort.Text = "Selection Sort";
            btnSelectionSort.UseVisualStyleBackColor = true;
            btnSelectionSort.Click += btnSelectionSort_Click;
            // 
            // btnRemoveAfter
            // 
            btnRemoveAfter.Location = new Point(233, 539);
            btnRemoveAfter.Name = "btnRemoveAfter";
            btnRemoveAfter.Size = new Size(135, 48);
            btnRemoveAfter.TabIndex = 11;
            btnRemoveAfter.Text = "Remove After";
            btnRemoveAfter.UseVisualStyleBackColor = true;
            btnRemoveAfter.Click += btnRemoveAfter_Click;
            // 
            // btnInsertAfter
            // 
            btnInsertAfter.Location = new Point(573, 87);
            btnInsertAfter.Name = "btnInsertAfter";
            btnInsertAfter.Size = new Size(117, 40);
            btnInsertAfter.TabIndex = 12;
            btnInsertAfter.Text = " Insert After";
            btnInsertAfter.UseVisualStyleBackColor = true;
            btnInsertAfter.Click += btnInsertAfter_Click;
            // 
            // textBoxInsertAfter
            // 
            textBoxInsertAfter.Location = new Point(360, 87);
            textBoxInsertAfter.Name = "textBoxInsertAfter";
            textBoxInsertAfter.Size = new Size(198, 27);
            textBoxInsertAfter.TabIndex = 13;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 601);
            Controls.Add(textBoxInsertAfter);
            Controls.Add(btnInsertAfter);
            Controls.Add(btnRemoveAfter);
            Controls.Add(btnSelectionSort);
            Controls.Add(btnSearch);
            Controls.Add(btnRemoveLast);
            Controls.Add(btnRemoveFirst);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInsertAtEnd);
            Controls.Add(btnInsertBeginning);
            Controls.Add(txtData);
            MaximumSize = new Size(921, 648);
            MinimumSize = new Size(921, 648);
            Name = "MainForm";
            Text = "Circular Linked List";
            Load += MainForm_Load;
            Paint += MainForm_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtData;
        private Button btnInsertBeginning;
        private Button btnInsertAtEnd;
        private Label label1;
        private Label label2;
        private Button btnRemoveFirst;
        private Button btnRemoveLast;
        private Button btnSearch;
        private Button btnSelectionSort;
        private Button btnRemoveAfter;
        private Button btnInsertAfter;
        private TextBox textBoxInsertAfter;
    }
}