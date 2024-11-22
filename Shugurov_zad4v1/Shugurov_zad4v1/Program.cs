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
            // Чтение всех строк из файла input.txt
            string[] inputLines = File.ReadAllLines("input.txt");
            // Разделение первой строки на параметры
            string[] parameters = inputLines[0].Split(' ');

            // Преобразование параметров в целые числа
            int m = int.Parse(parameters[0]); // Максимальное количество платных минут
            int s = int.Parse(parameters[1]); // Начальная стоимость
            int b = int.Parse(parameters[2]); // Стоимость каждой последующей минуты
            int d = int.Parse(parameters[3]);// Общее количество минут разговора

            // Проверка корректности входных данных
            if (m < 2 || m > 100 || s < 0 || s > 10 || b < 0 || b > 10 || d < 1 || d > 200)
            {
                // Если входные данные некорректны, записываем сообщение об ошибке в output.txt
                File.WriteAllText("output.txt", "Некорректные входные данные");
                return;
            }

            long cost; // Переменная для хранения итоговой стоимости

            // Рассчитываем стоимость в зависимости от количества минут разговора
            if (d <= 1)
            {
                // Если общее время разговора 1 минута или меньше, стоимость равна начальной стоимости
                cost = s; 
            }
            else if (d <= m)
            {
                // Если общее время разговора меньше или равно максимальному количеству платных минут
                cost = s + (d - 1) * b; 
            }
            else
            {
                // Если общее время разговора больше максимального количества платных минут
                cost = s + (m - 1) * b; 
            }

            // Запись результата в файл output.txt
            File.WriteAllText("output.txt", cost.ToString());
        }
    }
}
