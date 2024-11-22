using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shugurov_zad4v1
{
    public class Program
    {
        public static void Main()
        {
            string[] inputLines = File.ReadAllLines("input.txt");
            string[] parameters = inputLines[0].Split(' ');
            int n = int.Parse(parameters[0]);
            int a = int.Parse(parameters[1]);
            int b = int.Parse(parameters[2]);
            int k = int.Parse(parameters[3]);

            // Проверка корректности входных данных
            if (n < 2 || n > 100 || a < 0 || a > 10 || b < 0 || b > 10 || k < 1 || k > 200)
            {
                File.WriteAllText("output.txt", "Некорректные входные данные");
                return;
            }

            long cost;

            if (k <= 1)
            {
                cost = a; // Первая минута бесплатна, поэтому если k=1, то стоимость 0
            }
            else if (k <= n)
            {
                cost = a + (k - 1) * b; // Стоимость с учетом платных минут
            }
            else
            {
                cost = a + (n - 1) * b; // Стоимость, если общение заняло больше n минут
            }

            // Запись результата в файл output.txt
            File.WriteAllText("output.txt", cost.ToString());
        }
    }
}
