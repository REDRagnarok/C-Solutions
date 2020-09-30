using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var7Sol832
{
    class Calendar
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер года: ");
            int NumOfYear = int.Parse(Console.ReadLine());

            string[] NamesOfMonth = {   "январе", 
                                        "феврале", 
                                        "марте", 
                                        "апреле", 
                                        "мае", 
                                        "июне", 
                                        "июле", 
                                        "августе", 
                                        "сентябре", 
                                        "октябре", 
                                        "ноябре", 
                                        "декабре" };
                
           DateTime someDate = new DateTime(NumOfYear,01,01);
           DateTime CleanUpDay = new DateTime();

            Console.WriteLine("Санитарные дни: ");

            foreach(string someMonth in NamesOfMonth)
            {
                while (someDate.Month == Array.IndexOf(NamesOfMonth, someMonth)+1)
                {
                    if (someDate.DayOfWeek == DayOfWeek.Thursday)
                    {
                        CleanUpDay = someDate;
                    }
                    someDate = someDate.AddDays(1);
                }
                Console.WriteLine(CleanUpDay.Date.ToShortDateString());
            }
              
            
        }
    }
}
