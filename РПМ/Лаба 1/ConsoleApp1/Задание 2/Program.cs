using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите три целых числа:");

        // Вводим три числа
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        // Настраиваем цвета и выводим числа
        PrintColoredNumber(a);
        PrintColoredNumber(b);
        PrintColoredNumber(c);
    }

    static void PrintColoredNumber(int num)
    {
        if (num % 3 == 0 && num % 7 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        else if (num % 3 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (num % 7 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine(num);

        // Возвращаем цвет в исходное состояние
        Console.ResetColor();
    }
}
