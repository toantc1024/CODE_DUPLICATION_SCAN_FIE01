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
    public partial class UserCalender : Form
    {
        private Dictionary<DateTime, string> workoutTimes = new Dictionary<DateTime, string>();
        private string saveFilePath = "WorkoutTimes.TXT";

        public UserCalender()
        {
            InitializeComponent();
        }

        private void UserCalender_Load(object sender, EventArgs e)
        {
            LoadTextFromFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           


        }

        private void SaveWorkoutTimes()
        {
            using (StreamWriter writer = new StreamWriter(saveFilePath))
            {
                foreach (var entry in workoutTimes)
                {
                    writer.WriteLine($"Day: {entry.Key.ToShortDateString()}" +
                        $"   Time:  {entry.Value}");
                }
            }
        }

        private void LoadTextFromFile()
        {
            string[] lines = File.ReadAllLines(saveFilePath);

            int startY = 10;
            int i = 0;
            foreach (string line in lines)
            {
                Label label = new Label();
                label.Text = line;
                label.Font = new Font("Arial", 10, FontStyle.Bold);
                label.ForeColor = Color.Black;
                label.Location = new Point(10, startY);
                label.AutoSize = true;
                panelPlan.Controls.Add(label);
                startY += 20;
                i += 1;
            }
        }
        

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionStart.Date;
            workoutTimes[selectedDate] = textBoxTime.Text;
            SaveWorkoutTimes();
            LoadTextFromFile();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
            this.Hide();
        }
    }
}
