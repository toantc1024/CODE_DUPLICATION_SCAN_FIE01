using static Bai3_DSA.Form1;
using System.Collections.Generic;

namespace Bai3_DSA
{
    public partial class Form1 : Form
    {
        private ProductBinarySearchTree productTree;

        public Form1()
        {
            InitializeComponent();
            productTree = new ProductBinarySearchTree();
        }

        public class Product
        {
            public string ID;
            public string Name;
            public decimal Price;

            // Constructor for creating a Product
            public Product(string id, string name, decimal price)
            {
                ID = id;
                Name = name;
                Price = price;
            }
        }

        public class TreeNode
        {
            public Product Product;  // Stores the product
            public TreeNode Left;    // Left child
            public TreeNode Right;   // Right child

            // Constructor for TreeNode
            public TreeNode(Product product)
            {
                Product = product;
                Left = Right = null;
            }
        }

        public class ProductBinarySearchTree
        {
            public TreeNode Root { get; set; }

            public ProductBinarySearchTree()
            {
                Root = null;
            }

            // Insert a product into the tree
            public void Insert(Product product)
            {
                Root = InsertRecursive(Root, product);
            }

            private TreeNode InsertRecursive(TreeNode root, Product product)
            {
                if (root == null)
                {
                    return new TreeNode(product);  // Insert as a new node if root is null
                }

                // Compare the product IDs to decide where to insert
                if (string.Compare(product.ID, root.Product.ID) < 0)
                {
                    root.Left = InsertRecursive(root.Left, product);  // Go left if smaller
                }
                else
                {
                    root.Right = InsertRecursive(root.Right, product);  // Go right if larger or equal
                }

                return root;
            }

            // In-order traversal to get products in sorted order (by product ID)
            public void InOrderTraversal(TreeNode root, List<Product> products)
            {
                if (root != null)
                {
                    InOrderTraversal(root.Left, products);  // Traverse left subtree
                    products.Add(root.Product);  // Add the product to the list
                    InOrderTraversal(root.Right, products);  // Traverse right subtree
                }
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 5)
            {
                txtID.Text = txtID.Text.Substring(0, 5);
                txtID.SelectionStart = txtID.Text.Length;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Optionally add validation for the Name field if necessary
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            // Validate price input
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, @"[^0-9.]") ||
                txtPrice.Text.Count(c => c == '.') > 1)
            {
                MessageBox.Show("Please enter a valid numeric value.", "Invalid Input");
                txtPrice.Text = string.Empty; // Clear invalid input
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(txtID.Text) ||
                string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error");
                return;
            }

            // Ensure the price is a valid decimal number
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Price must be a positive number.", "Validation Error");
                return;
            }

            // Create a new product using the text box values
            Product newProduct = new Product(txtID.Text, txtName.Text, price);

            // Insert the product into the binary search tree
            productTree.Insert(newProduct);

            // Optionally, update the ListBox or DataGridView with sorted products
            UpdateProductList();

            // Clear input fields after adding the product
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();

            MessageBox.Show("Product added successfully!", "Success");
        }

        private void UpdateProductList()
        {
            List<Product> products = new List<Product>();
            productTree.InOrderTraversal(productTree.Root, products);

            lstProducts.Items.Clear(); // Clear the list before adding updated items
            foreach (var product in products)
            {
                lstProducts.Items.Add($"ID: {product.ID}, Name: {product.Name}, Price: {product.Price:C}");
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (lstProducts.SelectedIndex >= 0)
            {
                string selectedProduct = lstProducts.SelectedItem.ToString();
                // Display selected product details if needed
                MessageBox.Show($"Selected product: {selectedProduct}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // ID search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchID = txtSearchID.Text;
            Product foundProduct = SearchProductByID(productTree.Root, searchID);
            if (foundProduct != null)
            {
                MessageBox.Show($"Product found: {foundProduct.ID}, {foundProduct.Name}, {foundProduct.Price:C}");
            }
            else
            {
                MessageBox.Show("Product not found!");
            }
        }

        private Product SearchProductByID(TreeNode root, string id)
        {
            if (root == null)
                return null;

            // Tìm ki?m theo ID trong cây nh? phân
            if (id == root.Product.ID)
                return root.Product;

            if (string.Compare(id, root.Product.ID) < 0)
                return SearchProductByID(root.Left, id);

            return SearchProductByID(root.Right, id);
        }
        private bool ProductExists(string id)
        {
            // S? d?ng SearchProductByID ?? ki?m tra s?n ph?m có t?n t?i không
            return SearchProductByID(productTree.Root, id) != null;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string deleteID = txtDeleteID.Text;

            if (string.IsNullOrEmpty(deleteID))
            {
                MessageBox.Show("Please enter a valid Product ID to delete.");
                return;
            }

            // Tr??c khi g?i ph??ng th?c xóa, ki?m tra xem s?n ph?m có t?n t?i không
            if (!ProductExists(deleteID))
            {
                MessageBox.Show($"Product with ID {deleteID} not found.");
                return;
            }

            productTree.Root = DeleteProduct(productTree.Root, deleteID);
            UpdateProductList();
            MessageBox.Show($"Product with ID {deleteID} deleted.");
        }

        private TreeNode DeleteProduct(TreeNode root, string id)
        {
            if (root == null)
                return root;

            if (string.Compare(id, root.Product.ID) < 0)
            {
                root.Left = DeleteProduct(root.Left, id);
            }
            else if (string.Compare(id, root.Product.ID) > 0)
            {
                root.Right = DeleteProduct(root.Right, id);
            }
            else
            {
                // Node to be deleted found
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Product = MinValue(root.Right);  // Find the minimum value in the right subtree
                root.Right = DeleteProduct(root.Right, root.Product.ID);  // Delete the inorder successor
            }
            return root;
        }

        private Product MinValue(TreeNode root)
        {
            Product minValue = root.Product;
            while (root.Left != null)
            {
                minValue = root.Left.Product;
                root = root.Left;
            }
            return minValue;
        }
        // l?c 


    }
}
