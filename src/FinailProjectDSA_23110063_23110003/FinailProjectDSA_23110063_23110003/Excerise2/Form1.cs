using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QueueProject
{
    public partial class Form1 : Form
    {
        private Queue printQueue = new Queue(); 
        private List<PrintJob> completedJobs = new List<PrintJob>();

        public Form1()
        {
            InitializeComponent();
            printQueue.InitQueue();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            
            string docName = namedoctextBox.Text;
            if (int.TryParse(pagecounttextBox.Text, out int pageCount) && pageCount > 0)
            {
                PrintJob job = new PrintJob(docName, pageCount);
                printQueue.EnQueue(job); 
                UpdateQueueDisplay();
                namedoctextBox.Clear();
                pagecounttextBox.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid page number.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateQueueDisplay()
        {
            mainlistBox.Items.Clear();
            Node current = printQueue.FrontNode(); 
            while (current != null)
            {
                mainlistBox.Items.Add(current.Info.ToString());
                current = current.Next;
            }
        }

        private void UpdateCompletedJobsDisplay()
        {
            foreach (var job in completedJobs)
            {
                completedjoblistBox.Items.Add(job.ToString());
            }
            totalprintlabel.Text = $"Total number of printed documents: {completedJobs.Count}";
            totalcountlabel.Text = $"Total number of copies printed: {completedJobs.Sum(j => j.CopyCount)}";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            if (printQueue.IsEmptyQueue())
            {
                MessageBox.Show("Queue is empty.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Node jobNode = printQueue.DeQueue(); 
                if (jobNode != null)
                {
                    PrintJob job = jobNode.Info;
                    completedJobs.Add(job); 
                    MessageBox.Show($"Printing: {job}","Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateQueueDisplay();
                    completedjoblistBox.Items.Clear();
                    UpdateCompletedJobsDisplay();
                }
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (printQueue.IsEmptyQueue())
                MessageBox.Show("Queue is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                printQueue.Clear();
                UpdateQueueDisplay();
            }
        }
    
    }
}
