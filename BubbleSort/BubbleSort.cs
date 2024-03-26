namespace BubbleSort;

/// <summary>
/// Сортировка пузырьком.
/// </summary>
public static class BubbleSort
{
    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    /// <summary>
    /// Сортирвать элементы массива.
    /// </summary>
    /// <param name="array">Массив для сортировки.</param>
    public static int[] Sort(int[] array)
    {
        int len = array.Length;
        bool isSwapped = false;
        int a, b;
        for (int i = 1; i < len; i++)
        {
            for (int j = 0; j < len - i; j++)
            {
                a = array[j];
                b = array[j + 1];
                if (a > b)
                {
                    Swap(ref a, ref b);
                    isSwapped = true;
                }
            }

            if (!isSwapped) {
                break;
            }
        }

        return array;
    }
}