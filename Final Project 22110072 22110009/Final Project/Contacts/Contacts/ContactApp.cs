using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contacts
{
    public partial class ContactApp : Form
    {
        private ContactBST contactBST = new ContactBST();
        private string filePath = "contacts.txt";

        public ContactApp()
        {
            InitializeComponent();
            LoadContactsFromFile();
        }

        private void LoadContactsFromFile()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    if (int.TryParse(line, out int contactID))
                    {
                        contactBST.Insert(contactID);
                    }
                }
                DisplayContacts();
                lblStatus.Text = "Contacts loaded successfully.";
            }
        }

        private void SaveContactsToFile()
        {
            List<int> contacts = contactBST.GetSortedContacts();
            File.WriteAllLines(filePath, contacts.ConvertAll(id => id.ToString()));
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtContactID.Text, out int contactID))
            {
                contactBST.Insert(contactID);
                txtContactID.Clear();
                DisplayContacts();
                SaveContactsToFile();
                lblStatus.Text = "Contact added successfully.";
            }
            else
            {
                MessageBox.Show("Please enter a valid contact ID (integer).");
            }
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtContactID.Text, out int contactID))
            {
                bool found = contactBST.Search(contactID);
                lblStatus.Text = found ? "Contact found." : "Contact not found.";
            }
            else
            {
                MessageBox.Show("Please enter a valid contact ID (integer).");
            }
        }

        private void DisplayContacts()
        {
            lstContacts.Items.Clear();
            List<int> contacts = contactBST.GetSortedContacts();
            foreach (int id in contacts)
            {
                lstContacts.Items.Add($"Contact ID: {id}");
            }
        }
    }
}
