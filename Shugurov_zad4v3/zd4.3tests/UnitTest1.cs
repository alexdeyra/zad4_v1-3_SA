using NUnit.Framework;

using Shugurov_zad4v3;
namespace zd4._3tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           int actual= R.m(1, 1, 2, 2, -1, 0, 0, -1);
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test2()
        {
            int actual = R.m(1,1, 4, 4, 0, 3, 2, 5);
            int expected = 12;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test3()
        {
            int actual = R.m(0, 0, 0, 0, 0, 0, 0, 0);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test4()
        {
            int actual = R.m(1, 1, 1, 1, 1, 1, 1, 1);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test5()
        {
            int actual = R.m(-1, -1, -1, -1, -1, -1, -1, -1);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test6()
        {
            int actual = R.m(-1, -1, -1, -1, -1, -1, -1, -1);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test7()
        {
            int actual = R.m(1, 1, 4, 4, 1, 1, 4, 4);
            int expected = 9;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test8()
        {
            int actual = R.m(100, 100, 100, 100, 100, 100, 100, 100);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test9()
        {
            int actual = R.m(-100, -100, -100, -100, -100, -100, -100, -100);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test10()
        {
            int actual = R.m(-100, -100, -100, -100, -100, -100, -100, -100);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test11()
        {
            int actual = R.m(0, -100, 0, -100, 0, -100, 0, -100);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test12()
        {
            int actual = R.m(1,8,8,8,9,9,9,9);
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test13()
        {
            int actual = R.m(-300,2,3,4,5,6,7,8);
            int expected = 610;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test14()
        {
            int actual = R.m(-300, 2, 3, 4, 5, 6, 7, -500);
            int expected = 1618;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test15()
        {
            int actual = R.m(-300, 2, 3, -700, 5, 6, 7, -500);
            int expected = 213718;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test16()
        {
            int actual = R.m(-300, 82, 3, -700, 59, 86, 7, -500);
            int expected = 267418;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test17()
        {
            int actual = R.m(int.MaxValue, 82, 3, -700, 59, 86, 7, -500);
            int expected = -2920;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test18()
        {
            int actual = R.m(int.MaxValue,0, 0, 0, 0, 0, 7, int.MinValue);
            int expected = -2147483648;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test19()
        {
            int actual = R.m(int.MaxValue, 0, int.MaxValue, 0, 0, 0, 7, int.MinValue);
            int expected = -2147483648;

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test20()
        {
            int actual = R.m(int.MaxValue, int.MinValue, int.MaxValue, 0, 0, 0, 7, int.MinValue);
            int expected = -2147483648;

            Assert.AreEqual(expected, actual);
        }
    }
}