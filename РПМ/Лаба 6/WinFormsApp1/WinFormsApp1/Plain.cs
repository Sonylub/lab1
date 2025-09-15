using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;

using WinFormsApp1;

namespace TransportDemo
{
    // Производный класс Plain (самолёт)
    class Plain : Transport
    {
        // Дополнительное поле: высота полёта
        private double FlightHeight;

        // Конструктор
        public Plain(string name, int capacity, double speed, int year, double flightHeight)
            : base(name, capacity, speed, year)
        {
            FlightHeight = flightHeight;
        }

        // Переопределённый метод ShowInfo
        public override void ShowInfo()
        {
            Console.WriteLine($"Самолёт: {Name}, Мест: {Capacity}, Скорость: {Speed} км/ч, Год выпуска: {Year}, Высота полёта: {FlightHeight} м");
        }
    }
}
