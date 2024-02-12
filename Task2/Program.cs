namespace Task2;
using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        // #1
        const int MAX_USER_NUMBERS = 5;

        string? userInput = "";
        int userInputNumber = 0;
        int[] userInputNumbers = new int[MAX_USER_NUMBERS];
        Console.WriteLine("1. Ввод чисел в массив");
        for (int i = 0; i < MAX_USER_NUMBERS; i++) {
            Console.WriteLine($"Введите число #{i + 1}");
            userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userInputNumber)) {
                userInputNumbers[i] = userInputNumber;
            } else {
                Console.WriteLine("Пусстой ввод");
                i--;
                continue;
            }
        }

        // #2
        Console.WriteLine("\n2. Инвертирование массива целых чисел:");
        const int MAX_INVERSION_NUMBERS = 10;
        int[] notInvertedNumbers = new int[MAX_INVERSION_NUMBERS];
        for (int i = 0; i < MAX_INVERSION_NUMBERS; i++) {
            notInvertedNumbers[i] = random.Next(999, 9999);
        }

        // Инвертируем через for (но можно через Array.Reverse()) & Выводим результат
        int[] invertedNumbers = new int[MAX_INVERSION_NUMBERS];
        const int lastIndex = (MAX_INVERSION_NUMBERS - 1);
        const int halfSize = MAX_INVERSION_NUMBERS / 2;
        int a = 0;
        int b = 0;
        for (int i = 0; i < halfSize; i++) {
            a = notInvertedNumbers[i];
            b = notInvertedNumbers[lastIndex - i];
            invertedNumbers[i] = b;
            invertedNumbers[lastIndex - i] = a;
        }

        // Вывод результата
        Console.WriteLine("Исходный порядок | Инвертированный порядок");
        for (int i = 0; i < MAX_INVERSION_NUMBERS; i++) {
            Console.WriteLine($"{notInvertedNumbers[i]} | {invertedNumbers[i]}");
        }

        // #3
        Console.WriteLine("\n3. Пoдcчeт суммы квадрата второго столбца");
        const int FLOAT_NUMBERS_ROWS = 3;
        const int FLOAT_NUMBERS_COLS = 3;
        double[,] floatNumbers = new double[FLOAT_NUMBERS_ROWS, FLOAT_NUMBERS_COLS];
        double sum = 0.00;
        double cellValue = 0.00;
        for (int col = 0; col < FLOAT_NUMBERS_COLS; col++) {
            for (int row = 0; row < FLOAT_NUMBERS_ROWS; row++) {
                cellValue = random.NextDouble() * 8999.0 + 999.99;
                floatNumbers[row, col] = cellValue;
                sum += cellValue * cellValue;

                Console.WriteLine($"Значение ячейки[{row}-{col}]: {cellValue}; Сумма второго столбца: {sum}");
            }
        }

        Console.WriteLine($"Итоговая сумма второгостолбца: {sum}");
    }
}
