using System;
using ClassLibrary1;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. Создание массива через конструктор с размером
                Console.WriteLine("1. Создание массива размером 5 и заполнение случайными числами:");
                Arr arr1 = new Arr(5);
                arr1.RndInput(); // Заполнение случайными числами от -100 до 100
                Console.WriteLine($"Массив: {arr1}");
                Console.WriteLine($"Количество смен знаков: {arr1.CountSignChanges()}");
                Console.WriteLine();

                // 2. Создание массива через конструктор с параметрами
                Console.WriteLine("2. Создание массива из заданных значений [3, 0, -2, 5, 0]:");
                Arr arr2 = new Arr(3, 0, -2, 5, 0);
                Console.WriteLine($"Массив: {arr2}");
                Console.WriteLine($"Количество смен знаков: {arr2.CountSignChanges()}");
                Console.WriteLine();

                // 3. Использование оператора инкремента
                Console.WriteLine("3. Применение оператора ++ к arr2:");
                Arr arr3 = arr2++;
                Console.WriteLine($"Исходный массив после ++: {arr2}");
                Console.WriteLine($"Новый массив: {arr3}");
                Console.WriteLine();

                // 4. Использование оператора декремента
                Console.WriteLine("4. Применение оператора -- к arr2:");
                Arr arr4 = arr2--;
                Console.WriteLine($"Исходный массив после --: {arr2}");
                Console.WriteLine($"Новый массив: {arr4}");
                Console.WriteLine();

                // 5. Сложение двух массивов
                Console.WriteLine("5. Сложение arr1 и arr2:");
                Arr arr5 = arr1 + arr2;
                Console.WriteLine($"Массив arr1: {arr1}");
                Console.WriteLine($"Массив arr2: {arr2}");
                Console.WriteLine($"Результат сложения: {arr5}");
                Console.WriteLine();

                // 6. Вычитание массивов
                Console.WriteLine("6. Вычитание arr2 из arr1:");
                Arr arr6 = arr1 - arr2;
                Console.WriteLine($"Массив arr1: {arr1}");
                Console.WriteLine($"Массив arr2: {arr2}");
                Console.WriteLine($"Результат вычитания: {arr6}");
                Console.WriteLine();

                // 7. Использование индексатора
                Console.WriteLine("7. Использование индексатора для arr2:");
                Console.WriteLine($"Элемент arr2[2]: {arr2[2]}");
                arr2[2] = 10;
                Console.WriteLine($"Массив после изменения arr2[2] = 10: {arr2}");
                Console.WriteLine();

                // 8. Парсинг строки в массив
                Console.WriteLine("8. Парсинг строки '1 -2 3' в массив:");
                Arr arr7 = Arr.Parse("1 -2 3");
                Console.WriteLine($"Спарсенный массив: {arr7}");
                Console.WriteLine($"Количество смен знаков: {arr7.CountSignChanges()}");
                Console.WriteLine();

                // 9. Обработка исключения при некорректном индексе
                Console.WriteLine("9. Попытка доступа к некорректному индексу:");
                try
                {
                    int value = arr2[10]; // Должно выбросить исключение
                }
                catch (MyException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message} Значение: {ex.Value}");
                }
            }
            catch (MyException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message} Значение: {ex.Value}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Общая ошибка: {ex.Message}");
            }
        }
    }
}