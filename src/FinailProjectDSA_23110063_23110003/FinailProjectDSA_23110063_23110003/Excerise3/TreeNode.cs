using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTFinalProject
{
    internal unsafe class TreeNode
    {
        public Account Key { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(Account key)
        {
            Key = key;
            Left = null;
            Right = null;
        }
        
    }
}
