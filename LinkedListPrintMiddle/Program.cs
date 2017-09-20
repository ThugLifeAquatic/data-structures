using System;

namespace LinkedListPrintMiddle
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
            list.Add("FIVE");
            list.Add("SIX");
            list.Add("SEVEN");
            list.Add("EIGHT");
            list.Add("NINE");
            
            list.PrintList();
            list.PrintMiddle();

            Console.ReadLine();
        }
    }
}
