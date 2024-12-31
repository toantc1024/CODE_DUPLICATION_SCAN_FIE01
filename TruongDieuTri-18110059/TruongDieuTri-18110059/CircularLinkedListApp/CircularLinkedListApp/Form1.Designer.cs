namespace CircularLinkedListApp
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnAddFirst = new System.Windows.Forms.Button();
            this.btnAddLast = new System.Windows.Forms.Button();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(30, 20);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(300, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(30, 150);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(400, 200);
            this.lstDisplay.TabIndex = 1;
            // 
            // btnAddFirst
            // 
            this.btnAddFirst.Location = new System.Drawing.Point(30, 60);
            this.btnAddFirst.Name = "btnAddFirst";
            this.btnAddFirst.Size = new System.Drawing.Size(100, 30);
            this.btnAddFirst.TabIndex = 2;
            this.btnAddFirst.Text = "Add First";
            this.btnAddFirst.UseVisualStyleBackColor = true;
            this.btnAddFirst.Click += new System.EventHandler(this.btnAddFirst_Click);
            // 
            // btnAddLast
            // 
            this.btnAddLast.Location = new System.Drawing.Point(150, 60);
            this.btnAddLast.Name = "btnAddLast";
            this.btnAddLast.Size = new System.Drawing.Size(100, 30);
            this.btnAddLast.TabIndex = 3;
            this.btnAddLast.Text = "Add Last";
            this.btnAddLast.UseVisualStyleBackColor = true;
            this.btnAddLast.Click += new System.EventHandler(this.btnAddLast_Click);
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.Location = new System.Drawing.Point(30, 100);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveFirst.TabIndex = 4;
            this.btnRemoveFirst.Text = "Remove First";
            this.btnRemoveFirst.UseVisualStyleBackColor = true;
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Location = new System.Drawing.Point(150, 100);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveLast.TabIndex = 5;
            this.btnRemoveLast.Text = "Remove Last";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(270, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnRemoveFirst);
            this.Controls.Add(this.btnAddLast);
            this.Controls.Add(this.btnAddFirst);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Circular Linked List";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnAddFirst;
        private System.Windows.Forms.Button btnAddLast;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnSearch;
    }
}
