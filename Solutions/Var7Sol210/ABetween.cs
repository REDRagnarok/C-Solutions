using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var7Sol210
{
    class ABetween
    {
        static void Main(string[] args)
        {
            Random rGen = new Random();
            List<double> values = new List<double>();

            for (uint i = 1; i < 10; i++)
            {
                double nextVal = Math.Round(rGen.NextDouble() * 100, 2);
                values.Add(nextVal);
                Console.Write("{0}\t ", nextVal);
            }

            Console.WriteLine();

            for (int j = 0; j < values.Count()-1; j++)
            {
                if (j >= 2)
                {
                    if ((values[j] > values[j - 1]) && (values[j] < values[j + 1]))
                        Console.WriteLine(values[j]);
                }
            }
            
            Console.ReadKey();
        }
    }
}
