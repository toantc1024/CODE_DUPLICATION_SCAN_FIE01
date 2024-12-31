using System;
using System.Collections.Generic;
using System.Text;
    
namespace application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Stack<Product> warehouse = new Stack<Product>();

            while (true)
            {
                Console.WriteLine("\n--- Quản Lý Kho Hàng ---");
                Console.WriteLine("1. Nhập hàng");
                Console.WriteLine("2. Xuất hàng");
                Console.WriteLine("3. Hiển thị kho");
                Console.WriteLine("4. Tìm kiếm sản phẩm");
                Console.WriteLine("5. Cập nhật thông tin sản phẩm");
                Console.WriteLine("6. Thống kê tổng số lượng sản phẩm");
                Console.WriteLine("7. Hiển thị sản phẩm gần đây nhất");
                Console.WriteLine("8. Xóa toàn bộ sản phẩm trong kho");
                Console.WriteLine("9. Thoát");
                Console.Write("Chọn một tùy chọn (1-9): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Product.AddProduct(warehouse);
                        break;
                    case "2":
                        Product.RemoveProduct(warehouse);
                        break;
                    case "3":
                        Product.DisplayWarehouse(warehouse);
                        break;
                    case "4":
                        Product.SearchProduct(warehouse);
                        break;
                    case "5":
                        Product.UpdateProduct(warehouse);
                        break;
                    case "6":
                        Product.ShowTotalQuantity(warehouse);
                        break;
                    case "7":
                        Product.ShowMostRecentProduct(warehouse);
                        break;
                    case "8":
                        Product.ClearWarehouse(warehouse);
                        break;
                    case "9":
                        Console.WriteLine("Thoát chương trình.");
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }
            }
        }
    }
}

