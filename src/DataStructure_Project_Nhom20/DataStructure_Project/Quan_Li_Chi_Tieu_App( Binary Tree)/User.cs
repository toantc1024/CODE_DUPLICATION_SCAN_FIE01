namespace Quan_Li_Chi_Tieu_App
{
    public class User
    {
        public string Name { get; set; }
        public TransactionTree Transactions { get; set; } // Sử dụng cấu trúc cây để lưu trữ giao dịch
        public Dictionary<string, decimal> SpendingLimits { get; set; } // Lưu hạn mức chi tiêu theo danh mục

        public User(string name)
        {
            Name = name;
            Transactions = new TransactionTree(); // Khởi tạo cây giao dịch
            SpendingLimits = new Dictionary<string, decimal>(); // Khởi tạo hạn mức chi tiêu
        }


        public void SetSpendingLimit(string category, decimal limit)
        {
            SpendingLimits[category] = limit;
        }


        public void AddTransaction(decimal amount, string description, string category)
        {
            // Thêm giao dịch mới vào cây
            Transactions.AddTransaction(amount, description, category);
        }

  
        public List<TransactionNode> GetTransactions()
        {
            return Transactions.GetTransactions(); // Lấy toàn bộ giao dịch từ cây
        }

  
        public decimal CalculateTotalSpent()
        {
            return Transactions.CalculateTotalAmount(); // Tổng hợp số tiền từ cây giao dịch
        }

        public string GetTransactionsText()
        {
            return Transactions.GetTransactionsText(); // Lấy danh sách giao dịch dạng chuỗi
        }
    }
}