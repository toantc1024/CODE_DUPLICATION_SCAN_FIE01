using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal2
{
    internal class Book
    {
        private string title;
        private string author;
        private string isbn;
        private int yearPublished;

        public string _title
        {
            get { return title; }
            set { title = value; }
        }
        public string _author
        {
            get { return author; }
            set { author = value; }
        }
        public string _isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public int _yearPublished
        {
            get { return yearPublished; }
            set { yearPublished = value; }
        }

        public Book(string title,string author,string isbn,int yearPublished)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.yearPublished = yearPublished;
        }
        public override string ToString()
        {
            return $"{title} by {author} (ISBN: {isbn}, Year: {yearPublished})";
        }
    }
}
