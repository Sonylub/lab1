namespace Lab10
{
    public class Student
    {
        // Скрытые поля
        private string name;
        private double weight;
        private double height;

        // Конструктор
        public Student(string name = "", double weight = 0.0, double height = 0.0)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
        }

        // Свойство для чтения скрытого поля Weight (для расчета среднего веса)
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        // Свойства для остальных полей
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        // Перегрузка метода ToString
        public override string ToString()
        {
            return $"ФИО: {name}; Вес: {weight:F2}; Рост: {height:F2}";
        }
    }
}