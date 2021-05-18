using System;
using System.Collections.Generic;
using System.Text;

namespace IntershipUnity
{
    class Polindrome
    {
        /// <summary>
        /// Воспринимает на вход строку и проверяет является ли она полиндромом
        /// </summary>
        public void DefinesPolindrom()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string head = "Определение полиндрома!";
            Console.CursorLeft = (Console.WindowWidth - head.Length) / 2;
            Console.WriteLine(head);
            Console.ResetColor();
            Console.WriteLine("Введите строку, для определения является ли она полиндромом:");
            string polindromeString = Console.ReadLine();
            int startString = 0;
            int endString = polindromeString.Length - 1;
            polindromeString = polindromeString.ToLower();

            // условия на определения полиндрома
            while (true)
            {
                // вывод отдель символом для облегчения дебага
                char startChar = polindromeString[startString]; 
                char endChar = polindromeString[endString];

                if (startString >= endString)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Строка является полиндромом!");
                    Console.ResetColor();
                    break;
                }
                else if (startChar == endChar && startString != endString)
                {
                    startString++;
                    endString--;
                }
                else if (startChar == ' ')
                {
                    startString++;
                }
                else if (endChar == ' ')
                {
                    endString--;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Строка не полиндромом!");
                    Console.ResetColor();
                    break;
                }
            }
        }
    }
}
