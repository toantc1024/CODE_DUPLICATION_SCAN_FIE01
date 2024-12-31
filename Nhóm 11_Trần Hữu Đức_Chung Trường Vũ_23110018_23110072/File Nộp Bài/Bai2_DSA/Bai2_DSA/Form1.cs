namespace Bai2_DSA
{
    public partial class QuanLyChiTieu : Form
    {
        // Khai báo biến, stack
        int totalIncome = 0;
        private Stack<GiaoDich> pStack = new Stack<GiaoDich>();
        private Stack<string> transactionHistory = new Stack<string>();
        private int totalThu = 0;
        private int totalChi = 0;

        // Phương thức khởi tạo và cấu hình giao diện
        public QuanLyChiTieu()
        {
            InitializeComponent();
        }

        // Class GiaoDich
        public class GiaoDich
        {
            public string MaGD;
            public string TenGD;
            public string SoGD;
            public string ThuOrChi;

            public override string ToString()
            {
                return MaGD + " - " + TenGD + " - " + SoGD + " - " + ThuOrChi;
            }
        }

        // Lớp các hàm liên quan đến Stack
        public class Stack<T>
        {
            private List<T> elements = new List<T>();

            // Thêm phần tử vào đầu stack
            public void Push(T item)
            {
                elements.Add(item);
            }

            // Lấy ra phần tử trên cùng stack
            public T Pop()
            {
                if (elements.Count == 0)
                    throw new InvalidOperationException("Stack is empty.");

                T item = elements[elements.Count - 1];
                elements.RemoveAt(elements.Count - 1);
                return item;
            }

            // Xem phần tử trên cùng stack
            public T Peek()
            {
                if (elements.Count == 0)
                    throw new InvalidOperationException("Stack is empty.");

                return elements[elements.Count - 1];
            }

            // Kiểm tra stack có rỗng hay không
            public bool IsEmpty()
            {
                return elements.Count == 0;
            }

            // Đếm số lượng phần tử trong stack
            public int Count()
            {
                return elements.Count;
            }

            // Xoá tất cả phầ tử trong stack
            public void Clear()
            {
                elements.Clear();
            }

            // Tìm phần tử đầu tiên trong stack thoả điều kiện
            public T FirstOrDefault(Func<T, bool> dk)
            {
                if (dk == null)
                    throw new ArgumentNullException(nameof(dk));

                foreach (var item in elements)
                {
                    if (dk(item))
                    {
                        return item;
                    }
                }

                return default(T);
            }

            // Trả về phần tử tại vị trí(vt) xác định
            public T ElementAt(int vt)
            {
                if (vt < 0 || vt >= elements.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(vt), "Index is out of range.");
                }
                return elements[vt];
            }
            
        }

        // Giao diện Form1
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        // Thêm giao dịch vào ...
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaGD.Text) ||
                string.IsNullOrWhiteSpace(txtTenGD.Text) ||
                string.IsNullOrWhiteSpace(txtAmount.Text) ||
                cbTransactionType.SelectedIndex == -1)

            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedTransactionType = cbTransactionType.SelectedItem?.ToString();

            var gd = new GiaoDich
            {
                MaGD = txtMaGD.Text.Trim(),
                TenGD = txtTenGD.Text.Trim(),
                SoGD = txtAmount.Text.Trim(),
                ThuOrChi = selectedTransactionType
            };

            int amount;
            if (!int.TryParse(txtAmount.Text.Trim(), out amount) || amount <= 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedTransactionType == "Thu")
            {
                totalThu += amount;
            }
            else if (selectedTransactionType == "Chi")
            {
                totalChi += amount;
            }

            var VND = new System.Globalization.CultureInfo("vi-VN");
            lblTotalThu.Text = "Tổng Thu: " + totalThu.ToString("C0", VND);
            lblTotalChi.Text = "Tổng Chi: " + totalChi.ToString("C0", VND);

            pStack.Push(gd);
            UpdateTradeDisplay();
            ClearInputFields();
        }

        // Bảng hiện thông tin giao dịch
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Lấy ra giao dịch trên đầu
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (pStack.IsEmpty())
            {
                MessageBox.Show("Danh sách các giao dịch đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var gdXoa = pStack.Pop();
            int amount;
            if (int.TryParse(gdXoa.SoGD, out amount))
            {
                if (gdXoa.ThuOrChi == "Thu")
                {
                    totalThu -= amount;
                }
                else if (gdXoa.ThuOrChi == "Chi")
                {
                    totalChi -= amount;
                }
            }
            else
            {
                MessageBox.Show("Số tiền giao dịch không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            var VND = new System.Globalization.CultureInfo("vi-VN");
            lblTotalThu.Text = "Tổng Thu: " + totalThu.ToString("C0", VND);
            lblTotalChi.Text = "Tổng Chi: " + totalChi.ToString("C0", VND);
            MessageBox.Show("Đã xóa: " + gdXoa, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateTradeDisplay();
        }

        // Tìm kiếm giao dịch theo ID, tên
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtMaGD.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var GdTimThay = pStack.FirstOrDefault(gd => gd.MaGD == keyword || gd.TenGD.Contains(keyword, StringComparison.OrdinalIgnoreCase));

            if (GdTimThay != null)
            {
                MessageBox.Show("Tìm thấy: " + GdTimThay, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy giao dịch mà bạn đang tìm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Chỉnh sửa thông tin giao dịch sau khi tìm thấy
        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            string keyword = txtMaGD.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập mã hoặc tên giao dịch cần thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (pStack.IsEmpty())
            {
                MessageBox.Show("Danh sách các giao dịch đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Stack<GiaoDich> temp = new Stack<GiaoDich>();
            bool found = false;

            int count = pStack.Count();
            while (count > 0)
            {
                var gd = pStack.Pop();
                count--; // Decrease the count after popping

                if (!found && (gd.MaGD == keyword || gd.TenGD.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                {
                    int oldAmount = 0;
                    int.TryParse(gd.SoGD, out oldAmount);

                    gd.TenGD = txtTenGD.Text.Trim();
                    gd.SoGD = txtAmount.Text.Trim();
                    gd.ThuOrChi = cbTransactionType.SelectedItem?.ToString();
                    found = true;

                    int newAmount = 0;
                    int.TryParse(gd.SoGD, out newAmount);

                    if (gd.ThuOrChi == "Thu")
                    {
                        totalThu = totalThu - oldAmount + newAmount;
                    }
                    else if (gd.ThuOrChi == "Chi")
                    {
                        totalChi = totalChi - oldAmount + newAmount;
                    }
                }

                var VNDD = new System.Globalization.CultureInfo("vi-VN");
                lblTotalThu.Text = "Tổng Thu: " + totalThu.ToString("C0", VNDD);
                lblTotalChi.Text = "Tổng Chi: " + totalChi.ToString("C0", VNDD);
                temp.Push(gd);
            }

            int tempCount = temp.Count();
            while (tempCount > 0)
            {
                pStack.Push(temp.Pop());
                tempCount--; // Decrease the tempCount after pushing
            }

            if (found)
            {
                MessageBox.Show("Đã thay đổi thông tin giao dịch.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy giao dịch phù hợp để thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var VND = new System.Globalization.CultureInfo("vi-VN");
            lblTotalThu.Text = "Tổng Thu: " + totalThu.ToString("C0", VND);
            lblTotalChi.Text = "Tổng Chi: " + totalChi.ToString("C0", VND);

            UpdateTradeDisplay();
            ClearInputFields();
        }

        // Cập nhật lại bảng thông tin giao dịch
        private void UpdateTradeDisplay()
        {
            Display.Items.Clear();
            for (int i = pStack.Count() - 1; i >= 0; i--)
            {
                Display.Items.Add(pStack.ElementAt(i));
            }
        }

        // Xoá thông tin vừa nhập trên khung nhập
        private void ClearInputFields()
        {
            txtMaGD.Clear();
            txtTenGD.Clear();
            txtAmount.Clear();
        }

        // Mã giao dịch
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string maGD = txtMaGD.Text.Trim();
        }

        // Xem giao dịch trên đầu
        private void btnXemDinh_Click_1(object sender, EventArgs e)
        {
            int count = pStack.Count();
            if (count == 0)
            {
                MessageBox.Show("Danh sách các giao dịch đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var GdGanNhat = pStack.Peek();
            MessageBox.Show("Giao dịch gần nhất:\nMã GD: " + GdGanNhat.MaGD + "\nTên: " + GdGanNhat.TenGD + "\nSố tiền: " + GdGanNhat.SoGD + "\n Trạng thái: " + GdGanNhat.ThuOrChi,

                            "Thông tin giao dịch",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // Xoá hết lịch sử giao dịch
        private void btnXoaHet_Click_1(object sender, EventArgs e)
        {
            int count=pStack.Count();
            if (count == 0)
            {
                MessageBox.Show("Danh sách đã trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            totalThu = 0;
            totalChi = 0;
            var VND = new System.Globalization.CultureInfo("vi-VN");
            lblTotalThu.Text = "Tổng Thu: " + totalThu.ToString("C0", VND);
            lblTotalChi.Text = "Tổng Chi: " + totalChi.ToString("C0", VND);
            pStack.Clear();
            UpdateTradeDisplay();
            MessageBox.Show("Danh sách giao dịch đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Đếm số lượng giao dịch
        private void btn_Dem_Click(object sender, EventArgs e)
        {
            int count = pStack.Count();
            MessageBox.Show("Hiện tại có +" + count + " giao dịch trong danh sách",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        // Lượng tiền giao dịch
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            if (int.TryParse(txtAmount.Text.Trim(), out int SoGD))
            {
            }
        }

        // Tên giao dịch
        private void txtTenGd_TextChanged(object sender, EventArgs e)
        {
            string tenGD = txtTenGD.Text.Trim();
            if (!string.IsNullOrEmpty(tenGD))
            {
            }
            else
            {
            }
        }

        // Chọn loại giao dịch(Thu or chi)
        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTransactionType = cbTransactionType.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedTransactionType))
            {
                return;
            }

            if (selectedTransactionType == "Thu")
            {
            }
            else if (selectedTransactionType == "Chi")
            {
                // Xử lý khi chọn "Chi"
            }
        }

        // Hiện thông tin tổng thu được
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // Hiện thông tin tổng khoảng chi ra
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
