using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList_C_
{
    public class Exercise
    {
        private string name;
        private int difficulty;
        private string url;

        public string Name { get => name; set => name = value; }
        public int Difficulty { get => difficulty; set => difficulty = value; }
        public string URL { get => url; set => url = value; }

        public Exercise(string NameEx, int Difficulty, string URL) {
            Name = NameEx;
            this.Difficulty = Difficulty;
            this.URL = URL;
        }
    }
}
