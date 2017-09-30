using System;

namespace SortedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack:");
            Stack testS = new Stack();
            testS.Push("q");
            testS.Push("w");
            testS.Push("e");
            testS.Push("r");
            testS.Push("t");
            testS.Push("y");
            testS.Push("u");
            testS.Push("i");
            testS.Push("o");
            testS.Push("p");
            testS.Push("a");
            testS.Push("s");
            testS.Push("d");
            testS.Push("f");
            testS.Push("g");
            testS.Push("h");
            testS.Push("j");
            testS.Push("k");
            testS.Push("l");
            testS.Push("z");
            testS.Push("x");
            testS.Push("c");
            testS.Push("v");
            testS.Push("b");
            testS.Push("n");
            testS.Push("m");
            
            Console.WriteLine("");

            testS.SortPush("z");
            
            Console.Read();
        }
    }
}
