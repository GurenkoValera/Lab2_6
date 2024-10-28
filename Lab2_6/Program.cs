using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число от 1 до 100:");
        int N;

        // Проверяем, является ли ввод корректным
        while (!int.TryParse(Console.ReadLine(), out N) || N < 1 || N > 100)
        {
            Console.WriteLine("Пожалуйста, введите корректное число от 1 до 100:");
        }

        // Определяем правильное окончание
        string ending;
        if (N % 10 == 1 && N % 100 != 11)
        {
            ending = "год";
        }
        else if ((N % 10 >= 2 && N % 10 <= 4) && (N % 100 < 10 || N % 100 >= 20))
        {
            ending = "года";
        }
        else
        {
            ending = "лет";
        }

        // Выводим результат
        Console.WriteLine($"{N} {ending}");
    }
}
