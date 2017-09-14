using System;

namespace reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to be reversed.");
            string input = Console.ReadLine();
            WhirlDirly(input);
        }

        static void WhirlDirly(string word)
        {
            string whirlyWord = "";
            for (int i = word.Length - 1; i >= 0 ; i--)
            {
                whirlyWord += word[i];
            }
            Console.WriteLine(whirlyWord);
            Console.WriteLine("Enter a word to be reversed.");
            string input = Console.ReadLine();
            WhirlDirly(input);

        }
    }
}
