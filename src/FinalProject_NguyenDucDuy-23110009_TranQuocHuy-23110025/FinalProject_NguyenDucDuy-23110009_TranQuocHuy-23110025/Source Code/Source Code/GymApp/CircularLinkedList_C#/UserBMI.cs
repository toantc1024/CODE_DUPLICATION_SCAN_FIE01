using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularLinkedList_C_
{
    public partial class UserBMI : Form
    {

        
        public UserBMI()
        {
            InitializeComponent();
        }

        private void UserBMI_Load(object sender, EventArgs e)
        {
            

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Person NewUser = new Person(textBoxName.Text, textBoxAge.Text, textBoxSex.Text);

            textBoxName.Visible = false;
            textBoxAge.Visible = false;
            textBoxSex.Visible = false;

            lbSetName.Text = textBoxName.Text;
            lbSetAge.Text = textBoxAge.Text;
            lbSetSex.Text = textBoxSex.Text;


            btnSubmit.Visible = false;

            lbSetHeight.Visible = true;
            lbSetWeight.Visible = true;
            lbTitelHeight.Visible = true;
            lbTitelWeight.Visible = true;
            textBoxHeight.Visible = true;
            textBoxWeight.Visible = true;
            btnSubmit2.Visible = true;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            double heightInCm = Convert.ToDouble(textBoxHeight.Text);
            double weightInKg = Convert.ToDouble(textBoxWeight.Text);
            double heightInMeters = heightInCm / 100;

            Person NewUser = new Person(textBoxName.Text, textBoxAge.Text, textBoxSex.Text);

            NewUser.TakeInfo(textBoxName.Text, textBoxAge.Text, textBoxSex.Text, textBoxHeight.Text, textBoxWeight.Text);

            lbTitleBMI.Visible = true;
            lbSetBMI.Visible = true;
            lbSetBMI.Text = Convert.ToString(NewUser.CalculateBMI(heightInMeters, weightInKg));
            btnSubmit2.Text = "Go to home";
            if(btnSubmit2.Text == "Go to home" && btnSubmit2.Enabled == true)
            {
                UserInformation userInformation = new UserInformation(NewUser.CalculateBMI(heightInMeters, weightInKg));
                using (StreamWriter writer = new StreamWriter("BMI.TXT", true)) 
                {
                    
                    writer.WriteLine(NewUser.CalculateBMI(heightInMeters, weightInKg));


                }
                userInformation.Show();
                this.Hide();
            }
            
        }
    }
}
