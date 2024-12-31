using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListOperations.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách liên kết vòng
            CircularLinkedList list = new CircularLinkedList();

            // Nhập danh sách từ người dùng
            // Console.WriteLine("Initialize the Product List:");
            //list.InitializeList(); // Gọi hàm nhập danh sách sản phẩm từ người dùng

            list.AddLast(list.CreateNode(new Product("Broom", 2.5f)));
            list.AddLast(list.CreateNode(new Product("Mop", 3.0f)));
            list.AddLast(list.CreateNode(new Product("Bucket", 4.0f)));
            list.AddLast(list.CreateNode(new Product("Cloth", 1.0f)));
            list.AddLast(list.CreateNode(new Product("Sponge", 0.5f)));
            list.AddLast(list.CreateNode(new Product("Detergent", 5.0f)));
            list.AddLast(list.CreateNode(new Product("Trash Can", 10.0f)));
            list.AddLast(list.CreateNode(new Product("Dish Rack", 7.0f)));
            list.AddLast(list.CreateNode(new Product("Vacuum Cleaner", 50.0f)));
            list.AddLast(list.CreateNode(new Product("Iron", 20.0f)));




            list.PrintList();

            // Sắp xếp theo tên (tăng dần)
            list.QuickSort();
            Console.WriteLine("\nAfter sorting by name :");
            list.PrintList();

            // Sắp xếp danh sách sau khi nhập
            list.SelectionSort(list.CompareByPrice);
            Console.WriteLine("\nAfter Sorting by Price:");
            list.PrintList(); // In danh sách đã được sắp xếp

            // Đảo ngược danh sách
            list.ReverseList();
            Console.WriteLine("\nAfter Reversing the List:");
            list.PrintList();

            // Thêm node vào đầu danh sách
            list.AddFirst(list.CreateNode(new Product("Product0", 5)));
            Console.WriteLine("\nAfter Adding First:");
            list.PrintList();

            // Tìm kiếm node theo tên
            var searchResult = list.SearchNode("Product2");
            if (searchResult != null)
            {
                Console.WriteLine($"\nFound: {searchResult.Data.Name}, Price: {searchResult.Data.Price}");
            }

            // Xóa node cuối cùng
            list.RemoveLast();
            Console.WriteLine("\nAfter Removing Last:");
            list.PrintList();



            // Xóa các node có giá lớn hơn 15
            list.RemoveNodesByCondition(product => product.Price >= 5);
            Console.WriteLine("\nAfter Removing Nodes with Price >= 5:");
            list.PrintList();

            // Gộp với một danh sách khác
            CircularLinkedList otherList = new CircularLinkedList();
            otherList.AddLast(otherList.CreateNode(new Product("OtherProduct1", 50)));
            otherList.AddLast(otherList.CreateNode(new Product("OtherProduct2", 60)));

            list.MergeSortedLists(otherList);
            Console.WriteLine("\nAfter Merging with Another List:");
            list.PrintList();

            Console.ReadLine();

        }
    }
}
   

