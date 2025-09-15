using System;

class Program
{
    static void Main()
    {
        // Ввод размеров массива
        Console.Write("Введите количество строк массива: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов массива: ");
        int cols = int.Parse(Console.ReadLine());

        // Инициализация двумерного массива
        int[,] array = new int[rows, cols];
        Random rnd = new Random();

        // Заполнение массива случайными числами и вывод на экран
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rnd.Next(-100, 100);  // Диапазон [-100, 100]
                Console.Write("{0,5}", array[i, j]);
            }
            Console.WriteLine();
        }

        // Поиск первого и последнего положительных элементов
        int firstPosRow = -1, firstPosCol = -1;
        int lastPosRow = -1, lastPosCol = -1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array[i, j] > 0)
                {
                    if (firstPosRow == -1)
                    {
                        firstPosRow = i;
                        firstPosCol = j;
                    }
                    lastPosRow = i;
                    lastPosCol = j;
                }
            }
        }

        // Вывод массива с раскраской
        Console.WriteLine("Массив с отмеченными положительными элементами:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == firstPosRow && j == firstPosCol)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0,5}", array[i, j]);
                    Console.ResetColor();
                }
                else if (i == lastPosRow && j == lastPosCol)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("{0,5}", array[i, j]);
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("{0,5}", array[i, j]);
                }
            }
            Console.WriteLine();
        }
    }
}
