using System;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUEUE TEST:");
            Queue testQ = new Queue();
            testQ.Enqueue("ONE");
            testQ.Enqueue("TWO");
            testQ.Enqueue("THREE");
            testQ.Enqueue("FOUR");
            testQ.Dequeue();

            Console.WriteLine("");
            
            Console.WriteLine("STACK TEST:");
            Stack testS = new Stack();
            testS.Push("ONE");
            testS.Push("TWO");
            testS.Push("THREE");
            testS.Push("FOUR");
            testS.Pop();
            
            Console.Read();
        }
    }
}
