using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var7Sol139e
{
    class Rows
    {

        public int Factorial(int f)
        {
            if (f == 0)
                return 1;
            else
                return f * Factorial(f - 1);
        }

        static void Main(string[] args)
        {
            int iter;
            
            Console.WriteLine("Введите натуральное число N:");
            string input = Console.ReadLine();
            int.TryParse(input, out iter);

            int fact = 1;

            for (int i = 1; i <= iter; i++)
            {
                fact *= i;
                double rowVal = Math.Pow(2, i) / fact;
                Console.WriteLine(rowVal);
            }
        }
               
    }
}
