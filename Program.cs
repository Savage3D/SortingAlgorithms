using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            const int arrayLength = 100;
            const int maxValue = 500;

            int[] array = new int[arrayLength];

            Random rand = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rand.Next(maxValue);
            }

            array.PrintToConsole("Before sorting:");
            array.QuickSort().PrintToConsole("\nAfter sorting (using Quick Sort algorithm):");

            Console.ReadLine();
        }
    }
}
