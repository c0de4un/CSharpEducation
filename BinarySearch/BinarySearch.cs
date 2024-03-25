using System;

namespace BinarySearch;

/// <summary>
/// Двоичный поиск в отсортированном массиве.
/// </summary>
public static class BinarySearch
{
    /// <summary>
    /// Искать число <see cref="needle"/> массиве целочисленных чисел.
    /// </summary>
    /// <param name="heystack">Массив целочисленных чисел.</param>
    /// <param name="needle">Искомый элемент.</param>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns>Индекс <see cref="needle"/> в массиве. Иначе <c>-1</c>, если элемент не найден.</returns>
    public static int Search(int[] heystack, int needle)
    {
        return heystack.Length < 1 ? 0 : recursiveBinarySearch(needle, heystack, 0, heystack.Length);
    }

    private static int recursiveBinarySearch(int needle, int[] heystack, int left, int right)
    {
        if (left > right) {
            return -1;
        }

        int middle = ((left + right) / 2) - 1;
        int entry = heystack[middle];
        if (entry == needle) {
            return middle;
        }

        if (entry > needle) {
            return recursiveBinarySearch(needle, heystack, left, middle - 1);
        }

        return recursiveBinarySearch(needle, heystack, middle + 1, right);
    }
}