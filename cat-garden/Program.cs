using System;

namespace cat_garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string c = "catnip ";
            string m = "mint   ";
            string[,] garden = new string[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i % 2 == 0)
                    {
                        garden[i, j] = c;
                        if ((j > 0) && (garden[i, j - 1] == c))
                        {
                            garden[i, j] = m;
                        }
                    }
                    else
                    {
                        garden[i, j] = m;
                        if ((j > 0) && (garden[i, j - 1] == m))
                        {
                            garden[i, j] = c;
                        }
                    }
                    Console.Write(garden[i, j]);
                }
                Console.WriteLine("");
            }
            Console.Read();
        }

    }
}
