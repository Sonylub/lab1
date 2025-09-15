using System;
using System.Xml.Linq;
using WinFormsApp1;

namespace TransportDemo
{
    // Перечисляемый тип для портов приписки
    enum Ports { Санкт-Петербург, Владивосток, Мурманск, Новороссийск }

    // Производный класс Ship (корабль)
    class Ship : Transport
    {
        // Дополнительное поле: порт приписки
        private Ports Port;

        // Конструктор
        public Ship(string name, int capacity, double speed, int year, Ports port)
            : base(name, capacity, speed, year)
        {
            Port = port;
        }

        // Переопределённый метод ShowInfo
        public override void ShowInfo()
        {
            Console.WriteLine($"Корабль: {Name}, Мест: {Capacity}, Скорость: {Speed} км/ч, Год выпуска: {Year}, Порт приписки: {Port}");
        }
    }
}
