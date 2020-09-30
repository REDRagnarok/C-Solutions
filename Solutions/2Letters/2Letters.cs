using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _2Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            Random exchange = new Random ();
            
            Console.WriteLine("Введите строку для анализа: ");
            string sentence = Console.ReadLine();
            for (int i = 0; i <3; i++)
            {
                string mask = "^" + sentence.Substring(0, i+1) + "(\\w*)" + sentence.Substring(0, i + 1) + "$";
                Regex repeats = new Regex(mask);
                MatchCollection found = repeats.Matches(sentence);
                
                if (found.Count > 0)
                {
                    char[] letters = sentence.ToCharArray();
                    for (int j = 0; j <= i; j++)
                    {
                        letters[j] = (char)exchange.Next('а', 'я');
                        letters[sentence.Length - 1 - i + j] = (char)exchange.Next('а', 'я');
                    }

                    sentence = new string(letters);
                    Console.WriteLine(sentence);
                }

            }
        }
    }
}
