namespace Task2;
using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        // #1
        const int MAX_USER_NUMBERS = 5;

        string? userInput = "";
        int[] userInputNumbers = new int[MAX_USER_NUMBERS];
        Console.WriteLine("1. Ввод чисел в массив");
        for (int i = 0; i < MAX_USER_NUMBERS; i++) {
            Console.WriteLine($"Введите число #{i + 1}");
            userInput = Console.ReadLine();

            if (userInput == null) {
                Console.WriteLine("Пусстой ввод");
                i--;
                continue;
            }

            userInputNumbers[i] = int.Parse(userInput);
        }

        // #2
        Console.WriteLine("\n2. Инвертирование массива целых чисел:");
        const int MAX_INVERSION_NUMBERS = 10;
        int[] inversionNumbers = new int[MAX_INVERSION_NUMBERS];
        for (int i = 0; i < MAX_INVERSION_NUMBERS; i++) {
            inversionNumbers[i] = random.Next(999, 9999);
        }
        Array.Reverse(inversionNumbers); // Вместо цикла for, используем Array
        for (int i = 0; i < MAX_INVERSION_NUMBERS; i++) {
            Console.WriteLine(inversionNumbers[i]);
        }

        // #3
        Console.WriteLine("\n3. Пoдcчeт суммы квадрата второго столбца");
        const int FLOAT_NUMBERS_ROWS = 3;
        const int FLOAT_NUMBERS_COLS = 3;
        float[,] floatNumbers = new float[FLOAT_NUMBERS_ROWS, FLOAT_NUMBERS_COLS];
        string rndNumber_str = "";
        float sum = 0.00F;
        float cellValue = 0.00F;
        for (int col = 0; col < FLOAT_NUMBERS_COLS; col++) {
            for (int row = 0; row < FLOAT_NUMBERS_ROWS; row++) {
                rndNumber_str = $"{random.Next(99, 9999)}.{random.Next(0, 9999)}";
                cellValue = float.Parse(rndNumber_str);
                floatNumbers[row, col] = cellValue;
                sum += cellValue * cellValue;

                Console.WriteLine($"Значение ячейки[{row}-{col}]: {cellValue}; Сумма второго столбца: {sum}");
            }
        }

        Console.WriteLine($"Итоговая сумма второгостолбца: {sum}");
    }
}
