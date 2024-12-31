namespace ProjectFinal2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.controls = new System.Windows.Forms.GroupBox();
            this.btn_removeall = new System.Windows.Forms.Button();
            this.btn_addbook = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_searchcriteria = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_removeafter = new System.Windows.Forms.Button();
            this.btn_removelast = new System.Windows.Forms.Button();
            this.btn_removefirst = new System.Windows.Forms.Button();
            this.btn_insertafter = new System.Windows.Forms.Button();
            this.btn_insertend = new System.Windows.Forms.Button();
            this.btn_insertbegin = new System.Windows.Forms.Button();
            this.controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(267, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(608, 504);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // controls
            // 
            this.controls.Controls.Add(this.btn_removeall);
            this.controls.Controls.Add(this.btn_addbook);
            this.controls.Controls.Add(this.btn_sort);
            this.controls.Controls.Add(this.btn_print);
            this.controls.Controls.Add(this.btn_searchcriteria);
            this.controls.Controls.Add(this.btn_search);
            this.controls.Controls.Add(this.btn_removeafter);
            this.controls.Controls.Add(this.btn_removelast);
            this.controls.Controls.Add(this.btn_removefirst);
            this.controls.Controls.Add(this.btn_insertafter);
            this.controls.Controls.Add(this.btn_insertend);
            this.controls.Controls.Add(this.btn_insertbegin);
            this.controls.Location = new System.Drawing.Point(13, 13);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(248, 469);
            this.controls.TabIndex = 1;
            this.controls.TabStop = false;
            this.controls.Text = "Controls";
            // 
            // btn_removeall
            // 
            this.btn_removeall.Location = new System.Drawing.Point(6, 395);
            this.btn_removeall.Name = "btn_removeall";
            this.btn_removeall.Size = new System.Drawing.Size(93, 54);
            this.btn_removeall.TabIndex = 11;
            this.btn_removeall.Text = "Remove All";
            this.btn_removeall.UseVisualStyleBackColor = true;
            this.btn_removeall.Click += new System.EventHandler(this.btn_removeall_Click);
            // 
            // btn_addbook
            // 
            this.btn_addbook.Location = new System.Drawing.Point(135, 395);
            this.btn_addbook.Name = "btn_addbook";
            this.btn_addbook.Size = new System.Drawing.Size(93, 54);
            this.btn_addbook.TabIndex = 10;
            this.btn_addbook.Text = "Add Book";
            this.btn_addbook.UseVisualStyleBackColor = true;
            this.btn_addbook.Click += new System.EventHandler(this.btn_addbook_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(135, 322);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(93, 54);
            this.btn_sort.TabIndex = 9;
            this.btn_sort.Text = "Sort By Title";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(135, 243);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(93, 54);
            this.btn_print.TabIndex = 8;
            this.btn_print.Text = "Print List";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_searchcriteria
            // 
            this.btn_searchcriteria.Location = new System.Drawing.Point(135, 171);
            this.btn_searchcriteria.Name = "btn_searchcriteria";
            this.btn_searchcriteria.Size = new System.Drawing.Size(93, 54);
            this.btn_searchcriteria.TabIndex = 7;
            this.btn_searchcriteria.Text = "Search by Criteria";
            this.btn_searchcriteria.UseVisualStyleBackColor = true;
            this.btn_searchcriteria.Click += new System.EventHandler(this.btn_searchcriteria_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(135, 103);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(93, 54);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_removeafter
            // 
            this.btn_removeafter.Location = new System.Drawing.Point(135, 25);
            this.btn_removeafter.Name = "btn_removeafter";
            this.btn_removeafter.Size = new System.Drawing.Size(93, 54);
            this.btn_removeafter.TabIndex = 5;
            this.btn_removeafter.Text = "Remove After";
            this.btn_removeafter.UseVisualStyleBackColor = true;
            this.btn_removeafter.Click += new System.EventHandler(this.btn_removeafter_Click);
            // 
            // btn_removelast
            // 
            this.btn_removelast.Location = new System.Drawing.Point(6, 322);
            this.btn_removelast.Name = "btn_removelast";
            this.btn_removelast.Size = new System.Drawing.Size(93, 54);
            this.btn_removelast.TabIndex = 4;
            this.btn_removelast.Text = "Remove Last";
            this.btn_removelast.UseVisualStyleBackColor = true;
            this.btn_removelast.Click += new System.EventHandler(this.btn_removelast_Click);
            // 
            // btn_removefirst
            // 
            this.btn_removefirst.Location = new System.Drawing.Point(6, 243);
            this.btn_removefirst.Name = "btn_removefirst";
            this.btn_removefirst.Size = new System.Drawing.Size(93, 54);
            this.btn_removefirst.TabIndex = 3;
            this.btn_removefirst.Text = "Remove First";
            this.btn_removefirst.UseVisualStyleBackColor = true;
            this.btn_removefirst.Click += new System.EventHandler(this.btn_removefirst_Click);
            // 
            // btn_insertafter
            // 
            this.btn_insertafter.Location = new System.Drawing.Point(6, 171);
            this.btn_insertafter.Name = "btn_insertafter";
            this.btn_insertafter.Size = new System.Drawing.Size(93, 54);
            this.btn_insertafter.TabIndex = 2;
            this.btn_insertafter.Text = "Insert After";
            this.btn_insertafter.UseVisualStyleBackColor = true;
            this.btn_insertafter.Click += new System.EventHandler(this.btn_insertafter_Click);
            // 
            // btn_insertend
            // 
            this.btn_insertend.Location = new System.Drawing.Point(6, 103);
            this.btn_insertend.Name = "btn_insertend";
            this.btn_insertend.Size = new System.Drawing.Size(93, 54);
            this.btn_insertend.TabIndex = 1;
            this.btn_insertend.Text = "Insert At End";
            this.btn_insertend.UseVisualStyleBackColor = true;
            this.btn_insertend.Click += new System.EventHandler(this.btn_insertend_Click);
            // 
            // btn_insertbegin
            // 
            this.btn_insertbegin.Location = new System.Drawing.Point(6, 25);
            this.btn_insertbegin.Name = "btn_insertbegin";
            this.btn_insertbegin.Size = new System.Drawing.Size(93, 54);
            this.btn_insertbegin.TabIndex = 0;
            this.btn_insertbegin.Text = "Insert At Beginning";
            this.btn_insertbegin.UseVisualStyleBackColor = true;
            this.btn_insertbegin.Click += new System.EventHandler(this.btn_insertbegin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 527);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox controls;
        private System.Windows.Forms.Button btn_insertend;
        private System.Windows.Forms.Button btn_insertbegin;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_searchcriteria;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_removeafter;
        private System.Windows.Forms.Button btn_removelast;
        private System.Windows.Forms.Button btn_removefirst;
        private System.Windows.Forms.Button btn_insertafter;
        private System.Windows.Forms.Button btn_addbook;
        private System.Windows.Forms.Button btn_removeall;
    }
}

