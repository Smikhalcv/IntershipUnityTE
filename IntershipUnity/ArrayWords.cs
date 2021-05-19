using System;
using System.Collections.Generic;
using System.Text;

namespace IntershipUnity
{
    class ArrayWords
    {
        //оставленно для проверки
        public string[] example1 = new string[3] { "кот", "ток", "кто" };
        public string[] example2 = new string[3] { "кот", "тк", "кТо" };

        /// <summary>
        /// Определяет состоит ли переданный массив слов из одних и тех же символов
        /// </summary>
        /// <param name="arrayWords">Проверяемый массив слов</param>
        static public void DefiningChars(params string[] arrayWords)
        {
            
            // создание и заполнение массива символов для сравнения элементов
            char[] symbols = new char[arrayWords[0].Length];
            for (int i = 0; i < symbols.Length; i++)
            {
                symbols[i] = arrayWords[0][i];
            }
            bool indicator = true;
            // проверка длины массива символов с длиной элементов проверяемого массива
            for (int i = 1; i < arrayWords.Length; i++)
            {
                if (symbols.Length != arrayWords[i].Length)
                {
                    indicator = false;
                    break;
                }
                else
                {
                    // посимвольная проверка элементов массива
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
            // вывод результата, в зависимости от итогового значения indicator
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

        /// <summary>
        /// Конструктор массива, внутри сея вызывает DefiningChars
        /// </summary>
        public void MakeArray()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string head = "Определение символов массива!";
            Console.CursorLeft = (Console.WindowWidth - head.Length) / 2;
            Console.WriteLine(head);
            Console.ResetColor();

            // определение количесвта элементов проверяемого массива
            Console.WriteLine("Укажите количество элементов массива -");
            int countElemArray = 0;
            while (true)
            {
                try
                {
                    countElemArray = Convert.ToInt32(Console.ReadLine());
                    if (countElemArray > 0)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Укажите натуральное число больше 0");
                }
            }

            // заполнение массива
            string[] arrayCheck = new string[countElemArray];
            for (int i = 0; i < countElemArray; i++)
            {
                Console.WriteLine($"Укажите элемент массива номер {i + 1}");
                arrayCheck[i] = Console.ReadLine();
            }
            DefiningChars(arrayCheck);
        }
    }
}
