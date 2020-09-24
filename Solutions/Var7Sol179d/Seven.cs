using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//

namespace Var7Sol179d
{
    class Seven
    {
        static void Main(string[] args)
        {

            Console.Write("Введите натуральное число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<N; i++)
            {
                
                if ((i > 7) && ((i % 7 == 1) || (i % 7 ==2) || (i%7 == 5)))
                {
                    Console.Write("{0} ",i);
                    
                }
                
            }
            Console.WriteLine();
        }
    }
}
