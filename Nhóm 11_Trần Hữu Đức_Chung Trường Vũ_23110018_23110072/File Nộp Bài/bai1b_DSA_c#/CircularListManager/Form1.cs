using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircularListManager
{
    public partial class Form1 : Form
    {
        private CircularLinkedList productList;  // Khai báo productList

        public Form1()
        {
            InitializeComponent();
            // Truyền ListBox từ giao diện vào CircularLinkedList
            productList = new CircularLinkedList(listBoxProducts);
  //          secondList = new CircularLinkedList(listBoxSecondList);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Bạn có thể thêm logic cần thiết cho sự kiện này ở đây
            int productCount;
            if (int.TryParse(txtProductCount.Text, out productCount))
            {
                // Cập nhật hành động khi nhập đúng số
            }
            else
            {
                // Cập nhật thông báo lỗi nếu người dùng nhập sai
                MessageBox.Show("Please enter a valid number.");
            }
        }

        // Phương thức xử lý sự kiện SelectedIndexChanged
        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu có mục nào được chọn
            if (listBoxProducts.SelectedIndex != -1)
            {
                string selectedItem = listBoxProducts.SelectedItem.ToString();
                MessageBox.Show("You selected: " + selectedItem);
            }
        }

        // Khi nhấn nút "Initialize List"
        private void btnInitializeList_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtProductCount.Text, out int numberOfProducts) || numberOfProducts <= 0)
                {
                    MessageBox.Show("Please enter a valid number of products.");
                    return;
                }

                // Khởi tạo danh sách
                productList.Clear();

                for (int i = 0; i < numberOfProducts; i++)
                {
                    string name = Prompt.ShowDialog($"Enter name for Product {i + 1}:", "Product Name");
                    if (string.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("Product name cannot be empty.");
                        continue;
                    }

                    if (!float.TryParse(Prompt.ShowDialog($"Enter price for {name}:", "Product Price"), out float price))
                    {
                        MessageBox.Show("Invalid price. Please try again.");
                        continue;
                    }

                    // Thêm sản phẩm vào danh sách
                    productList.AddLast(new Node(new Product(name, price)));
                }

                // Cập nhật giao diện
                DisplayProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // nhấn addfirst
        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại để người dùng nhập tên sản phẩm
            string name = Prompt.ShowDialog("Enter product name: ", "Add First");
            if (string.IsNullOrEmpty(name)) return; // Kiểm tra nếu tên trống

            // Hiển thị hộp thoại để người dùng nhập giá sản phẩm
            float price;
            string priceString = Prompt.ShowDialog("Enter product price: ", "Price");
            if (!float.TryParse(priceString, out price)) return; // Kiểm tra nếu giá không hợp lệ

            // Tạo sản phẩm mới và thêm vào danh sách
            Product newProduct = new Product(name, price);
            Node newNode = new Node(newProduct);

            // Thêm sản phẩm vào đầu danh sách
            productList.AddFirst(newNode);

            // Cập nhật giao diện sau khi thêm sản phẩm
            DisplayProductList();
        }
        // Khi nhấn nút "Add Last"
        private void btnAddLast_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại để người dùng nhập tên sản phẩm
            string name = Prompt.ShowDialog("Enter product name: ", "Add Last");
            if (string.IsNullOrEmpty(name)) return; // Kiểm tra nếu tên trống

            // Hiển thị hộp thoại để người dùng nhập giá sản phẩm
            float price;
            string priceString = Prompt.ShowDialog("Enter product price: ", "Price");
            if (!float.TryParse(priceString, out price)) return; // Kiểm tra nếu giá không hợp lệ

            // Tạo sản phẩm mới và thêm vào danh sách
            Product newProduct = new Product(name, price);
            Node newNode = new Node(newProduct);

            // Thêm sản phẩm vào cuối danh sách
            productList.AddLast(newNode);

            // Cập nhật giao diện sau khi thêm sản phẩm
            DisplayProductList();
        }
        // Khi nhấn nút "Add After"

        private void btnAddAfter_Click(object sender, EventArgs e)
        {
            string afterProductName = Prompt.ShowDialog("Enter the product name to add after: ", "Add After");
            MessageBox.Show($"Searching for: {afterProductName}");  // Hiển thị tên sản phẩm cần tìm
            if (string.IsNullOrEmpty(afterProductName)) return;

            string name = Prompt.ShowDialog("Enter product name: ", "New Product");
            if (string.IsNullOrEmpty(name)) return;

            float price;
            string priceString = Prompt.ShowDialog("Enter product price: ", "Price");
            if (!float.TryParse(priceString, out price)) return;

            Product newProduct = new Product(name, price);
            Node newNode = new Node(newProduct);


            if (afterProductName != "")
            {
                productList.AddAfter(newNode, afterProductName);  // Thêm node mới sau node tìm thấy
                MessageBox.Show("Product added after " + afterProductName);
            }
            else
            {
                MessageBox.Show("Product not found.");
            }

            DisplayProductList();  // Cập nhật danh sách hiển thị
        }


        // Khi nhấn "Remove First"
        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            // Gọi phương thức RemoveFirst để xóa phần tử đầu tiên
            productList.RemoveFirst();
            DisplayProductList();

        }

        // Khi nhấn "Remove Last"
        private void btnRemoveLast_Click(object sender, EventArgs e)
        {
            // Gọi phương thức RemoveLast để xóa phần tử cuối cùng
            productList.RemoveLast();
            DisplayProductList();
        }
        // Khi nhấn "Remove After"
        private void btnRemoveAfter_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại để người dùng nhập tên sản phẩm
            string afterProductName = Prompt.ShowDialog("Enter product name to remove after:", "Remove After");
            if (string.IsNullOrEmpty(afterProductName)) return;

            // Gọi phương thức RemoveAfter để xóa phần tử sau tên sản phẩm đó
            productList.RemoveAfter(afterProductName);
            DisplayProductList();
        }
        // Khi nhấn "Sort by QuickSort"
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            try
            {
                productList.QuickSort(); // Sắp xếp theo QuickSort
                MessageBox.Show("List sorted by QuickSort!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Khi nhấn "Sort by SelectionSort"
        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            try
            {
                productList.SelectionSort(); // Sắp xếp theo SelectionSort
                MessageBox.Show("List sorted by SelectionSort!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Reverse List
        private void btnReverseList_Click(object sender, EventArgs e)
        {
            try
            {
                productList.ReverseList();
                MessageBox.Show("The list has been reversed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //// khi nhấn merge 
        //private void btnMergeLists_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Kiểm tra nếu secondList rỗng
        //        if (secondList.IsEmpty())
        //        {
        //            MessageBox.Show("The second list is empty. Nothing to merge.");
        //            return;
        //        }

        //        // Gọi phương thức MergeSortedLists để hợp nhất secondList vào productList
        //        productList.MergeSortedLists(secondList);
        //        MessageBox.Show("The lists have been merged.");

        //        // Cập nhật giao diện để hiển thị danh sách sau khi hợp nhất
        //        DisplayProductList();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}


        // Hiển thị danh sách sản phẩm trong ListBox
        private void DisplayProductList()
        {
            listBoxProducts.Items.Clear(); // Xóa dữ liệu cũ
            foreach (var productString in productList.GetListAsString()) // Lấy danh sách sản phẩm dưới dạng chuỗi
            {
                listBoxProducts.Items.Add(productString); // Thêm sản phẩm (chuỗi mô tả sản phẩm)
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}

 

    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                Text = caption
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Width = 250, Text = text };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 250 };
            Button confirmation = new Button() { Text = "Ok", Left = 200, Width = 75, Top = 70 };

            // Xử lý sự kiện khi bấm Enter trên bàn phím
            inputBox.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)  // Kiểm tra nếu phím Enter được nhấn
                {
                    confirmation.PerformClick(); // Kích hoạt nút OK
                }
            };

            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.ShowDialog();

            return inputBox.Text;
        }

    }

