using System;

namespace ArrayProcessing
{
    class Program
    {
        // Функция для заполнения массива случайными числами
        static void FillArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 101); // [-100, 100]
            }
        }

        // Функция для вывода массива на экран
        static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write($"{num,8}");
            }
            Console.WriteLine();
        }

        // Функция для нахождения максимального элемента в массиве
        static int FindMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        // Функция для удвоения элементов массива до середины
        static void DoubleHalf(int[] array)
        {
            int mid = array.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                array[i] *= 2;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                // Ввод размерностей массивов
                Console.Write("Введите размер первого массива: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Введите размер второго массива: ");
                int m = int.Parse(Console.ReadLine());

                // Проверка размерностей
                if (n <= 0 || m <= 0)
                {
                    throw new ArgumentException("Размерности массивов должны быть положительными.");
                }

                // Создание массивов
                int[] arrayA = new int[n];
                int[] arrayB = new int[m];

                // Заполнение массивов
                FillArray(arrayA);
                FillArray(arrayB);

                // Вывод массивов
                Console.WriteLine("Первый массив:");
                PrintArray(arrayA);
                Console.WriteLine("Второй массив:");
                PrintArray(arrayB);

                // Поиск максимальных элементов
                int maxA = FindMax(arrayA);
                int maxB = FindMax(arrayB);

                Console.WriteLine($"Максимальный элемент первого массива: {maxA}");
                Console.WriteLine($"Максимальный элемент второго массива: {maxB}");

                // Сравнение максимумов и удвоение элементов
                if (maxA > maxB)
                {
                    Console.WriteLine("Удваиваем элементы первого массива до середины.");
                    DoubleHalf(arrayA);
                }
                else if (maxB > maxA)
                {
                    Console.WriteLine("Удваиваем элементы второго массива до середины.");
                    DoubleHalf(arrayB);
                }
                else
                {
                    Console.WriteLine("Максимальные элементы равны. Изменений нет.");
                }

                // Вывод измененных массивов
                Console.WriteLine("Измененный первый массив:");
                PrintArray(arrayA);
                Console.WriteLine("Измененный второй массив:");
                PrintArray(arrayB);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}