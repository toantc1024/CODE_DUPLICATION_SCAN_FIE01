using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace b_1
{
    public class SongNode
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Time { get; set; }
        public SongNode Next { get; set; }

        public SongNode(string title, string author, double time)
        {
            Title = title;
            Author = author;
            Time = time;
            Next = null;
        }
    }

}
