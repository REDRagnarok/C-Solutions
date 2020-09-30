using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var7136e
{
    class RowsOf2
    {
        static void Main(string[] args)
        {
            Random RealRandomNumber = new Random();
            double SumOfElements = 0;
            double MultOfElements = 1;

            Console.Write("Введите количество элементов ряда: ");
            int NumberOfRowElements = int.Parse(Console.ReadLine());

            double[] Arr = new double[NumberOfRowElements];
            Console.Write("Элементы ряда: ");

            for (int ctr = 0; ctr < Arr.Length; ctr++)
            {
                Arr[ctr] = Math.Round(-100 + RealRandomNumber.NextDouble() * 200, 2);
                Console.Write("{0}  ", Arr[ctr]);
            }
            Console.WriteLine();
            foreach (double element in Arr)
            {
                SumOfElements += element;
                MultOfElements *= element;
            }

            Console.Write("Сумма элементов ряда равна: {0} \nПроизведение элементов ряда равно: {1}\n", SumOfElements,MultOfElements);
            Console.ReadKey();
        }
    }
}
