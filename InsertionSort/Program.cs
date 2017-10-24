using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 3, 1, 5, 4, 6, 20, 15, 11, 3 };
            int[] newArr = InsertionSort(arr);
            foreach(int item in newArr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
        static int[] InsertionSort(int[] arr)
        {
            int temp;

            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];

                for (int j = i; j > 0; j--)
                {
                    if (arr[j-1] > arr[j])
                    {
                        int swap = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = swap;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return arr;
        }
    }
}
