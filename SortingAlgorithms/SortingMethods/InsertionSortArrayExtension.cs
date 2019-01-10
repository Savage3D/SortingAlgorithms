using System;

namespace SortingAlgorithms.SortingMethods
{
    public static class InsertionSortArrayExtension
    {
        public static T[] InsertionSort<T>(this T[] array)
            where T : IComparable<T>
        {
            int arrayLength = array.Length;
            if (arrayLength <= 1) return array;

            int i = 1;
            while (i < arrayLength)
            {
                T current = array[i];
                int j = i - 1;

                while (j >= 0 && current.CompareTo(array[j]) < 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = current;
                i++;
            }

            return array;
        }

    }
}
