using System;
using System.IO;
using System.Reflection.Emit;

namespace ClassLibrary1
{
    public class MyException : Exception
    {
        public const string ArgumentError = "Массив не обработан!";
        public const string SizeError = "Выход за границы массива!";

        public int Value { get; }

        public MyException(string message)
            : base(message)
        {
        }

        public MyException(string message, int value)
            : base(message)
        {
            Value = value;
        }
    }

    public class Arr
    {
        private int[] a;
        private int size;
        private static Random rnd = new Random();

        public Arr()
        {
            size = 0;
            a = null;
        }

        public Arr(int n)
        {
            a = new int[n];
            size = n;
        }

        public Arr(params int[] x)
        {
            if (x == null) throw new MyException(MyException.ArgumentError);
            size = x.Length;
            a = new int[size];
            for (int i = 0; i < size; i++)
                a[i] = x[i];
        }

        public Arr(Arr B)
        {
            if (B.a == null)
                throw new MyException(MyException.ArgumentError);
            size = B.size;
            a = new int[size];
            for (int i = 0; i < size; i++)
                a[i] = B.a[i];
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj as Arr == null)
                return false;
            if (size != ((Arr)obj).size)
                return false;
            for (int i = 0; i < size; i++)
                if (a[i] != ((Arr)obj).a[i])
                    return false;
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int Size
        {
            get { return size; }
        }

        public void RndInput()
        {
            for (int i = 0; i < size; i++)
                a[i] = rnd.Next(-100, 101);
        }

        public void RndInput(int n1)
        {
            for (int i = 0; i < size; i++)
                a[i] = rnd.Next(n1 + 1);
        }

        public static Arr operator --(Arr arr)
        {
            Arr temp = new Arr(arr.size);
            for (int i = 0; i < temp.size; i++)
                temp.a[i] = arr.a[i] - 1;
            return temp;
        }

        public static Arr operator ++(Arr arr)
        {
            Arr temp = new Arr(arr.size);
            for (int i = 0; i < temp.size; i++)
                temp.a[i] = arr.a[i] + 1;
            return temp;
        }

        public static Arr operator +(Arr X, Arr Y)
        {
            int newSize = Math.Max(X.size, Y.size);
            Arr temp = new Arr(newSize);
            for (int i = 0; i < newSize; i++)
            {
                int xValue = (i < X.size) ? X[i] : 0;
                int yValue = (i < Y.size) ? Y[i] : 0;
                temp[i] = xValue + yValue;
            }
            return temp;
        }

        public static Arr operator -(Arr X, Arr Y)
        {
            int newSize = Math.Max(X.size, Y.size);
            Arr temp = new Arr(newSize);
            for (int i = 0; i < newSize; i++)
            {
                int xValue = (i < X.size) ? X[i] : 0;
                int yValue = (i < Y.size) ? Y[i] : 0;
                temp[i] = xValue - yValue;
            }
            return temp;
        }

        public static Arr operator +(Arr arr, int value)
        {
            Arr temp = new Arr(arr.size);
            for (int i = 0; i < arr.size; i++)
                temp[i] = arr[i] + value;
            return temp;
        }

        public static Arr operator -(Arr arr, int value)
        {
            Arr temp = new Arr(arr.size);
            for (int i = 0; i < arr.size; i++)
                temp[i] = arr[i] - value;
            return temp;
        }

        public int this[int i]
        {
            get
            {
                if (i >= 0 && i < size)
                    return a[i];
                throw new MyException(MyException.SizeError, i);
            }
            set
            {
                if (i >= 0 && i < size)
                    a[i] = value;
                else
                    throw new MyException(MyException.SizeError, i);
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < size; i++)
                s += a[i].ToString() + " ";
            return s.Trim();
        }

        public static Arr Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new MyException(MyException.ArgumentError);

            string[] elements = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] parsedArray = new int[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                if (!int.TryParse(elements[i], out parsedArray[i]))
                    throw new MyException(MyException.ArgumentError);
            }

            return new Arr(parsedArray);
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
            Console.WriteLine();
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new MyException("Файл не найден!");

            string[] lines = File.ReadAllLines(filePath);
            string[] elements = lines[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            a = new int[elements.Length];
            size = elements.Length;

            for (int i = 0; i < size; i++)
            {
                if (!int.TryParse(elements[i], out a[i]))
                    throw new MyException("Ошибка при чтении данных из файла!");
            }
        }

        public int CountSignChanges()
        {
            if (size < 2)
                return 0;

            int count = 0;
            for (int i = 1; i < size; i++)
            {
                if ((a[i - 1] > 0 && a[i] < 0) || (a[i - 1] < 0 && a[i] > 0))
                    count++;
            }
            return count;
        }
    }
}