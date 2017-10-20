using System;

namespace BSTreeFromArray
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

            Console.WriteLine("PRINT:");
            testTree.Print(testTree.Root);

            Console.Write("REMOVE:");
            Console.WriteLine(testTree.Remove(testTree.Root, 5).Data);
            Console.WriteLine(testTree.Remove(testTree.Root, 4).Data);
            Console.WriteLine(testTree.Remove(testTree.Root, 7).Data);

            Console.WriteLine("PRINT:");
            testTree.Print(testTree.Root);

            Console.WriteLine("ARRAY TO BST:");
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            SearchTree testTWO = new SearchTree();
            testTWO.Root = testTWO.ArrToBST(arr,0, arr.Length-1);

            testTWO.Print(testTWO.Root);





            Console.Read();
        }
    }
}
