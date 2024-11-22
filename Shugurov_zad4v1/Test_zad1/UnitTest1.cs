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
            File.WriteAllText(InputFilePath, content);
        }

        private string ReadOutputFile()
        {
            return File.ReadAllText(OutputFilePath);
        }

        //программа правильно вычисляет стоимость при максимально допустимых параметрах
        [TestMethod]
        public void Test_CorrectCostWithMaxValidParameters()
        {
            WriteInputFile("100 10 10 200");
            Program.Main(); // Проверяем, что метод правильно обрабатывает входные данные
            Assert.AreEqual("1000", ReadOutputFile());  // Ожидаем, что стоимость будет 1000
        }

        //программа правильно обрабатывает минимальные параметры.
        [TestMethod]
        public void Test_CorrectCostWithMinimumParameters()
        {
            WriteInputFile("2 0 0 1");
            Program.Main();
            Assert.AreEqual("0", ReadOutputFile());
        }

        //Это последний случай, когда нет платных минут
        [TestMethod]
        public void Test_CorrectCostWithNoPaidMinutes()
        {
            WriteInputFile("10 10 0 5");
            Program.Main(); 
            Assert.AreEqual("10", ReadOutputFile());
        }

        // программа правильно обработает случай, когда все затраты будут равными
        [TestMethod]
        public void Test_CorrectCostWithMaxMinutesAndZeroCost()
        {
            WriteInputFile("100 0 0 200");
            Program.Main();
            Assert.AreEqual("0", ReadOutputFile());
        }

        //программа корректно обрабатывает отрицательное количество минут
        [TestMethod]
        public void Test_IncorrectInputNegativeMinutes()
        {
            WriteInputFile("-1 10 10 1");
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile());
        }

        //программа правильно обрабатывает случай, когда количество минут достигает максимального значения.
        [TestMethod]
        public void Test_IncorrectInputExceedingMaxMinutes()
        {
            WriteInputFile("101 10 10 1");
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile());
        }

        //программа корректно обрабатывает низкую начальную стоимость
        [TestMethod]
        public void Test_IncorrectInputNegativeCostA()
        {
            WriteInputFile("5 -1 10 1");
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile());
        }

        // программа правильно обработала случай, когда начальная стоимость составила наибольшее значение
        [TestMethod]
        public void Test_IncorrectInputExceedingMaxCostA()
        {
            WriteInputFile("5 11 10 1");
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile());
        }

        //программа корректно обрабатывает низкую стоимость за минуту.
        [TestMethod]
        public void Test_IncorrectInputNegativeCostB()
        {
            WriteInputFile("5 10 -1 1");
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile());
        }

        //программа правильно обрабатывает случай, когда стоимость за минуту достигает максимального значения
        [TestMethod]
        public void Test_IncorrectInputExceedingMaxCostB()
        {
            WriteInputFile("5 10 11 1");
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile());
        }

        //программа корректно обрабатывает отрицательное значение K(количество минут общения)
        [TestMethod]
        public void Test_IncorrectInputNegativeK()
        {
            WriteInputFile("5 10 10 -1");
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile());
        }

        //программа правильно обрабатывает случай, когда K достигает максимального значения
        [TestMethod]
        public void Test_IncorrectInputExceedingMaxK()
        {
            WriteInputFile("5 10 10 201");
            Program.Main();
            Assert.AreEqual("Некорректные входные данные", ReadOutputFile());
        }

        //программа правильно вычисляет стоимость, когда все минуты платные
        [TestMethod]
        public void Test_CorrectCostWithAllPaidMinutes()
        {
            WriteInputFile("5 0 3 5");
            Program.Main();
            Assert.AreEqual("12", ReadOutputFile()); // 0 + 4*3 = 12
        }

        //программа правильно вычисляет стоимость, когда K рассчитывает N
        [TestMethod]
        public void Test_CorrectCostWithHighKExceedingN()
        {
            WriteInputFile("7 2 1 10");
            Program.Main();
            Assert.AreEqual("8", ReadOutputFile()); // 2 + 6*1 = 8
        }


        // программа правильно обработает случай, когда все затраты будут равными
        [TestMethod]
        public void Test_CorrectCostWithZeroCostAAndB()
        {
            WriteInputFile("10 0 0 1");
            Program.Main();
            Assert.AreEqual("0", ReadOutputFile()); // Все стоимости равны нулю
        }

        //программа правильно вычисляет стоимость, когда K равно 2.
        [TestMethod]
        public void Test_CorrectCostWithKEqualToTwoAndHighB()
        {
            WriteInputFile("20 10 10 2");
            Program.Main();
            Assert.AreEqual("20", ReadOutputFile()); // 10 + 1*10 = 20
        }

        //программа правильно вычисляет стоимость с максимальной стоимостью за минуту
        [TestMethod]
        public void Test_CorrectCostWithHighAdditionalCost()
        {
            WriteInputFile("10 10 10 10");
            Program.Main();
            Assert.AreEqual("100", ReadOutputFile()); // 10 + 9*10 = 100
        }


        //программа правильно обрабатывает минимальные параметры
        [TestMethod]
        public void Test_CorrectCostWithMinimumValidParameters()
        {
            WriteInputFile("2 0 0 1");
            Program.Main();
            Assert.AreEqual("0", ReadOutputFile()); // Первая минута бесплатна, стоимость 0
        }

        //программа правильно вычисляет стоимость, когда K равно N с максимальной стоимостью за минуту.
        [TestMethod]
        public void Test_CorrectCostWithKEqualToNAndHighCostB()
        {
            WriteInputFile("10 5 5 10");
            Program.Main();
            Assert.AreEqual("50", ReadOutputFile()); // 5 + 9*5 = 50
        }

        //программа правильно обрабатывает случай, когда все минуты бесплатны.
        [TestMethod]
        public void Test_CorrectCostWithAllFreeMinutes()
        {
            WriteInputFile("10 0 0 10");
            Program.Main();
            Assert.AreEqual("0", ReadOutputFile()); // Все минуты бесплатные
        }
       
    }
 }
