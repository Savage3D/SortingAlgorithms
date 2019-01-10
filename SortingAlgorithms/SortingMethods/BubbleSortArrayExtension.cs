using System;

namespace SortingAlgorithms.SortingMethods
{
    public static class BubbleSortArrayExtension
    {
        public static T[] BubbleSort<T>(this T[] array)
            where T : IComparable<T>
        {
            int arrayLength = array.Length;
            if (arrayLength <= 1) return array;

            int n = arrayLength - 1;
            while (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) > 0)
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }

                n--;
            }

            return array;
        }

        private static void Swap<T>(ref T first, ref T second)
            where T : IComparable<T>
        {
            T temp = first;
            first = second;
            second = temp;
        }
    }
}
