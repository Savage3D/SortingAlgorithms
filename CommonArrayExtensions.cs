using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public static class CommonArrayExtensions
    {
        public static void PrintToConsole<T>(this T[] array, string startString = "")
        {
            Console.Write($"{startString}\n{string.Join(" ", array)}\n");
        }
    }
}
