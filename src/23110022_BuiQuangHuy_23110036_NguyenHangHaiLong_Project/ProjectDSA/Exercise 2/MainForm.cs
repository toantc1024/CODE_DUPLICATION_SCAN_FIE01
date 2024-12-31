using System;
using System.Windows.Forms;

namespace DoctorQueueApp
{
    public partial class MainForm : Form
    {
        private LinkedList<(string Name, string Concern)> regularQueue = new LinkedList<(string, string)>();
        private LinkedList<(string Name, string Concern)> priorityQueue = new LinkedList<(string, string)>();
        private (string Name, string Concern)? currentPatientInRoom = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void AddToQueue(string name, string concern, bool isPriority)
        {
            if (isPriority)
            {
                priorityQueue.AddToTail((name, concern));
            }
            else
            {
                regularQueue.AddToTail((name, concern));
            }
            UpdateQueueDisplay();
        }

        private (string Name, string Concern)? GetNextPatient()
        {
            (string Name, string Concern)? nextPatient = null;

            if (!priorityQueue.IsEmpty())
            {
                nextPatient = priorityQueue.RemoveFromHead();
            }
            else if (!regularQueue.IsEmpty())
            {
                nextPatient = regularQueue.RemoveFromHead();
            }

            UpdateQueueDisplay();
            return nextPatient;
        }


        private void UpdateQueueDisplay()
        {
            dgvQueue.Rows.Clear();

            priorityQueue.Traverse(patient =>
            {
                dgvQueue.Rows.Add($"(Priority) {patient.Name}", patient.Concern);
            });

            regularQueue.Traverse(patient =>
            {
                dgvQueue.Rows.Add(patient.Name, patient.Concern);
            });
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            using (PatientInformation patientInfo = new PatientInformation())
            {
                if (patientInfo.ShowDialog() == DialogResult.OK)
                {
                    AddToQueue(patientInfo.PatientName, patientInfo.PatientConcern, isPriority: false);
                }
            }
        }

        private void btnPrioritySignUp_Click(object sender, EventArgs e)
        {
            using (PatientInformation patientInfo = new PatientInformation())
            {
                if (patientInfo.ShowDialog() == DialogResult.OK)
                {
                    AddToQueue(patientInfo.PatientName, patientInfo.PatientConcern, isPriority: true);
                }
            }
        }

        private void btnEnterRoom_Click(object sender, EventArgs e)
        {
            if (currentPatientInRoom == null)
            {
                currentPatientInRoom = GetNextPatient();

                if (currentPatientInRoom != null)
                {
                    txtDisplayRoomInfo.Text = $"Name: {currentPatientInRoom.Value.Name}\nConcern: {currentPatientInRoom.Value.Concern}";
                }
                else
                {
                    MessageBox.Show("No patients in queue.");
                }
            }
            else
            {
                MessageBox.Show("There is already a patient in the room.");
            }
        }

        private void btnBeginConsultation_Click(object sender, EventArgs e)
        {
            if (currentPatientInRoom != null)
            {
                MessageBox.Show($"Consultation for {currentPatientInRoom.Value.Name} has started.");
                MessageBox.Show($"Consultation for {currentPatientInRoom.Value.Name} has ended.");
                currentPatientInRoom = null;
                txtDisplayRoomInfo.Text = "";
            }
            else
            {
                MessageBox.Show("There is no patient in the room.");
            }
        }

        private void btnClosingTime_Click(object sender, EventArgs e)
        {
            priorityQueue.Clear();
            regularQueue.Clear();
            currentPatientInRoom = null;
            txtDisplayRoomInfo.Text = "";
            UpdateQueueDisplay();
            MessageBox.Show("All patients have been cleared from the queue.");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dgvQueue.Rows.Clear();


            txtDisplayRoomInfo.Text = "Room is empty.";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtDisplayRoomInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
