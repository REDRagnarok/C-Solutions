using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var7Sol77d
{
    class Square
    {
        static void Main(string[] args)
        {
            int num;
            double result = 0;

            Console.Write("Введите натуральное число N:");
            string input = Console.ReadLine();
            int.TryParse(input, out num);

            for (int k = 0; k < num; k++)
            {
                result += Math.Sqrt(2);
            }

            result /= num;

            Console.WriteLine($"Результат: {result}");
        }
    }
}
