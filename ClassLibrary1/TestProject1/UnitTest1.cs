using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIncrementOperator()
        {
            // Arrange
            Arr actual = new Arr(new int[] { 10, -5, 4 });

            // Act
            actual++;

            // Assert
            Arr expected = new Arr(new int[] { 11, -4, 5 });
            Assert.AreEqual(expected.ToString(), actual.ToString(), "–езультат инкремента не соответствует ожидаемому.");
        }

        [TestMethod]
        public void TestDecrementOperator()
        {
            // Arrange
            Arr actual = new Arr(new int[] { 10, -5, 4 });

            // Act
            actual--;

            // Assert
            Arr expected = new Arr(new int[] { 9, -6, 3 });
            Assert.AreEqual(expected.ToString(), actual.ToString(), "–езультат декремента не соответствует ожидаемому.");
        }

        [TestMethod]
        public void TestCountSignChanges_EmptyArray()
        {
            // Arrange
            Arr arr = new Arr();

            // Act
            int result = arr.CountSignChanges();

            // Assert
            Assert.AreEqual(0, result, "ѕустой массив должен возвращать 0 смен знаков.");
        }

        [TestMethod]
        public void TestCountSignChanges_AllZeros()
        {
            // Arrange
            Arr arr = new Arr(new int[] { 0, 0, 0 });

            // Act
            int result = arr.CountSignChanges();

            // Assert
            Assert.AreEqual(0, result, "ћассив только с нул€ми должен возвращать 0 смен знаков.");
        }

        [TestMethod]
        public void TestCountSignChanges_MaxSignChanges()
        {
            // Arrange
            Arr arr = new Arr(new int[] { 1, -2, 3 });

            // Act
            int result = arr.CountSignChanges();

            // Assert
            Assert.AreEqual(2, result, "ћассив с чередующимис€ знаками должен возвращать 2 смены знаков.");
        }

        [TestMethod]
        [ExpectedException(typeof(MyException))]
        public void TestIndexer_OutOfBounds()
        {
            // Arrange
            Arr arr = new Arr(2);

            // Act
            int value = arr[3]; // ƒолжно выбросить MyException
        }
    }
}