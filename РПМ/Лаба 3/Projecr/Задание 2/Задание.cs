using System;

class Program
{
    // Функция для ввода массива
    static int[] InputArray(int length)
    {
        int[] array = new int[length];
        Console.WriteLine($"Введите {length} элементов массива:");
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    // Функция для вывода массива
    static void OutputArray(int[] array)
    {
        Console.WriteLine("Элементы массива:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Функция для нахождения максимального элемента в массиве
    static int FindMax(int[] array)
    {
        int max = array[0];
        foreach (var item in array)
        {
            if (item > max)
                max = item;
        }
        return max;
    }

    // Функция для удвоения элементов до середины массива
    static void DoubleElementsToMiddle(int[] array)
    {
        int middle = array.Length / 2;
        for (int i = 0; i < middle; i++)
        {
            array[i] *= 2;
        }
    }

    static void Main(string[] args)
    {
        // Ввод размеров массивов
        Console.WriteLine("Введите размер первого массива:");
        int length1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите размер второго массива:");
        int length2 = int.Parse(Console.ReadLine());

        // Ввод массивов
        int[] array1 = InputArray(length1);
        int[] array2 = InputArray(length2);

        // Вывод массивов
        Console.WriteLine("Первый массив:");
        OutputArray(array1);
        Console.WriteLine("Второй массив:");
        OutputArray(array2);

        // Нахождение максимальных элементов
        int max1 = FindMax(array1);
        int max2 = FindMax(array2);

        // Определение массива для удвоения элементов
        if (max1 > max2)
        {
            Console.WriteLine("Удваиваем элементы до середины в первом массиве:");
            DoubleElementsToMiddle(array1);
            OutputArray(array1);
        }
        else
        {
            Console.WriteLine("Удваиваем элементы до середины во втором массиве:");
            DoubleElementsToMiddle(array2);
            OutputArray(array2);
        }
    }
}
