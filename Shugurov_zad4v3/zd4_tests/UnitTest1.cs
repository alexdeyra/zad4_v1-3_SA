using NUnit.Framework;
using Shugurov_zad4v3;
namespace zd4_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Метод, который выполняется перед каждым тестом
        }

        // Проверяет, правильно ли работает метод R.m с положительными координатами и отрицательными значениями
        [Test]
        public void Test_CalculateIntersectionWithPositiveCoordinatesAndNegativeValues()
        {
            int actual = SA.m(1, 1, 2, 2, -1, 0, 0, -1); // Входные данные: координаты и значения
            int expected = 2; // Ожидаемое значение пересечения

            Assert.AreEqual(expected, actual); // Проверка результата
        }

        // Проверяет, правильно ли работает метод R.m с координатами и положительными значениями
        [Test]
        public void Test_CalculateIntersectionWithPositiveCoordinates()
        {
            int actual = SA.m(1, 1, 4, 4, 0, 3, 2, 5); // Входные данные: координаты и значения
            int expected = 12; // Ожидаемое значение пересечения

            Assert.AreEqual(expected, actual); // Проверка результата
        }

        // Проверяет, правильно ли работает метод R.m с нулевыми координатами и значениями
        [Test]
        public void Test_CalculateIntersectionWithZeroValues()
        {
            int actual = SA.m(0, 0, 0, 0, 0, 0, 0, 0); // Входные данные: все значения равны нулю
            int expected = 0; // Ожидаемое значение пересечения

            Assert.AreEqual(expected, actual); // Проверка результата
        }

        // Проверяет, правильно ли работает метод R.m с одинаковыми положительными координатами
        [Test]
        public void Test_CalculateIntersectionWithEqualCoordinates()
        {
            int actual = SA .m(1, 1, 1, 1, 1, 1, 1, 1); // Входные данные: одинаковые координаты
            int expected = 0; // Ожидаемое значение пересечения

            Assert.AreEqual(expected, actual); // Проверка результата
        }

        // Проверяет, правильно ли работает метод R.m с отрицательными координатами
        [Test]
        public void Test_CalculateIntersectionWithNegativeCoordinates()
        {
            int actual  =SA.m(-1, -1, -1, -1, -1, -1, -1, -1); // Входные данные: все значения отрицательные
            int expected = 0; // Ожидаемое значение пересечения

            Assert.AreEqual(expected, actual); // Проверка результата
        }

        // Проверяет, правильно ли работает метод R.m с повторяющимися отрицательными координатами
        [Test]
        public void Test_CalculateIntersectionWithRepeatedNegativeCoordinates()
        {
            int actual = SA.m(-1, -1, -1, -1, -1, -1, -1, -1); // Входные данные: все значения отрицательные
            int expected = 0; // Ожидаемое значение пересечения

            Assert.AreEqual(expected, actual); // Проверка результата
        }

        // Проверяет, правильно ли работает метод R.m с перекрывающимися положительными координатами
        [Test]
        public void Test_CalculateIntersectionWithOverlappingPositiveCoordinates()
        {
            int actual = SA.m(1, 1, 4, 4, 1, 1, 4, 4); // Входные данные: перекрывающиеся координаты
            int expected = 9; // Ожидаемое значение пересечения

            Assert.AreEqual(expected, actual); // Проверка результата
        }

        // Проверяет, правильно ли работает метод R.m с большими положительными координатами
        [Test]
        public void Test_CalculateIntersectionWithLargePositiveCoordinates()
        {
            int actual = SA.m(100, 100, 100, 100, 100, 100, 100, 100); // Входные данные: большие значения
            int expected = 0; // Ожидаемое значение пересечения

            Assert.AreEqual(expected, actual); // Проверка результата
        }

        // Проверяет, правильно ли работает метод R.m с большими отрицательными координатами
        [Test]
        public void Test_CalculateIntersectionWithLargeNegativeCoordinates()
        {
            int actual = SA.m(-100, -100, -100, -100, -100, -100, -100, -100); // Входные данные: большие отрицательные значения
            int expected = 0; // Ожидаемое значение пересечения

            Assert.AreEqual(expected, actual); // Проверка результата
        }

        // Проверяет, правильно ли работает метод R.m с повторяющимися большими отрицательными координатами
        [Test]
        public void Test_CalculateIntersectionWithRepeatedLargeNegativeCoordinates()
        {
            int actual = SA.m(-100, -100, -100, -100, -100, -100, -100, -100); // Входные данные: повторяющиеся большие отрицательные значения
            int expected = 0; // Ожидаемое значение пересечения

            Assert.AreEqual(expected, actual); // Проверка результата
        }
        [Test]
        public void Test_CalculateResultWithZeroAndNegativeValues()
        {
            // Проверяет, правильно ли работает метод R.m с нулевыми и отрицательными значениями
            int actual = SA.m(0, -100, 0, -100, 0, -100, 0, -100);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithPositiveValuesAndNoOverlap()
        {
            // Проверяет, правильно ли работает метод R.m с положительными значениями, которые не пересекаются
            int actual = SA.m(1, 8, 8, 8, 9, 9, 9, 9);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithNegativeStartAndPositiveValues()
        {
            // Проверяет, правильно ли работает метод R.m с отрицательным началом и положительными значениями
            int actual = SA.m(-300, 2, 3, 4, 5, 6, 7, 8);
            int expected = 610;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithNegativeStartAndMixedValues()
        {
            // Проверяет, правильно ли работает метод R.m с отрицательным началом и смешанными значениями
            int actual = SA.m(-300, 2, 3, 4, 5, 6, 7, -500);
            int expected = 1618;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithNegativeStartAndNegativeValues()
        {
            // Проверяет, правильно ли работает метод R.m с отрицательным началом и некоторыми отрицательными значениями
            int actual = SA.m(-300, 2, 3, -700, 5, 6, 7, -500);
            int expected = 213718;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithNegativeStartAndMoreComplexValues()
        {
            // Проверяет, правильно ли работает метод R.m с отрицательным началом и более сложными значениями
            int actual = SA.m(-300, 82, 3, -700, 59, 86, 7, -500);
            int expected = 267418;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithMaxValueAndNegativeValues()
        {
            // Проверяет, правильно ли работает метод R.m с максимальным значением и отрицательными значениями
            int actual = SA.m(int.MaxValue, 82, 3, -700, 59, 86, 7, -500);
            int expected = -2920;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithMaxValueAndZeroes()
        {
            // Проверяет, правильно ли работает метод R.m с максимальным значением и нулями
            int actual = SA.m(int.MaxValue, 0, 0, 0, 0, 0, 7, int.MinValue);
            int expected = -2147483648;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithMaxValueAndMixedZeroes()
        {
            // Проверяет, правильно ли работает метод R.m с максимальным значением и смешанными нулями
            int actual = SA.m(int.MaxValue, 0, int.MaxValue, 0, 0, 0, 7, int.MinValue);
            int expected = -2147483648;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithMaxAndMinValues()
        {
            // Проверяет, правильно ли работает метод R.m с максимальным и минимальным значениями
            int actual = SA.m(int.MaxValue, int.MinValue, int.MaxValue, 0, 0, 0, 7, int.MinValue);
            int expected = -2147483648;

            Assert.AreEqual(expected, actual);
        }
    }
}