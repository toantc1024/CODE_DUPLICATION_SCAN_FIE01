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
using static System.Windows.Forms.AxHost;


namespace CircularLinkedList_C_
{
    public partial class UserInformation : Form
    {
        private int CountTime = 0;
        private int CountDay = 0;
        private int  Kcal =0;
        private double BMIUser;
        private List<System.Windows.Forms.Label> labels = new List<System.Windows.Forms.Label>();

        public UserInformation(double BMI)
        {
            InitializeComponent();
            BMIUser = BMI;
        }
        public UserInformation()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Histories_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UserChoices userChoices = new UserChoices();
            userChoices.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ConfigureScrollPanel()
        {
            // Đảm bảo Panel có AutoScroll
            panel1.AutoScroll = true;

            // Lấy các button từ Panel và thêm vào danh sách
            foreach (Control control in panel1.Controls)
            {
                if (control is System.Windows.Forms.Label label)
                {
                    labels.Add(label);
                }
            }

        }
        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Điều chỉnh vị trí các button theo thanh cuộn nếu cần
            int offset = -e.NewValue; // Giá trị thanh cuộn
            for (int i = 0; i < labels.Count; i++)
            {
                labels[i].Top = (i * 50) + offset;
            }
        }
        private void UserInformation_Load(object sender, EventArgs e)
        {
            LoadTextFromFile();

            lbKcal.Text = Convert.ToString(Kcal);
            if(BMIUser > 18.5 && BMIUser <24.9)
            {
                lbSetBMI.Text = Convert.ToString(BMIUser) + " (Very Good)";

            }
            else if (BMIUser > 25 && BMIUser < 29.9)
            {
                lbSetBMI.Text = Convert.ToString(BMIUser) + " (Over Weight)";

            }
            else if (BMIUser > 30 && BMIUser < 39.9)
            {
                lbSetBMI.Text = Convert.ToString(BMIUser) + " (Obese)";

            }
            else if (BMIUser > 40)
            {
                lbSetBMI.Text = Convert.ToString(BMIUser) + " (Morbidly Obese)";

            }
            lbNumberOfExercises.Text = Convert.ToString(CountTime);

            string[] lines = File.ReadAllLines("BMI.TXT");
            foreach (string line in lines)
            {
                lbSetBMI.Text = line;
            }
        }

        private void LoadTextFromFile()
        {
            string[] lines = File.ReadAllLines("History.TXT");

            int startY = 10;
            int i = 0;
            int movePos = 1;
            foreach (string line in lines)
            {
                Label label = new Label();
                label.Text = line;
                if (i == movePos)
                {
                    Kcal+= Convert.ToInt32(line);
                    movePos += 4;
                }
                label.Font = new Font("Arial", 10, FontStyle.Bold);
                label.ForeColor = Color.Blue;
                label.Location = new Point(10, startY);
                label.AutoSize = true;
                Histories.Controls.Add(label);
                CountTime += 1;
                startY += 20;
                i += 1;
            }
        }

        private void btnExercises_Click(object sender, EventArgs e)
        {
            UserChoices userChoices = new UserChoices();
            userChoices.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            UserCalender userCalender = new UserCalender();
            userCalender.Show();
            this.Hide();
        }
    }
}
