using System;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto Label;
            #region Задание 1
            // 1. Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Задание 1. Минимальное из трёх.\n");
            Console.Write("Введите первое значение : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе значение : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье значение : ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nМинимальное значение : {getMin(a, b, c)}");
            next();
            #endregion

            #region Задание 2
            // 2. Написать метод подсчета количества цифр числа.
            Console.WriteLine("Задание 2. Количество цифр в числе.\n");
            Console.Write("Введите число : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр : {quantityDigits(a)}");
            next();
            #endregion

            #region Задание 3
            // 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            a = 0;
            int sum = 0;
            do
            {
                Console.WriteLine("Задание 3. Сумма положительных нечётных.\n");
                Console.WriteLine($"Сумма = {sum}");
                Console.Write("Введите число (для выхода введите 0) : ");
                a = int.Parse(Console.ReadLine());
                if (isOddPositive(a))
                    sum += a;
                Console.Clear();
            }
            while (a != 0);
            Console.WriteLine("Задание 3. Сумма положительных нечётных.\n");
            Console.WriteLine($"Был введён 0.\n" +
                $"Сумма = {sum}");
            next();
            #endregion

            #region Задание 4
            // 4. Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
            //    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            //    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //    С помощью цикла do while ограничить ввод пароля тремя попытками.
            Console.WriteLine("Задание 4. Проверка логина и пароля.\n");

            byte countForTry = 3; // Количество попыток
            string login = "";
            string password = "";
            bool accessGranted = false;

            do
            {
                Console.WriteLine($"\nОсталось попыток : {countForTry}");
                Console.Write("Введите логин : ");
                login = Console.ReadLine();
                Console.Write("Введите пароль : ");
                password = Console.ReadLine();
                accessGranted = checkLoginPassword(login, password);
                countForTry--;
            }
            while (countForTry > 0 && !accessGranted);

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
                // Можно тут для прерывания программы написать:
                // break;
            }

            next();
            #endregion

            #region Задание 5
            // 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
            //    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            Console.WriteLine("Задание 5. Про ИМТ.\n");

            Console.Write("Введите ваш вес (кг) : ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш рост (м) : ");
            double height = double.Parse(Console.ReadLine());

            double imt = weight / (height * height);

            Console.WriteLine($"Ваш ИМТ : {imt:F2}\n");

            if (imt > 25)
                Console.WriteLine($"Для нормализации веса вам нужно похудеть на {(weight - 25 * height * height):F2} кг.");
            else
                if (imt < 18.5)
            {
                Console.WriteLine($"Для нормализации веса вам нужно набрать {(18.5 * height * height - weight):F2} кг.");
            }
            else
            {
                Console.WriteLine("Всё в норме.");
            }

            next();
            #endregion

            #region Задание 6
            // 6. * Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр.
            //    Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
            Console.WriteLine("Задание 6. Хорошие числа.\n");
            int countGoodNum = 0;

            DateTime startProgramm = DateTime.Now;

            for (long i = 1; i < 1000000000; i++)
                if (isNumGood(i))
                    countGoodNum++;

            // Количество "хороших" чисел от 1 до 1 000 000 000 : 61574509
            // Время выполнения программы: 01:23:07.9497019
            Console.WriteLine($"Количество \"хороших\" чисел от 1 до 1 000 000 000 : {countGoodNum}");
            Console.WriteLine($"Время выполнения программы : {DateTime.Now - startProgramm}");

            next();
            #endregion

            //Label:;
            #region Задание 7
            // 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a < b).
            //    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            Console.WriteLine("Задание 7. Рекурсия\n");
            Console.Write("Введите число a : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b : ");
            b = int.Parse(Console.ReadLine());

            Console.Write("\nВывод чисел от a до b : ");
            printFromAtoB(a, b);
            Console.WriteLine($"\nСумма чисел от a до b : {sumFromAtoB(a, b)}");

            next();
            #endregion
        }

        /// <summary>
        /// Подсчёт суммы чисел от a до b используя рекурсию
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int sumFromAtoB(int a, int b)
        {
            a++;
            if (a <= b)
                return a - 1 + sumFromAtoB(a, b);
            else
                return b;
        }

        /// <summary>
        /// Вывод чисел от А до В используя рекурсию
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void printFromAtoB(int a, int b)
        {
            Console.Write($"{a} ");
            a++;
            if (a <= b)
                printFromAtoB(a, b);
        }

        /// <summary>
        /// Возвращает TRUE, если число делится на сумму своих цифр
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static bool isNumGood(long a)
        {
            if (a % sumDigits(a) == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Подсчёт суммы цифр числа используя рекурсию
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static long sumDigits(long a)
        {
            // Если число не делится на 10, то это одна цифра. Иначе убираем один разряд делением на 10 и вызываем себя рекурсивно
            if (a / 10 == 0)
                return a % 10;
            else
                return sumDigits(a / 10) + a % 10;
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

        /// <summary>
        /// Проверка числа на положительность и нечётность
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static bool isOddPositive(int a)
        {
            if ((a % 2 == 0) && (a > 0))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Подсчёт количества цифр с использованием рекурсии
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int quantityDigits(int a)
        {
            // Если число не делится на 10, то это одна цифра. Иначе убираем один разряд делением на 10 и вызываем себя рекурсивно
            if (a / 10 == 0)
                return 1;
            else
                return quantityDigits(a / 10) + 1;
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

        /// <summary>
        /// Поиск минимального из трёх значений
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int getMin(int a, int b, int c)
        {
            int min = a < b ? a : b;
            return min < c ? min : c;
        }
    }
}
