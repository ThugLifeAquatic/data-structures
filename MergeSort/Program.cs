using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ImmaBeSortedYall = new int[] { 1, 9, 2, 8, 3, 7, 4, 6, 5 };
            MergeSort(ImmaBeSortedYall, 0, ImmaBeSortedYall.Length - 1);

            foreach (var item in ImmaBeSortedYall)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

        //For the Below methods I used this resource: https://gist.github.com/pmgeorg/9122984
        //Same basic logic, but I tightened up the code quite a bit for a more streamlined implementation
        static void DoMerge(int[] toSort, int left, int middle, int right)
        {
            int leftPointer = left;
            int rightPointer = middle + 1;
            int[] temp = new int[(right - left) + 1];
            int tempPointer = 0;

            while (leftPointer <= middle && rightPointer <= right)
            {
                if (toSort[leftPointer] < toSort[rightPointer])
                {
                    temp[tempPointer++] = toSort[leftPointer++];
                }
                else
                {
                    temp[tempPointer++] = toSort[rightPointer++];
                }
            }

            while (leftPointer <= middle)
            {
                temp[tempPointer++] = toSort[leftPointer++];
            }

            while (rightPointer <= right)
            {
                temp[tempPointer++] = toSort[rightPointer++];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                toSort[left + i] = temp[i];
            }
        }

        static void MergeSort(int[] toSort, int left, int right)
        {
            if (left < right)
            {
                int middle = (left / 2) + (right / 2);
                MergeSort(toSort, left, middle);
                MergeSort(toSort, middle + 1, right);
                DoMerge(toSort, left, middle, right);
            }
        }
    }
}
