using System;

namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        string[] names = {
            "Иван", "Алексей", "Сергей", "Антон", "Дмитрий",
            "Анна", "Екатерина", "Мария", "Наталья", "Ольга"
        };
        string[] surNames = {
            "Анна", "Екатерина", "Мария", "Наталья", "Ольга",
            "Иванова", "Петрова", "Сидорова", "Смирнова", "Соколова"
        };
        string[] emails = {
             "ivan.ivanov@example.com", "alexey.petrov@example.com", "sergey.sidorov@example.com", "anton.smirnov@example.com", "dmitry.sokolov@example.com"
        };
        

        int age = 0;
        int universityCode = 0;
        const int MAX_STUDENTS = 5;
        string name = "";
        string surname = "";
        string email = "";
        Student student;
        Student[]students = new Student[5];

        Student? youngest = null;
        Student? oldest = null;

        System.Console.WriteLine("Список студентов: Имя | Возраст");
        for (int i = 0; i < MAX_STUDENTS; i++) {
            age = i < 1 ? 21 : rnd.Next(18, 60);
            universityCode = rnd.Next(1, 3);
            name = names[rnd.Next(0, 9)];
            surname = surNames[rnd.Next(0, 9)];
            email = emails[rnd.Next(0, 4)];

            student = new Student(
                age,
                name,
                surname,
                email,
                universityCode
            );

            if (youngest == null) {
                youngest = student;
            } else if (youngest.getAge() > age) {
                youngest = student;
            }
            
            if (oldest == null) {
                oldest = student;
            } else if (oldest.getAge() < age) {
                oldest = student;
            }

            students[i] = student;

            System.Console.WriteLine($"{student.getName()} | {student.getAge()}");
        }

        Student? studentToFind = null;
        for (int i = 0; i < MAX_STUDENTS; i++) { // Array.Find()
            student = students[i];

            if (student.getAge() == 21) {
                studentToFind = student;
                break;
            }
        }

        studentToFind?.IntroduceYourself();

        System.Console.WriteLine($"Младший: {youngest?.getName()}");
        System.Console.WriteLine($"Старший: {oldest?.getName()}");
    }
}
