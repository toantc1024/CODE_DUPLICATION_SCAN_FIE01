namespace BST_Fiinal
{
    partial class FDictionary
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
            this.liboxData = new System.Windows.Forms.ListBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.tbMeaning = new System.Windows.Forms.TextBox();
            this.lbWord = new System.Windows.Forms.Label();
            this.lbMeaning = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // liboxData
            // 
            this.liboxData.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.liboxData.FormattingEnabled = true;
            this.liboxData.ItemHeight = 22;
            this.liboxData.Location = new System.Drawing.Point(49, 51);
            this.liboxData.Name = "liboxData";
            this.liboxData.Size = new System.Drawing.Size(534, 488);
            this.liboxData.TabIndex = 0;
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btDelete.Location = new System.Drawing.Point(733, 386);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(83, 62);
            this.btDelete.TabIndex = 1;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btInsert.Location = new System.Drawing.Point(625, 386);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(74, 62);
            this.btInsert.TabIndex = 2;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // tbWord
            // 
            this.tbWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbWord.Location = new System.Drawing.Point(690, 82);
            this.tbWord.Multiline = true;
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(223, 50);
            this.tbWord.TabIndex = 3;
            // 
            // tbMeaning
            // 
            this.tbMeaning.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMeaning.Location = new System.Drawing.Point(625, 217);
            this.tbMeaning.Multiline = true;
            this.tbMeaning.Name = "tbMeaning";
            this.tbMeaning.Size = new System.Drawing.Size(288, 121);
            this.tbMeaning.TabIndex = 4;
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbWord.Location = new System.Drawing.Point(622, 85);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(56, 23);
            this.lbWord.TabIndex = 5;
            this.lbWord.Text = "Word";
            // 
            // lbMeaning
            // 
            this.lbMeaning.AutoSize = true;
            this.lbMeaning.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMeaning.Location = new System.Drawing.Point(622, 182);
            this.lbMeaning.Name = "lbMeaning";
            this.lbMeaning.Size = new System.Drawing.Size(83, 23);
            this.lbMeaning.TabIndex = 6;
            this.lbMeaning.Text = "Meaning";
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSearch.Location = new System.Drawing.Point(840, 386);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(87, 62);
            this.btSearch.TabIndex = 7;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "DICTIONARY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label2.Location = new System.Drawing.Point(569, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "23110015_ToPhatDat 23110035_TongGiaKhanh";
            // 
            // FDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lbMeaning);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.tbMeaning);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.liboxData);
            this.Name = "FDictionary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FDictionary";
            this.Load += new System.EventHandler(this.FDictionary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox liboxData;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.TextBox tbMeaning;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label lbMeaning;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}