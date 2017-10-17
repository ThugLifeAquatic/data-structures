using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTree testTree = new SearchTree();
            testTree.Add(testTree.Root, 5);
            testTree.Add(testTree.Root, 6);
            testTree.Add(testTree.Root, 4);
            testTree.Add(testTree.Root, 1);
            Console.Read();
        }
    }
}
