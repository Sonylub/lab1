using System;

class Program
{
    // Функция для вычисления суммы вклада CalculateDeposit
    static double CD(double Deposit, double Rate, int months)
    {
        if (Deposit <= 0 || Rate < 0 || months <= 0)
        {
            throw new ArgumentException("Некорректные исходные данные");
        }

        // Месячная процентная ставка
        double monthlyRate = Rate / 12 / 100;
        // Итоговая сумма с капитализацией
        double finalAmount = Deposit * Math.Pow(1 + monthlyRate, months);
        return finalAmount;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите начальную сумму вклада:");
            double Deposit = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите годовую процентную ставку:");
            double Rate = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев:");
            int months = Int32.Parse(Console.ReadLine());

            // Вызов функции
            double finalAmount = CD(Deposit, Rate, months);

            // Вывод результата
            Console.WriteLine("Итоговая сумма вклада с капитализацией процентов: {0:F2}", finalAmount);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
