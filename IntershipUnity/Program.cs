using System;

namespace IntershipUnity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приветствие
            Console.ForegroundColor = ConsoleColor.Green;
            string welcome1 = "Здравствуйте! Вас приветствует программа тестового задания";
            string welcome2 = "на стажировку в компанию OpenMyGame!";
            Console.CursorLeft = (Console.WindowWidth - welcome1.Length) / 2;
            Console.WriteLine(welcome1);
            Console.CursorLeft = (Console.WindowWidth - welcome2.Length) / 2;
            Console.WriteLine(welcome2);

            // Тело программы
            bool program = true;
            while (program)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Выберете задачу, которую желаете просмотреть:\n" +
                "1 - Функция определения високосного года\n" +
                "2 - Функция определяющая, состоят ли элементы массива строк из одних и тех же букв\n" +
                "3 - Функция определения строки полиндрома\n" +
                "4 - Функция определения правильно скобочной последовательности.\n" +
                "Введите \"Выход\", чтоб выйти из программы.");
                Console.ResetColor();
                string inputUser = Console.ReadLine();
                switch (inputUser.ToLower())
                {
                    case "1":
                        LeapYear year = new LeapYear();
                        year.DefineLeapYear();
                        break;
                    case "2":
                        ArrayWords arrayWords = new ArrayWords();
                        arrayWords.MakeArray();
                        // Оставлена для проверки
                        //ArrayWords.DefiningChars(arrayWords.example1); 
                        break;
                    case "3":
                        Polindrome polindrome = new Polindrome();
                        polindrome.DefinesPolindrom();
                        break;
                    case "4":
                        Console.WriteLine("not done");
                        break;
                    case "выход":
                        program = false;
                        break;
                    case "q":
                        program = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет такого варианта!");
                        Console.ResetColor();
                        break;
                }
            }
        }
    }
}
