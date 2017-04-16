using System;
using System.Collections.Generic;

namespace HeapSorting.Usage
{
    public static class Program
    {
        /// <summary>
        /// Пример использования
        /// Сначала выводим на экран неотсортированный массив, после чего сортируем и выводим сортированый
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Before sorting: ");
            var beforeSorting = new[] { 7, 5, 2, 0, -5, 2, 3 };
            Print(beforeSorting);

            Console.WriteLine();
            Console.WriteLine("After sorting: ");
            var afterSorting = HeapSorting.HeapSort(beforeSorting);
            Print(afterSorting);

            Console.ReadKey();
        }

        /// <summary>
        /// Выводит на экран все значения массива
        /// </summary>
        /// <param name="someArray">Массив</param>
        private static void Print(IEnumerable<int> someArray)
        {
            foreach (var item in someArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}