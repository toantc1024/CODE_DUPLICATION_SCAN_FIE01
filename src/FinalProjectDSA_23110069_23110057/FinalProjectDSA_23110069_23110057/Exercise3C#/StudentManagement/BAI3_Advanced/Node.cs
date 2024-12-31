using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3_Advanced
{
    public class Node
    {
        public Student Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public Node(Student student)
        {
            Data = student;
            Left = null;
            Right = null;
        }
    }
}
