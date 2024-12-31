using Question_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ques_2_21_12
{
    public partial class Form1 : Form
    {
        private Queue<PrintJob> jobQueue = new Queue<PrintJob>();
        private System.Windows.Forms.Timer printTimer = new System.Windows.Forms.Timer();
        private double remainingTime = 0;
        private PrintJob currentJob = null;
        private Label lblStatus = new Label();

        public Form1()
        {
            InitializeComponent();
            printTimer.Interval = 1000;
            printTimer.Tick += ProcessJob_Click;
            StopProcessing.Click += StopProcessing_Click;


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContinueProcessing.Enabled = false;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Addprintjob(object sender, EventArgs e)
        {
            string jobName = jobname.Text.Trim();
            if (string.IsNullOrEmpty(jobName))
            {
                MessageBox.Show("Invalid page count.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(PageCount.Text.Trim(), out int pageCount) || pageCount <= 0)
            {
                MessageBox.Show("The number of pages must be a positive integer.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isDoubleSided = DoubleSided.Checked;
            var newJob = new PrintJob(jobName, pageCount, isDoubleSided);
            jobQueue.Enqueue(newJob);
            UpdateJobList();
            ClearInputFields();

        }
        private void UpdateJobList()
        {
            lstJobs.Items.Clear();
            foreach (var job in jobQueue)
            {
                lstJobs.Items.Add(job.ToString());
            }
        }

        private void ClearInputFields()
        {
            jobname.Clear();
            PageCount.Clear();
            DoubleSided.Checked = false;
        }

        private void Deletecurrentprintjob(object sender, EventArgs e)
        {
            DeleteCurrentJob(jobQueue, lblStatus);
            UpdateJobList();

        }
        public static void DeleteCurrentJob(Queue<PrintJob> jobQueue, Label lblStatus)
        {
            if (jobQueue.Count == 0)
            {
                lblStatus.Text = "No jobs to delete.";
            }
            else
            {
                PrintJob removedJob = jobQueue.Dequeue();
                lblStatus.Text = $"Deleted job: {removedJob.JobName}";
            }
        }

        private void Prindocument(object sender, EventArgs e)
        {

        }

        private void Processnext_Click(object sender, EventArgs e)
        {
            if (jobQueue.Count > 0)
            {
                currentJob = jobQueue.Dequeue();
                remainingTime = currentJob.GetPrintTime();

                lblCurrentJob.Text = $"Processing Job: {currentJob.JobName}";
                lblEstimatedTime.Text = $"Estimated Time: {remainingTime} seconds";
                lblTimeRemaining.Text = $"Time Remaining: {remainingTime} seconds";

                printTimer.Start(); 
            }
            else
            {
                MessageBox.Show("No jobs in the queue.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ProcessJob_Click(object sender, EventArgs e)
        {
            if (remainingTime > 0)
            {
                lblTimeRemaining.Text = $"Time Remaining: {remainingTime--} seconds";
                return;
            }

            printTimer.Stop();
            lblTimeRemaining.Text = "Time Remaining: 0 seconds";

            if (currentJob != null)
            {
                MessageBox.Show($"Job {currentJob.JobName} completed.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                currentJob = null; 
            }

            UpdateJobList();

            lblCurrentJob.Text = "No job is being processed.";
            lblEstimatedTime.Text = "Estimated Time: N/A";
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void StopProcessing_Click(object sender, EventArgs e)
        {
            printTimer.Stop();
            lblTimeRemaining.Text = "Processing stopped.";

            lblCurrentJob.Text = "No job is being processed.";
            lblEstimatedTime.Text = "Estimated Time: N/A";

            MessageBox.Show("Processing has been stopped.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ContinueProcessing.Enabled = currentJob != null && remainingTime > 0;
        }

        private void ContinueProcessing_Click(object sender, EventArgs e)
        {
            if (currentJob != null && remainingTime > 0)
            {
                printTimer.Start(); 
                MessageBox.Show("Resuming printing.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No job to resume.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Queuestatic_Click(object sender, EventArgs e)
        {
            QueueStatistics(jobQueue, Statistics);
        }

        public static void QueueStatistics(Queue<PrintJob> jobQueue, ListBox lblStatistics)
        {
            lblStatistics.Items.Clear();

            if (jobQueue.Count == 0)
            {
                lblStatistics.Items.Add("No jobs in the queue.");
                return;
            }

            int totalJobs = jobQueue.Count;
            int totalPages = 0;
            int doubleSidedJobs = 0;

            foreach (var job in jobQueue)
            {
                totalPages += job.PageCount;
                if (job.IsDoubleSided) doubleSidedJobs++;
            }

            lblStatistics.Items.Add($"Queue Statistics:");
            lblStatistics.Items.Add($"Total Jobs: {totalJobs}");
            lblStatistics.Items.Add($"Total Pages: {totalPages}");
            lblStatistics.Items.Add($"Double-Sided Jobs: {doubleSidedJobs}");
        }

        private void Printalljob_Click(object sender, EventArgs e)
        {
            lstJobs.Items.Clear();

            if (jobQueue.Count == 0)
            {
                lstJobs.Items.Add("No jobs in the queue.");
                return;
            }

            foreach (var job in jobQueue)
            {
                lstJobs.Items.Add(job.ToString());
            }
        }

    }
}
