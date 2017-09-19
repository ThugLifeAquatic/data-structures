using System;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add("ONE");
            list.Add("TWO");
            list.Add("THREE");
            list.Add("FOUR");
            list.PrintList();

            Console.ReadLine();
        }
    }
}
