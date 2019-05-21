using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTreeNode<T>
    {
        //HAS
        private T item;
        private BinaryTreeNode<T> left = null;
        private BinaryTreeNode<T> right = null;
        
        //CONSTRUCTOR


        public BinaryTreeNode()                                                             //empty default contructor
        {

        }

        public BinaryTreeNode(T item) : this(item, null, null)                              //one perameter constructor assumes item, calls three parameter constructor with null children
        {

        }

        public BinaryTreeNode(T item, BinaryTreeNode<T> left, BinaryTreeNode<T> right)      //three parameter constructor takes item, left and right children, creates the node with the correct item pointing to the specified left and right
        {
            this.item = item;
            this.left = left;
            this.right = right;
        }
        public T Item
        {
            get
            {
                return item;
            }

            set
            {
                item = value;
            }
        }
        public BinaryTreeNode<T> Left
        {
            get
            {
                return left;
            }
            set
            {
                left = value;
            }
        }

        public BinaryTreeNode<T> Right
        {
            get
            {
                return right;
            }
            set
            {
                right = value;
            }
        }

        
        

        
        //DOES


       
        public override string ToString()
        {
            if (item == null)
            {
                return string.Empty;
            }
            else
            {
                return item.ToString();            
            }

        }
    }
}
