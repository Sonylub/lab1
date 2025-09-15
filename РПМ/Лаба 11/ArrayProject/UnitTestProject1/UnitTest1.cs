using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Исходные данные для теста.
            Double[] myAr = { 2.4, -6.1, -3.9, 5.6 };

            // Ожидаемое значение (2.4 + 5.6)/2 = 4.0
            Double expected = 4.0;

            // Вызов тестируемой функции.      
            Double actual = MyArray.AveragePositiv(myAr);
            Assert.AreEqual(expected, actual, 0.001, "Ожидаемое среднее арифметическое положительных элементов массива не было получено!");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "В массиве нет положительных!")]
        public void TestMethod2()
        {
            // Исходные данные для теста.
            Double[] myAr = { -1.2, -9.6, -11.5, -7.8 };

            // Вызов тестируемой функции.
            Double actual = MyArray.AveragePositiv(myAr);
        }
    }
}