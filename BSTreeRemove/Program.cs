using System;

namespace BSTreeRemove
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
            testTree.Add(testTree.Root, 2);
            testTree.Add(testTree.Root, 3);
            testTree.Add(testTree.Root, 7);
            testTree.Add(testTree.Root, 8);

            Console.Write("MIN: ");
            Console.WriteLine(testTree.Min(testTree.Root).Data);

            Console.Write("MAX: ");
            Console.WriteLine(testTree.Max(testTree.Root).Data);

            Console.Write("FIND:");
            Console.WriteLine(testTree.FindParent(testTree.Root, 8).Data);

            Console.WriteLine("Print:");
            testTree.Print(testTree.Root);

            Console.Write("REMOVE:");
            Console.WriteLine(testTree.Remove(testTree.Root, 5).Data);

            Console.WriteLine("Print:");
            testTree.Print(testTree.Root);





            Console.Read();
        }
    }
}
