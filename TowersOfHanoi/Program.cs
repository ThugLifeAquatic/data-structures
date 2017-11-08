using System;
using System.Collections.Generic;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack<int> A = new Stack<int>();
            Populate(A, 3);
            Console.WriteLine(A.Count);
            Stack<int> B = new Stack<int>();
            Stack<int> C = new Stack<int>();
            RecursiveTowerShuffle(A, B, C, C, A.Count);
            while (C.Count > 0)
            {
                Console.WriteLine(C.Pop());
            }
            Console.Read();

        }

        static void Populate(Stack<int> theStack, int length)
        {
            for (int i = length; i > 0; i--)
            {
                theStack.Push(i);
            }
        }

        static void RecursiveTowerShuffle(Stack<int> origin, Stack<int> near, Stack<int> far, int until)
        {
            Stack<int> temp = new Stack<int>();
            while (end.Count == 0 || end.Peek() != until)
            {

                far.Push(origin.Pop());
                near.Push(origin.Pop());
                near.Push(far.Pop());
                

                temp = origin;
                origin = near;
                near = far;
                far = temp;
            }
            RecursiveTowerShuffle(near, far, origin, end, until - 1);
        }

        static void Hanoiafy(Stack<int> A, Stack<int> B, Stack<int> C)
        {
            if (C.Count == 0 || C.Peek() != 1)
            {
                RecursiveTowerShuffle(B, C, A, C, A.Count);
            }
        }
    }
}
