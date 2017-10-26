using System;
using System.Collections.Generic;

namespace RadixSort
{
    class Program
    {
        //To write this solution I used this resource as a logical guide: http://www.csharpstar.com/csharp-program-radix-sort/
        //This implementation is entirely my own except for the modulo math on line 33.  It was borrowed from the above resource.

        //ALGORITH DESCRIPTION:
        //1. Take in unsorted array, attain the size of its max value.
        //2. Perform first pass sort on the array, pushing each value into the appropriate bucket. Return the bucket.
        //3. Take in the new bucket, increment power and sort it using the incremented power, and return the new bucket. 
        //4. Repeat on the new bucket until the last power is reached.
        //5. Convert final bucket into an array and return the sorted array.

        static void Main(string[] args)
        {
            int[] sortMe = new int[] {4, 25, 123, 45, 532, 12, 19, 6, 66 };

            foreach (var item in RadixSort(sortMe))
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        //Does the underlying math to determine which bucket a value should go in.
        static int DoTheMonsterMath(int power, int value)
        {
            return (int)((value % Math.Pow(10, power + 1)) / Math.Pow(10, power));
        }

        //Takes the original array, does the first sort and returns an array of populated buckets
        static List<int>[] ToBuckets(int[] toSort)
        {
            List<int>[] theBuckets = new List<int>[10];
            for (int i = 0; i < theBuckets.Length; i++)
            {
                theBuckets[i] = new List<int>();
            }
            for (int i = 0; i < toSort.Length; i++)
            {
                theBuckets[DoTheMonsterMath(0, toSort[i])].Add(toSort[i]);
            }
            return theBuckets;
        }

        //Takes an array of populated buckets and creates a newly sorted bucket array determined by the power.
        static List<int>[] SortDemBuckets(int power, List<int>[] bucketToSort)
        {
            List<int>[] newBuckets = new List<int>[10];
            for (int i = 0; i < newBuckets.Length; i++)
            {
                newBuckets[i] = new List<int>();
            }
            for (int i = 0; i < bucketToSort.Length; i++)
            {
                if (bucketToSort[i].Count > 0)
                {
                    for (int j = 0; j < bucketToSort[i].Count; j++)
                    {
                        newBuckets[DoTheMonsterMath(power, bucketToSort[i][j])].Add(bucketToSort[i][j]);
                    }
                }
            }
            return newBuckets;
        }

        //Converts a bucket list int the final sorted array
        static int[] ToFinalArray(List<int>[] bucketToSort, int originalArrayLength)
        {

            int[] returnArray = new int[originalArrayLength];
            int addAtIndex = 0;
            for (int i = 0; i < bucketToSort.Length; i++)
            {
                if (bucketToSort[i].Count > 0)
                {
                    for (int j = 0; j < bucketToSort[i].Count; j++)
                    {
                        returnArray[addAtIndex] = bucketToSort[i][j];
                        addAtIndex++;
                    }
                }
            }
            return returnArray;
        }

        //Returns the length of the largest number in the Array
        static int GetMax(int[] theArray)
        {
            int max = 0;
            int checkLength;

            for (int i = 0; i < theArray.Length; i++)
            {
                checkLength = theArray[i].ToString().Length;
                if (checkLength > max)
                {
                    max = checkLength;
                }
            }

            return max;
        }

        static int[] RadixSort(int[] toSort)
        {
            List<int>[] SortedBucket = ToBuckets(toSort);
            for (int i = 1; i < GetMax(toSort) ; i++)
            {
                SortedBucket = SortDemBuckets(i, SortedBucket);
            }

            int[] returnArray = ToFinalArray(SortedBucket, toSort.Length);

            return returnArray;
        }

    }
}
