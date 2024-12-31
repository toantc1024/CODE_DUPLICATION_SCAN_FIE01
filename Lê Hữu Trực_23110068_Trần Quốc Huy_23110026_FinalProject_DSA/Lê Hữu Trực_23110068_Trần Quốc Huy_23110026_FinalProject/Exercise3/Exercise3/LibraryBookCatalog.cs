using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class LibraryBookCatalog : Form
    {
        Modify modify;
        Book book;
        public LibraryBookCatalog()
        {
            InitializeComponent();
            modify = new Modify();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            string id = this.BookIDTB.Text;
            string tittle = this.BookTittleTB.Text;
            string author = this.AuthorTB.Text;
            string genre = this.GenreTB.Text;
            int year = this.PublishedYearPicker.Value.Year;

            book = new Book(id, tittle, author, genre, year);

            if (modify.Insert(book))
            {
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshListBox();
            }
            else
            {
                MessageBox.Show("Error: Cannot add Book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditBT_Click(object sender, EventArgs e)
        {
            string id = this.BookIDTB.Text;
            string tittle = this.BookTittleTB.Text;
            string author = this.AuthorTB.Text;
            string genre = this.GenreTB.Text;
            int year = this.PublishedYearPicker.Value.Year;

            book = new Book(id, tittle, author, genre, year);

            if (modify.Update(book))
            {
                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshListBox();
            }
            else
            {
                MessageBox.Show("Error: Cannot update Book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                // Get the selected book's information from the list box
                string selectedBook = BooksListBox.SelectedItem.ToString();

                // Extract the BookID using a regular expression or simple string manipulation
                // Assuming the format is: "BookID: 1 | Tittle: A by Author B | Genre: C | Published Year: 2024"
                string bookId = selectedBook.Split('|')[0].Split(':')[1].Trim(); // Extracting the ID part

                // Now attempt to delete the book using the extracted ID
                if (modify.Delete(bookId))
                {
                    MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshListBox();
                }
                else
                {
                    MessageBox.Show("Error: Cannot delete Book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DoneBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            string bookId = BookIDTB.Text.Trim();
            if (string.IsNullOrEmpty(bookId))
            {
                MessageBox.Show("Please enter a Book ID to search.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Book result = modify.Search(bookId);
            if (result != null)
            {
                MessageBox.Show(result.ToString(), "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No book found with the given ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void DisplayBooksBT_Click(object sender, EventArgs e)
        {
            // Get all the books (you can also directly get from modify.GetAllBooks() if you prefer)
            List<Book> allBooks = modify.GetAllBooks();

            // Build a formatted string to pass to the BooksInformation form
            StringBuilder booksInfo = new StringBuilder();
            foreach (var book in allBooks)
            {
                // Add each book information to the string
                booksInfo.AppendLine($"BookID: {book.Id} | " +
                                     $"Title: {book.Tittle} | " +
                                     $"Author: {book.Author} | " +
                                     $"Genre: {book.Genre} | " +
                                     $"Published Year: {book.PublishedYear}");
            }

            // Create an instance of BooksInformation form and pass the formatted string
            BooksInformation bif = new BooksInformation();
            bif.UpdateBooksLabel(booksInfo.ToString());  // Pass the formatted string to the form
            bif.ShowDialog();
        }
        private void RefreshListBox()
        {
            BooksListBox.Items.Clear();
            foreach (var book in modify.GetAllBooks())
            {
                BooksListBox.Items.Add(book.ToString());
            }
        }
    }
}