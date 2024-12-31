using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    internal class Modify
    {
        private BinarySearchTree bst;
        public Modify()
        {
            bst = new BinarySearchTree();
        }
        public bool Insert(Book book)
        {
            if (bst.Search(book.Id) == null)
            {
                bst.Insert(book);
                return true;
            }
            return false;
        }

        public bool Update(Book book)
        {
            if (bst.Search(book.Id) != null)
            {
                bst.Delete(book.Id);
                bst.Insert(book);
                return true;
            }
            return false;
        }

        public bool Delete(string id)
        {
            if (bst.Search(id) != null)
            {
                bst.Delete(id);
                return true;
            }
            return false;
        }

        public Book Search(string id)
        {
            Node node = bst.Search(id);
            return node?.Data;
        }
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            CollectBooks(bst.Root, books);
            return books;
        }

        private void CollectBooks(Node node, List<Book> books)
        {
            if (node != null)
            {
                CollectBooks(node.Left, books);
                books.Add(node.Data);
                CollectBooks(node.Right, books);
            }
        }
    }
}
