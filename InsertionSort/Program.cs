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

            for (int i = 0; i < arr.Length; i++)
            {
                //Had everything correct on my own with no reference exept the below conditional.
                //I was starting j at 1 and incrementing instead of starting j at i and deprecating.
                //I went here for help: "http://www.c-sharpcorner.com/blogs/insertion-sorting-algorithm-in-c-sharp1"

                //START EXTERNAL RESOURCE
                for (int j = i; j > 0; j--)
                //END EXTERNAL RESOURCE
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
