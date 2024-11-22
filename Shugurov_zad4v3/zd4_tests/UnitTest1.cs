using NUnit.Framework;
using Shugurov_zad4v3;
namespace zd4_tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // �����, ������� ����������� ����� ������ ������
        }

        // ���������, ��������� �� �������� ����� R.m � �������������� ������������ � �������������� ����������
        [Test]
        public void Test_CalculateIntersectionWithPositiveCoordinatesAndNegativeValues()
        {
            int actual = SA.m(1, 1, 2, 2, -1, 0, 0, -1); // ������� ������: ���������� � ��������
            int expected = 2; // ��������� �������� �����������

            Assert.AreEqual(expected, actual); // �������� ����������
        }

        // ���������, ��������� �� �������� ����� R.m � ������������ � �������������� ����������
        [Test]
        public void Test_CalculateIntersectionWithPositiveCoordinates()
        {
            int actual = SA.m(1, 1, 4, 4, 0, 3, 2, 5); // ������� ������: ���������� � ��������
            int expected = 12; // ��������� �������� �����������

            Assert.AreEqual(expected, actual); // �������� ����������
        }

        // ���������, ��������� �� �������� ����� R.m � �������� ������������ � ����������
        [Test]
        public void Test_CalculateIntersectionWithZeroValues()
        {
            int actual = SA.m(0, 0, 0, 0, 0, 0, 0, 0); // ������� ������: ��� �������� ����� ����
            int expected = 0; // ��������� �������� �����������

            Assert.AreEqual(expected, actual); // �������� ����������
        }

        // ���������, ��������� �� �������� ����� R.m � ����������� �������������� ������������
        [Test]
        public void Test_CalculateIntersectionWithEqualCoordinates()
        {
            int actual = SA .m(1, 1, 1, 1, 1, 1, 1, 1); // ������� ������: ���������� ����������
            int expected = 0; // ��������� �������� �����������

            Assert.AreEqual(expected, actual); // �������� ����������
        }

        // ���������, ��������� �� �������� ����� R.m � �������������� ������������
        [Test]
        public void Test_CalculateIntersectionWithNegativeCoordinates()
        {
            int actual  =SA.m(-1, -1, -1, -1, -1, -1, -1, -1); // ������� ������: ��� �������� �������������
            int expected = 0; // ��������� �������� �����������

            Assert.AreEqual(expected, actual); // �������� ����������
        }

        // ���������, ��������� �� �������� ����� R.m � �������������� �������������� ������������
        [Test]
        public void Test_CalculateIntersectionWithRepeatedNegativeCoordinates()
        {
            int actual = SA.m(-1, -1, -1, -1, -1, -1, -1, -1); // ������� ������: ��� �������� �������������
            int expected = 0; // ��������� �������� �����������

            Assert.AreEqual(expected, actual); // �������� ����������
        }

        // ���������, ��������� �� �������� ����� R.m � ���������������� �������������� ������������
        [Test]
        public void Test_CalculateIntersectionWithOverlappingPositiveCoordinates()
        {
            int actual = SA.m(1, 1, 4, 4, 1, 1, 4, 4); // ������� ������: ��������������� ����������
            int expected = 9; // ��������� �������� �����������

            Assert.AreEqual(expected, actual); // �������� ����������
        }

        // ���������, ��������� �� �������� ����� R.m � �������� �������������� ������������
        [Test]
        public void Test_CalculateIntersectionWithLargePositiveCoordinates()
        {
            int actual = SA.m(100, 100, 100, 100, 100, 100, 100, 100); // ������� ������: ������� ��������
            int expected = 0; // ��������� �������� �����������

            Assert.AreEqual(expected, actual); // �������� ����������
        }

        // ���������, ��������� �� �������� ����� R.m � �������� �������������� ������������
        [Test]
        public void Test_CalculateIntersectionWithLargeNegativeCoordinates()
        {
            int actual = SA.m(-100, -100, -100, -100, -100, -100, -100, -100); // ������� ������: ������� ������������� ��������
            int expected = 0; // ��������� �������� �����������

            Assert.AreEqual(expected, actual); // �������� ����������
        }

        // ���������, ��������� �� �������� ����� R.m � �������������� �������� �������������� ������������
        [Test]
        public void Test_CalculateIntersectionWithRepeatedLargeNegativeCoordinates()
        {
            int actual = SA.m(-100, -100, -100, -100, -100, -100, -100, -100); // ������� ������: ������������� ������� ������������� ��������
            int expected = 0; // ��������� �������� �����������

            Assert.AreEqual(expected, actual); // �������� ����������
        }
        [Test]
        public void Test_CalculateResultWithZeroAndNegativeValues()
        {
            // ���������, ��������� �� �������� ����� R.m � �������� � �������������� ����������
            int actual = SA.m(0, -100, 0, -100, 0, -100, 0, -100);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithPositiveValuesAndNoOverlap()
        {
            // ���������, ��������� �� �������� ����� R.m � �������������� ����������, ������� �� ������������
            int actual = SA.m(1, 8, 8, 8, 9, 9, 9, 9);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithNegativeStartAndPositiveValues()
        {
            // ���������, ��������� �� �������� ����� R.m � ������������� ������� � �������������� ����������
            int actual = SA.m(-300, 2, 3, 4, 5, 6, 7, 8);
            int expected = 610;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithNegativeStartAndMixedValues()
        {
            // ���������, ��������� �� �������� ����� R.m � ������������� ������� � ���������� ����������
            int actual = SA.m(-300, 2, 3, 4, 5, 6, 7, -500);
            int expected = 1618;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithNegativeStartAndNegativeValues()
        {
            // ���������, ��������� �� �������� ����� R.m � ������������� ������� � ���������� �������������� ����������
            int actual = SA.m(-300, 2, 3, -700, 5, 6, 7, -500);
            int expected = 213718;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithNegativeStartAndMoreComplexValues()
        {
            // ���������, ��������� �� �������� ����� R.m � ������������� ������� � ����� �������� ����������
            int actual = SA.m(-300, 82, 3, -700, 59, 86, 7, -500);
            int expected = 267418;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithMaxValueAndNegativeValues()
        {
            // ���������, ��������� �� �������� ����� R.m � ������������ ��������� � �������������� ����������
            int actual = SA.m(int.MaxValue, 82, 3, -700, 59, 86, 7, -500);
            int expected = -2920;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithMaxValueAndZeroes()
        {
            // ���������, ��������� �� �������� ����� R.m � ������������ ��������� � ������
            int actual = SA.m(int.MaxValue, 0, 0, 0, 0, 0, 7, int.MinValue);
            int expected = -2147483648;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithMaxValueAndMixedZeroes()
        {
            // ���������, ��������� �� �������� ����� R.m � ������������ ��������� � ���������� ������
            int actual = SA.m(int.MaxValue, 0, int.MaxValue, 0, 0, 0, 7, int.MinValue);
            int expected = -2147483648;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_CalculateResultWithMaxAndMinValues()
        {
            // ���������, ��������� �� �������� ����� R.m � ������������ � ����������� ����������
            int actual = SA.m(int.MaxValue, int.MinValue, int.MaxValue, 0, 0, 0, 7, int.MinValue);
            int expected = -2147483648;

            Assert.AreEqual(expected, actual);
        }
    }
}