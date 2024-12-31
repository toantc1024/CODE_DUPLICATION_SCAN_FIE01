using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularLinkedList_C_
{
    public partial class GymApp : Form
    {
        private Node current;
        //--------------------------------------------------------------------------
        private List<Exercise> exercises;
        public CircularDoublyLinkedList ListExercise;
        private string[] filePathImage;
        //-----------------------------------------------------------------------------
        private int second;
        private int secondBreak = 5;
        private int currentImageIndex = 0;
        private int CountLoop;

        public GymApp(List<Exercise> exercises)
        {
            InitializeComponent();
            ListExercise = new CircularDoublyLinkedList();
            this.exercises = exercises;



            //MessageBox.Show("GymApp" + Convert.ToString(this.exercises.Count));
            //TakeImage();
            AddURLImageToList(exercises);
        }
/*
        public void TakeImage()
        {
            if (TypeOfExercise == "Stomach")
            {
                if (Directory.Exists("Image\\Stomach"))
                {
                    filePathImage = Directory.GetFiles("Image\\Stomach", "*.*")
                                           .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png"))
                                           .ToArray();
                    if (filePathImage.Length == 0)
                    {
                        MessageBox.Show("No image or can't take any imange");
                    }
                    //else MessageBox.Show("Have dictionary");
                }
                else
                {
                    MessageBox.Show("Image folder does not exist.");
                }
                AddURLImageToList(filePathImage);
            }
            else if (TypeOfExercise == "Calo")
            {
                if (Directory.Exists("Image\\Calo"))
                {
                    filePathImage = Directory.GetFiles("Image\\Calo", "*.*")
                                           .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png"))
                                           .ToArray();
                    if (filePathImage.Length == 0)
                    {
                        MessageBox.Show("No image or can't take any imange");
                    }
                    //else MessageBox.Show("Have dictionary");
                }
                else
                {
                    MessageBox.Show("Image folder does not exist.");
                }
                AddURLImageToList(filePathImage);
            }
            else if (TypeOfExercise == "Chest")
            {
                if (Directory.Exists("Image\\Chest"))
                {
                    filePathImage = Directory.GetFiles("Image\\Chest", "*.*")
                                           .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png"))
                                           .ToArray();
                    if (filePathImage.Length == 0)
                    {
                        MessageBox.Show("No image or can't take any imange");
                    }
                   // else MessageBox.Show("Have dictionary");
                }
                else
                {
                    MessageBox.Show("Image folder does not exist.");
                }
                AddURLImageToList(filePathImage);
            }
            else if (TypeOfExercise == "Leg")
            {
                if (Directory.Exists("Image\\Leg"))
                {
                    filePathImage = Directory.GetFiles("Image\\Leg", "*.*")
                                           .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png"))
                                           .ToArray();
                    if (filePathImage.Length == 0)
                    {
                        MessageBox.Show("No image or can't take any imange");
                    }
                   // else MessageBox.Show("Have dictionary");
                }
                else
                {
                    MessageBox.Show("Image folder does not exist.");
                }
                AddURLImageToList(filePathImage);
            }
            else if (TypeOfExercise == "Shoulder")
            {
                if (Directory.Exists("Image\\Shoulder"))
                {
                    filePathImage = Directory.GetFiles("Image\\Shoulder", "*.*")
                                           .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png"))
                                           .ToArray();
                    if (filePathImage.Length == 0)
                    {
                        MessageBox.Show("No image or can't take any imange");
                    }
                    //else MessageBox.Show("Have dictionary");
                }
                else
                {
                    MessageBox.Show("Image folder does not exist.");
                }
                AddURLImageToList(filePathImage);
            }
        }
*/    
        
        private void AddURLImageToList(List<Exercise> exercises)
        {
            foreach (var exercise in exercises)
            {
                ListExercise.InsertAtEnd(exercise);
            }

        }
        private void RemoveOtherSign(ref int indexDot, ref string textResultImage, Node current)
        {
            indexDot = current.Data.URL.IndexOf("\\");
            textResultImage = current.Data.URL.Substring(indexDot + 1);

            indexDot = textResultImage.IndexOf("\\");
            textResultImage = textResultImage.Substring(indexDot + 1);

            indexDot = textResultImage.IndexOf(".");
            textResultImage = textResultImage.Substring(0, indexDot);
        }
        private void TimerCountdown_Tick(object sender, EventArgs e)
        {
           
            lbCountdowm.Text = Convert.ToString(second--);

            if (second == -1)
            {
                second = 2;
                TimerCountdown.Stop();
                TimerTimeBreak.Start();
                currentImageIndex++;
                    if (currentImageIndex >= exercises.Count && CountLoop != 0)
                    {
                        CountLoop -= 1;
                        btnRepeat.Text = $"Repeat({CountLoop})";
                        current = current.PtrNext;
                        currentImageIndex = 0;
                    }
                    else if (currentImageIndex >= exercises.Count && CountLoop == 0)
                    {
                        TimerCountdown.Stop();
                        TimerTimeBreak.Stop();

                        btnStart.Text = "Done";
                        lbEnd.Visible = true;
                        using (StreamWriter writer = new StreamWriter("History.TXT",true)) // append: true để ghi tiếp vào file
                        {
                            DateTime currentDate = DateTime.Now.Date;
                            DateTime now = DateTime.Now;
                            int hour = now.Hour;
                            int minute = now.Minute;
                            int second = now.Second;
                            writer.WriteLine(currentDate.ToShortDateString());
                            writer.WriteLine(Convert.ToString(13 * currentImageIndex));
                            writer.WriteLine($"{hour:D2}:{minute:D2}:{second:D2}");
                            writer.WriteLine("-------------------------------------");

                        }
                        return;
                    }
                    //transver
                        current = current.PtrNext;

                    pictureBoxDisplay.ImageLocation = current.Data.URL;
                    int indexDot=0;
                    string textResultImage="";
                    RemoveOtherSign(ref indexDot, ref textResultImage, current);
           
                    lbExerciseNum.Text = "Exercise " + (currentImageIndex + 1) + ": ";
                    lbExerciseName.Text = textResultImage;
                    pictureBoxDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
                }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            current = ListExercise.PTail.PtrNext;
            //MessageBox.Show(current.Data);
            currentImageIndex = 0;
            second = 2;
            lbCountdowm.Text = Convert.ToString(second);
            TimerCountdown.Start();
            pictureBoxDisplay.ImageLocation = current.Data.URL;

            int indexDot = 0;
            string textResultImage = "";
            RemoveOtherSign(ref indexDot, ref textResultImage, current);

            lbExerciseNum.Visible = true;
            lbExerciseName.Visible = true;
            lbExerciseNum.Text = "Exercise 1: ";
            lbExerciseName.Text = textResultImage;
            pictureBoxDisplay.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void GymApp_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            CountLoop += 1;
            btnRepeat.Text = $"Repeat({CountLoop})";
        }

        private void btnStopRepeat_Click(object sender, EventArgs e)
        {
            if (btnStopRepeat.Text == "Continue")
            {
                btnStopRepeat.Text = "Stop";
                btnStopRepeat.ForeColor = Color.Red;
                if (lbTimeBreak.Visible == false) TimerCountdown.Start();
                else if (lbTimeBreak.Visible == true)
                {
                    TimerTimeBreak.Start();
                    TimerCountdown.Stop();

                }
            }
            else if(btnStopRepeat.Text == "Stop")
            {
                btnStopRepeat.Text = "Continue";
                btnStopRepeat.ForeColor = Color.Green;

                if (lbTimeBreak.Visible == false) TimerCountdown.Stop();
                else if (lbTimeBreak.Visible == true)
                {
                    TimerTimeBreak.Stop();
                    TimerCountdown.Stop();
                }
            }
        }

        private void btnGetBack_Click(object sender, EventArgs e)
        {
            UserChoices userChoices = new UserChoices();
            userChoices.Show();
            this.Hide();
        }

        private void TimerTimeBreak_Tick(object sender, EventArgs e)
        {
            lbTimeBreak.Visible = true;
            lbTimeBreak.ForeColor = Color.Red;
            lbCountdowm.Text = Convert.ToString(secondBreak--);
            if(secondBreak == -1)
            {
                lbTimeBreak.Visible = false;
                TimerTimeBreak.Stop();
                TimerCountdown.Start();
                secondBreak = 5;
            }
        }

        private void lbTimeBreak_Click(object sender, EventArgs e)
        {

        }
    }
}
