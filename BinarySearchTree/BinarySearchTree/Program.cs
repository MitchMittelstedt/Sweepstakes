using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> BST = new BinarySearchTree<int>();

            BST.Add(12);
            BST.Add(1);
            BST.Add(5);
            BST.Add(30);
            BST.Add(15);
            Console.WriteLine(BST.ToString());
            Console.ReadKey();
        }
    }
}
