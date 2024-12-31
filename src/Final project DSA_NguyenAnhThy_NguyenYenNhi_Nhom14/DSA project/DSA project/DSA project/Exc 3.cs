using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA_project
{
    public partial class Exc3 : Form
    {
        private MovieBST _movieBST;


        public Exc3()
        {
            InitializeComponent();
            _movieBST = new MovieBST(listTree);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Film
        {
            public string Title { get; set; }
            public string Director { get; set; }
            public int ReleaseYear { get; set; }
            public string MainActor { get; set; }
            public double Rating { get; set; }

            public override string ToString()
            {
                return $"{Title} ({ReleaseYear}), Directed by {Director}, Starring {MainActor}, Rating: {Rating}";
            }
        }

        public class FilmNode
        {
            public Film Info { get; set; }
            public FilmNode L { get; set; }
            public FilmNode R { get; set; }

            public FilmNode(Film info)
            {
                Info = info;
                L = null;
                R = null;
            }
        }
        public class MovieBST
        {
            private FilmNode _root;
            private ListBox _listTree;

            public MovieBST(ListBox listTree)
            {
                _listTree = listTree; // Store reference to the ListBox
            }

            public void Insert(Film film)
            {
                _root = InsertRecursively(_root, film);
            }

            private FilmNode InsertRecursively(FilmNode node, Film film)
            {
                if (node == null) return new FilmNode(film);

                if (film.ReleaseYear < node.Info.ReleaseYear)
                    node.L = InsertRecursively(node.L, film);
                else if (film.ReleaseYear > node.Info.ReleaseYear)
                    node.R = InsertRecursively(node.R, film);
                return node;
            }

            public void TraverseInOrder()
            {
                _listTree.Items.Clear();
                TraverseInOrderRecursively(_root);
            }

            private void TraverseInOrderRecursively(FilmNode node)
            {
                if (node == null) return;

                TraverseInOrderRecursively(node.L);
                _listTree.Items.Add(node.Info.ToString());
                TraverseInOrderRecursively(node.R);
            }

            public void SearchByYearRange(int startYear, int endYear)
            {
                _listTree.Items.Clear();
                SearchByYearRangeRecursively(_root, startYear, endYear);
            }

            private void SearchByYearRangeRecursively(FilmNode node, int startYear, int endYear)
            {
                if (node == null) return;

                if (node.Info.ReleaseYear >= startYear && node.Info.ReleaseYear <= endYear)
                    _listTree.Items.Add(node.Info.ToString());

                if (startYear < node.Info.ReleaseYear)
                    SearchByYearRangeRecursively(node.L, startYear, endYear);

                if (endYear > node.Info.ReleaseYear)
                    SearchByYearRangeRecursively(node.R, startYear, endYear);
            }

            public void SearchByRatingRange(double minRating, double maxRating)
            {
                _listTree.Items.Clear();
                SearchByRatingRangeRecursively(_root, minRating, maxRating);
            }

            private void SearchByRatingRangeRecursively(FilmNode node, double minRating, double maxRating)
            {
                if (node == null) return;

                if (node.Info.Rating >= minRating && node.Info.Rating <= maxRating)
                    _listTree.Items.Add(node.Info.ToString());

                SearchByRatingRangeRecursively(node.L, minRating, maxRating);
                SearchByRatingRangeRecursively(node.R, minRating, maxRating);
            }

            public void SearchByYearAndRating(int startYear, int endYear, double minRating, double maxRating)
            {
                _listTree.Items.Clear();
                SearchByYearAndRatingRecursively(_root, startYear, endYear, minRating, maxRating);
            }

            private void SearchByYearAndRatingRecursively(FilmNode node, int startYear, int endYear, double minRating, double maxRating)
            {
                if (node == null) return;

                if (node.Info.ReleaseYear >= startYear && node.Info.ReleaseYear <= endYear &&
                    node.Info.Rating >= minRating && node.Info.Rating <= maxRating)
                {
                    _listTree.Items.Add(node.Info.ToString());
                }

                if (startYear < node.Info.ReleaseYear)
                    SearchByYearAndRatingRecursively(node.L, startYear, endYear, minRating, maxRating);

                if (endYear > node.Info.ReleaseYear)
                    SearchByYearAndRatingRecursively(node.R, startYear, endYear, minRating, maxRating);
            }
        }

        public void DisplayFilm(Film film)
            {
                listTree.Items.Add(film.ToString());
            }
        

        private void InsertBttn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Y.Text, out int releaseYear) &&
                 double.TryParse(R.Text, out double rating) &&
                 !string.IsNullOrEmpty(TT.Text) &&
                 !string.IsNullOrEmpty(D.Text) &&
                 !string.IsNullOrEmpty(MA.Text))
            {
                Film newFilm = new Film
                {
                    Title = TT.Text,
                    Director = D.Text,
                    ReleaseYear = releaseYear,
                    Rating = rating,
                    MainActor = MA.Text
                };
                _movieBST.Insert(newFilm);
                TT.Clear();
                D.Clear();
                Y.Clear();
                R.Clear();
                MA.Clear();
                MessageBox.Show("Movie inserted successfully.");
            }
            else
            {
                MessageBox.Show("Please fill in all fields correctly.");
            }
        }

        private void SearchBttn_Click(object sender, EventArgs e)
        {
            listTree.Items.Clear();
            if (int.TryParse(StartY.Text, out int startYear) &&
               int.TryParse(EndY.Text, out int endYear) &&
               double.TryParse(StartR.Text, out double minRating) &&
               double.TryParse(EndR.Text, out double maxRating))
            {
                _movieBST.SearchByYearAndRating(startYear, endYear, minRating, maxRating);
            }
            else
            {
                MessageBox.Show("Please enter valid year and rating values.");
            }
        }

        private void DisplayBttn_Click(object sender, EventArgs e)
        {
            listTree.Items.Clear();
            _movieBST.TraverseInOrder();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listTree_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Inputlbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SY_Click(object sender, EventArgs e)
        {
            if (int.TryParse(StartY.Text, out int startYear) && int.TryParse(EndY.Text, out int endYear))
            {
                _movieBST.SearchByYearRange(startYear, endYear);
            }
            else
            {
                MessageBox.Show("Please enter valid start and end years.");
            }

        }

        private void SR_Click(object sender, EventArgs e)
        {
            if (double.TryParse(StartR.Text, out double minRating) && double.TryParse(EndR.Text, out double maxRating))
            {
                _movieBST.SearchByRatingRange(minRating, maxRating);
            }
            else
            {
                MessageBox.Show("Please enter valid rating values.");
            }
        }
    }
}
