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
    public partial class Exc2 : Form
    {
        private FilmStack _filmStack = new FilmStack(); 


        public class Film
        {
            public string Title { get; set; }
            public string Director { get; set; }
            public int ReleaseYear { get; set; }
            public string MainActor { get; set; }
            public Film Next { get; set; }
            public override string ToString()
            {
                return $"{Title} ({ReleaseYear}), Directed by {Director}, Starring {MainActor}";
            }
        }

         public class FilmStack
        {
            private Film _top;

            public void Push(Film film)
            {
                film.Next = _top;
                _top = film;
            }

            public Film Pop()
            {
                if (_top == null)
                    throw new InvalidOperationException("Stack is empty.");
                Film topFilm = _top;
                _top = _top.Next;
                return topFilm;
            }

            public Film Peek()
            {
                if (_top == null)
                    throw new InvalidOperationException("Stack is empty.");
                return _top;
            }

            public Film[] GetAllItems()
            {
                var films = new List<Film>();
                Film current = _top;
                while (current != null)
                {
                    films.Add(current);
                    current = current.Next;
                }
                return films.ToArray();
            }
        }


        public Exc2()
        {
            InitializeComponent();
        
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void Pushbttn_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string director = txtDirector.Text;
            if (!int.TryParse(txtYear.Text, out int releaseYear))
            {
                MessageBox.Show("Please enter a valid release year.");
                return;
            }
            string mainActor = txtMActor.Text;

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(director) && !string.IsNullOrEmpty(mainActor))
            {
                Film newFilm = new Film
                {
                    Title = title,
                    Director = director,
                    ReleaseYear = releaseYear,
                    MainActor = mainActor
                };
                _filmStack.Push(newFilm);
                UpdateStackDisplay();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void Popbttn_Click(object sender, EventArgs e)
        {
            try
            {
                Film removedFilm = _filmStack.Pop();
                MessageBox.Show($"Removed from stack: {removedFilm}");
                UpdateStackDisplay();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void UpdateStackDisplay()
        {
            listStack.Items.Clear();
            foreach (var film in _filmStack.GetAllItems())
            {
                listStack.Items.Add(film);
            }
        }
        private void ClearInputFields()
        {
            txtTitle.Clear();
            txtDirector.Clear();
            txtYear.Clear();
            txtMActor.Clear();
        }
        private void Peakbttn_Click(object sender, EventArgs e)
        {

            try
            {
                Film topFilm = _filmStack.Peek();
                MessageBox.Show($"This time watch: {topFilm}");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Goexc3_Click(object sender, EventArgs e)
        {
            Exc3 nextForm3 = new Exc3();
            nextForm3.Show();                   
            this.Hide();                        
        }
    }
}
