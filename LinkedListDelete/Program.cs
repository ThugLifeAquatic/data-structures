using System;

namespace ReturnNthNode
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
            //list.PrintMiddle();
            Console.WriteLine();
            list.PrintNth(3);
            Console.WriteLine();
            list.PrintNthData("SEVEN");
            list.Delete("ONE");
            Console.WriteLine();
            list.PrintList();
            list.Delete("FIVE");
            Console.WriteLine();
            list.PrintList();


            Console.ReadLine();
        }
    }
}
