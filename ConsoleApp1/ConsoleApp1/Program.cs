using System;

namespace ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод размерности массива
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());

            // Создание и заполнение массива случайными числами
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-1000, 1000);
                Console.Write("{0,8}", array[i]);
            }
            Console.WriteLine();

            // Вычисление суммы четных элементов
            int sumEven = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    sumEven += num;
                }
            }

            // Проверка условия и выполнение соответствующего действия
            if (sumEven > 0)
            {
                // Удвоение четных элементов
                for (int i = 0; i < n; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        array[i] *= 2;
                    }
                }
            }
            else
            {
                // Поиск максимального элемента и его индекса
                int maxIndex = 0;
                for (int i = 1; i < n; i++)
                {
                    if (array[i] > array[maxIndex])
                    {
                        maxIndex = i;
                    }
                }

                // Удвоение элементов после максимального
                for (int i = maxIndex + 1; i < n; i++)
                {
                    array[i] *= 2;
                }
            }

            // Вывод измененного массива
            Console.WriteLine("Измененный массив:");
            foreach (int num in array)
            {
                Console.Write("{0,8}", num);
            }
            Console.WriteLine();
        }
    }
}