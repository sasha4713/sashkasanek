using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите строку: ");
            string S = Console.ReadLine();
            S = S.ToLower();

            char[] C = { 'А', 'а', 'Е', 'е', 'Ё', 'ё', 'У', 'у', 'Ы', 'ы', 'Я', 'я', 'И', 'и', 'О', 'о', 'Ю', 'ю', 'Э', 'э' };
            int i = 0;
            
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
            Console.WriteLine("Гласных букв в строке:{0}", i);
            Console.ReadLine();

        }
          
        
        }
    }

