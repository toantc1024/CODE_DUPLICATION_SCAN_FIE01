using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Node
    {
        public string Title; // Song title
        public string FilePath; // File path to the song
        public Node next = null; // Pointer to the next node
        public Node prev = null; // Pointer to the previous node

        public Node() { }

        public Node(string title, string filePath)
        {
            Title = title;
            FilePath = filePath;
            next = null;
            prev = null;
        }
    }
}

