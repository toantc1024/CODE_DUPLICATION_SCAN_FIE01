namespace EnglishWordApp_EX3
{
    partial class AppCheckSpelling
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.btnRandomImage = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.btnMakeDic = new System.Windows.Forms.Button();
            this.pictureBoxRamdon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewYourDic = new System.Windows.Forms.ListView();
            this.lbHint = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowYourDic = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRamdon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write word here:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(490, 71);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 71);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBoxWord
            // 
            this.textBoxWord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxWord.Location = new System.Drawing.Point(185, 336);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(158, 20);
            this.textBoxWord.TabIndex = 2;
            this.textBoxWord.TextChanged += new System.EventHandler(this.textBoxWord_TextChanged);
            // 
            // btnRandomImage
            // 
            this.btnRandomImage.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomImage.Location = new System.Drawing.Point(490, 1);
            this.btnRandomImage.Name = "btnRandomImage";
            this.btnRandomImage.Size = new System.Drawing.Size(125, 71);
            this.btnRandomImage.TabIndex = 4;
            this.btnRandomImage.Text = "Start";
            this.btnRandomImage.UseVisualStyleBackColor = true;
            this.btnRandomImage.Click += new System.EventHandler(this.btnRandomImage_Click);
            // 
            // btnHint
            // 
            this.btnHint.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(490, 141);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(125, 71);
            this.btnHint.TabIndex = 6;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(490, 211);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(125, 71);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(118, 28);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(302, 349);
            this.listViewResult.TabIndex = 8;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.Visible = false;
            this.listViewResult.SelectedIndexChanged += new System.EventHandler(this.listViewResult_SelectedIndexChanged);
            // 
            // btnMakeDic
            // 
            this.btnMakeDic.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeDic.Location = new System.Drawing.Point(490, 352);
            this.btnMakeDic.Name = "btnMakeDic";
            this.btnMakeDic.Size = new System.Drawing.Size(125, 53);
            this.btnMakeDic.TabIndex = 9;
            this.btnMakeDic.Text = "Make your own dictionary";
            this.btnMakeDic.UseVisualStyleBackColor = true;
            this.btnMakeDic.Click += new System.EventHandler(this.btnMakeDic_Click);
            // 
            // pictureBoxRamdon
            // 
            this.pictureBoxRamdon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBoxRamdon.Location = new System.Drawing.Point(81, 68);
            this.pictureBoxRamdon.Name = "pictureBoxRamdon";
            this.pictureBoxRamdon.Size = new System.Drawing.Size(356, 237);
            this.pictureBoxRamdon.TabIndex = 3;
            this.pictureBoxRamdon.TabStop = false;
            this.pictureBoxRamdon.Click += new System.EventHandler(this.pictureBoxRamdon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EnglishWordApp_EX3.Properties.Resources.d4dcabc4d06ec889c388bd4ce99cb6b4;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listViewYourDic
            // 
            this.listViewYourDic.HideSelection = false;
            this.listViewYourDic.Location = new System.Drawing.Point(118, 53);
            this.listViewYourDic.Name = "listViewYourDic";
            this.listViewYourDic.Size = new System.Drawing.Size(302, 349);
            this.listViewYourDic.TabIndex = 10;
            this.listViewYourDic.UseCompatibleStateImageBehavior = false;
            this.listViewYourDic.Visible = false;
            // 
            // lbHint
            // 
            this.lbHint.AutoSize = true;
            this.lbHint.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHint.Location = new System.Drawing.Point(171, 22);
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(55, 28);
            this.lbHint.TabIndex = 11;
            this.lbHint.Text = "hint";
            this.lbHint.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hint: ";
            // 
            // btnShowYourDic
            // 
            this.btnShowYourDic.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowYourDic.Location = new System.Drawing.Point(490, 403);
            this.btnShowYourDic.Name = "btnShowYourDic";
            this.btnShowYourDic.Size = new System.Drawing.Size(125, 50);
            this.btnShowYourDic.TabIndex = 13;
            this.btnShowYourDic.Text = "Show your own dictionary";
            this.btnShowYourDic.UseVisualStyleBackColor = true;
            this.btnShowYourDic.Click += new System.EventHandler(this.btnShowYourDic_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(786, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 452);
            this.panel1.TabIndex = 14;
            // 
            // btnPass
            // 
            this.btnPass.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.Location = new System.Drawing.Point(490, 281);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(125, 71);
            this.btnPass.TabIndex = 14;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // AppCheckSpelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnRandomImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowYourDic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbHint);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.listViewYourDic);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.btnMakeDic);
            this.Controls.Add(this.pictureBoxRamdon);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AppCheckSpelling";
            this.Text = "AppCheckSpelling";
            this.Load += new System.EventHandler(this.AppCheckSpelling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRamdon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.PictureBox pictureBoxRamdon;
        private System.Windows.Forms.Button btnRandomImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.Button btnMakeDic;
        private System.Windows.Forms.ListView listViewYourDic;
        private System.Windows.Forms.Label lbHint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowYourDic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPass;
    }
}