using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree<T>                                     //declare BinaryTree<T> class
    {
        //HAS

        private BinaryTreeNode<T> root = null;

        public BinaryTreeNode<T> Root                       //declaring BinaryTree<T> declares BinaryTreeNode<T> root of null
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }

        //CONSTRUCTOR
        public BinaryTree()
        {
            root = null;
        }

        //DOES
        public virtual void Clear()
        {
            root = null;
        }

        private string DisplayInOrder(BinaryTreeNode<T> current)
        {
            string tree = string.Empty;

            if (current != null)
            {
                tree += DisplayInOrder(current.Left);
                tree += current.ToString() + " ";
                tree += DisplayInOrder(current.Right);
            }
            return tree;
        }

        public string DisplayInOrderTraverse()
        {
            return DisplayInOrder(root);
        }

        public override string ToString()
        {
            return DisplayInOrder(root);
        }
    }
}