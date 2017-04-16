using System;

namespace HeapSorting
{
    /// <summary>
    /// Реализация алгоритма пирамидальной сортировки
    /// </summary>
    public class HeapSorting
    {
        /// <summary>
        /// Выполнение пирамидальной сортировки
        /// </summary>
        /// <typeparam name="T">Тип для сортировки</typeparam>
        /// <param name="data">Коллекция, которую нужно осортировать</param>
        public static T[] HeapSort<T>(T[] data) where T : IComparable
        {
            // Сохраняем размер массива
            var heapSize = data.Length;

            // Создаём из массива сортирующее дерево. Максимальный элемент окажется в корне
            for (var p = (heapSize - 1) / 2; p >= 0; --p)
                MaxHeapify(data, heapSize, p);
            
            for (var i = data.Length - 1; i > 0; --i)
            {
                // Меняем максимум с последним элементом
                var temp = data[i];
                data[i] = data[0];
                data[0] = temp;
                
                // Уменьшаем число необработанных элементов
                --heapSize;

                // Перестравиваем сортирующее дерево для неотсортированной части массива
                MaxHeapify(data, heapSize, 0);
            }

            return data;
        }

        /// <summary>
        /// Перестраиваение элементов пирамиды при условии, 
        /// что элемент с указанным индексом меньше хотя бы одного из своих потомков,
        /// нарушая тем самым свойство невозрастающей пирамиды
        /// </summary>
        /// <typeparam name="T">Тип для сортировки</typeparam>
        /// <param name="data">Элементы пирамиды</param>
        /// <param name="heapSize">Размер пирамиды</param>
        /// <param name="index">Текущий элемент</param>
        private static void MaxHeapify<T>(T[] data, int heapSize, int index) where T : IComparable
        {
            int largest;
            var left = (index + 1) * 2 - 1; // Получаем левого потмка
            var right = (index + 1) * 2; // Получаем правого потмка

            // Получаем индекс наибольшего элемента
            if (left < heapSize && data[left].CompareTo(data[index]) > 0)
                largest = left;
            else
                largest = index;

            if (right < heapSize && data[right].CompareTo(data[largest]) > 0)
                largest = right;

            // Пока индекс не равен индексу наибольшего элемента
            if (largest != index)
            {
                // Меняем максимум с наибольшим элементом
                var temp = data[index];
                data[index] = data[largest];
                data[largest] = temp;

                // Перестравиваем сортирующее дерево для неотсортированной части массива
                MaxHeapify(data, heapSize, largest);
            }
        }
    }
}