namespace C_Queue
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.CheckedListBox checkedListBoxCombos;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelChooseCombos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.checkedListBoxCombos = new System.Windows.Forms.CheckedListBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelChooseCombos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(216, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 29);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Text = "Enter your name...";
            this.textBoxName.GotFocus += new System.EventHandler(this.RemovePlaceholderText);
            this.textBoxName.LostFocus += new System.EventHandler(this.SetPlaceholderText);
            // 
            // checkedListBoxCombos
            // 
            this.checkedListBoxCombos.FormattingEnabled = true;
            this.checkedListBoxCombos.Items.AddRange(new object[] {
            "C1",
            "C2",
            "C3",
            "C4"});
            this.checkedListBoxCombos.Location = new System.Drawing.Point(216, 81);
            this.checkedListBoxCombos.Name = "checkedListBoxCombos";
            this.checkedListBoxCombos.Size = new System.Drawing.Size(200, 108);
            this.checkedListBoxCombos.TabIndex = 1;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDone.Location = new System.Drawing.Point(436, 247);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(95, 43);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(322, 247);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(94, 43);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 25);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelChooseCombos
            // 
            this.labelChooseCombos.AutoSize = true;
            this.labelChooseCombos.Location = new System.Drawing.Point(24, 81);
            this.labelChooseCombos.Name = "labelChooseCombos";
            this.labelChooseCombos.Size = new System.Drawing.Size(160, 25);
            this.labelChooseCombos.TabIndex = 5;
            this.labelChooseCombos.Text = "Choose Combos";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(543, 302);
            this.Controls.Add(this.labelChooseCombos);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.checkedListBoxCombos);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form2";
            this.Text = "Customer Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
