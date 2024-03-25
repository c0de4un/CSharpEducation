namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        // #1 Random int array
        int size = rnd.Next(0, 10);
        int[] numbers = new int[size];
        for (int i = 0; i < size; i++) {
            numbers[i] = rnd.Next(1, 99);
        }

        Array.Sort(numbers);

        int correctIndex = rnd.Next(0, size - 1);
        int numberToFind = numbers[correctIndex];

        int index = Search.LinearSearch(numberToFind, numbers);
        System.Console.WriteLine($"Линейный поиск целого числа: Правильный={(correctIndex == index)}; Индекс числа {numberToFind} = {index}");

        index = Search.BinarySearch(numberToFind, numbers);
        System.Console.WriteLine($"Бинарный поиск целого числа: Правильный={(correctIndex == index)}; Индекс числа {numberToFind} = {index}");

        string[] russianNames = {
            "Александр",
            "Михаил",
            "Иван",
            "Сергей",
            "Дмитрий",
            "Андрей",
            "Николай",
            "Владимир",
            "Алексей",
            "Юрий"
        };
        Array.Sort(russianNames);

        string nameToFind = russianNames[5];
        index = Search.BinarySearch(nameToFind, russianNames);
        System.Console.WriteLine($"Бинарный поиск строки: Правильный={(index == 5)}; Индекс={index}");
    }
}
