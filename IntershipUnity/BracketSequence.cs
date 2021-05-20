using System;
using System.Collections.Generic;
using System.Text;

namespace IntershipUnity
{
    class BracketSequence
    {
        // для проверки
        public string example1 = "())()([]][{()}";

        /// <summary>
        /// Воспринимат на вход строку и проверяет является ли она правильно скобочной последовательностью
        /// </summary>
        /// <param name="sequence">Проверяемая скобочная последовательность</param>
        public static void bracketSequence(string sequence)
        {
            bool indicator = true;
            string workingSequence = sequence;
            if (sequence.Length % 2 != 0)
            {
                indicator = false;
            }
            else
            {
                // проходится по строке, пока не найдёт пару скобок
                // после нахождения пара скобок удаляется, а счётчик сбрасывает на 1
                for (int i = 1; i < workingSequence.Length; i++)
                {
                    if (workingSequence[0] == ')' || workingSequence[0] == ']' || workingSequence[0] == '}')
                    {
                        indicator = false;
                        break;
                    }
                    if (workingSequence[i] == ')' && workingSequence[i - 1] == '(')
                    {
                        workingSequence = workingSequence.Remove(i, 1);
                        workingSequence = workingSequence.Remove(i - 1, 1);
                        i = 1;
                    }
                    else if (workingSequence[i] == ']' && workingSequence[i - 1] == '[')
                    {
                        workingSequence = workingSequence.Remove(i, 1);
                        workingSequence = workingSequence.Remove(i - 1, 1);
                        i = 1;
                    }
                    else if (workingSequence[i] == '}' && workingSequence[i - 1] == '{')
                    {
                        workingSequence = workingSequence.Remove(i, 1);
                        workingSequence = workingSequence.Remove(i - 1, 1);
                        i = 1;
                    }
                    if (i == workingSequence.Length)
                    {
                        indicator = false;
                    }
                }   
            }

            // вывод результата, в зависимости от итогового значения indicator
            if (indicator)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Скобочная последовательно правильная!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Не является правильной скобочной последовательностью!");
                Console.ResetColor();
            }
        }

        /// <summary>
        /// Создаёт и проверяет является ли она скобочной последовательностью.
        /// Запускает bracketSequence.
        /// </summary>
        public void CreatingSequence()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string head = "Определение правильной скобочной последовательности!";
            Console.CursorLeft = (Console.WindowWidth - head.Length) / 2;
            Console.WriteLine(head);
            Console.ResetColor();
            string sequence = "";
            bool indicator = true;
            // запрашивает строку, пока она не будет состоять только из скобок
            while (indicator)
            {
                Console.WriteLine("Введите скобочную последовательность -");
                sequence = Console.ReadLine();
                for (int i = 0; i < sequence.Length; i++)
                {
                    if (
                    sequence[i] == ')' ||
                    sequence[i] == '(' ||
                    sequence[i] == ']' ||
                    sequence[i] == '[' ||
                    sequence[i] == '}' ||
                    sequence[i] == '{'
                    )
                    {
                        indicator = false;
                    }
                    else if (i - 1 == sequence.Length)
                    {
                        indicator = false;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели несоответствующий символ!");
                        indicator = true;
                        break;
                    }
                }
            }
            bracketSequence(sequence);
        }
    }
}
