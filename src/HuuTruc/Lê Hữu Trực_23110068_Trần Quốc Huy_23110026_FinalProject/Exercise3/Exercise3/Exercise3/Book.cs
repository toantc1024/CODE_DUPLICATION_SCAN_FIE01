using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Book
    {
        private string _id;
        private string _tittle;
        private string _author;
        private string _genre;
        private int _publishedYear;
        public Book()
        {
        }
        public Book(string id, string tittle, string author, string genre, int publishedYear)
        {
            Id = id;
            Tittle = tittle;
            Author = author;
            Genre = genre;
            PublishedYear = publishedYear;
        }

        public string Id { get => _id; set => _id = value; }
        public string Tittle { get => _tittle; set => _tittle = value; }
        public string Author { get => _author; set => _author = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public int PublishedYear { get => _publishedYear; set => _publishedYear = value; }

        public override string ToString()
        {
            return $"BookID: {Id} | Tittle: {Tittle} by Author {Author} | Genre: {Genre} | Published Year: {PublishedYear}";
        }
    }
}
