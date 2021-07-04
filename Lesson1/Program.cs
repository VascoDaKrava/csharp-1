using System;

/// <summary>
/// Автор - Кравчук Василий
/// </summary>
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1
            // 1.Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
            // В результате вся информация выводится в одну строчку:
            //   а) используя склеивание;
            //   б) используя форматированный вывод;
            //   в) используя вывод со знаком $.

            MyMetods.PrintWithNewLine("Задание 1. Программа анкета");

            string firstName, lastName;
            int age;
            double height, weight;
                        
            Console.Write("Введите имя: ");
            firstName = Console.ReadLine();
            
            Console.Write("Введите фамилию: ");
            lastName = Console.ReadLine();

            Console.Write("Введите возраст: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост (м): ");
            height = double.Parse(Console.ReadLine());

            Console.Write("Введите вес (кг): ");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine("\nВывод, используя склеивание:");
            Console.WriteLine("Имя - " + firstName + ", Фамилия - " + lastName + ", Возраст - " + age + ", Рост - " + height + " м, Вес - " + weight + " кг.");

            Console.WriteLine("\nИспользуя форматированный вывод:");
            Console.WriteLine("Имя - {0:G}, Фамилия - {1:G}, Возраст - {2:D}, Рост - {3:F2} м, Вес - {4:F2} кг.", firstName, lastName, age, height, weight);

            Console.WriteLine("\nИспользуя вывод со знаком $:");
            Console.WriteLine($"Имя - {firstName}, Фамилия - {lastName}, Возраст - {age}, Рост - {height} м, Вес - {weight} кг.");

            MyMetods.Pause();
            #endregion

            #region Задание 2
            //2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            
            MyMetods.PrintWithNewLine("Задание 2. Индекс массы тела (ИМТ)");

            Console.WriteLine($"Для введённых ранее данных (масса - {weight:F2} кг, рост - {height:F2} м) ИМТ составит - {I(weight, height):F3}");
            MyMetods.Pause();
            #endregion

            #region Задание 3
            //3.а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2, y2
            //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
            //Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
            //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

            MyMetods.PrintWithNewLine("Задание 3. Расстояние между точками");

            int x1, y1, x2, y2;

            Console.WriteLine("Введите координаты:");
            Console.Write("   X1 : ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("   Y1 : ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("   X2 : ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("   Y2 : ");
            y2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nРасстояние между этими точками - {r(x1, y1, x2, y2):F2}");

            MyMetods.Pause();
            #endregion
            
            #region Задание 4
            //4. Написать программу обмена значениями двух переменных:
            //а) с использованием третьей переменной;
            //б) *без использования третьей переменной.

            MyMetods.PrintWithNewLine("Задание 4. Обмен значений переменных");

            string var1, var2, var3, var11, var22;

            Console.WriteLine("Введите значение переменных:");
            Console.Write("var1 = ");
            var11 = var1 = Console.ReadLine();
            Console.Write("var2 = ");
            var22 = var2 = Console.ReadLine();

            // а) с использованием третьей переменной;
            var3 = var1;
            var1 = var2;
            var2 = var3;
            Console.WriteLine($"Значение переменных, после замены через третью переменную: var1 - {var1}, var2 - {var2}");

            // б) *без использования третьей переменной.
            var11 = var22 + var11;
            var22 = var11.Replace(var22, "");
            var11 = var11.Replace(var22, "");
            Console.WriteLine($"Значение переменных, после замены без использования переменных: var11 - {var11}, var22 - {var22}");
            
            MyMetods.Pause();
            #endregion
            
            #region Задание 5
            //5.а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            //б) *Сделать задание, только вывод организовать в центре экрана.
            //в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).

            MyMetods.PrintWithNewLine("Задание 5. Вывод по центру экрана");

            string message = "Василий Кравчук, Москва";

            Print(message, (Console.WindowWidth - message.Length) / 2, Console.WindowHeight / 2);

            MyMetods.Pause();
            #endregion

            #region Задание 6
            //6. * Создать класс с методами, которые могут пригодиться в вашей учебе(PrintWithNewLine, Pause).

            // Создал класс MyMetods
            #endregion
        }

        #region Мои методы
        /// <summary>
        /// ИМТ
        /// </summary>
        /// <param name="m">масса, кг</param>
        /// <param name="h">рост, м</param>
        /// <returns></returns>
        static double I(double m, double h)
        {
            return m / (h * h);
        }

        /// <summary>
        /// Расстояние между двумя точками
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        static double r(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        /// <summary>
        /// Вывод текста в заданной позиции
        /// </summary>
        /// <param name="ms"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ms);
        }
        #endregion
    }

    /// <summary>
    /// Класс с моими методами для задания 6
    /// </summary>
    class MyMetods
    {
        /// <summary>
        /// Ожидание нажатия Enter и последующая очистка экрана
        /// </summary>
        public static void Pause()
        {
            Console.Write("\nНажмите Enter ");
            Console.ReadLine();
            Console.Clear();
        }

        /// <summary>
        /// Вывод сообщения с дополнительной пустой строкой
        /// </summary>
        /// <param name="message"></param>
        public static void PrintWithNewLine(string message)
        {
            Console.WriteLine($"{message}\n");
        }
    }
}
