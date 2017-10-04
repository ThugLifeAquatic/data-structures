﻿using System;

namespace TreeTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Tree World!");
            Trees aTree = new Trees();
            aTree.AddFirst(4);
            aTree.Root.Left = new Node(2);
            aTree.Root.Right = new Node(6);
            aTree.Root.Left.Left = new Node(1);
            aTree.Root.Left.Right = new Node(3);
            aTree.Root.Right.Left = new Node(5);
            aTree.Root.Right.Right = new Node(7);

            Console.WriteLine("TRAVERSAL:");

            aTree.Traverse(aTree.Root);
            Console.ReadLine();
        }
    }
}
