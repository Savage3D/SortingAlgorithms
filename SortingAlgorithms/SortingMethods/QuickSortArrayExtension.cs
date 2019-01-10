using System;

namespace SortingAlgorithms.SortingMethods
{
    public static class QuickSortArrayExtension
    {
        public static T[] QuickSort<T>(this T[] array)
            where T : IComparable<T>
        {
            Sort(array, 0, array.Length - 1);
            return array;
        }

        private static void Sort<T>(T[] array, int lowIndex, int highIndex)
            where T : IComparable<T>
        {
            if (lowIndex < highIndex)
            {
                int partitionIndex = DoPartition(array, lowIndex, highIndex);

                Sort(array, lowIndex, partitionIndex);
                Sort(array, partitionIndex + 1, highIndex);
            }
        }

        private static int DoPartition<T>(T[] array, int lowIndex, int hignIndex)
            where T : IComparable<T>
        {
            T pivot = array[(lowIndex + hignIndex) / 2];
            int leftIndex = lowIndex - 1;
            int rightIndex = hignIndex + 1;

            while (true)
            {
                do
                {
                    leftIndex++;
                } while (array[leftIndex].CompareTo(pivot) < 0);

                do
                {
                    rightIndex--;
                } while (array[rightIndex].CompareTo(pivot) > 0);

                if (leftIndex >= rightIndex) return rightIndex;

                SwapElements(ref array[leftIndex], ref array[rightIndex]);
            }
        }

        private static void SwapElements<T>(ref T first, ref T second)
            where T : IComparable<T>
        {
            T temp = first;
            first = second;
            second = temp;
        }
    }
}
