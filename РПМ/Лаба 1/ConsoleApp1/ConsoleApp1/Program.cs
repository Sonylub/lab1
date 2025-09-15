using System;
using System.Linq;
class Program
{
    static void Main()
    {
        char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
        int correctCount = 0;
        int attemptCount = 0;

        while (true)
        {
            Console.WriteLine("Введите слово или нажмите пробел для завершения: ");
            string input = Console.ReadLine()?.ToLower();

            if (string.IsNullOrEmpty(input))
            {
                break; 
            }

            attemptCount++;

            int syllableCount = input.Count(c => vowels.Contains(c));

            if (syllableCount >= 2)
            {
                correctCount++; 
                Console.WriteLine("Слово принято.");
            }
            else
            {
                Console.WriteLine("Слово должно содержать два слога.");
            }
        }

        if (attemptCount > 0)
        {
            double score = (double)correctCount / attemptCount * 100;
            Console.WriteLine($"\nКоличество попыток: {attemptCount}");
            Console.WriteLine($"Количество правильных ответов: {correctCount}");
            Console.WriteLine($"Ваша оценка: {score:F2} из 100");
        }
        else
        {
            Console.WriteLine("Попыток не было.");
        }
    }
}
