using System;
using System.Linq;
using NUnit.Framework;

namespace BinarySearch.Tests
{
    public class BinarySearchTests
    {
        private const int N = 1_000_000_000;
        private int[] _sortedArray;
        private int[] _unsortedArray;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this._sortedArray = Enumerable.Range(0, N).ToArray();
            this._unsortedArray = new int [N];
            var rand = new Random();
            for (int i = 0; i < N; i++)
            {
                _unsortedArray[i] = rand.Next(); 
            }
        }

        [TestCase(0, ExpectedResult = 0, TestName = "Поиск элемента на первом месте в массиве")]
        [TestCase(N - 1, ExpectedResult = N - 1, TestName = "Поиск элемента на последнем месте в массиве.")]
        [TestCase(N / 2, ExpectedResult = N / 2, TestName = "Поиск элемента в середине массива.")]
        [TestCase(N, ExpectedResult = -1, TestName = "Поиск элемента, которого нет в массиве.")]
        public int BinarySearch_SortedArray_FindX(int x)
        {
            return BinarySearch.Search(_sortedArray, x);
        }

        [TestCase(-1, ExpectedResult = -1, TestName = "Поиск элемента в неотсортированном массиве.")]
        public int BinarySearch_UnsortedArray_FindX(int x)
        {
            return BinarySearch.Search(_unsortedArray, x);
        }
    }
}