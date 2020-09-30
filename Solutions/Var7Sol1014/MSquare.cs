using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var7Sol1014
{
    class MSquare
    {
        static void Main(string[] args)
        {
            int RightDiagonal = 0;
            int LeftDiagonal = 0;
            string IsMagic = "";

            int[,] MagicSquare = {  { 11, 24, 7, 20, 3 },
                                    { 4, 12, 25, 8, 16 },
                                    { 17, 5, 13, 21, 9 }, 
                                    { 10, 18, 1, 14, 22 },
                                    { 23, 6, 19, 2, 15 } };
            
            int[] ValuesToCheck = new int[((MagicSquare.GetUpperBound(0)+1) * 2) + 2];
            int ctr = 0;

            for (int i = 0; i <= MagicSquare.GetUpperBound(0); i++)
            {
                int RowValue = 0;
                int ColumnValue = 0;
                
                for (int j = 0; j <= MagicSquare.GetUpperBound(0); j++)
                {
                    RowValue += MagicSquare[i, j];
                    
                }
                
                //Console.Write("{0} ", RowValue);

                for (int j = 0; j <= MagicSquare.GetUpperBound(0); j++)
                {
                    ColumnValue += MagicSquare[j, i];
                    
                    
                }

                ValuesToCheck[ctr++] = RowValue;
                ValuesToCheck[ctr++] = ColumnValue;
                //Console.Write("{0} ", ColumnValue);

                RightDiagonal += MagicSquare[i, i];
                LeftDiagonal += MagicSquare[MagicSquare.GetUpperBound(0) - i, MagicSquare.GetUpperBound(0) - i];
               
            }
            ValuesToCheck[ctr++] = RightDiagonal;
            ValuesToCheck[ctr++] = LeftDiagonal;

            for (int k = 1; k < ValuesToCheck.Length; k++)
            {
                if (ValuesToCheck[k] != ValuesToCheck[k - 1])
                {
                    IsMagic = "не" ;
                }
            }
           
            Console.WriteLine("Квадрат " + IsMagic + " является \"магическим\"");
            //Console.Write("{0} {1}", RightDiagonal,LeftDiagonal);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
