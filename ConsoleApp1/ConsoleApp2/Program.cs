using System;

namespace ArrayProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод размерностей массива
            Console.Write("Введите количество строк: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов: ");
            int n = int.Parse(Console.ReadLine());

            // Создание и заполнение массива случайными числами
            int[,] matrix = new int[m, n];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(-1000, 1000);
                    Console.Write("{0,8}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            // Поиск первого и последнего положительных элементов
            Tuple<int, int> firstPos = null;
            Tuple<int, int> lastPos = null;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        if (firstPos == null)
                        {
                            firstPos = Tuple.Create(i, j);
                        }
                        lastPos = Tuple.Create(i, j);
                    }
                }
            }

            // Вывод массива с раскрашенными элементами
            Console.WriteLine("Массив с раскрашенными элементами:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (firstPos != null && i == firstPos.Item1 && j == firstPos.Item2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0,8}", matrix[i, j]);
                        Console.ResetColor();
                    }
                    else if (lastPos != null && i == lastPos.Item1 && j == lastPos.Item2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("{0,8}", matrix[i, j]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("{0,8}", matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}