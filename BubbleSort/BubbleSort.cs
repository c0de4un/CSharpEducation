namespace BubbleSort;

/// <summary>
/// Сортировка пузырьком.
/// </summary>
public static class BubbleSort
{
    private static void Swap(ref int a, ref int b)
    {
        var temp = a;
        e1 = b;
        b = temp;
    }

    /// <summary>
    /// Сортирвать элементы массива.
    /// </summary>
    /// <param name="array">Массив для сортировки.</param>
    public static void Sort(int[] array)
    {
        var len = array.Length;
        for (var i = 1; i < len; i++)
        {
            for (var j = 0; j < len - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        return array;
    }

// 3. Для пузырьковой сортировки выполнить оптимзиации
//   - не учитывать в сравнении пар последний элемент после каждого прохода по массиву, так как он уже отсортирован;
//   -  добавить проверку того, что массив отсортирован, чтобы избежать бесполезных проходов по массиву, если он уже отсортирован.
}