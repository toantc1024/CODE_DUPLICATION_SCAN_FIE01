using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CircularLinkedList_C_
{
    public partial class ListOfChosenExercise : Form
    {
        private string NameTitleExercise;
        //----------------------------------------------------------
        private string[] filePathImage;
        private string[] filePathMainImage;

        private List<System.Windows.Forms.PictureBox> pics = new List<System.Windows.Forms.PictureBox>();
        private List<Exercise> exercises = new List<Exercise> { };
        private List<Exercise> sortedExercises = new List<Exercise> { };
        public List<Exercise> SortedExercises { get { return sortedExercises; } }
        private CircularDoublyLinkedList SortedList = new CircularDoublyLinkedList();

        public ListOfChosenExercise()
        {
            InitializeComponent();
            TakeImage();
        }
        public ListOfChosenExercise(string nameTitleExcercies)
        {
            InitializeComponent();
            NameTitleExercise = nameTitleExcercies;
            TakeImage();

        }

        private void ListOfChosenExercise_Load(object sender, EventArgs e)
        {
            DisplayExercises();
            LoadMainPic();
        }
        private void LoadMainPic()
        {
            filePathMainImage = Directory.GetFiles("Image\\MainPic", "*.*")
                                          .Where(file => file.EndsWith(".jpg") || file.EndsWith(".png"))
                                          .ToArray();

            foreach (string filepath in filePathMainImage)
            {
                int indexDot = filepath.IndexOf("\\");
                string textResultImage = filepath.Substring(indexDot + 1); // xóa image


                indexDot = textResultImage.IndexOf("\\");
                textResultImage = textResultImage.Substring(indexDot + 1);


                indexDot = textResultImage.IndexOf(".");
                textResultImage = textResultImage.Substring(0, indexDot);



                if (NameTitleExercise == textResultImage)
                {
                    pictureBoxMainPic.ImageLocation = filepath;
                    pictureBoxMainPic.SizeMode = PictureBoxSizeMode.Zoom;

                    lbNameMainPic.Text = NameTitleExercise;
                    break;
                }
                
            }
        }
        private void TakeImage()
        {
            if (NameTitleExercise == "Stomach")
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
                //AddURLImageToList(filePathImage);
            }
            else if (NameTitleExercise == "Calo")
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
                //AddURLImageToList(filePathImage);
            }
            else if (NameTitleExercise == "Chest")
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
                //AddURLImageToList(filePathImage);
            }
            else if (NameTitleExercise == "Leg")
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
                //AddURLImageToList(filePathImage);
            }
            else if (NameTitleExercise == "Shoulder")
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
                //AddURLImageToList(filePathImage);
            }
        }

        private void DisplayExercises()
        {

            int xPic = 24, yPic = 18;
            int xLb = 149, yLb = 18;
            int imageWidth = 100, imageHeight = 100;
            foreach (string filePath in filePathImage)
            {
                int index = Path.GetFileName(filePath).IndexOf(".");

                Random random = new Random();
                int randomNumber = random.Next(1, 4);

                AddToList(Path.GetFileName(filePath).Substring(0, index), randomNumber, filePath);
                // Tạo PictureBox
                var pictureBox = new PictureBox
                {
                    Image = Image.FromFile(filePath),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(xPic, yPic),
                    Size = new Size(imageWidth, imageHeight)
                };

                // Tạo Label
                var label = new Label
                {
                    Text = Path.GetFileName(filePath).Substring(0, index),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(xLb, yLb + imageHeight / 2)

                };

                // Thêm vào Panel
                panelContainer.Controls.Add(pictureBox);
                panelContainer.Controls.Add(label);

                // Cập nhật tọa độ y để xuống dòng tiếp theo
                yPic += 84;
                yLb += 84;
            }
        }
        private void DisplaySortedExercises()
        {

            int xPic = 24, yPic = 18;
            int xLb = 149, yLb = 18;
            int imageWidth = 100, imageHeight = 100;
            foreach (Exercise exercise in sortedExercises)
            {
                int index = Path.GetFileName(exercise.URL).IndexOf(".");

                Random random = new Random();
                int randomNumber = random.Next(1, 4);

                //AddToList(Path.GetFileName(exercise.URL).Substring(0, index), randomNumber, exercise.URL);
                // Tạo PictureBox
                var pictureBox = new PictureBox
                {
                    Image = Image.FromFile(exercise.URL),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(xPic, yPic),
                    Size = new Size(imageWidth, imageHeight)
                };

                // Tạo Label
                var label = new Label
                {
                    Text = Path.GetFileName(exercise.URL).Substring(0, index),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(xLb, yLb + imageHeight / 2)

                };

                // Thêm vào Panel
                panelContainer.Controls.Add(pictureBox);
                panelContainer.Controls.Add(label);

                // Cập nhật tọa độ y để xuống dòng tiếp theo
                yPic += 84;
                yLb += 84;
            }
        }
        private void ConfigureScrollPanel()
        {
            // Đảm bảo Panel có AutoScroll
            panelContainer.AutoScroll = true;

            // Lấy các button từ Panel và thêm vào danh sách
            foreach (Control control in panelContainer.Controls)
            {
                if (control is System.Windows.Forms.PictureBox picture)
                {
                    pics.Add(picture);
                }
            }

        }
        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // Điều chỉnh vị trí các button theo thanh cuộn nếu cần
            int offset = -e.NewValue; // Giá trị thanh cuộn
            for (int i = 0; i < filePathImage.Length; i++)
            {
                pics[i].Top = (i * 50) + offset;
            }
        }

        private void pictureBoxMainPic_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ReturnToList();

            if (NameTitleExercise == "Chest" || NameTitleExercise == "Calo" || NameTitleExercise == "Leg" || NameTitleExercise == "Shoulder" || NameTitleExercise == "Stomach")
            {
                //MessageBox.Show(Convert.ToString(sortedExercises.Count));
                GymApp gymApp = new GymApp(SortedExercises);
                gymApp.Show();

                this.Hide();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            SortedList.SelectionSort(SortedList.PTail);
            ReturnToList();
            DisplaySortedExercises();
            sortedExercises.Clear();

            //MessageBox.Show(Convert.ToString(sortedExercises.Count));

        }
        private void AddToList(string name, int difficulty, string url)
        {
            Exercise newExercise = new Exercise(name, difficulty, url);
            exercises.Add(newExercise);
            SortedList.InsertAtEnd(newExercise);

        }
        public void ReturnToList()
        {
            Node PTail = SortedList.PTail;
            if (PTail == null)
                return; // Danh sách liên kết vòng rỗng.

            Node current = PTail.PtrNext; // Bắt đầu từ phần tử đầu tiên.
            do
            {
                sortedExercises.Add(current.Data); // Thêm dữ liệu vào List<Exercise>.
                current = current.PtrNext;  // Chuyển đến nút tiếp theo.
            } while (current != PTail.PtrNext); // Dừng khi quay lại nút đầu tiên.

        }
    }
}
