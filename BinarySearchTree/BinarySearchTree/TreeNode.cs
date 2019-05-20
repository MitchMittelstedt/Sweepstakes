using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class TreeNode
    {
        public int data;
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode(int data)
        {
            this.data = data;
        }
    }
}
