using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto Label;
            #region Задание 1. Корректность ввода логина.
            // 1. Создать программу, которая будет проверять корректность ввода логина.
            //    Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
            //    при этом цифра не может быть первой:
            // а) без использования регулярных выражений;
            // б) **с использованием регулярных выражений.
            Console.WriteLine("Задание 1. Корректность ввода логина\n");
            bool correct_login = false;
            string login;
            Regex expr = new Regex(@"(^[a-zA-Z][0-9a-zA-Z]{1,9}$)");

            Console.Write("Введите логин : ");
            while (!correct_login)
            {
                login = Console.ReadLine();
                if (login.Length >= 2 &&
                    login.Length <= 10 &&
                    !char.IsDigit(login[0]))
                {
                    correct_login = true;
                    for (int i = 0; i < login.Length; i++)
                    {
                        if (!(Char.IsDigit(login[i]) ||
                            (login[i] >= 'a' && login[i] <= 'z') ||
                            (login[i] >= 'A' && login[i] <= 'Z')))
                        {
                            correct_login = false;
                            break;
                        };
                    }
                }
                Console.Write(correct_login ? "Логин корректен.\n" : "Введён некорректный логин. Попробуйте ещё раз : ");
            }
            Console.Write("\nВведите логин для проверки через RegExpr : ");
            correct_login = false;
            while (!correct_login)
            {
                login = Console.ReadLine();
                if (expr.IsMatch(login))
                    correct_login = true;
                Console.Write(correct_login ? "Логин корректен.\n" : "Введён некорректный логин. Попробуйте ещё раз : ");
            }

            next();
        #endregion

        Label:;
            #region MyRegion
            // 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            // а) Вывести только те слова сообщения, которые содержат не более n букв.
            // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            // в) Найти самое длинное слово сообщения.
            // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            // д) *** Создать метод, который производит частотный анализ текста.
            //    В качестве параметра в него передается массив слов и текст,
            //    в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
            //    Здесь требуется использовать класс Dictionary.
            #endregion

            #region MyRegion
            // 3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            //    Например:
            //    badc являются перестановкой abcd.
            #endregion

            #region MyRegion
            // 4. * Задача ЕГЭ.
            //    На вход программе подаются сведения о сдаче экзаменов учениками 9 - х классов некоторой средней школы.
            //    В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100,
            //    каждая из следующих N строк имеет следующий формат:
            //    < Фамилия > < Имя > < оценки >,
            //    где
            //    < Фамилия > — строка, состоящая не более чем из 20 символов,
            //    < Имя > — строка, состоящая не более чем из 15 символов,
            //    < оценки > — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
            //    < Фамилия > и<Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
            //    Иванов Петр 4 5 3
            //    Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и
            //    имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
            //    набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
            #endregion

        }

        /// <summary>
        /// По нажатию Enter очищает экран
        /// </summary>
        static void next()
        {
            Console.Write("\nДля продолжения нажмите Enter..");
            Console.ReadLine();
            Console.Clear();
        }
    }

    /// <summary>
    /// Класс для второго задания
    /// </summary>
    static class Message
    {
        static string[] separators = { ",", ".", "!", "?", ";", ":", " " };

        #region Methods

        /// <summary>
        /// Вывести только те слова сообщения, которые содержат не более n букв.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="n"></param>
        public static void NoMoreLetters(string str, int n)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in words)
            {
                if (item.Length < n)
                    Console.WriteLine(item);
            }
        }

        // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        
        public static string DeleteSomeWorlds(string str, char a)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in words)
            {
                if (item[item.Length - 1] == a)
            //str.Replace()

            }
        }


        // в) Найти самое длинное слово сообщения.

        // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.

        // д) *** Создать метод, который производит частотный анализ текста.
        //    В качестве параметра в него передается массив слов и текст,
        //    в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        //    Здесь требуется использовать класс Dictionary.
        #endregion
    }
}
