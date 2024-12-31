using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA
{
    public partial class Form1 : Form
    {
        private List<Table> tables = new List<Table>();
        private Queue<string> waitingQueue = new Queue<string>();
        private Table selectedTable; // Lưu bàn được chọn
        private Table destinationTable; // Lưu bàn đích được chọn 
        private Dictionary<string, Table> reservations = new Dictionary<string, Table>(); // Lưu tên khách và bàn đặt trước
        public Form1()
        {
            InitializeComponent();
            InitializeTables(5);
        }
        private void InitializeTables(int tableCount)
        {
            for (int i = 1; i <= tableCount; i++)
            {
                string tableName = "Bàn " + i;

                var newTable = new Table
                {
                    Name = tableName,
                    CustomerName = null,
                    TableButton = CreateTableButton(tableName) // Tạo nút bàn
                };

                tables.Add(newTable);
            }
        }

        private Button CreateTableButton(string tableName)
        {
            Button btn = new Button
            {
                Text = tableName + "\n(Trống)",
                BackColor = Color.Green,
                Width = 100,
                Height = 50,
                Margin = new Padding(5),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Sự kiện Click để chọn bàn
            btn.Click += (s, e) =>
            {
                if (selectedTable == null)
                {
                    selectedTable = tables.Find(t => t.TableButton == btn);
                    MessageBox.Show($"Đã chọn {selectedTable.Name} làm bàn nguồn.", "Thông báo");
                }
                else if (destinationTable == null)
                {
                    destinationTable = tables.Find(t => t.TableButton == btn);
                    MessageBox.Show($"Đã chọn {destinationTable.Name} làm bàn đích.", "Thông báo");
                }
            };

            flowLayoutPanelTables.Controls.Add(btn); // Thêm vào FlowLayoutPanel
            return btn;
        }

        
        private void UpdateWaitingList()
        {
            listBoxQueue.Items.Clear();

            foreach (var customer in waitingQueue)
            {
                listBoxQueue.Items.Add(customer);
            }
        }

        
        private void UpdateTableStatus()
        {
            foreach (var table in tables)
            {
                Button tableButton = table.TableButton;

                if (reservations.ContainsValue(table)) // Bàn được đặt trước
                {
                    string reservedCustomer = reservations.FirstOrDefault(r => r.Value == table).Key;
                    tableButton.BackColor = Color.DeepSkyBlue;
                    tableButton.Text = $"{table.Name}\n(Đặt trước: {reservedCustomer})";
                }
                else if (table.CustomerName == null) // Bàn trống
                {
                    tableButton.BackColor = Color.Green;
                    tableButton.Text = $"{table.Name}\n(Trống)";
                }
                else // Bàn có khách
                {
                    tableButton.BackColor = Color.Red;
                    tableButton.Text = $"{table.Name}\n({table.CustomerName})";
                }
            }
        }

       

        
        private void ResetTableSelection()
        {
            selectedTable = null;
            destinationTable = null;
        }

       

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi");
                return;
            }

            // Kiểm tra xem khách có đặt trước không
            if (reservations.ContainsKey(customerName))
            {
                Table reservedTable = reservations[customerName];
                reservedTable.CustomerName = customerName;
                reservedTable.TableButton.BackColor = Color.Red;
                reservations.Remove(customerName);

                MessageBox.Show($"Khách hàng {customerName} đã được xếp vào {reservedTable.Name} theo đặt trước.", "Thông báo");
                UpdateTableStatus();
                txtCustomerName.Clear();
                return;
            }

            // Nếu không đặt trước, thêm vào hàng chờ
            waitingQueue.Enqueue(customerName);
            UpdateWaitingList();
            txtCustomerName.Clear();

            MessageBox.Show($"Khách hàng {customerName} đã được thêm vào danh sách chờ.", "Thông báo");
        }
        private void btnReserveTable_Click(object sender, EventArgs e)
        {
            if (selectedTable == null || selectedTable.CustomerName != null)
            {
                MessageBox.Show("Hãy chọn một bàn trống để đặt trước.", "Thông báo");
                return;
            }

            string customerName = txtCustomerName.Text.Trim();
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo");
                return;
            }

            // Kiểm tra xem tên này đã đặt trước chưa
            if (reservations.ContainsKey(customerName))
            {
                MessageBox.Show("Khách hàng này đã đặt bàn trước rồi.", "Thông báo");
                return;
            }

            // Thêm vào danh sách đặt trước
            reservations[customerName] = selectedTable;
            selectedTable.CustomerName = customerName; // Gán tên khách hàng vào bàn
            selectedTable.TableButton.BackColor = Color.DeepSkyBlue; // Màu xanh nước biển
            selectedTable.TableButton.Text = $"{selectedTable.Name}\n(Đặt trước: {customerName})"; // Hiển thị thông tin

            MessageBox.Show($"Đã đặt trước {selectedTable.Name} cho {customerName}.", "Thông báo");

            // Xóa ô nhập tên và đặt lại lựa chọn
            txtCustomerName.Clear();
            selectedTable = null;
        }

        private void btnTransferCustomer_Click(object sender, EventArgs e)
        {
            if (selectedTable == null || selectedTable.CustomerName == null)
            {
                MessageBox.Show("Bàn nguồn không hợp lệ hoặc không có khách.", "Thông báo");
                ResetTableSelection(); // Đặt lại lựa chọn
                return;
            }

            // Kiểm tra bàn đích
            if (destinationTable == null || destinationTable.CustomerName != null)
            {
                MessageBox.Show("Bàn đích không hợp lệ hoặc đã có khách.", "Thông báo");
                ResetTableSelection(); // Đặt lại lựa chọn
                return;
            }

            // Thực hiện chuyển khách
            destinationTable.CustomerName = selectedTable.CustomerName;
            selectedTable.CustomerName = null;

            // Cập nhật giao diện
            UpdateTableStatus();

            MessageBox.Show($"Khách {destinationTable.CustomerName} đã được chuyển từ {selectedTable.Name} sang {destinationTable.Name}.", "Thông báo");

            // Đặt lại lựa chọn
            ResetTableSelection();
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Kiểm tra phím Enter
            {
                string customerName = txtCustomerName.Text.Trim();

                if (!string.IsNullOrEmpty(customerName))
                {
                    waitingQueue.Enqueue(customerName); // Thêm khách hàng vào hàng chờ
                    UpdateWaitingList(); // Cập nhật danh sách chờ
                    txtCustomerName.Clear(); // Xóa TextBox sau khi thêm
                    MessageBox.Show($"Khách hàng {customerName} đã được thêm vào danh sách chờ.", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng.", "Lỗi");
                }

                e.Handled = true; // Ngăn hành động mặc định
                e.SuppressKeyPress = true; // Ngăn phát ra âm thanh 'beep'
            }
        }

        private void btnCheckTable_Click(object sender, EventArgs e)
        {
            if (selectedTable == null)
            {
                MessageBox.Show("Hãy chọn một bàn để kiểm tra.", "Thông báo");
                return;
            }

            // Kiểm tra trạng thái bàn
            if (reservations.ContainsValue(selectedTable))
            {
                // Tìm khách hàng đặt trước bàn này
                string reservedCustomer = reservations.FirstOrDefault(r => r.Value == selectedTable).Key;
                MessageBox.Show($"{selectedTable.Name} đã được đặt trước bởi khách hàng: {reservedCustomer}.", "Thông báo");
            }
            else if (selectedTable.CustomerName == "(Đặt trước)")
            {
                MessageBox.Show($"{selectedTable.Name} đang được đặt trước.", "Thông báo");
            }
            else if (selectedTable.CustomerName == null)
            {
                MessageBox.Show($"{selectedTable.Name} đang trống.", "Thông báo");
            }
            else
            {
                MessageBox.Show($"{selectedTable.Name} đang có khách: {selectedTable.CustomerName}.", "Thông báo");
            }
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            int newTableIndex = tables.Count + 1;
            string newTableName = "Bàn " + newTableIndex;

            var newTable = new Table
            {
                Name = newTableName,
                CustomerName = null,
                TableButton = CreateTableButton(newTableName)
            };

            tables.Add(newTable);
            UpdateTableStatus();
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (selectedTable == null)
            {
                MessageBox.Show("Hãy chọn một bàn để xóa.", "Thông báo");
                return;
            }

            // Kiểm tra nếu bàn đang được đặt trước
            if (reservations.ContainsValue(selectedTable))
            {
                // Xóa thông tin khách hàng đặt trước
                string reservedCustomer = reservations.FirstOrDefault(r => r.Value == selectedTable).Key;
                reservations.Remove(reservedCustomer);

                // Đặt lại trạng thái bàn
                selectedTable.CustomerName = null;
                selectedTable.TableButton.BackColor = Color.Green;
                selectedTable.TableButton.Text = $"{selectedTable.Name}\n(Trống)";

                MessageBox.Show($"{selectedTable.Name} đã được hủy đặt trước bởi khách hàng: {reservedCustomer}.", "Thông báo");
            }
            else if (selectedTable.CustomerName != null)
            {
                // Trường hợp bàn có khách
                string customerName = selectedTable.CustomerName;

                // Đặt lại trạng thái bàn
                selectedTable.CustomerName = null;
                selectedTable.TableButton.BackColor = Color.Green;
                selectedTable.TableButton.Text = $"{selectedTable.Name}\n(Trống)";

                MessageBox.Show($"Khách hàng {customerName} đã được xóa khỏi bàn {selectedTable.Name}.", "Thông báo");
            }
            else
            {
                // Trường hợp bàn trống
                MessageBox.Show($"{selectedTable.Name} đang trống, không có thông tin để xóa.", "Thông báo");
            }

            // Đặt lại lựa chọn bàn
            selectedTable = null;
        }

        private void btnSeatCustomer_Click(object sender, EventArgs e)
        {
            if (waitingQueue.Count == 0)
            {
                MessageBox.Show("Không có khách hàng trong danh sách chờ.", "Thông báo");
                return;
            }

            var emptyTable = tables.Find(t => t.CustomerName == null);

            if (emptyTable == null)
            {
                MessageBox.Show("Không có bàn trống.", "Thông báo");
                return;
            }

            string customerName = waitingQueue.Dequeue();
            emptyTable.CustomerName = customerName;

            UpdateWaitingList();
            UpdateTableStatus();
        }
    }
    public class Table
    {
        public string Name { get; set; }
        public string CustomerName { get; set; }
        public Button TableButton { get; set; }
    }
}
