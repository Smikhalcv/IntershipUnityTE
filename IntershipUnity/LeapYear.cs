using System;
using System.Collections.Generic;
using System.Text;

namespace IntershipUnity
{
    class LeapYear
    {
        /// <summary>
        /// Просит ввести год, для определения является ли он високосным.
        /// Для выхода из подпрограммы нужно ввести "Выход" или "q".
        /// </summary>
        public void DefineLeapYear()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string head = "Определение високосного года!";
            Console.CursorLeft = (Console.WindowWidth - head.Length) / 2;
            Console.WriteLine(head);
            Console.ResetColor();
            Console.WriteLine("Введите \"Выход\", чтоб выйти из подпрограммы.");
            Console.WriteLine("Укажите год: ");
            int year = 0;
            string inputUser;
            while (true)
            {
                inputUser = Console.ReadLine();

                // Условие выхода
                if (inputUser.ToLower() == "выход" || inputUser.ToLower() == "q")
                {
                    break;
                }

                // Перевод строки в число, до указания числа
                try
                {
                    year = Convert.ToInt32(inputUser);
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Укажите натуральное число!");
                    Console.ResetColor();
                    continue;
                }

                if (year < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Укажите год после нашей эры!");
                    Console.ResetColor();
                }
                else
                {
                    // Условия високосного года
                    if (year % 400 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Год {year} високосный!");
                        Console.ResetColor();
                    }
                    else if (year % 4 == 0 && year % 100 != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Год {year} високосный!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Год {year} не високосный!");
                        Console.ResetColor();
                    }
                }               
            }
        }
    }
}
