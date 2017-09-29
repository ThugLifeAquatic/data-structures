using System;

namespace IsPalindromeQueue
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

            IsPalindrome();

            Console.WriteLine("");
            
            Console.Read();
        }

        public static void IsPalindrome()
        {
            Console.WriteLine("Enter a word to check if it is a palindrome.");
            Queue palinQ = new Queue();
            string OGword = Console.ReadLine();
            string newWord = "";
            for (int i = OGword.Length-1; i >= 0; i--)
            {
                palinQ.Enqueue(OGword[i]);
            }

            for (int i = 0; i < OGword.Length; i++)
            {
                newWord += palinQ.Dequeue();
            }

            Console.WriteLine(newWord);

            if (newWord == OGword)
            {
                Console.WriteLine($"{OGword} is a palindrome!");
            }
            else
            {
                Console.WriteLine($"{OGword} is NOT a palindrome :(");
            }

        }
    }
}
