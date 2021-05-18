using System;
using System.Collections.Generic;
using System.Text;

namespace IntershipUnity
{
    class ArrayWords
    {
        public string[] example1 = new string[3] { "кот", "ток", "кто" };
        public string[] example2 = new string[3] { "кот", "тк", "кТо" };

        public void DefiningChars(params string[] arrayWords)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string head = "Определение символов массива!";
            Console.CursorLeft = (Console.WindowWidth - head.Length) / 2;
            Console.WriteLine(head);
            Console.ResetColor();
            // создание и заполнение массива символов для сравнения элементов
            char[] symbols = new char[arrayWords[0].Length];
            for (int i = 0; i < symbols.Length; i++)
            {
                symbols[i] = arrayWords[0][i];
            }
            bool indicator = true;
            for (int i = 1; i < arrayWords.Length; i++)
            {
                if (symbols.Length != arrayWords[i].Length)
                {
                    indicator = false;
                    break;
                }
                else
                {
                    foreach (char symbol in symbols)
                    {
                        if (arrayWords[i].IndexOf(symbol) < 0)
                        {
                            indicator = false;
                            break;
                        }
                    }
                }
            }
            if (indicator)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Слова составлены из одних и тех же символов!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Слова не составлены из одних и тех же символов!");
                Console.ResetColor();
            }
        }


    }
}
