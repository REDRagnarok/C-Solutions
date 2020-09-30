using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Var7Sol316a
{
    class words
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение для анализа: ");
            string sentence = Console.ReadLine();
            Regex mask = new Regex(@"(\w*)д$",RegexOptions.IgnoreCase);
            MatchCollection found = mask.Matches(sentence);
            if (found.Count > 0)
            {
                foreach (Match instance in found)
                    Console.WriteLine(instance);
            }
            else
                Console.WriteLine("Слов, оканчивающихся на букву \'д\' в тексте не найдено");
            Console.ReadKey();

        }
    }
}
