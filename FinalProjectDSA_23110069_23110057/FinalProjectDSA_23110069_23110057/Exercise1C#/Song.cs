using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircularLinkedList_CSharp
{
    public class Song
    {
        private string name;
        private string path;
        private TimeSpan duration;

        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
        public TimeSpan Duration { get => duration; set => duration = value; }
        public Song() { }
        public Song(string name, string path, TimeSpan duration)
        {
            this.name = name;
            this.path = path;
            this.duration = duration;
        }
        public override string ToString()
        {
            return $"{Name} ({Duration:mm\\:ss})";
        }
    }
}