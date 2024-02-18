namespace Task3;
using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    public string GetName()
    {
        return string.Empty;
    }

    public int[] GetArray()
    {
        return [];
    }

    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int[] AllocArray(int size)
    {
        return new int[size];
    }

    /// <summary>
    /// InvertArr
    /// </summary>
    /// <param name="inArr"></param>
    /// <param name="arrSize"></param>
    /// <returns>Новую копию</returns>
    public int[] InvertArr(int[] inArr, int arrSize)
    {
        // Инвертируем через for (но можно через Array.Reverse()) & Выводим результат
        int[] invertedNumbers = new int[arrSize];
        int lastIndex = (arrSize - 1);
        int halfSize = arrSize / 2;
        int a = 0;
        int b = 0;
        for (int i = 0; i < halfSize; i++) {
            a = inArr[i];
            b = inArr[lastIndex - i];
            invertedNumbers[i] = b;
            invertedNumbers[lastIndex - i] = a;
        }

        return invertedNumbers;
    }

    public void InvertInt(ref int val)
    {
        val *= -1;
    }

    public void ReplaceInts(ref int a, ref int b)
    {
        int a_val = a;
        int b_val = b;
        a = b;
        b = a;
    }

    public int[] RemoveNegativeArr(int[] inArr, ref int removesCounter)
    {
        int arrSize = inArr.Length;
        int[] output = new int[arrSize];
        int tmpVal = 0;
        for (int i = 0; i < arrSize; i++) {
            tmpVal = inArr[i];
            if (tmpVal < 0) {
                this.InvertInt(ref tmpVal);
                removesCounter++;
            }

            output[i] = tmpVal;
        }

        return output;
    }

    static void Main(string[] args)
    {
        Program app = new Program();

        // #1
        app.GetName();

        // #2
        app.GetArray();

        // #3
        int sum = app.Sum(1, 1);
        Console.WriteLine($"Сумма: {sum}");

        // #4
        const int ARR_SIZE = 8;
        int[] arr = app.AllocArray(ARR_SIZE);
        Random random = new Random();

        // Заполняем и выводим одним циклом
        int tmpInt = 0;
        for (int i = 0; i < ARR_SIZE; i++) {
            tmpInt = random.Next(99, 9999);
            arr[i] = tmpInt;

            Console.WriteLine($"Запись#{i + 1} = {tmpInt}");
        }

        // #5
        Console.WriteLine("Инвертирование массива");
        int rnd_elements_count = random.Next(5, 10);
        int[] rndArr = app.AllocArray(rnd_elements_count);
        for (int i = 0; i < rnd_elements_count; i++) {
            tmpInt = random.Next(99, 9999);
            rndArr[i] = tmpInt;
        }
        int[] invertedArr = app.InvertArr(rndArr, rnd_elements_count);
        for (int i = 0; i < rnd_elements_count; i++) {
            Console.WriteLine($"{rndArr[i]} | {invertedArr[i]}");
        }

        // #6
        int val = -100;
        app.InvertInt(ref val);

        // #7
        Console.WriteLine("Удаление отрицательныхэлементов");
        Console.WriteLine("Оригинал | Новый");
        int removesCounter = 0;
        int[] negativeArr = new int[rnd_elements_count];
        for (int i = 0; i < rnd_elements_count; i++) {
            tmpInt = random.Next(99, 9999);
            if (i % 2 == 0) {
                app.InvertInt(ref tmpInt);
            }

            negativeArr[i] = tmpInt;
        }
        int[] positiveArr = app.RemoveNegativeArr(negativeArr, ref removesCounter);

        for (int i = 0; i < rnd_elements_count; i++) {
            Console.WriteLine($"{negativeArr[i]} | {positiveArr[i]}");
        }
    }
}
