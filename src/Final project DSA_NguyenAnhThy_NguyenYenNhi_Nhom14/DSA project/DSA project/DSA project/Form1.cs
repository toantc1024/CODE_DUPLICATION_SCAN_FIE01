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
    public partial class Form1 : Form
    {
        private CircularLinkedList filmList = new CircularLinkedList();
        private CircularLinkedList otherList = new CircularLinkedList();
        public class Film
        {
            public string Title { get; set; }
            public string Director { get; set; }
            public int ReleaseYear { get; set; }
            public string MainActor { get; set; }

            public override string ToString()
            {
                return $"{Title} ({ReleaseYear}), directed by {Director}, starring {MainActor}";
            }
        }

        public class Node
        {
            public Film Data { get; set; }
            public Node Next { get; set; }

            public Node(Film data)
            {
                Data = data;
                Next = null;
            }
        }

        public class CircularLinkedList
        {
            private Node head;

            //Initalize a list: 
            public CircularLinkedList()
            {
                head = null;
            }

            //Check whether a node is empty or not 
            public bool IsEmpty()
            {
                return head == null;
            }

            // Insert at the beginning of the list
            public void InsertAtBeginning(Film data)
            {
                Node newNode = new Node(data);
                if (IsEmpty())
                {
                    head = newNode;
                    head.Next = head;
                }
                else
                {
                    Node t = head;
                    while (t.Next != head)
                    {
                        t = t.Next;
                    }
                    newNode.Next = head;
                    t.Next = newNode;
                    head = newNode;
                }
            }

            // Insert at the end of the list
            public void InsertAtEnd(Film data)
            {
                Node newNode = new Node(data);
                if (IsEmpty())
                {
                    head = newNode;
                    head.Next = head;
                }
                else
                {
                    Node t = head;
                    while (t.Next != head)
                    {
                        t = t.Next;
                    }
                    t.Next = newNode;
                    newNode.Next = head;
                }
            }

            //Insert a new node after a node of the list 
            public void InsertAfter(Film data, Film after)
            {
                Node t = head;
                do
                {
                    if (t.Data.Title == after.Title && t.Data.Director == after.Director && t.Data.ReleaseYear == after.ReleaseYear && t.Data.MainActor == after.MainActor)
                    {
                        Node newNode = new Node(data);
                        newNode.Next = t.Next;
                        t.Next = newNode;
                        return;
                    }
                    t = t.Next;
                } while (t != head);
            }

            // Remove the first node of the list
            public void RemoveFirst()
            {
                if (IsEmpty())
                    return;

                if (head.Next == head)
                {
                    head = null;
                }
                else
                {
                    Node t = head;
                    while (t.Next != head)
                    {
                        t = t.Next;
                    }
                    t.Next = head.Next;
                    head = head.Next;
                }
            }

            // Remove the last node of the list
            public void RemoveLast()
            {
                if (IsEmpty())
                    return;

                if (head.Next == head)
                {
                    head = null;
                }
                else
                {
                    Node t = head;
                    while (t.Next.Next != head)
                    {
                        t = t.Next;
                    }
                    t.Next = head;
                }
            }

            // Remove a node after a node of the list 
            public void RemoveAfter(Film after)
            {
                Node t = head;
                do
                {
                    if (t.Data.Title == after.Title && t.Data.Director == after.Director && t.Data.ReleaseYear == after.ReleaseYear && t.Data.MainActor == after.MainActor && t.Next != head)
                    {
                        t.Next = t.Next.Next;
                        return;
                    }
                    t = t.Next;
                } while (t != head);
            }

            // Search a node in the list
            public Node Search(Film data)
            {
                Node t = head;
                do
                {
                    if (t.Data.Title == data.Title && t.Data.Director == data.Director && t.Data.ReleaseYear == data.ReleaseYear && t.Data.MainActor == data.MainActor)
                    {
                        return t;
                    }
                    t = t.Next;
                } while (t != head);

                return null;
            }

            // Search nodes in the list satisfying a specific criteria
            public void SearchByDirector(string director)
            {
                if (IsEmpty())
                {
                    Console.WriteLine("List is empty.");
                    return;
                }

                Console.WriteLine($"Films directed by {director}:");
                Node t = head;
                do
                {
                    if (t.Data.Director == director)
                    {
                        Console.WriteLine(t.Data);
                    }
                    t = t.Next;
                } while (t != head);
            }

            public void SearchByYear(int year)
            {
                if (IsEmpty())
                {
                    Console.WriteLine("List is empty.");
                    return;
                }

                Console.WriteLine($"Films released in {year}:");
                Node t = head;
                do
                {
                    if (t.Data.ReleaseYear == year)
                    {
                        Console.WriteLine(t.Data);
                    }
                    t = t.Next;
                } while (t != head);
            }

            // Merge two lists
            public void Merge(CircularLinkedList otherList)
            {
                if (IsEmpty())
                {
                    head = otherList.head;
                    return;
                }

                if (otherList.IsEmpty())
                {
                    return;
                }

                Node t = head;
                while (t.Next != head)
                {
                    t = t.Next;
                }

                Node otherTail = otherList.head;
                while (otherTail.Next != otherList.head)
                {
                    otherTail = otherTail.Next;
                }

                t.Next = otherList.head;
                otherTail.Next = head;
            }

         
            public void RemoveAllByDirector(string director)
            {
                if (IsEmpty())
                    return;

                Node t = head;
                Node prev = null;
                do
                {
                    if (t.Data.Director == director)
                    {
                        if (t == head)
                        {
                            RemoveFirst();
                            t = head;
                            if (IsEmpty())
                                break;
                        }
                        else
                        {
                            prev.Next = t.Next;
                            t = t.Next;
                        }
                    }
                    else
                    {
                        prev = t;
                        t = t.Next;
                    }
                } while (t != head);
            }
            

            public void SortSelection()
            {
                if (IsEmpty() || head.Next == head)
                    return;

                Node current = head;
                do
                {
                    Node min = current;
                    Node t = current.Next;
                    while (t != head)
                    {
                        if (string.Compare(t.Data.Title, min.Data.Title, StringComparison.Ordinal) < 0)
                        {
                            min = t;
                        }
                        t = t.Next;
                    }

                    if (min != current)
                    {
                        Film tempData = current.Data;
                        current.Data = min.Data;
                        min.Data = tempData;
                    }

                    current = current.Next;
                } while (current != head);
            }
            public void PrintToListBox(ListBox listBox)
            {
                if (IsEmpty())
                {
                    listBox.Items.Add("List is empty.");
                    return;
                }

                Node t = head;
                listBox.Items.Clear(); 
                do
                {
                    listBox.Items.Add(t.Data.ToString());
                    t = t.Next;
                } while (t != head);
            }
            public void SearchByDirector(string director, ListBox listBox)
            {
                if (IsEmpty())
                {
                    listBox.Items.Add("List is empty.");
                    return;
                }

                Node t = head;
                do
                {
                    if (t.Data.Director == director)
                    {
                        listBox.Items.Add(t.Data.ToString());
                    }
                    t = t.Next;
                } while (t != head);
            }

            public void SearchByYear(int year, ListBox listBox)
            {
                if (IsEmpty())
                {
                    listBox.Items.Add("List is empty.");
                    return;
                }

                Node t = head;
                do
                {
                    if (t.Data.ReleaseYear == year)
                    {
                        listBox.Items.Add(t.Data.ToString());
                    }
                    t = t.Next;
                } while (t != head);
            }
            public void Clear()
            {
                head = null;
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tTT.Text) || string.IsNullOrEmpty(tD.Text) || string.IsNullOrEmpty(tY.Text) || string.IsNullOrEmpty(tMA.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(tY.Text, out int year))
            {
                MessageBox.Show("Please enter a valid release year.");
                return;
            }

            Film newFilm = new Film
            {
                Title = tTT.Text,
                Director = tD.Text,
                ReleaseYear = year,
                MainActor = tMA.Text
            };

            if (rAF.Checked)
            {
                filmList.InsertAtBeginning(newFilm);
            }
            else if (rAL.Checked)
            {
                filmList.InsertAtEnd(newFilm);
            }

            tTT.Clear();
            tD.Clear();
            tY.Clear();
            tMA.Clear();

            MessageBox.Show("Movie added successfully.");

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rmvD.Text))
            {
                MessageBox.Show("Please enter a director name.");
                return;
            }

            filmList.RemoveAllByDirector(rmvD.Text);
            MessageBox.Show($"All movies directed by {rmvD.Text} removed.");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SD.Text))
            {
                MessageBox.Show("Please enter a director name.");
                return;
            }

            lstMovies.Items.Clear();
            filmList.SearchByDirector(SD.Text, lstMovies);
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            otherList.SortSelection();
            MessageBox.Show("Second list sorted successfully.");
        }

        private void Display_Click(object sender, EventArgs e)
        {
            lstMovies.Items.Clear();
            filmList.PrintToListBox(lstMovies);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rmvL_Click(object sender, EventArgs e)
        {
            filmList.RemoveLast();
            MessageBox.Show("Last movie removed.");
        }

        private void rmvF_Click(object sender, EventArgs e)
        {
            filmList.RemoveFirst();
            MessageBox.Show("First movie removed.");
        }

        private void Search2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(SY.Text, out int year))
            {
                MessageBox.Show("Please enter a valid year.");
                return;
            }

            lstMovies.Items.Clear();
            filmList.SearchByYear(year, lstMovies);
        }

        private void SortQ_Click(object sender, EventArgs e)
        {
            filmList.SortSelection();
            MessageBox.Show("Movies sorted alphabetically by title.");
            lstMovies.Items.Clear();
            filmList.PrintToListBox(lstMovies);
        }

        private void ResetP_Click(object sender, EventArgs e)
        {
            if (otherList != null)
            {
                otherList.Clear();
                MessageBox.Show("Second list reset successfully.");
            }
            else
            {
                MessageBox.Show("Error: Second list is null.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstPotential.Items.Clear();
            otherList.PrintToListBox(lstPotential);
        }

        private void AddP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tTT.Text) || string.IsNullOrEmpty(tD.Text) || string.IsNullOrEmpty(tY.Text) || string.IsNullOrEmpty(tMA.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(tY.Text, out int year))
            {
                MessageBox.Show("Please enter a valid release year.");
                return;
            }

            Film newFilm = new Film
            {
                Title = tTT.Text,
                Director = tD.Text,
                ReleaseYear = year,
                MainActor = tMA.Text
            };

            otherList.InsertAtEnd(newFilm);

            tTT.Clear();
            tD.Clear();
            tY.Clear();
            tMA.Clear();

            MessageBox.Show("Movie added to the second list successfully.");
        }

        private void Merge_Click(object sender, EventArgs e)
        {
            filmList.Merge(otherList);
            MessageBox.Show("Lists merged successfully.");
        }

        private void GoExc2_Click(object sender, EventArgs e)
        {
            Exc2 nextForm2 = new Exc2();
            nextForm2.Show();
            this.Hide();
        }
    }

}
