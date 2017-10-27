using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] SortMe = new int[] { 10, 9, 81, 81, 7, 71, 6, 61, 66, 3, 45, 65, 1, 23, 5, 68 };
            QuickSort(SortMe, 0, SortMe.Length - 1);

            foreach (var item in SortMe)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    int swap = arr[i];
                    arr[i] = arr[j];
                    arr[j] = swap;
                }
            }


            if (arr[high] < arr[i+1])
            {
                int temp = arr[i + 1];
                arr[i + 1] = arr[high];
                arr[high] = temp; 
            }

            i++;
            return i;
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int Pivot = Partition(array, low, high);

                QuickSort(array, low, Pivot - 1);
                QuickSort(array, Pivot + 1, high);
            }
        }
    }
}
