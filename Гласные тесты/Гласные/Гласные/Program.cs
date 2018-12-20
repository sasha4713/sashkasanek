using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гласные
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string S = Console.ReadLine();
            S = S.ToLower();
            Program o = new Program();
            char[] C = { 'А', 'а', 'Е', 'е', 'Ё', 'ё', 'У', 'у', 'Ы', 'ы', 'Я', 'я', 'И', 'и', 'О', 'о', 'Ю', 'ю', 'Э', 'э' };
            int i = 0;
            i = o.Glasnai(S, C, i);
            Console.WriteLine("Гласных букв в строке:{0}", i);
            Console.ReadLine();

        }

        public int Glasnai(string S, char[] C, int i)
        {
            foreach (char d in S)
            {
                if (d != '!')
                {
                    if (C.Contains(d))
                    {
                        i++;
                    }


                }
                else
                {
                    Console.WriteLine("Гласных букв в строке:{0}", i);
                    Console.ReadLine();
                }

            }

            return i;
        }
    }
}
   