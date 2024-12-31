namespace CircularListManager
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
            this.txtProductCount = new System.Windows.Forms.TextBox();
            this.btnInitializeList = new System.Windows.Forms.Button();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFirst = new System.Windows.Forms.Button();
            this.btnAddLast = new System.Windows.Forms.Button();
            this.btnAddAfter = new System.Windows.Forms.Button();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnRemoveAfter = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnReverseList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxSecondList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtProductCount
            // 
            this.txtProductCount.Location = new System.Drawing.Point(15, 54);
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.Size = new System.Drawing.Size(155, 22);
            this.txtProductCount.TabIndex = 0;
            this.txtProductCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnInitializeList
            // 
            this.btnInitializeList.Location = new System.Drawing.Point(182, 36);
            this.btnInitializeList.Name = "btnInitializeList";
            this.btnInitializeList.Size = new System.Drawing.Size(128, 40);
            this.btnInitializeList.TabIndex = 1;
            this.btnInitializeList.Text = "Initialize List";
            this.btnInitializeList.UseVisualStyleBackColor = true;
            this.btnInitializeList.Click += new System.EventHandler(this.btnInitializeList_Click);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(12, 127);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.ScrollAlwaysVisible = true;
            this.listBoxProducts.Size = new System.Drawing.Size(298, 356);
            this.listBoxProducts.TabIndex = 2;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter number of products:";
            // 
            // btnAddFirst
            // 
            this.btnAddFirst.Location = new System.Drawing.Point(381, 36);
            this.btnAddFirst.Name = "btnAddFirst";
            this.btnAddFirst.Size = new System.Drawing.Size(75, 40);
            this.btnAddFirst.TabIndex = 4;
            this.btnAddFirst.Text = "AddFirst";
            this.btnAddFirst.UseVisualStyleBackColor = true;
            this.btnAddFirst.Click += new System.EventHandler(this.btnAddFirst_Click);
            // 
            // btnAddLast
            // 
            this.btnAddLast.Location = new System.Drawing.Point(381, 116);
            this.btnAddLast.Name = "btnAddLast";
            this.btnAddLast.Size = new System.Drawing.Size(75, 40);
            this.btnAddLast.TabIndex = 5;
            this.btnAddLast.Text = "AddLast";
            this.btnAddLast.UseVisualStyleBackColor = true;
            this.btnAddLast.Click += new System.EventHandler(this.btnAddLast_Click);
            // 
            // btnAddAfter
            // 
            this.btnAddAfter.Location = new System.Drawing.Point(381, 206);
            this.btnAddAfter.Name = "btnAddAfter";
            this.btnAddAfter.Size = new System.Drawing.Size(75, 40);
            this.btnAddAfter.TabIndex = 6;
            this.btnAddAfter.Text = "AddAfter";
            this.btnAddAfter.UseVisualStyleBackColor = true;
            this.btnAddAfter.Click += new System.EventHandler(this.btnAddAfter_Click);
            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.Location = new System.Drawing.Point(492, 36);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(102, 40);
            this.btnRemoveFirst.TabIndex = 7;
            this.btnRemoveFirst.Text = "RemoveFirst";
            this.btnRemoveFirst.UseVisualStyleBackColor = true;
            this.btnRemoveFirst.Click += new System.EventHandler(this.btnRemoveFirst_Click);
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Location = new System.Drawing.Point(492, 116);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(102, 40);
            this.btnRemoveLast.TabIndex = 8;
            this.btnRemoveLast.Text = "RemoveLast";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // btnRemoveAfter
            // 
            this.btnRemoveAfter.Location = new System.Drawing.Point(492, 206);
            this.btnRemoveAfter.Name = "btnRemoveAfter";
            this.btnRemoveAfter.Size = new System.Drawing.Size(102, 40);
            this.btnRemoveAfter.TabIndex = 9;
            this.btnRemoveAfter.Text = "RemoveAfter";
            this.btnRemoveAfter.UseVisualStyleBackColor = true;
            this.btnRemoveAfter.Click += new System.EventHandler(this.btnRemoveAfter_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(366, 346);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(120, 51);
            this.btnQuickSort.TabIndex = 10;
            this.btnQuickSort.Text = "QuickSort        Descending Sort.";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(492, 346);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(125, 51);
            this.btnSelectionSort.TabIndex = 11;
            this.btnSelectionSort.Text = "SelectionSort       Ascending Sort.";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnReverseList
            // 
            this.btnReverseList.Location = new System.Drawing.Point(366, 443);
            this.btnReverseList.Name = "btnReverseList";
            this.btnReverseList.Size = new System.Drawing.Size(120, 40);
            this.btnReverseList.TabIndex = 12;
            this.btnReverseList.Text = "ReverseList";
            this.btnReverseList.UseVisualStyleBackColor = true;
            this.btnReverseList.Click += new System.EventHandler(this.btnReverseList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "main list";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(677, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "main list";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "second list";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(674, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter number of second list";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(878, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Initialize List";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBoxSecondList
            // 
            this.listBoxSecondList.FormattingEnabled = true;
            this.listBoxSecondList.ItemHeight = 16;
            this.listBoxSecondList.Location = new System.Drawing.Point(725, 127);
            this.listBoxSecondList.Name = "listBoxSecondList";
            this.listBoxSecondList.Size = new System.Drawing.Size(266, 356);
            this.listBoxSecondList.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 762);
            this.Controls.Add(this.listBoxSecondList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReverseList);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnRemoveAfter);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnRemoveFirst);
            this.Controls.Add(this.btnAddAfter);
            this.Controls.Add(this.btnAddLast);
            this.Controls.Add(this.btnAddFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.btnInitializeList);
            this.Controls.Add(this.txtProductCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductCount;
        private System.Windows.Forms.Button btnInitializeList;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFirst;
        private System.Windows.Forms.Button btnAddLast;
        private System.Windows.Forms.Button btnAddAfter;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnRemoveAfter;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnReverseList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxSecondList;
    }
}

