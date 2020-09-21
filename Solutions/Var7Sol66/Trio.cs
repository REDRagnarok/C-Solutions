using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var7Sol66
{
    class Trio
    {
        static void Main(string[] args)
        {
            int k, m;
            double x, y, z;

            Console.Write("Введите два целых числа (через запятую): ");
            string [] input = Console.ReadLine().Split(',');
            int.TryParse(input[0], out k);
            int.TryParse(input[1], out m);

            Console.Write("Введите три действительных числа (через запятую): ");
            input = Console.ReadLine().Split(',');
            double.TryParse(input[0], out x);
            double.TryParse(input[1], out y);
            double.TryParse(input[2], out z);


            if (k < Math.Pow(m, 2)) {
                x = Math.Abs(x);
                y -= 0.5;
                z -= 0.5;
            }
            else if (k == Math.Pow(m, 2)) {
                y = Math.Abs(y);
                x -= 0.5;
                z -= 0.5;
            } 
            else
            {
                z = Math.Abs(z);
                x -= 0.5;
                y -= 0.5;
            }
            
            Console.WriteLine($"k = {k}\nm = {m}\nx = {x}\ny = {y}\nz = {z}");
        }
    }
}
