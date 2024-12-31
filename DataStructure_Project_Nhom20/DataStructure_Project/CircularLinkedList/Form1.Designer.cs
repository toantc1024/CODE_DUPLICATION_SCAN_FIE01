namespace CircularLinkedListApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnInsertAtBeginning;
        private System.Windows.Forms.Button btnInsertAtEnd;
        private System.Windows.Forms.Button btnRemoveFirst;
        private System.Windows.Forms.Button btnRemoveLast;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInsertAfter; // Nút Insert After
        private System.Windows.Forms.Button btnRemoveAfter; // Nút Remove After
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cmbLists;  
        private System.Windows.Forms.Button btnCreateNewList;  
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.TextBox lbTarget;  // TextBox nhập giá trị mục tiêu cho Insert After và Remove After
        private System.Windows.Forms.Button BtnSelectionSort;
        private System.Windows.Forms.Button BtnQuickSort;
        private System.Windows.Forms.Button BtnMergeLists;
        private System.Windows.Forms.Button BtnSearchFromCriteria;
        private System.Windows.Forms.Button BtnRemoveAllCriteria;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsertAtBeginning = new System.Windows.Forms.Button();
            this.btnInsertAtEnd = new System.Windows.Forms.Button();
            this.btnRemoveFirst = new System.Windows.Forms.Button();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsertAfter = new System.Windows.Forms.Button(); // Khởi tạo nút Insert After
            this.btnRemoveAfter = new System.Windows.Forms.Button(); // Khởi tạo nút Remove After
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.cmbLists = new System.Windows.Forms.ComboBox();  
            this.btnCreateNewList = new System.Windows.Forms.Button();  
            this.txtTarget = new System.Windows.Forms.TextBox(); // Khởi tạo TextBox nhập giá trị mục tiêu
            this.lbTarget =new System.Windows.Forms.TextBox();
            this.BtnSelectionSort= new System.Windows.Forms.Button();
            this.BtnQuickSort= new System.Windows.Forms.Button();
            this.BtnMergeLists= new System.Windows.Forms.Button();
            this.BtnSearchFromCriteria= new System.Windows.Forms.Button();
            this.BtnRemoveAllCriteria= new System.Windows.Forms.Button();


            this.SuspendLayout();
            
            // 
            // btnInsertAtBeginning
            // 
            this.btnInsertAtBeginning.Location = new System.Drawing.Point(12, 50);
            this.btnInsertAtBeginning.Name = "btnInsertAtBeginning";
            this.btnInsertAtBeginning.Size = new System.Drawing.Size(150, 23);
            this.btnInsertAtBeginning.TabIndex = 0;
            this.btnInsertAtBeginning.Text = "Insert at Beginning";
            this.btnInsertAtBeginning.UseVisualStyleBackColor = true;
            this.btnInsertAtBeginning.Click += new System.EventHandler(this.BtnInsertAtBeginning_Click);

            // 
            // btnInsertAtEnd
            // 
            this.btnInsertAtEnd.Location = new System.Drawing.Point(12, 80);
            this.btnInsertAtEnd.Name = "btnInsertAtEnd";
            this.btnInsertAtEnd.Size = new System.Drawing.Size(150, 23);
            this.btnInsertAtEnd.TabIndex = 1;
            this.btnInsertAtEnd.Text = "Insert at End";
            this.btnInsertAtEnd.UseVisualStyleBackColor = true;
            this.btnInsertAtEnd.Click += new System.EventHandler(this.BtnInsertAtEnd_Click);

            // 
            // btnRemoveFirst
            // 
            this.btnRemoveFirst.Location = new System.Drawing.Point(12, 110);
            this.btnRemoveFirst.Name = "btnRemoveFirst";
            this.btnRemoveFirst.Size = new System.Drawing.Size(150, 23);
            this.btnRemoveFirst.TabIndex = 2;
            this.btnRemoveFirst.Text = "Remove First";
            this.btnRemoveFirst.UseVisualStyleBackColor = true;
            this.btnRemoveFirst.Click += new System.EventHandler(this.BtnRemoveFirst_Click);

            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Location = new System.Drawing.Point(12, 140);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(150, 23);
            this.btnRemoveLast.TabIndex = 3;
            this.btnRemoveLast.Text = "Remove Last";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.BtnRemoveLast_Click);

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 170);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);

            // 
            // btnInsertAfter
            // 
            this.btnInsertAfter.Location = new System.Drawing.Point(12, 200);
            this.btnInsertAfter.Name = "btnInsertAfter";
            this.btnInsertAfter.Size = new System.Drawing.Size(150, 23);
            this.btnInsertAfter.TabIndex = 5;
            this.btnInsertAfter.Text = "Insert After";
            this.btnInsertAfter.UseVisualStyleBackColor = true;
            this.btnInsertAfter.Click += new System.EventHandler(this.BtnInsertAfter_Click); // Thêm sự kiện cho Insert After

            // 
            // btnRemoveAfter
            // 
            this.btnRemoveAfter.Location = new System.Drawing.Point(12, 230);
            this.btnRemoveAfter.Name = "btnRemoveAfter";
            this.btnRemoveAfter.Size = new System.Drawing.Size(150, 23);
            this.btnRemoveAfter.TabIndex = 6;
            this.btnRemoveAfter.Text = "Remove After";
            this.btnRemoveAfter.UseVisualStyleBackColor = true;
            this.btnRemoveAfter.Click += new System.EventHandler(this.BtnRemoveAfter_Click); // Thêm sự kiện cho Remove After

            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(170, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 7;
            //
            // lbTarget
            //
            this.lbTarget.Location= new System.Drawing.Point(400,200);
            this.lbTarget.Text="Target:";
            this.lbTarget.Size = new System.Drawing.Size(100, 20);
            this.lbTarget.TabIndex = 8;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(400, 50); // Vị trí TextBox cho giá trị mục tiêu
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(100, 20);
            this.txtTarget.TabIndex = 9;

            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(170, 80);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(200, 160);
            this.lstItems.TabIndex = 10;

            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(170, 250);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 11;

            // 
            // cmbLists
            // 
            this.cmbLists.FormattingEnabled = true;
            this.cmbLists.Location = new System.Drawing.Point(12, 260);
            this.cmbLists.Name = "cmbLists";
            this.cmbLists.Size = new System.Drawing.Size(150, 21);
            this.cmbLists.TabIndex = 12;
            this.cmbLists.SelectedIndexChanged += new System.EventHandler(this.CmbLists_SelectedIndexChanged);

            // 
            // btnCreateNewList
            // 
            this.btnCreateNewList.Location = new System.Drawing.Point(12, 290);
            this.btnCreateNewList.Name = "btnCreateNewList";
            this.btnCreateNewList.Size = new System.Drawing.Size(150, 23);
            this.btnCreateNewList.TabIndex = 13;
            this.btnCreateNewList.Text = "Create New List";
            this.btnCreateNewList.UseVisualStyleBackColor = true;
            this.btnCreateNewList.Click += new System.EventHandler(this.BtnCreateNewList_Click);
            // 
    // BtnSelectionSort
    // 
    this.BtnSelectionSort = new System.Windows.Forms.Button();
    this.BtnSelectionSort.Location = new System.Drawing.Point(12, 320);
    this.BtnSelectionSort.Name = "BtnSelectionSort";
    this.BtnSelectionSort.Size = new System.Drawing.Size(75, 23);
    this.BtnSelectionSort.TabIndex = 10;
    this.BtnSelectionSort.Text = "Selection Sort";
    this.BtnSelectionSort.UseVisualStyleBackColor = true;
    this.BtnSelectionSort.Click += new System.EventHandler(this.BtnSelectionSort_Click);
    
    // 
    // BtnQuickSort
    // 
    this.BtnQuickSort = new System.Windows.Forms.Button();
    this.BtnQuickSort.Location = new System.Drawing.Point(12, 350);
    this.BtnQuickSort.Name = "BtnQuickSort";
    this.BtnQuickSort.Size = new System.Drawing.Size(75, 23);
    this.BtnQuickSort.TabIndex = 11;
    this.BtnQuickSort.Text = "Quick Sort";
    this.BtnQuickSort.UseVisualStyleBackColor = true;
    this.BtnQuickSort.Click += new System.EventHandler(this.BtnQuickSort_Click);

    // 
    // BtnMergeLists
    // 
    this.BtnMergeLists = new System.Windows.Forms.Button();
    this.BtnMergeLists.Location = new System.Drawing.Point(12, 380);
    this.BtnMergeLists.Name = "BtnMergeLists";
    this.BtnMergeLists.Size = new System.Drawing.Size(75, 23);
    this.BtnMergeLists.TabIndex = 12;
    this.BtnMergeLists.Text = "Merge Lists";
    this.BtnMergeLists.UseVisualStyleBackColor = true;
    this.BtnMergeLists.Click += new System.EventHandler(this.BtnMergeLists_Click);
    //
    // BtnSearchFromCriteria
    //
    this.BtnSearchFromCriteria = new System.Windows.Forms.Button();
    this.BtnSearchFromCriteria.Location = new System.Drawing.Point(12, 420);
    this.BtnSearchFromCriteria.Name = "BtnSearchFromCriteria";
    this.BtnSearchFromCriteria.Size = new System.Drawing.Size(125, 23);
    this.BtnSearchFromCriteria.TabIndex = 12;
    this.BtnSearchFromCriteria.Text = "Search From Criteria";
    this.BtnSearchFromCriteria.UseVisualStyleBackColor = true;
    this.BtnSearchFromCriteria.Click += new System.EventHandler(this.BtnSearchByCriteria_Click);
    //
    // BtnRemoveAllCriteria
    this.BtnRemoveAllCriteria = new System.Windows.Forms.Button();
    this.BtnRemoveAllCriteria.Location = new System.Drawing.Point(12, 450);
    this.BtnRemoveAllCriteria.Name = "BtnRemoveAllCriteria";
    this.BtnRemoveAllCriteria.Size = new System.Drawing.Size(125, 23);
    this.BtnRemoveAllCriteria.TabIndex = 12;
    this.BtnRemoveAllCriteria.Text = "Remove All Criteria";
    this.BtnRemoveAllCriteria.UseVisualStyleBackColor = true;
    this.BtnRemoveAllCriteria.Click += new System.EventHandler(this.BtnRemoveByCriteria_Click);


            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(900, 900);
            this.Controls.Add(this.btnCreateNewList);
            this.Controls.Add(this.BtnSearchFromCriteria);
            this.Controls.Add(this.BtnRemoveAllCriteria);
            this.Controls.Add(this.cmbLists);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.BtnSelectionSort);
            this.Controls.Add(this.BtnQuickSort);
            this.Controls.Add(this.BtnMergeLists);
            this.Controls.Add(this.txtTarget); // Thêm TextBox cho giá trị mục tiêu
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnRemoveAfter);
            this.Controls.Add(this.btnInsertAfter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.btnRemoveFirst);
            this.Controls.Add(this.btnInsertAtEnd);
            this.Controls.Add(this.btnInsertAtBeginning);
            this.Name = "Form1";
            this.Text = "Circular Linked List App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}