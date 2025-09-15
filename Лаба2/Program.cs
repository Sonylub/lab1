using System;

class Program
{
    static void Main()
    {
        // Ввод размерности массива
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());

        // Инициализация массива и генератора случайных чисел
        int[] mas = new int[n];
        Random rnd = new Random();

        // Заполнение массива случайными числами
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = rnd.Next(-1000, 1000);
        }


        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write("{0,8}", mas[i]);
        }
        Console.WriteLine();

        // Вычисление суммы четных элементов
        int evenSum = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] % 2 == 0)
            {
                evenSum += mas[i];
            }
        }

        Console.WriteLine($"Сумма чётных элементов: {evenSum}");

        // Удваиваем четные элементы, если их сумма положительная
        if (evenSum > 0)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    mas[i] *= 2;
                }
            }
            Console.WriteLine("Чётные элементы удвоены:");
        }
        else
        {
            // Находим максимальный элемент
            int maxIndex = 0;
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] > mas[maxIndex])
                {
                    maxIndex = i;
                }
            }

            // Удваиваем элементы после максимального
            for (int i = maxIndex + 1; i < mas.Length; i++)
            {
                mas[i] *= 2;
            }
            Console.WriteLine($"Элементы после максимального элемента (mas[{maxIndex}] = {mas[maxIndex]}) удвоены:");
        }

        // Вывод измененного массива
        for (int i = 0; i < mas.Length; i++)
        {
            Console.Write("{0,8}", mas[i]);
        }
    }
}
