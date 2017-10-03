using System;

namespace TwoLevelTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tree World!");
            Trees aTree = new Trees();
            aTree.AddFirst(0);
            aTree.Root.Left = new Node(1);
            aTree.Root.Right = new Node(2);
            aTree.Root.Left.Left = new Node(3);
            aTree.Root.Left.Right = new Node(4);
            aTree.Root.Right.Left = new Node(5);
            aTree.Root.Right.Right = new Node(6);

            Console.ReadLine();
        }
    }
}
