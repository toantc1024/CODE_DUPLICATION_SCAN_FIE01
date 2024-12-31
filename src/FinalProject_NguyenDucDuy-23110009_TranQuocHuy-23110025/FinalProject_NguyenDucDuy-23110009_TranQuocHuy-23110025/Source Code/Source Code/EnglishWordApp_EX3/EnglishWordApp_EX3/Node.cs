using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishWordApp_EX3
{
    public class Node
    {
        public Word Data; 
        public Node Left; 
        public Node Right; 
        public Node(Word data) { 
            Data = data; 
            Left = null; 
            Right = null; 
        }
    }
}
