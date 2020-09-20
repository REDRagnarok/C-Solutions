using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Var7Sol8
{
    class Polygon
    {
        static void Main(string[] args)
        {
            string input;
            int corners;
            double radius;
            double perimeter;

            while (true)
            {
                Console.Clear();
                Console.Write("Введите число углов многоугольника: ");
                input = Console.ReadLine();
                int.TryParse(input, out corners);
                if ((corners < 0) || (corners < 3))
                {
                    Console.WriteLine("Недопустимое значение.Повторите ввод.");
                    continue;
                }
                Console.Write("Введите радиус описанной окружности: ");
                input = Console.ReadLine();
                double.TryParse(input, out radius);
                if (radius < 0)
                {
                    Console.WriteLine("Недопустимое значение.Повторите ввод.");
                    continue;
                }
                break;
            }

            perimeter = 2 * radius * corners * Math.Sin(Math.PI / corners);

            Console.Clear();
            Console.WriteLine(value: $"Число сторон многоугольника равно: {corners}\n"+
                $"Радиус вписанной окружности равен: {radius}\n" +
                $"Периметр описанного многоугольника равен: {perimeter}");
            Console.ReadKey();

        }
    }
}
