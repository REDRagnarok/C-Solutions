using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var7Sol371
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Random RealRandomNumber = new Random();
            Console.Write("Введите длину измерения квадратной матрицы: ");
            int MatrixDimension = int.Parse(Console.ReadLine());
            double[,] Matrix = new double[MatrixDimension, MatrixDimension];
            // Заполняем массив действительными числами;
            for (int i = 0; i < MatrixDimension; i++)
            {
                for (int j = 0; j < MatrixDimension; j++)
                {
                    Matrix[i, j] = Math.Round(-100 + RealRandomNumber.NextDouble()*200,2);
                }
                                
            }

            Console.WriteLine();

            // Выводим исходную матрицу на печать
            for (int k = 0; k < Matrix.GetUpperBound(0) + 1; k++)
            {
                for (int m = 0; m < Matrix.GetUpperBound(0) + 1; m++)
                {
                    Console.Write("{0,6}  ", Matrix[k, m]);
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();
            Console.WriteLine();

            // Выводим матрицу B на печать ( b [k,m] = a [k,m] при k >= m; b [k,m] = a [k,m] при k < m)
            Console.WriteLine("Матрица B: \n");

            for (int k = 0; k < Matrix.GetUpperBound(0) + 1; k++)
            {
                for (int m = 0; m < Matrix.GetUpperBound(0) + 1; m++)
                {
                    if (k >= m)
                        Console.Write("{0,6}  ", Matrix[k, m]);
                    else
                        Console.Write("{0,6}  ", Matrix[m, k]);
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();

            // Выводим матрицу C на печать ( с [k,m] = a [k,m] при k < m; c [k,m] = -a[k,m] при k >= m)
            Console.WriteLine("Матрица C: \n");

            for (int k = 0; k < Matrix.GetUpperBound(0) + 1; k++)
            {
                for (int m = 0; m < Matrix.GetUpperBound(0) + 1; m++)
                {
                    if (k < m)
                        Console.Write("{0,6}  ", Matrix[k, m]);
                    else
                        Console.Write("{0,6}  ", -1*(Matrix[m, k]));
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();
        }
    }
}
