using System;
using System.Collections.Generic;
using System.IO;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto Label;
            #region Задание 1. Массив и пары, в которых только одно число делится на 3
            // 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
            //    Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива,
            //    в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
            //    Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
            Console.WriteLine("Задание 1. Массив и пары, в которых только одно число делится на 3.\n");
            int arrT1_length = 20;
            int arrT1_minValue = -10000;
            int arrT1_maxValue = 10000;
            int[] arrT1 = new int[arrT1_length];
            Random rand = new Random();

            Console.WriteLine("Сгенерированный массив :\n");
            for (int i = 0; i < arrT1_length; i++)
            {
                arrT1[i] = rand.Next(arrT1_minValue, arrT1_maxValue + 1);
                Console.WriteLine($"{i + 1:D2}. {arrT1[i]}, остаток от деления на 3 = {arrT1[i] % 3}");
            }
            Console.WriteLine($"\n\nКоличество искомых пар : {countOfPairDiv3(arrT1)}");

            next();
            #endregion

            #region Задание 2. Статический класс
            // 2. Реализуйте задачу 1 в виде статического класса StaticClass;
            //    а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            //    б) * Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
            //    в) ** Добавьте обработку ситуации отсутствия файла на диске.
            Console.WriteLine("Задание 2. Статический класс, считывание массива из текстового файла.\n");
            string sourceFile = "./TextFile1.txt";

            int[] arrT2 = ArrayTask2.ReadArrayFromFile(sourceFile);

            Console.WriteLine($"Массив, считанный из файла {sourceFile} :\n");
            for (int i = 0; i < arrT2.Length; i++)
            {
                Console.WriteLine($"{i + 1:D2}. {arrT2[i]}, остаток от деления на 3 = {arrT2[i] % 3}");
            }
            Console.WriteLine($"\n\nКоличество искомых пар : {ArrayTask2.CountOfPairDiv3(arrT2)}");

            next();
            #endregion

            #region Задание 3. Доработка класса
            // 3. а) Дописать класс для работы с одномерным массивом.
            //    Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
            //    Создать свойство Sum, которое возвращает сумму элементов массива,
            //    метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
            //    метод Multi, умножающий каждый элемент массива на определённое число,
            //    свойство MaxCount, возвращающее количество максимальных элементов. 
            //    б) ** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
            //    в) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
            Console.WriteLine("Задание 3. Доработка класса.\n");
            int t3ArrLen = 5;
            int t3Start = -2;
            int t3Step = 3;
            int a = 2;

            ArrayTask3 arrT3 = new ArrayTask3(t3ArrLen, t3Start, t3Step);
            Console.WriteLine($"Массив, созданный конструктором \"new ArrayTask2({t3ArrLen}, {t3Start}, {t3Step})\" : \n{arrT3}");
            Console.WriteLine("Сумма элементов : " + arrT3.sum);

            int[] arrT3Inv = new int[t3ArrLen];
            Array.Copy(arrT3.Inverse(), arrT3Inv, t3ArrLen);
            Console.WriteLine("\nНовый инвертированный массив :");
            for (int i = 0; i < arrT3Inv.Length; i++)
            {
                Console.WriteLine($"{i + 1:D2}\t{arrT3Inv[i]}");
            }

            arrT3.Multi(a);
            Console.WriteLine($"\nМассив после умножения на {a} :\n{arrT3}");

            arrT3[0] = arrT3[t3ArrLen - 1];
            Console.WriteLine($"\nМассив {a} :\n{arrT3}");
            Console.WriteLine($"Количество максимумов : {arrT3.MaxCount}\n");

            Console.WriteLine("Для предыдущего массива частота вхождения : ");
            Dictionary<int, int> qwe = arrT3.frequencyDictionary();
            foreach (KeyValuePair<int, int> item in qwe)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            next();
            #endregion

            #region Задание 4. Логин и пароль
            // 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
            //    Создайте структуру Account, содержащую Login и Password.
            Console.WriteLine("Задание 4. Логин и пароль\n");

            byte countForTry = 3; // Количество попыток
            bool accessGranted = false;
            char separator = ' ';
            string path = "./login_and_pass.txt";

            Account[] accounts = accountsFromFile(path, separator);

            Console.WriteLine("Логины и пароли, считанные из файла:\n");
            foreach (Account item in accounts)
            {
                Console.WriteLine(item.Login + " - " + item.Password);
                if (checkLoginPassword(item.Login, item.Password) && countForTry > 0)
                {
                    accessGranted = true; // Доступ разрешён только, если логин и пароль верные и не превышено число попыток
                }
                countForTry--;
            }

            if (accessGranted)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nДоступ получен.\n" +
                    "Программа пропускает дальше.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nДоступ запрещён!\n" +
                    "Программа дальше не пропускает.");
                Console.ResetColor();
            }

            next();
            #endregion

            //Label:;
            #region Задание 5. Библиотека для двумерного массива
            // 5. * а) Реализовать библиотеку с классом для работы с двумерным массивом.
            //    Реализовать конструктор, заполняющий массив случайными числами.
            //    Создать методы, которые возвращают сумму всех элементов массива,
            //    сумму всех элементов массива больше заданного,
            //    свойство, возвращающее минимальный элемент массива,
            //    свойство, возвращающее максимальный элемент массива,
            //    метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
            //    ** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
            //    ** в) Обработать возможные исключительные ситуации при работе с файлами.
            Console.WriteLine("Задание 5. Библиотека для двумерного массива.\n");

            int x = 5;
            int y = 3;
            int minValue = -5;
            int maxValue = 5;
            int maxPositionX;
            int maxPositionY;
            string pathToMatrix = "./matrix.txt";
            string pathToMatrixNew = "./matrix0.txt";
            char separatorForMatrix = '\t';

            ArrayTask5 arrT5 = new ArrayTask5(x, y, minValue, maxValue);
            Console.WriteLine($"Массив {x} x {y}:");
            arrT5.Print();

            Console.WriteLine($"\nСумма всех элементов : {arrT5.sum()}");
            Console.WriteLine($"Сумма всех элементов, больших {maxValue / 2} : {arrT5.sum(maxValue / 2)}");
            Console.WriteLine($"Минимальный элемент : {arrT5.min}");
            Console.WriteLine($"Максимальный элемент : {arrT5.max}");
            arrT5.whereMax(out maxPositionX, out maxPositionY);
            Console.WriteLine($"Номер максимального элемента : {maxPositionX}, {maxPositionY}");

            Console.WriteLine($"\nМассив из файла ({pathToMatrix}) : ");
            ArrayTask5 arrT5File = new ArrayTask5(pathToMatrix, separatorForMatrix);
            arrT5File.Print();

            arrT5.Print(pathToMatrixNew);

            next();
            #endregion
        }

        #region Методы задания 4
        /// <summary>
        /// Чтение логинов и паролей, разделённых разделителем separator из файла по пути path
        /// </summary>
        /// <param name="path"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        static Account[] accountsFromFile(string path, char separator)
        {
            StreamReader sr = new StreamReader(path);
            int countOfPairs = 0;
            string buff;
            Account[] passPairBuff = new Account[100];

            while (!sr.EndOfStream)
            {
                buff = sr.ReadLine();
                passPairBuff[countOfPairs].Login = buff.Split(separator)[0];
                passPairBuff[countOfPairs].Password = buff.Split(separator)[1];
                countOfPairs++;
            }
            Account[] passPair = new Account[countOfPairs];

            Array.Copy(passPairBuff, passPair, countOfPairs);

            sr.Close();

            return passPair;
        }

        /// <summary>
        /// Структура Account, содержащая Login и Password.
        /// </summary>
        struct Account
        {
            public string Login;
            public string Password;
        }

        /// <summary>
        /// Проверка логина и пароля на соответствие root/GeekBrains
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static bool checkLoginPassword(string login, string password)
        {
            if (login.Equals("root") && password.Equals("GeekBrains"))
                return true;
            else
                return false;
        }
        #endregion

        #region Методы задания 1
        /// <summary>
        /// Определение количества пар элементов массива, в которых только одно число делится на 3
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int countOfPairDiv3(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) ||
                    (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                {
                    count++;
                }
            }
            return count;
        }
        #endregion

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
    /// Класс второго задания о массивах
    /// </summary>
    static class ArrayTask2
    {
        #region Методы для второго задания. Деление на 3 и считывание из файла

        /// <summary>
        /// Определение количества пар элементов массива, в которых только одно число делится на 3
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int CountOfPairDiv3(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) ||
                    (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Считывание массива из файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static int[] ReadArrayFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл {path} не найден.");

            StreamReader sr = new StreamReader(path);

            int[] result = Array.ConvertAll<string, int>(File.ReadAllLines(path), Convert.ToInt32);

            sr.Close();
            return result;
        }
        #endregion
    }
}
