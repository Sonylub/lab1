using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProject
{
    public class MyArray
    {
        /// <summary>
        /// Метод для подсчёта среднего арифметического положительных эл. массива.
        /// </summary>
        /// <param name="mas">double[] mas исходный массив.</param>
        /// <returns>Среднее арифметическое положительных эл. массива.</returns>
        /// <exception cref="Exception">Если положительных элементов нет</exception>
        public static double AveragePositiv(double[] mas)
        {
            double s = 0;
            int k = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 0)
                {
                    s += mas[i];
                    k++;
                }
            }
            if (k == 0)
                throw new Exception("В массиве нет положительных!");
            return s / k;
        }
    }
}