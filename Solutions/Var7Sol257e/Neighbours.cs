using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Var7Sol257e
{
    class Neighbours
    {
        static void Main(string[] args)
        {
            int strLen;
            bool neighbours = false;
            List<char> symbols = new List<char>();
            List<char> found = new List<char>();

            Console.Write("Введите длину строки символов: ");
            string input = Console.ReadLine();
            int.TryParse(input, out strLen);

            Random charRow = new Random();
            for (int i = 0; i < strLen; i++)
            {
                char nextChar = (char)charRow.Next('!', 'z');
                Console.Write( nextChar);
                symbols.Add(nextChar);
            }

            Console.WriteLine();

            for (int j = 1; j < symbols.Count - 1; j++)
            {
                if ((symbols[j] == symbols[j + 1])&& (symbols[j] != symbols[j-1]))
                {
                    if (neighbours)
                    {
                        Console.WriteLine("Найдены последовательные пары");
                        found.Add(symbols[j]);
                        found.Add(symbols[j + 1]);
                        foreach (char sym in found)
                            Console.Write("{0}", sym);
                        break;
                    }
                    else
                    {
                        neighbours = true;
                        found.Add(symbols[j]);
                        found.Add(symbols[j + 1]);
                    }
                                                             
                }
            }

            if (found.Count < 4)
                Console.WriteLine("Последовательных пар не обнаружено");

            Console.ReadKey();
        }
    }
}
