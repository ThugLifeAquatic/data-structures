using System;

namespace Possible_combinations
{
    class Program
    {
    
        static void Main(string[] args)
        {
            ComboCounter getDemCombos = new ComboCounter();
            getDemCombos.FindCombinations("abcd");
            Console.Read();
        }

        public class ComboCounter
        {
            public int Count { get; set; }

            public ComboCounter()
            {
                Count = 1;
            }

            public void FindCombinations(string theString)
            {

                Console.WriteLine(theString);
                RecursiveScrambler(0, theString);
                Console.WriteLine(Count);
            }

            public void RecursiveScrambler(int start, string alphabet)
            {
                if (start < alphabet.Length)
                {
                    char temp = alphabet[start];
                    char[] toArray = ToArray(alphabet);
                    for (int i = start; i < toArray.Length; i++)
                    {
                        char[] printArray = ToArray(alphabet);
                        printArray[start] = toArray[i];
                        printArray[i] = temp;
                        string newString = ArrToString(printArray);
                        if (!newString.Contains(alphabet))
                        {
                            Console.WriteLine(newString);
                            Count++;
                        }
                        if (start <= alphabet.Length)
                        {
                            RecursiveScrambler(start + 1, newString);
                        }
                    }
                }
            }

            public char[] ToArray(string alphabet)
            {
                char[] toArray = new char[alphabet.Length];
                for (int i = 0; i < alphabet.Length; i++)
                {
                    toArray[i] = alphabet[i];
                }
                return toArray;
            }

            public string ArrToString(char[] alphabet)
            {
                string newString = "";
                for (int i = 0; i < alphabet.Length; i++)
                {
                    newString += alphabet[i];
                }
                return newString;
            }
        }
    }
}
