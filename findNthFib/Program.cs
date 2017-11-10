using System;

namespace findNthFib
{
    class Program
    {
        static void Main(string[] args)
        {
            FindNthFib(0, 1, 7);
            Console.Read();
        }

        static void FindNthFib(int first, int second, int target)
        {
            //since we start with the first 2 numbers stop at 2.
            if (target != 2)
            {
                int next = first + second;
                //decrement target so we can stop the algorithm in the right place.
                target--;
                //recall the function with the next pair in the sequence.
                FindNthFib(second, next, target);
            }
            //print the result
            Console.WriteLine(second);
        }
    }

}
