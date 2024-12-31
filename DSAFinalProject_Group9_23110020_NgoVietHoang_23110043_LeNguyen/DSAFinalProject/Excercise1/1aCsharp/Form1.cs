using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectFinal2
{
    public partial class Form1 : Form
    {
        private CircularLinkedList list = new CircularLinkedList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_insertbegin_Click(object sender, EventArgs e)
        {
            list.InsertAtBeginning(new Book("Beginning Book", "Author A", "ISBN001", 2024));
            list.PrintList(listBox1);
        }

        private void btn_insertend_Click(object sender, EventArgs e)
        {
            list.InsertAtEnd(new Book("End Book", "Author B", "ISBN002", 2024));
            list.PrintList(listBox1);
        }

        private void btn_insertafter_Click(object sender, EventArgs e)
        {
            var node = list.Search("Beginning Book");
            if (node != null)
            {
                list.InsertAfter(node, new Book("After Book", "Author C", "ISBN003", 2020));
            }
            else
            {
                MessageBox.Show("Node not found.");
            }
            list.PrintList(listBox1);
        }

        private void btn_removefirst_Click(object sender, EventArgs e)
        {
            list.RemoveFirst();
            MessageBox.Show("First node removed.");
            list.PrintList(listBox1);
        }

        private void btn_removelast_Click(object sender, EventArgs e)
        {
            list.RemoveLast();
            MessageBox.Show("Last node removed.");
            list.PrintList(listBox1);
        }

        private void btn_removeafter_Click(object sender, EventArgs e)
        {
            var node = list.Search("Beginning Book");
            if (node != null)
            {
                list.RemoveAfter(node);
                MessageBox.Show("Node after specified node removed.");
            }
            else
            {
                MessageBox.Show("Node not found.");
            }
            list.PrintList(listBox1);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchTitle = Prompt.ShowDialog("Enter Book Title to Search:", "Search Book");

            if (string.IsNullOrWhiteSpace(searchTitle))
            {
                MessageBox.Show("Search query cannot be empty.");
                return;
            }

            Node result = list.Search(searchTitle);
            if (result != null)
            {
                MessageBox.Show($"Book Found:\n{result.data}");
            }
            else
            {
                MessageBox.Show("No book found with the given title.");
            }
            list.PrintList(listBox1);
        }

        private void btn_searchcriteria_Click(object sender, EventArgs e)
        {
  
            string criteria = Prompt.ShowDialog("Enter criteria (e.g., Author Name, Year, ISBN):", "Search by Criteria");


            if (string.IsNullOrWhiteSpace(criteria))
            {
                MessageBox.Show("Search criteria cannot be empty.");
                return;
            }
            listBox1.Items.Clear();

            list.SearchByCriteria(book =>
                (book._title.IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (book._author.IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (book._isbn.IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (book._yearPublished.ToString().IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0),
                listBox1);

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No books match the given criteria.");
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            list.PrintList(listBox1);
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            list.SortByTitle();
            MessageBox.Show("List sorted by book title.");
            list.PrintList(listBox1);
        }

        private void btn_addbook_Click(object sender, EventArgs e)
        {
            string title = Prompt.ShowDialog("Enter Book Title:", "Add Book");
            string author = Prompt.ShowDialog("Enter Author Name:", "Add Book");
            string isbn = Prompt.ShowDialog("Enter ISBN:", "Add Book");
            string yearInput = Prompt.ShowDialog("Enter Year of Publication:", "Add Book");

            if (int.TryParse(yearInput, out int year))
            {
                list.InsertAtEnd(new Book(title, author, isbn, year));
                MessageBox.Show("Book added successfully!");
            }
            else
            {
                MessageBox.Show("Invalid year. Please enter a valid number.");
            }

            list.PrintList(listBox1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_removeall_Click(object sender, EventArgs e)
        {
            string criteria = Prompt.ShowDialog("Enter criteria (e.g., Title, Author, Year, ISBN):", "Remove All by Criteria");

            if (string.IsNullOrWhiteSpace(criteria))
            {
                MessageBox.Show("Search criteria cannot be empty.");
                return;
            }

            list.RemoveAllByCriteria(book =>
                book._title.IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0 ||
                book._author.IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0 ||
                book._isbn.IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0 ||
                book._yearPublished.ToString().IndexOf(criteria, StringComparison.OrdinalIgnoreCase) >= 0
            );

            list.PrintList(listBox1);

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("No books match the given criteria.");
            }
        }
    }
}
