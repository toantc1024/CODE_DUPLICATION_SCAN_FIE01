namespace Exercise3
{
    partial class LibraryBookCatalog
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
            this.IBGB = new System.Windows.Forms.GroupBox();
            this.DisplayBooksBT = new System.Windows.Forms.Button();
            this.GenreTB = new System.Windows.Forms.TextBox();
            this.GenreLB = new System.Windows.Forms.Label();
            this.SearchBT = new System.Windows.Forms.Button();
            this.DoneBT = new System.Windows.Forms.Button();
            this.PublishedYearPicker = new System.Windows.Forms.DateTimePicker();
            this.EditBT = new System.Windows.Forms.Button();
            this.DeleteBT = new System.Windows.Forms.Button();
            this.AddBT = new System.Windows.Forms.Button();
            this.AuthorTB = new System.Windows.Forms.TextBox();
            this.BookTittleTB = new System.Windows.Forms.TextBox();
            this.BookIDTB = new System.Windows.Forms.TextBox();
            this.AuthorLB = new System.Windows.Forms.Label();
            this.PulishedYearLB = new System.Windows.Forms.Label();
            this.BookTittleLB = new System.Windows.Forms.Label();
            this.BookIDLB = new System.Windows.Forms.Label();
            this.BooksListBox = new System.Windows.Forms.ListBox();
            this.IBGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // IBGB
            // 
            this.IBGB.Controls.Add(this.DisplayBooksBT);
            this.IBGB.Controls.Add(this.GenreTB);
            this.IBGB.Controls.Add(this.GenreLB);
            this.IBGB.Controls.Add(this.SearchBT);
            this.IBGB.Controls.Add(this.DoneBT);
            this.IBGB.Controls.Add(this.PublishedYearPicker);
            this.IBGB.Controls.Add(this.EditBT);
            this.IBGB.Controls.Add(this.DeleteBT);
            this.IBGB.Controls.Add(this.AddBT);
            this.IBGB.Controls.Add(this.AuthorTB);
            this.IBGB.Controls.Add(this.BookTittleTB);
            this.IBGB.Controls.Add(this.BookIDTB);
            this.IBGB.Controls.Add(this.AuthorLB);
            this.IBGB.Controls.Add(this.PulishedYearLB);
            this.IBGB.Controls.Add(this.BookTittleLB);
            this.IBGB.Controls.Add(this.BookIDLB);
            this.IBGB.Location = new System.Drawing.Point(13, 13);
            this.IBGB.Margin = new System.Windows.Forms.Padding(4);
            this.IBGB.Name = "IBGB";
            this.IBGB.Padding = new System.Windows.Forms.Padding(4);
            this.IBGB.Size = new System.Drawing.Size(658, 240);
            this.IBGB.TabIndex = 2;
            this.IBGB.TabStop = false;
            this.IBGB.Text = "Information of Book";
            // 
            // DisplayBooksBT
            // 
            this.DisplayBooksBT.Location = new System.Drawing.Point(372, 165);
            this.DisplayBooksBT.Margin = new System.Windows.Forms.Padding(4);
            this.DisplayBooksBT.Name = "DisplayBooksBT";
            this.DisplayBooksBT.Size = new System.Drawing.Size(100, 28);
            this.DisplayBooksBT.TabIndex = 24;
            this.DisplayBooksBT.Text = "Books Info";
            this.DisplayBooksBT.UseVisualStyleBackColor = true;
            this.DisplayBooksBT.Click += new System.EventHandler(this.DisplayBooksBT_Click);
            // 
            // GenreTB
            // 
            this.GenreTB.Location = new System.Drawing.Point(143, 187);
            this.GenreTB.Margin = new System.Windows.Forms.Padding(4);
            this.GenreTB.Name = "GenreTB";
            this.GenreTB.Size = new System.Drawing.Size(187, 22);
            this.GenreTB.TabIndex = 23;
            // 
            // GenreLB
            // 
            this.GenreLB.AutoSize = true;
            this.GenreLB.Location = new System.Drawing.Point(60, 187);
            this.GenreLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLB.Name = "GenreLB";
            this.GenreLB.Size = new System.Drawing.Size(47, 16);
            this.GenreLB.TabIndex = 22;
            this.GenreLB.Text = "Genre:";
            // 
            // SearchBT
            // 
            this.SearchBT.Location = new System.Drawing.Point(507, 114);
            this.SearchBT.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(100, 28);
            this.SearchBT.TabIndex = 21;
            this.SearchBT.Text = "Search";
            this.SearchBT.UseVisualStyleBackColor = true;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // DoneBT
            // 
            this.DoneBT.Location = new System.Drawing.Point(507, 165);
            this.DoneBT.Margin = new System.Windows.Forms.Padding(4);
            this.DoneBT.Name = "DoneBT";
            this.DoneBT.Size = new System.Drawing.Size(100, 28);
            this.DoneBT.TabIndex = 20;
            this.DoneBT.Text = "Done";
            this.DoneBT.UseVisualStyleBackColor = true;
            this.DoneBT.Click += new System.EventHandler(this.DoneBT_Click);
            // 
            // PublishedYearPicker
            // 
            this.PublishedYearPicker.CustomFormat = "yyyy";
            this.PublishedYearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PublishedYearPicker.Location = new System.Drawing.Point(494, 12);
            this.PublishedYearPicker.Margin = new System.Windows.Forms.Padding(4);
            this.PublishedYearPicker.Name = "PublishedYearPicker";
            this.PublishedYearPicker.ShowUpDown = true;
            this.PublishedYearPicker.Size = new System.Drawing.Size(113, 22);
            this.PublishedYearPicker.TabIndex = 18;
            this.PublishedYearPicker.Value = new System.DateTime(2024, 12, 20, 0, 0, 0, 0);
            // 
            // EditBT
            // 
            this.EditBT.Location = new System.Drawing.Point(371, 114);
            this.EditBT.Margin = new System.Windows.Forms.Padding(4);
            this.EditBT.Name = "EditBT";
            this.EditBT.Size = new System.Drawing.Size(100, 28);
            this.EditBT.TabIndex = 13;
            this.EditBT.Text = "Edit";
            this.EditBT.UseVisualStyleBackColor = true;
            this.EditBT.Click += new System.EventHandler(this.EditBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.Location = new System.Drawing.Point(507, 66);
            this.DeleteBT.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(100, 28);
            this.DeleteBT.TabIndex = 12;
            this.DeleteBT.Text = "Delete";
            this.DeleteBT.UseVisualStyleBackColor = true;
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // AddBT
            // 
            this.AddBT.Location = new System.Drawing.Point(371, 66);
            this.AddBT.Margin = new System.Windows.Forms.Padding(4);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(100, 28);
            this.AddBT.TabIndex = 11;
            this.AddBT.Text = "Add";
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // AuthorTB
            // 
            this.AuthorTB.Location = new System.Drawing.Point(143, 136);
            this.AuthorTB.Margin = new System.Windows.Forms.Padding(4);
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(187, 22);
            this.AuthorTB.TabIndex = 10;
            // 
            // BookTittleTB
            // 
            this.BookTittleTB.Location = new System.Drawing.Point(143, 84);
            this.BookTittleTB.Margin = new System.Windows.Forms.Padding(4);
            this.BookTittleTB.Name = "BookTittleTB";
            this.BookTittleTB.Size = new System.Drawing.Size(187, 22);
            this.BookTittleTB.TabIndex = 7;
            // 
            // BookIDTB
            // 
            this.BookIDTB.Location = new System.Drawing.Point(143, 36);
            this.BookIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.BookIDTB.Name = "BookIDTB";
            this.BookIDTB.Size = new System.Drawing.Size(187, 22);
            this.BookIDTB.TabIndex = 6;
            // 
            // AuthorLB
            // 
            this.AuthorLB.AutoSize = true;
            this.AuthorLB.Location = new System.Drawing.Point(60, 136);
            this.AuthorLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorLB.Name = "AuthorLB";
            this.AuthorLB.Size = new System.Drawing.Size(48, 16);
            this.AuthorLB.TabIndex = 5;
            this.AuthorLB.Text = "Author:";
            // 
            // PulishedYearLB
            // 
            this.PulishedYearLB.AutoSize = true;
            this.PulishedYearLB.Location = new System.Drawing.Point(369, 17);
            this.PulishedYearLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PulishedYearLB.Name = "PulishedYearLB";
            this.PulishedYearLB.Size = new System.Drawing.Size(102, 16);
            this.PulishedYearLB.TabIndex = 3;
            this.PulishedYearLB.Text = "Published Year:";
            // 
            // BookTittleLB
            // 
            this.BookTittleLB.AutoSize = true;
            this.BookTittleLB.Location = new System.Drawing.Point(60, 88);
            this.BookTittleLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookTittleLB.Name = "BookTittleLB";
            this.BookTittleLB.Size = new System.Drawing.Size(74, 16);
            this.BookTittleLB.TabIndex = 1;
            this.BookTittleLB.Text = "Book Tittle:";
            // 
            // BookIDLB
            // 
            this.BookIDLB.AutoSize = true;
            this.BookIDLB.Location = new System.Drawing.Point(60, 39);
            this.BookIDLB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookIDLB.Name = "BookIDLB";
            this.BookIDLB.Size = new System.Drawing.Size(58, 16);
            this.BookIDLB.TabIndex = 0;
            this.BookIDLB.Text = "Book ID:";
            // 
            // BooksListBox
            // 
            this.BooksListBox.FormattingEnabled = true;
            this.BooksListBox.ItemHeight = 16;
            this.BooksListBox.Location = new System.Drawing.Point(13, 260);
            this.BooksListBox.Name = "BooksListBox";
            this.BooksListBox.Size = new System.Drawing.Size(663, 276);
            this.BooksListBox.TabIndex = 3;
            // 
            // LibraryBookCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 552);
            this.Controls.Add(this.BooksListBox);
            this.Controls.Add(this.IBGB);
            this.Name = "LibraryBookCatalog";
            this.Text = "LibraryBookCatalog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.IBGB.ResumeLayout(false);
            this.IBGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox IBGB;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.Button DoneBT;
        private System.Windows.Forms.DateTimePicker PublishedYearPicker;
        private System.Windows.Forms.Button EditBT;
        private System.Windows.Forms.Button DeleteBT;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.TextBox AuthorTB;
        private System.Windows.Forms.TextBox BookTittleTB;
        private System.Windows.Forms.TextBox BookIDTB;
        private System.Windows.Forms.Label AuthorLB;
        private System.Windows.Forms.Label PulishedYearLB;
        private System.Windows.Forms.Label BookTittleLB;
        private System.Windows.Forms.Label BookIDLB;
        private System.Windows.Forms.TextBox GenreTB;
        private System.Windows.Forms.Label GenreLB;
        private System.Windows.Forms.Button DisplayBooksBT;
        private System.Windows.Forms.ListBox BooksListBox;
    }
}

