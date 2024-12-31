using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Product(string id, string name, int quantity)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Tên: {Name}, Số lượng: {Quantity}";
        }

        public static void AddProduct(Stack<Product> warehouse)
        {
            Console.Write("Nhập ID sản phẩm: ");
            string id = Console.ReadLine();
            Console.Write("Nhập tên sản phẩm: ");
            string name = Console.ReadLine();
            Console.Write("Nhập số lượng: ");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
            {
                Console.Write("Số lượng không hợp lệ. Nhập lại: ");
            }

            warehouse.Push(new Product(id, name, quantity));
            Console.WriteLine("Nhập hàng thành công!");
        }

        public static void RemoveProduct(Stack<Product> warehouse)
        {
            if (warehouse.Count > 0)
            {
                Product exportedProduct = warehouse.Pop();
                Console.WriteLine($"Sản phẩm đã xuất: {exportedProduct}");
            }
            else
            {
                Console.WriteLine("Kho hàng rỗng, không thể xuất hàng.");
            }
        }

        public static void DisplayWarehouse(Stack<Product> warehouse)
        {
            if (warehouse.Count > 0)
            {
                Console.WriteLine("Danh sách sản phẩm trong kho:");
                foreach (var product in warehouse)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.WriteLine("Kho hàng rỗng.");
            }
        }

        public static void SearchProduct(Stack<Product> warehouse)
        {
            Console.Write("Nhập ID hoặc tên sản phẩm cần tìm: ");
            string keyword = Console.ReadLine().ToLower();
            bool found = false;

            foreach (var product in warehouse)
            {
                if (product.Id.ToLower().Contains(keyword) || product.Name.ToLower().Contains(keyword))
                {
                    Console.WriteLine($"Tìm thấy: {product}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy sản phẩm nào.");
            }
        }

        public static void UpdateProduct(Stack<Product> warehouse)
        {
            Console.Write("Nhập ID sản phẩm cần cập nhật: ");
            string id = Console.ReadLine();
            bool found = false;
            Stack<Product> tempStack = new Stack<Product>();

            while (warehouse.Count > 0)
            {
                Product product = warehouse.Pop();
                if (product.Id == id)
                {
                    Console.Write("Nhập tên mới (để trống nếu không thay đổi): ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newName))
                    {
                        product.Name = newName;
                    }

                    Console.Write("Nhập số lượng mới (nhập 0 nếu không thay đổi): ");
                    if (int.TryParse(Console.ReadLine(), out int newQuantity) && newQuantity > 0)
                    {
                        product.Quantity = newQuantity;
                    }

                    Console.WriteLine("Cập nhật thành công!");
                    found = true;
                }
                tempStack.Push(product);
            }

            while (tempStack.Count > 0)
            {
                warehouse.Push(tempStack.Pop());
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy sản phẩm với ID đã nhập.");
            }
        }

        public static void ShowTotalQuantity(Stack<Product> warehouse)
        {
            int totalQuantity = 0;
            foreach (var product in warehouse)
            {
                totalQuantity += product.Quantity;
            }

            Console.WriteLine($"Tổng số lượng sản phẩm trong kho: {totalQuantity}");
        }

        public static void ShowMostRecentProduct(Stack<Product> warehouse)
        {
            if (warehouse.Count > 0)
            {
                Product mostRecent = warehouse.Peek();
                Console.WriteLine($"Sản phẩm gần đây nhất: {mostRecent}");
            }
            else
            {
                Console.WriteLine("Kho hàng rỗng.");
            }
        }

        public static void ClearWarehouse(Stack<Product> warehouse)
        {
            warehouse.Clear();
            Console.WriteLine("Toàn bộ sản phẩm trong kho đã bị xóa.");
        }
    }
}

