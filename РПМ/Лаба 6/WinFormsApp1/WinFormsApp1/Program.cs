using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace TransportNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём список транспортных средств
            List<Transport> transports = new List<Transport>();

            // Добавляем объекты
            transports.Add(new Plain("Боинг 747", 400, 900, 2015, 10000));
            transports.Add(new Plain("Airbus A320", 180, 850, 2020, 12000));
            transports.Add(new Ship("Аврора", 300, 25, 2000, Port.Санкт - Петербург));
            transports.Add(new Ship("Адмирал Кузнецов", 1500, 30, 2010, Port.Мурманск));

            // Запрашиваем порог вместимости
            Console.WriteLine("Введите минимальное количество мест:");
            int minCapacity = int.Parse(Console.ReadLine());

            Console.WriteLine("\nТранспортные средства с вместимостью больше заданной:\n");

            // Выводим транспорты с вместимостью больше заданного значения
            foreach (Transport t in transports)
            {
                if (t.Capacity > minCapacity)
                {
                    t.Show();
                }
            }

            Console.ReadKey();
        }
    }
}
