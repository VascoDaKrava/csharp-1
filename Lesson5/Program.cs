using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

            #region Задание 2. Класс Message для обработки текста.
            // 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
            // а) Вывести только те слова сообщения, которые содержат не более n букв.
            // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            // в) Найти самое длинное слово сообщения.
            // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
            // д) *** Создать метод, который производит частотный анализ текста.
            //    В качестве параметра в него передается массив слов и текст,
            //    в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
            //    Здесь требуется использовать класс Dictionary.
            Console.WriteLine("Задание 2. Класс Message для обработки текста.\n");

            int max_n = 5;
            char endLetter = 'е';
            string[] arrayForFreq = new string[] { "Москве", "болт", "COVID-19" };
            Dictionary<string, int> freqWords = new Dictionary<string, int>();

            string str_task2 = @"Сейчас в СМИ в Москве
Прокуратура требует ужесточить обвинение девушке, сбившей детей в Москве
Руководство «Команды 29» адвоката Павлова приняло решение о самороспуске
В Сколтехе обнаружили трудноизлечимый «длинный COVID-19»
МВД Украины сообщило о нападении на пограничников на участке границы с Россией
Абстрагирование...";

            Console.WriteLine($"Исходная строка : \n\n{str_task2}\n");

            Console.WriteLine($"\nСписок слов, которые содержат не более {max_n} букв :");
            Message.NoMoreLetters(str_task2, max_n);

            Console.WriteLine($"\nИз текста удалены все слова, оканчивающиеся на {endLetter} : \n" +
                $"{Message.DeleteSomeWords(str_task2, endLetter)}\n");

            Console.WriteLine($"Самое длинное слово в тексте : {Message.LongestWord(str_task2)}\n");

            Console.WriteLine($"Строка из самых длинных слов : \"{Message.AllLongestWords(str_task2)}\"\n");

            Console.WriteLine("Частотный анализ текста :");
            freqWords = Message.FrequencyOfWords(arrayForFreq, str_task2);
            foreach (var item in freqWords)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
            next();
            #endregion

            #region Задание 3. Опредение перестановки.
            // 3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            //    Например:
            //    badc являются перестановкой abcd.
            Console.WriteLine("Задание 3. Опредение перестановки.\n");
            string a = "qwe";
            string b = "ewq";
            string c = "ewa";

            Console.WriteLine($"Строка {a} является перестановкой {b}? - {transposition(a, b)}");
            Console.WriteLine($"Строка {a} является перестановкой {c}? - {transposition(a, c)}");

            next();
            #endregion

            //Label:;
            #region Задание 4. Три худших ученика.
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
            Console.WriteLine("Задание 4. Три худших ученика.\n");

            string incomingData = @"30
Мумриков Пармен 5 4 1
Пукай Андроник 5 5 5
Новодранов Абрам 2 4 4
Блятник Федот 1 5 2
Прикольский Анисим 3 2 4
Вралов Маркел 1 5 2
Магазинер Николай 3 1 3
Гавныкин Галактион 3 4 4
Удобников Фаддей 1 5 2
Криворуков Аникей 5 4 3
Моторов Ипат 3 1 5
Тюфякин Варфоломей 1 5 1
Пиздякин Акинф 2 2 4
Выродов Дорофей 1 2 2
Голубец Зиновий 2 1 5
Докукин Платон 2 1 4
Каша Осип 5 3 4
Недумов Марей 3 3 5
Тяпкин Протас 2 2 1
Гадов Алфёр 5 3 3
Лихопой Акинф 2 1 2
Удобников Фектист 1 2 5
Нетудыхата Мирон 4 4 4
Тюфякин Гурий 2 3 2
Сисюк Власий 1 5 5
Ящур Данил 2 3 1
Новорусский Акиндин 2 4 5
Тяпкин Галактион 1 2 2
Недоедов Кондратий 4 1 1
Скоропостижный Федос 5 2 3";

            int countOfLearners = int.Parse(Regex.Match(incomingData, @"(^[0-9]{1,3})").ToString());
            int ii;
            int countOfWorst = 3;
            int[] grades = new int[countOfLearners];
            string[] learners = incomingData.Split(new string[] { ((char)13).ToString(), "\n" }, StringSplitOptions.RemoveEmptyEntries);
            string[] names = new string[countOfLearners];
            string[] buf = new string[5];

            // Формирование массива с Ф.И. и массива с суммой оценок
            for (ii = 1; ii <= countOfLearners; ii++)
            {
                buf = learners[ii].Split(' ');
                names[ii - 1] = buf[0] + " " + buf[1];
                grades[ii - 1] = int.Parse(buf[2]) + int.Parse(buf[3]) + int.Parse(buf[4]);
            }

            Array.Sort(grades, names);

            Console.WriteLine("Список учеников :\n" + incomingData);
            Console.WriteLine("\nСписок худших :");
            ii = 0;
            while (grades[ii] != grades[ii + 1] || ii < countOfWorst)
            {
                Console.WriteLine($"{names[ii]} - {(double)grades[ii] / 3:F2}");
                ii++;
            }

            next();
            #endregion
        }

        /// <summary>
        /// Определение, является ли одна строка перестановкой другой
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static bool transposition(string a, string b)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] != b[a.Length - i - 1])
                    return false;
            }
            return true;
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
    /// Класс для работы с текстом второго задания
    /// </summary>
    static class Message
    {
        static string[] separators = { ",", ".", "!", "?", ";", ":", " ", "«", "»", "\n", ((char)13).ToString() };

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

        /// <summary>
        /// Удаление из сообщения всех слов, которые заканчиваются на заданный символ
        /// </summary>
        /// <param name="str"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static string DeleteSomeWords(string str, char a)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in words)
            {
                if (item[item.Length - 1] == a)
                    str = str.Replace(item, null);
            }

            return str;
        }


        /// <summary>
        /// Поиск самого длинного слова в тексте
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string LongestWord(string str)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int maxLength = 0;
            string longest = "";

            foreach (string item in words)
            {
                if (item.Length > maxLength)
                {
                    maxLength = item.Length;
                    longest = item;
                }
            }
            return longest;
        }

        /// <summary>
        /// Строка из самых длинных слов, сформированная из StringBuilder
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string AllLongestWords(string str)
        {
            string[] words = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            int maxLength = LongestWord(str).Length;
            StringBuilder result = new StringBuilder();

            foreach (string item in words)
            {
                if (item.Length == maxLength)
                {
                    result.Append(item);
                }
            }

            return result.ToString();
        }

        /// <summary>
        /// Частотный анализ текста
        /// </summary>
        /// <param name="arrayOfWords">Массив слов</param>
        /// <param name="text">Текст для анализа</param>
        /// <returns></returns>
        public static Dictionary<string, int> FrequencyOfWords(string[] arrayOfWords, string text)
        {
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> result = new Dictionary<string, int>();
            int count;

            for (int i = 0; i < arrayOfWords.Length; i++)
            {
                count = 0;
                foreach (string item in words)
                {
                    if (item == arrayOfWords[i])
                        count++;
                }
                result.Add(arrayOfWords[i], count);
            }

            return result;
        }
        #endregion
    }
}
