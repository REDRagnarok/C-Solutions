using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var7Sol55
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            double A1, A2, B1, B2;
            string result ="";

            Console.Write("Введите длины сторон прямоугольника A (через запятую): ");
            string[] input = Console.ReadLine().Split(',');
            double.TryParse(input[0], out A1);
            double.TryParse(input[1], out A2);

            Console.Write("Введите длины сторон прямоугольника B (через запятую): ");
            input = Console.ReadLine().Split(',');
            double.TryParse(input[0], out B1);
            double.TryParse(input[1], out B2);

            Console.WriteLine($"A1 = {A1}\nA2 = {A2}\nB1 = {B1}\nB2 = {B2}");

            double maxA = A1 >= A2 ? A1 : A2;
            double maxB = B1 >= B2 ? B1 : B2;
            double minA = maxA == A1 ? A2 : A1;
            double minB = maxB == B1 ? B2 : B1;

            if (maxA > maxB)
            {
                if (minA > minB) result = "Да";
            }
            else
                result = "Нет";

            Console.WriteLine($"Прямоугольник \'B\' может быть вложен в прямоугольник \'А\'.Ответ - {result}"); ;
            Console.ReadKey();
        }
    }
}
