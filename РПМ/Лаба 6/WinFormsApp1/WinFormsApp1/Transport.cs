using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    // Абстрактный базовый класс
    public abstract class Transport
    {
        // Поля
        protected string name;      // Название транспорта
        protected int capacity;     // Количество мест
        protected int speed;        // Скорость
        protected int year;         // Год выпуска

        // Конструктор
        public Transport(string name, int capacity, int speed, int year)
        {
            this.name = name;
            this.capacity = capacity;
            this.speed = speed;
            this.year = year;
        }

        // Абстрактный метод для вывода информации
        public abstract void Show();

        // Свойство для получения вместимости
        public int Capacity
        {
            get { return capacity; }
        }
    }
}