namespace Circular_Linked_List
{
    partial class FManagement
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
            this.components = new System.ComponentModel.Container();
            this.lbID = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btADD = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbValue = new System.Windows.Forms.TextBox();
            this.cboxSort = new System.Windows.Forms.ComboBox();
            this.btSort = new System.Windows.Forms.Button();
            this.liboxData = new System.Windows.Forms.ListBox();
            this.cboxCriteria = new System.Windows.Forms.ComboBox();
            this.cboxType = new System.Windows.Forms.ComboBox();
            this.cboxSize = new System.Windows.Forms.ComboBox();
            this.btShowAll = new System.Windows.Forms.Button();
            this.btRemoveAll = new System.Windows.Forms.Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbID.Location = new System.Drawing.Point(38, 68);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(28, 21);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID";
            // 
            // tbSize
            // 
            this.tbSize.AutoSize = true;
            this.tbSize.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSize.Location = new System.Drawing.Point(249, 113);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(41, 21);
            this.tbSize.TabIndex = 2;
            this.tbSize.Text = "Size";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(38, 113);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(55, 21);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Name";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbType.Location = new System.Drawing.Point(249, 71);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(49, 21);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "Type";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPrice.Location = new System.Drawing.Point(38, 159);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(49, 21);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbID.Location = new System.Drawing.Point(107, 68);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(119, 29);
            this.tbID.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbName.Location = new System.Drawing.Point(107, 110);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(119, 29);
            this.tbName.TabIndex = 5;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPrice.Location = new System.Drawing.Point(107, 159);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(119, 29);
            this.tbPrice.TabIndex = 6;
            // 
            // btADD
            // 
            this.btADD.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btADD.Location = new System.Drawing.Point(107, 204);
            this.btADD.Name = "btADD";
            this.btADD.Size = new System.Drawing.Size(87, 43);
            this.btADD.TabIndex = 8;
            this.btADD.Text = "ADD ITEM";
            this.btADD.UseVisualStyleBackColor = true;
            this.btADD.Click += new System.EventHandler(this.btADD_Click);
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearch.Location = new System.Drawing.Point(33, 318);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(145, 28);
            this.btSearch.TabIndex = 9;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDelete.Location = new System.Drawing.Point(242, 204);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(99, 43);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "DELETE ITEM";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbValue
            // 
            this.tbValue.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbValue.Location = new System.Drawing.Point(327, 266);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(140, 29);
            this.tbValue.TabIndex = 12;
            // 
            // cboxSort
            // 
            this.cboxSort.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboxSort.FormattingEnabled = true;
            this.cboxSort.Items.AddRange(new object[] {
            "Increasing",
            "Decreasing"});
            this.cboxSort.Location = new System.Drawing.Point(201, 371);
            this.cboxSort.Name = "cboxSort";
            this.cboxSort.Size = new System.Drawing.Size(140, 29);
            this.cboxSort.TabIndex = 13;
            // 
            // btSort
            // 
            this.btSort.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSort.Location = new System.Drawing.Point(33, 371);
            this.btSort.Name = "btSort";
            this.btSort.Size = new System.Drawing.Size(145, 29);
            this.btSort.TabIndex = 14;
            this.btSort.Text = "Sort";
            this.btSort.UseVisualStyleBackColor = true;
            this.btSort.Click += new System.EventHandler(this.btSort_Click);
            // 
            // liboxData
            // 
            this.liboxData.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.liboxData.FormattingEnabled = true;
            this.liboxData.ItemHeight = 21;
            this.liboxData.Location = new System.Drawing.Point(504, 68);
            this.liboxData.Name = "liboxData";
            this.liboxData.Size = new System.Drawing.Size(623, 466);
            this.liboxData.TabIndex = 17;
            // 
            // cboxCriteria
            // 
            this.cboxCriteria.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboxCriteria.FormattingEnabled = true;
            this.cboxCriteria.Items.AddRange(new object[] {
            "id",
            "name",
            "price",
            "size",
            "type"});
            this.cboxCriteria.Location = new System.Drawing.Point(33, 266);
            this.cboxCriteria.Name = "cboxCriteria";
            this.cboxCriteria.Size = new System.Drawing.Size(277, 29);
            this.cboxCriteria.TabIndex = 18;
            // 
            // cboxType
            // 
            this.cboxType.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboxType.FormattingEnabled = true;
            this.cboxType.Items.AddRange(new object[] {
            "T-Shirt",
            "Pants",
            "Jacket"});
            this.cboxType.Location = new System.Drawing.Point(327, 71);
            this.cboxType.Name = "cboxType";
            this.cboxType.Size = new System.Drawing.Size(121, 29);
            this.cboxType.TabIndex = 19;
            // 
            // cboxSize
            // 
            this.cboxSize.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboxSize.FormattingEnabled = true;
            this.cboxSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL",
            "XXL"});
            this.cboxSize.Location = new System.Drawing.Point(327, 113);
            this.cboxSize.Name = "cboxSize";
            this.cboxSize.Size = new System.Drawing.Size(121, 29);
            this.cboxSize.TabIndex = 20;
            // 
            // btShowAll
            // 
            this.btShowAll.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btShowAll.Location = new System.Drawing.Point(33, 437);
            this.btShowAll.Name = "btShowAll";
            this.btShowAll.Size = new System.Drawing.Size(108, 35);
            this.btShowAll.TabIndex = 21;
            this.btShowAll.Text = "SHOW ALL";
            this.btShowAll.UseVisualStyleBackColor = true;
            this.btShowAll.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // btRemoveAll
            // 
            this.btRemoveAll.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRemoveAll.Location = new System.Drawing.Point(202, 437);
            this.btRemoveAll.Name = "btRemoveAll";
            this.btRemoveAll.Size = new System.Drawing.Size(108, 35);
            this.btRemoveAll.TabIndex = 22;
            this.btRemoveAll.Text = "REMOVE ALL";
            this.btRemoveAll.UseVisualStyleBackColor = true;
            this.btRemoveAll.Click += new System.EventHandler(this.btRemoveAll_Click);
            // 
            // lbHeader
            // 
            this.lbHeader.AutoSize = true;
            this.lbHeader.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHeader.ForeColor = System.Drawing.Color.IndianRed;
            this.lbHeader.Location = new System.Drawing.Point(621, 21);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(360, 30);
            this.lbHeader.TabIndex = 23;
            this.lbHeader.Text = "CLOTHES SHOP MANAGEMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "23110015_ToPhatDat_23110035_ToGiaKhanh";
            // 
            // FManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHeader);
            this.Controls.Add(this.btRemoveAll);
            this.Controls.Add(this.btShowAll);
            this.Controls.Add(this.cboxSize);
            this.Controls.Add(this.cboxType);
            this.Controls.Add(this.cboxCriteria);
            this.Controls.Add(this.liboxData);
            this.Controls.Add(this.btSort);
            this.Controls.Add(this.cboxSort);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.btADD);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbSize);
            this.Controls.Add(this.lbID);
            this.Name = "FManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManagement";
            this.Load += new System.EventHandler(this.FManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label tbSize;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btADD;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.ComboBox cboxSort;
        private System.Windows.Forms.Button btSort;
        private System.Windows.Forms.ListBox liboxData;
        private System.Windows.Forms.ComboBox cboxCriteria;
        private System.Windows.Forms.ComboBox cboxType;
        private System.Windows.Forms.ComboBox cboxSize;
        private System.Windows.Forms.Button btShowAll;
        private System.Windows.Forms.Button btRemoveAll;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.Label label1;
    }
}