using System;

namespace Matrix_XMarksTheZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix testMatrix = new Matrix(20,10);
            testMatrix.Populate(1);
            Console.WriteLine("OG MATRIX");
            for (int i = 0; i < testMatrix.Depth; i++)
            {
                for (int j = 0; j < testMatrix.Width; j++)
                {
                    Console.Write(testMatrix.MyMatrix[j, i]);
                }
                Console.WriteLine();
            }
            testMatrix.AddAt(9, 4, 0);

            Console.WriteLine("NEW MATRIX");
            for (int i = 0; i < testMatrix.Depth; i++)
            {
                for (int j = 0; j < testMatrix.Width; j++)
                {
                    Console.Write(testMatrix.MyMatrix[j, i]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }

    class Matrix
    {
        public int[,] MyMatrix { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        public Matrix(int width, int depth)
        {
            Width = width;
            Depth = depth;
            MyMatrix = new int[ width, depth ];
        }

        public void Populate(int value)
        {
            for(int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Depth; y++)
                {
                    MyMatrix[x, y] = value;
                }
            }
        }

        public void AddAt(int x, int y, int value)
        {
            if (value == 0)
            {
                for (int i = 0; i < Width; i++)
                {
                    MyMatrix[i, y] = 0;
                }
                for (int j = 0; j < Depth; j++)
                {
                    MyMatrix[x, j] = 0;
                }
            }
            else
            {
                MyMatrix[x, y] = value;
            }
        }
    }
}
