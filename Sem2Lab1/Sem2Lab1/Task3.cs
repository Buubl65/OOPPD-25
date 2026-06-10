using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab1
{
    class Task3
    {
        public delegate bool FilterPredicate(int number);

        public static bool IsEven(int number) => number % 2 == 0;
        public static bool IsGreaterThan5(int number) => number > 5;

        public static void FilterArray(int[] array, FilterPredicate predicate)
        {
            foreach (var num in array)
            {
                if (predicate(num))
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }
    }
}
