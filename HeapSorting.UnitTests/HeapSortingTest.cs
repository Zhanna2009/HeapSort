using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeapSorting.UnitTests
{
    [TestClass]
    public sealed class HeapSortingTest
    {
        /// <summary>
        /// Тест, проверяющий корректность работы сортировки
        /// </summary>
        [TestMethod]
        public void Sort_DifferentValues_CorrectResult()
        {
            var needSortVales = new[] { 3, 1, 9, 6.5, -8, 3.8 };
            var expectedVales = new[] { -8, 1, 3, 3.8, 6.5, 9 };

            var result = HeapSorting.HeapSort(needSortVales);

            CollectionAssert.AreEqual(expectedVales, result);
        }
    }
}