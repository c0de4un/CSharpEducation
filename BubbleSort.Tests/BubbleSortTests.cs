using System;
using System.Linq;
using NUnit.Framework;

namespace BubbleSort.Tests;

public class Tests
{
    private const int N = 1_000_000;
    private int[] _array;

    [SetUp]
    public void Setup()
    {
        _array = new int[N];
        var rand = new Random();
        for (int i = 0; i < N; i++)
        {
            _array[i] = rand.Next(0, N); 
        }
    }

    [TestCase(TestName = "Сортировка случайного массива")]
    public void BubbleSort_RandomArray_ShouldBeSorted()
    {
        BubbleSort.Sort(_array);
        Assert.That(IsSorted(_array, true), Is.EqualTo(true));
    }
    
    [TestCase(TestName = "Сортировка отсортированного массива")]
    public void BubbleSort_SortedArray_ShouldBeSorted()
    {
        _array = Enumerable.Range(0, N).ToArray();
        BubbleSort.Sort(_array);
        Assert.That(IsSorted(_array, true), Is.EqualTo(true));
    } 

    [TestCase(TestName = "Сортировка массива, который уже отсорирован в другую сторону")]
    public void BubbleSort_ReversedArray_ShouldBeSorted()
    {
        _array = Enumerable.Range(N, 0).ToArray();
        BubbleSort.Sort(_array);
        Assert.That(IsSorted(_array, false), Is.EqualTo(true));
    }
    
    private bool IsSorted(int[] array, bool ascending)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (ascending)
            {
                if (_array[i] > _array[i + 1])
                    return false;
            }
            else
            {
                if (_array[i] < _array[i + 1])
                    return false;
            }
        }

        return true;
    }
}