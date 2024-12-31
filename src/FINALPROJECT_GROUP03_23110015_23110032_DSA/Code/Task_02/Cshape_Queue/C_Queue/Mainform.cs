using System;
using System.Collections.Generic;
using System.Drawing; 
using System.Windows.Forms;

namespace C_Queue
{
    public partial class MainForm : Form
    {
        private LinkedListQueue mainQueue;

        public MainForm()
        {
            InitializeComponent();
            mainQueue = new LinkedListQueue();
        }

        private void buttonChooseCombos_Click(object sender, EventArgs e)
        {
            Form2 customerInfo = new Form2();
            customerInfo.ShowDialog();

            if (customerInfo.IsInfoProvided)
            {
                mainQueue.AddLast(customerInfo.CustomerName, customerInfo.SelectedCombos);

                // Add customer details to dataGridView1
                dataGridView1.Rows.Add(customerInfo.CustomerName, customerInfo.SelectedCombos);
            }
        }

        private void buttonDelivered_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Press Choose Combo");
                    return;
                }

                var customer = mainQueue.RemoveFirst();

                // Add the delivered customer to dataGridView2
                dataGridView2.Rows.Add(customer.CustomerName, customer.SelectedCombos);

                // Remove the first customer from dataGridView1
                dataGridView1.Rows.RemoveAt(0);

                // Check again if the queue is empty after removing the customer
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Press choose Combo");
                }
                else
                {
                    MessageBox.Show("Delivered successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void buttonClosed_Click(object sender, EventArgs e)
        {
            mainQueue = new LinkedListQueue();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            MessageBox.Show("All consultations cleared.");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateDataGridView(DataGridView dataGridView, List<(string CustomerName, string SelectedCombos)> values)
        {
            dataGridView.Rows.Clear();
            foreach (var value in values)
            {
                dataGridView.Rows.Add(value.CustomerName, value.SelectedCombos);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
