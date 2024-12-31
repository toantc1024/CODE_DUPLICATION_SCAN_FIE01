namespace Contacts
{
    partial class ContactApp
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
            this.lblContactIDNull = new System.Windows.Forms.Label();
            this.txtContactID = new System.Windows.Forms.TextBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusNull = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblContactIDNull
            // 
            this.lblContactIDNull.AutoSize = true;
            this.lblContactIDNull.Location = new System.Drawing.Point(31, 28);
            this.lblContactIDNull.Name = "lblContactIDNull";
            this.lblContactIDNull.Size = new System.Drawing.Size(133, 20);
            this.lblContactIDNull.TabIndex = 0;
            this.lblContactIDNull.Text = "Enter Contact ID:";
            // 
            // txtContactID
            // 
            this.txtContactID.Location = new System.Drawing.Point(210, 28);
            this.txtContactID.Name = "txtContactID";
            this.txtContactID.Size = new System.Drawing.Size(134, 26);
            this.txtContactID.TabIndex = 1;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(12, 86);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(152, 33);
            this.btnAddContact.TabIndex = 2;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.Location = new System.Drawing.Point(210, 86);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(156, 33);
            this.btnSearchContact.TabIndex = 3;
            this.btnSearchContact.Text = "Search Conact";
            this.btnSearchContact.UseVisualStyleBackColor = true;
            this.btnSearchContact.Click += new System.EventHandler(this.btnSearchContact_Click);
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.ItemHeight = 20;
            this.lstContacts.Location = new System.Drawing.Point(11, 145);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(354, 344);
            this.lstContacts.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(141, 506);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 22);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "status here";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusNull
            // 
            this.lblStatusNull.AutoSize = true;
            this.lblStatusNull.Location = new System.Drawing.Point(31, 508);
            this.lblStatusNull.Name = "lblStatusNull";
            this.lblStatusNull.Size = new System.Drawing.Size(60, 20);
            this.lblStatusNull.TabIndex = 7;
            this.lblStatusNull.Text = "Status:";
            // 
            // ContactApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 544);
            this.Controls.Add(this.lblStatusNull);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.btnSearchContact);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.txtContactID);
            this.Controls.Add(this.lblContactIDNull);
            this.Name = "ContactApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContactIDNull;
        private System.Windows.Forms.TextBox txtContactID;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusNull;
    }
}

