using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Shugurov_zad4v1;
using System.IO;

namespace Test_zad1
{
    [TestClass]
    public class CostCalculationTests
    {

        private const string InputFilePath = "input.txt";
        private const string OutputFilePath = "output.txt";

        private void WriteInputFile(string content)
        {
            // Записывает содержимое в файл входных данных
            File.WriteAllText(InputFilePath, content);
        }


        private string ReadOutputFile()
        {
            // Читает и возвращает содержимое выходного файла
            return File.ReadAllText(OutputFilePath);
        }

        // Проверяет, правильно ли программа вычисляет стоимость с высокой стоимостью за минуту
        /*1*/ [TestMethod]
        public void Test_CalculateCostWithHighPerMinuteCost()
        {
            WriteInputFile("10 10 10 10"); // Записываем входные данные с высокой стоимостью за минуту
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("100", ReadOutputFile()); // Ожидаем, что стоимость будет 100 (10 + 9*10)
        }

        // Проверяет, правильно ли программа обрабатывает случай, когда все минуты бесплатны
       /*1*/ [TestMethod]
        public void Test_CalculateCostWithAllMinutesFree()
        {
            WriteInputFile("10 0 0 10"); // Записываем входные данные, где все минуты бесплатны
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("0", ReadOutputFile()); // Ожидаем, что стоимость будет 0 (все минуты бесплатные)
        }

        // Проверяет обработку отрицательного количества минут
        /*1*/[TestMethod]
        public void Test_HandleNegativeMinutesInput()
        {
            WriteInputFile("-1 10 10 1"); // Записываем входные данные с отрицательными минутами
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile()); // Ожидаем сообщение об ошибке
        }


        // Проверяет случай, когда нет платных минут
        [TestMethod]
        public void Test_CalculateCostWithNoPaidMinutes()
        {
            WriteInputFile("10 10 0 5"); // Записываем входные данные, где нет платных минут
            Program.Main();
            Assert.AreEqual("10", ReadOutputFile()); // Ожидаем, что стоимость будет 10
        }

        // Проверяет случай, когда все затраты будут равными
        [TestMethod]
        public void Test_CorrectCostWithMaxMinutesAndZeroCost()
        {
            WriteInputFile("100 0 0 200");
            Program.Main();
            Assert.AreEqual("0", ReadOutputFile());
        }

        // Проверяет, правильно ли программа обрабатывает случай, когда K превышает максимальное значение
        /*1*/[TestMethod]
        public void Test_HandleExceedingMaxKValue()
        {
            WriteInputFile("5 10 10 201"); // Записываем входные данные с превышением максимального значения K
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile()); // Ожидаем сообщение об ошибке
        }

        // Проверяет, правильно ли программа вычисляет стоимость, когда K равно N с высокой стоимостью за минуту
        /*1*/ [TestMethod]
        public void Test_CalculateCostWithKEqualToNAndMaxCostPerMinute()
        {
            WriteInputFile("10 5 5 10"); // Записываем входные данные, где K равно N и высокая стоимость за минуту
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("50", ReadOutputFile()); // Ожидаем, что стоимость будет 50 (5 + 9*5)
        } 

        // Проверяет, правильно ли программа обрабатывает случай, когда начальная стоимость превышает максимальное значение
        [TestMethod]
        public void Test_HandleExceedingMaxInitialCost()
        {
            WriteInputFile("5 11 10 1"); // Записываем входные данные с превышением максимальной стоимости
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile()); // Ожидаем сообщение об ошибке
        }

        // Проверяет, правильно ли программа обрабатывает низкую стоимость за минуту
        [TestMethod]
        public void Test_HandleNegativeCostPerMinute()
        {
            WriteInputFile("5 10 -1 1"); // Записываем входные данные с отрицательной стоимостью за минуту
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile()); // Ожидаем сообщение об ошибке
        }

        // Проверяет, правильно ли программа обрабатывает случай, когда стоимость за минуту превышает максимальное значение
        [TestMethod]
        public void Test_HandleExceedingMaxCostPerMinute()
        {
            WriteInputFile("5 10 11 1"); // Записываем входные данные с превышением максимальной стоимости за минуту
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile()); // Ожидаем сообщение об ошибке
        }

        // Проверяет, правильно ли программа обрабатывает отрицательное значение K (количество минут общения)
        [TestMethod]
        public void Test_HandleNegativeKValue()
        {
            WriteInputFile("5 10 10 -1"); // Записываем входные данные с отрицательным значением K
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile()); // Ожидаем сообщение об ошибке
        }

        // Проверяет, правильно ли программа обрабатывает минимальные параметры
        /*1*/[TestMethod]
        public void Test_CalculateCostWithMinimumParameters()
        {
            WriteInputFile("2 0 0 1"); // Записываем минимальные параметры
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("0", ReadOutputFile()); // Ожидаем, что стоимость будет 0
        }

        // Проверяет обработку случая, когда количество минут превышает максимальное значение
        /*1*/
        [TestMethod]
        public void Test_HandleExceedingMaxMinutesInput()
        {
            WriteInputFile("101 10 10 1"); // Записываем входные данные с превышением максимума
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile()); // Ожидаем сообщение об ошибке
        }

        //программа правильно вычисляет стоимость при максимально допустимых параметрах
       /*1*/ [TestMethod]
        public void Test_CorrectCostWithMaxValidParameters()
        {
            WriteInputFile("100 10 10 200");
            Program.Main(); // Проверяем, что метод правильно обрабатывает входные данные
            Assert.AreEqual("1000", ReadOutputFile());  // Ожидаем, что стоимость будет 1000
        }

        // Проверяет, правильно ли программа обрабатывает случай, когда все стоимости равны нулю
        /*1*/[TestMethod]
        public void Test_CalculateCostWithZeroCosts()
        {
            WriteInputFile("10 0 0 1"); // Записываем входные данные, где все стоимости равны нулю
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("0", ReadOutputFile()); // Ожидаем, что стоимость будет 0
        }

        // Проверяет, правильно ли программа обрабатывает минимальные параметры
        /*1*/
        [TestMethod]
        public void Test_CalculateCostWithMinimumParameterss()
        {
            WriteInputFile("2 0 0 1"); // Записываем минимальные параметры
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("0", ReadOutputFile()); // Ожидаем, что стоимость будет 0 (первая минута бесплатна)
        }

        // Проверяет, правильно ли программа вычисляет стоимость, когда K равно 2
        /*1*/[TestMethod]
        public void Test_CalculateCostWithKEqualToTwoAndHighB()
        {
            WriteInputFile("20 10 10 2"); // Записываем входные данные, где K равно 2
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("20", ReadOutputFile()); // Ожидаем, что стоимость будет 20 (10 + 1*10)
        }

        // Проверяет, правильно ли программа вычисляет стоимость, когда все минуты платные
        /*1*/[TestMethod]
        public void Test_CalculateCostWithAllPaidMinutes()
        {
            WriteInputFile("5 0 3 5"); // Записываем входные данные, где все минуты платные
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("12", ReadOutputFile()); // Ожидаем, что стоимость будет 12 (0 + 4*3)
        }

        // Проверяет обработку низкой начальной стоимости
        /*1*/
        [TestMethod]
        public void Test_HandleNegativeInitialCostInput()
        {
            WriteInputFile("5 -1 10 1"); // Записываем входные данные с отрицательной начальной стоимостью
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile()); // Ожидаем сообщение об ошибке
        }

        // Проверяет, правильно ли программа вычисляет стоимость, когда K превышает N
        /*1*/ [TestMethod]
        public void Test_CalculateCostWithHighKExceedingN()
        {
            WriteInputFile("7 2 1 10"); // Записываем входные данные, где K превышает N
            Program.Main(); // Вызываем основной метод программы
            Assert.AreEqual("8", ReadOutputFile()); // Ожидаем, что стоимость будет 8 (2 + 6*1)
        }

    }
}
