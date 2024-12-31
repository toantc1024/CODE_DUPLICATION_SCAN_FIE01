using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CircularLinkedList_C_
{
    public partial class UserChoices : Form
    {
        private List<System.Windows.Forms.Button> buttons = new List<System.Windows.Forms.Button>();

        public UserChoices()
        {
            InitializeComponent();
        }
       
        private void UserChoices_Load(object sender, EventArgs e)
        {
            Image originalImage = btnLeg.Image;
            Size newsize = new Size(originalImage.Width / 4, originalImage.Height / 4);
            Bitmap resizedBitmap = new Bitmap(originalImage, newsize); 
            btnLeg.Image = resizedBitmap;

            originalImage = btnBurnFat.Image;
            newsize = new Size(originalImage.Width / 2, originalImage.Height / 2);
            resizedBitmap = new Bitmap(originalImage, newsize);
            btnBurnFat.Image = resizedBitmap;

            originalImage = btnShoulder.Image;
            newsize = new Size(originalImage.Width / 2, originalImage.Height / 2);
            resizedBitmap = new Bitmap(originalImage, newsize);
            btnShoulder.Image = resizedBitmap;
        }
        private void ConfigureScrollPanel()
        {
            // Đảm bảo Panel có AutoScroll
            panel1.AutoScroll = true;

            // Lấy các button từ Panel và thêm vào danh sách
            foreach (Control control in panel1.Controls)
            {
                if (control is System.Windows.Forms.Button button)
                {
                    buttons.Add(button);
                }
            }

        }
        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Điều chỉnh vị trí các button theo thanh cuộn nếu cần
            int offset = -e.NewValue; // Giá trị thanh cuộn
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Top = (i * 50) + offset;
            }
        }
        private void btnMuscle_Click(object sender, EventArgs e)
        {
            ListOfChosenExercise PageListExercies = new ListOfChosenExercise("Leg");
            PageListExercies.Show();
            this.Hide();
        }

        private void btnBurnFat_Click(object sender, EventArgs e)
        {
            ListOfChosenExercise PageListExercies = new ListOfChosenExercise("Stomach");
            PageListExercies.Show();

            this.Hide();
        }

        private void btnBurnCalo_Click(object sender, EventArgs e)
        {
            ListOfChosenExercise PageListExercies = new ListOfChosenExercise("Calo");
            PageListExercies.Show();

            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChest_Click(object sender, EventArgs e)
        {
            ListOfChosenExercise PageListExercies = new ListOfChosenExercise("Chest");
            PageListExercies.Show();

            this.Hide();
        }

        private void btnShoulder_Click(object sender, EventArgs e)
        {
            ListOfChosenExercise PageListExercies = new ListOfChosenExercise("Shoulder");
            PageListExercies.Show();

            this.Hide();
        }

        private void btnGetBack_Click(object sender, EventArgs e)
        {

            UserInformation userInformation = new UserInformation();
            userInformation.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserInformation userInformation = new UserInformation();
            userInformation.Show();
            this.Hide();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            UserCalender userCalender = new UserCalender();
            userCalender.Show();
            this.Hide();
        }

        private void btnExercises_Click(object sender, EventArgs e)
        {

        }
    }
}
