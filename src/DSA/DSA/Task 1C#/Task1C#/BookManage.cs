using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace CircularLinkedListDemo
{
    public partial class BookManagementForm : Form
    {
        private CircularLinkedList bookList;
        private Node selectedNode;

        public BookManagementForm()
        {
            InitializeComponents();
            bookList = new CircularLinkedList();
            LoadSampleData();
            RefreshBookList();
        }

        private void InitializeComponents()
        {
            this.Size = new Size(800, 600);
            this.Text = "Book Management System";

         
            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1
            };
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));

            
            ListView bookListView = new ListView
            {
                Dock = DockStyle.Fill,
                View = View.Details,
                FullRowSelect = true,
                Name = "bookListView"
            };
            bookListView.Columns.Add("ID", 50);
            bookListView.Columns.Add("Title", 200);
            bookListView.Columns.Add("Author", 150);
            bookListView.Columns.Add("Price", 80);
            bookListView.SelectedIndexChanged += BookListView_SelectedIndexChanged;

           
            TableLayoutPanel inputPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 12,
                ColumnCount = 2,
                Padding = new Padding(10)
            };
            inputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            inputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));

          
            AddLabelAndTextBox(inputPanel, "ID:", "txtId", 0);
            AddLabelAndTextBox(inputPanel, "Title:", "txtTitle", 1);
            AddLabelAndTextBox(inputPanel, "Author:", "txtAuthor", 2);
            AddLabelAndTextBox(inputPanel, "Price:", "txtPrice", 3);

            
            TableLayoutPanel buttonPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 3,
                Padding = new Padding(0, 10, 0, 0)
            };

            AddButton(buttonPanel, "Add Book", "btnAdd", 0, 0);
            AddButton(buttonPanel, "Update Book", "btnUpdate", 0, 1);
            AddButton(buttonPanel, "Delete Book", "btnDelete", 1, 0);
            AddButton(buttonPanel, "Sort by ID", "btnSort", 1, 1);
            AddButton(buttonPanel, "Search by Price", "btnSearch", 2, 0);
            AddButton(buttonPanel, "Clear", "btnClear", 2, 1);

            // Price range search panel
            GroupBox searchGroup = new GroupBox
            {
                Text = "Price Range Search",
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            TableLayoutPanel searchPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 2
            };

            AddLabelAndTextBox(searchPanel, "Min Price:", "txtMinPrice", 0);
            AddLabelAndTextBox(searchPanel, "Max Price:", "txtMaxPrice", 1);

            searchGroup.Controls.Add(searchPanel);

            inputPanel.Controls.Add(searchGroup, 0, 5);
            inputPanel.SetColumnSpan(searchGroup, 2);
            inputPanel.Controls.Add(buttonPanel, 0, 6);
            inputPanel.SetColumnSpan(buttonPanel, 2);

         
            StatusStrip statusStrip = new StatusStrip();
            ToolStripStatusLabel statusLabel = new ToolStripStatusLabel
            {
                Name = "statusLabel",
                Text = "Ready"
            };
            statusStrip.Items.Add(statusLabel);

            
            mainLayout.Controls.Add(bookListView, 0, 0);
            mainLayout.Controls.Add(inputPanel, 1, 0);

            // Add controls to form
            this.Controls.Add(mainLayout);
            this.Controls.Add(statusStrip);

          
            this.GetButton("btnAdd").Click += BtnAdd_Click;
            this.GetButton("btnUpdate").Click += BtnUpdate_Click;
            this.GetButton("btnDelete").Click += BtnDelete_Click;
            this.GetButton("btnSort").Click += BtnSort_Click;
            this.GetButton("btnSearch").Click += BtnSearch_Click;
            this.GetButton("btnClear").Click += BtnClear_Click;
        }

        private void AddLabelAndTextBox(TableLayoutPanel panel, string labelText, string textBoxName, int row)
        {
            Label label = new Label
            {
                Text = labelText,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight
            };

            TextBox textBox = new TextBox
            {
                Name = textBoxName,
                Dock = DockStyle.Fill
            };

            panel.Controls.Add(label, 0, row);
            panel.Controls.Add(textBox, 1, row);
        }

        private void AddButton(TableLayoutPanel panel, string text, string name, int row, int col)
        {
            Button button = new Button
            {
                Text = text,
                Name = name,
                Dock = DockStyle.Fill,
                Margin = new Padding(5)
            };
            panel.Controls.Add(button, col, row);
        }

        private TextBox GetTextBox(string name)
        {
            return this.Controls.Find(name, true)[0] as TextBox;
        }

        private Button GetButton(string name)
        {
            return this.Controls.Find(name, true)[0] as Button;
        }

        private ListView GetBookListView()
        {
            return this.Controls.Find("bookListView", true)[0] as ListView;
        }

        private ToolStripStatusLabel GetStatusLabel()
        {
            StatusStrip statusStrip = this.Controls.OfType<StatusStrip>().FirstOrDefault();
            if (statusStrip != null)
            {
                return statusStrip.Items.OfType<ToolStripStatusLabel>().FirstOrDefault();
            }
            return null;
        }

        private void LoadSampleData()
        {
            bookList.InsertAtEnd(new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 15.99m });
            bookList.InsertAtEnd(new Book { Id = 2, Title = "1984", Author = "George Orwell", Price = 12.99m });
            bookList.InsertAtEnd(new Book { Id = 3, Title = "Pride and Prejudice", Author = "Jane Austen", Price = 9.99m });
        }

        private void RefreshBookList()
        {
            ListView bookListView = GetBookListView();
            bookListView.Items.Clear();

            if (!bookList.IsEmpty())
            {
                Node current = bookList.SearchById(1); 
                do
                {
                    var book = current.Data;
                    var item = new ListViewItem(new[]
                    {
                        book.Id.ToString(),
                        book.Title,
                        book.Author,
                        book.Price.ToString("C")
                    });
                    bookListView.Items.Add(item);
                    current = current.Next;
                } while (current != bookList.SearchById(1));
            }

            UpdateStatus($"Total books: {bookListView.Items.Count}");
        }

        private void UpdateStatus(string message)
        {
            GetStatusLabel().Text = message;
        }

        private void ClearInputs()
        {
            GetTextBox("txtId").Clear();
            GetTextBox("txtTitle").Clear();
            GetTextBox("txtAuthor").Clear();
            GetTextBox("txtPrice").Clear();
            GetTextBox("txtMinPrice").Clear();
            GetTextBox("txtMaxPrice").Clear();
            selectedNode = null;
        }

        private bool ValidateInputs()
        {
            if (!int.TryParse(GetTextBox("txtId").Text, out _))
            {
                MessageBox.Show("Please enter a valid ID.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(GetTextBox("txtTitle").Text))
            {
                MessageBox.Show("Please enter a title.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(GetTextBox("txtAuthor").Text))
            {
                MessageBox.Show("Please enter an author.");
                return false;
            }

            if (!decimal.TryParse(GetTextBox("txtPrice").Text, out _))
            {
                MessageBox.Show("Please enter a valid price.");
                return false;
            }

            return true;
        }

    
        private void BookListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView bookListView = GetBookListView();
            if (bookListView.SelectedItems.Count > 0)
            {
                var item = bookListView.SelectedItems[0];
                int id = int.Parse(item.SubItems[0].Text);
                selectedNode = bookList.SearchById(id);

                GetTextBox("txtId").Text = selectedNode.Data.Id.ToString();
                GetTextBox("txtTitle").Text = selectedNode.Data.Title;
                GetTextBox("txtAuthor").Text = selectedNode.Data.Author;
                GetTextBox("txtPrice").Text = selectedNode.Data.Price.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            var book = new Book
            {
                Id = int.Parse(GetTextBox("txtId").Text),
                Title = GetTextBox("txtTitle").Text,
                Author = GetTextBox("txtAuthor").Text,
                Price = decimal.Parse(GetTextBox("txtPrice").Text)
            };

            bookList.InsertAtEnd(book);
            RefreshBookList();
            ClearInputs();
            UpdateStatus("Book added successfully.");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedNode == null)
            {
                MessageBox.Show("Please select a book to update.");
                return;
            }

            if (!ValidateInputs())
                return;

            selectedNode.Data.Id = int.Parse(GetTextBox("txtId").Text);
            selectedNode.Data.Title = GetTextBox("txtTitle").Text;
            selectedNode.Data.Author = GetTextBox("txtAuthor").Text;
            selectedNode.Data.Price = decimal.Parse(GetTextBox("txtPrice").Text);

            RefreshBookList();
            ClearInputs();
            UpdateStatus("Book updated successfully.");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedNode == null)
            {
                MessageBox.Show("Please select a book to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (selectedNode == bookList.SearchById(1))
                {
                    bookList.RemoveFirst();
                }
                else
                {
                    Node prev = bookList.SearchById(1);
                    while (prev.Next != selectedNode)
                    {
                        prev = prev.Next;
                    }
                    bookList.RemoveAfterNode(prev);
                }

                RefreshBookList();
                ClearInputs();
                UpdateStatus("Book deleted successfully.");
            }
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            bookList.SelectionSort();
            RefreshBookList();
            UpdateStatus("Books sorted by ID using SelectionSort.");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(GetTextBox("txtMinPrice").Text, out decimal minPrice) ||
                !decimal.TryParse(GetTextBox("txtMaxPrice").Text, out decimal maxPrice))
            {
                MessageBox.Show("Please enter valid price range.");
                return;
            }

            var results = bookList.SearchByPriceRange(minPrice, maxPrice);
            ListView bookListView = GetBookListView();
            bookListView.Items.Clear();

            foreach (var book in results)
            {
                var item = new ListViewItem(new[]
                {
                    book.Id.ToString(),
                    book.Title,
                    book.Author,
                    book.Price.ToString("C")
                });
                bookListView.Items.Add(item);
            }

            UpdateStatus($"Found {results.Count} books in price range ${minPrice:F2} - ${maxPrice:F2}");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            RefreshBookList();
            UpdateStatus("Ready");
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BookManagementForm());
        }
    }
}