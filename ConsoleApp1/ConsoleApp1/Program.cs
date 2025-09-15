using System;

namespace BankDeposit
{
    class Program
    {
 
        static double CalculateDeposit(double initialAmount, double annualRate, int months)
        {
            // Проверка входных данных
            if (initialAmount <= 0)
                throw new ArgumentException("Первоначальная сумма вклада должна быть положительной.");
            if (annualRate < 0)
                throw new ArgumentException("Годовая процентная ставка не может быть отрицательной.");
            if (months <= 0)
                throw new ArgumentException("Количество месяцев должно быть больше нуля.");

            // Вычисление месячной процентной ставки
            double monthlyRate = annualRate / (12 * 100);

            // Вычисление итоговой суммы вклада
            double finalAmount = initialAmount * Math.Pow(1 + monthlyRate, months);

            return finalAmount;
        }

        static void Main(string[] args)
        {
            try
            {
                // Ввод данных
                Console.Write("Введите первоначальную сумму вклада: ");
                double initialAmount = double.Parse(Console.ReadLine());

                Console.Write("Введите годовую процентную ставку (%): ");
                double annualRate = double.Parse(Console.ReadLine());

                Console.Write("Введите количество месяцев: ");
                int months = int.Parse(Console.ReadLine());

                // Вызов функции
                double finalAmount = CalculateDeposit(initialAmount, annualRate, months);

                // Вывод результата
                Console.WriteLine($"Итоговая сумма вклада через {months} месяцев: {finalAmount:F2}");
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}